using System.Net;

namespace Kandy.Types {

    public class EmptyUri : System.Uri 
    {
        public static readonly string Uri = "https://this.is.empty.url";

        public EmptyUri() : base(Uri) {}
    }

}
