/*
* @author 3ashry
*/

namespace GuessTheWordClient
{   public delegate void ResponseEventHandler(HttpResponseMessage response);
    internal class ResponseHandler
    {
        public event ResponseEventHandler OnResponse;


    }
}
