.PHONY: clean test test-docker install release docs
PROJECT_NAME ?= kandy_kandy-csharp
SONAR_SOURCES ?= /d:sonar.exclusions=src/Kandy/Rest/**/*.*,test/Kandy.Test/**/*.*

clean:
	dotnet clean

install:
	@dotnet --version || (echo "Dotnet is not installed, please install Dotnet CLI"; exit 1);
	dotnet restore

test:
	dotnet build -c Release
	dotnet test -c Release --filter TestCategory!="ClusterTest"

test-docker:
	docker build -t kandy/kandy-csharp .
	docker run kandy/kandy-csharp /bin/bash -c "dotnet build -c Release; dotnet test -c Release --filter TestCategory!=\"ClusterTest\""

release:
	dotnet pack -c Release

docs:
	doxygen Doxyfile

API_DEFINITIONS_SHA=$(shell git log --oneline | grep Regenerated | head -n1 | cut -d ' ' -f 5)
CURRENT_TAG=$(shell expr "${GITHUB_TAG}" : ".*-rc.*" >/dev/null && echo "rc" || echo "latest")
docker-build:
	docker build -t kandy/kandy-csharp .
	docker tag kandy/kandy-csharp kandy/kandy-csharp:${GITHUB_TAG}
	docker tag kandy/kandy-csharp kandy/kandy-csharp:apidefs-${API_DEFINITIONS_SHA}
	docker tag kandy/kandy-csharp kandy/kandy-csharp:${CURRENT_TAG}

docker-push:
	docker push kandy/kandy-csharp:${GITHUB_TAG}
	docker push kandy/kandy-csharp:apidefs-${API_DEFINITIONS_SHA}
	docker push kandy/kandy-csharp:${CURRENT_TAG}

cover:
	dotnet sonarscanner begin /k:"$(PROJECT_NAME)" /o:"kandy" /d:sonar.host.url=https://sonarcloud.io /d:sonar.login="${SONAR_TOKEN}"  /d:sonar.language="cs" $(SONAR_SOURCES) /d:sonar.cs.opencover.reportsPaths="test/lcov.net451.opencover.xml"
	# Write to a log file since the logs for build with sonar analyzer are pretty beefy and travis has a limit on the number of log lines
	dotnet build Kandy.sln > buildsonar.log
	dotnet test test/Kandy.Test/Kandy.Test.csproj --no-build /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput=../lcov
	dotnet sonarscanner end /d:sonar.login="${SONAR_TOKEN}"

cache:
	directories:
		- '$HOME/.sonar/cache'
