using System.Web;
using Machine.Specifications;
using Machine.Specifications.DevelopWithPassion.Rhino;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs.web
{
    public class WebRequestSpecs
    {
        public abstract class concern : Observes<Request,
                                            WebRequest>
        {

        }

        [Subject(typeof(WebRequest))]
        public class when_mapping_a_request_to_an_input_model : concern
        {
            Establish c = () =>
            {
                http_request = the_dependency<HttpRequest>();

            };

            Because b = () =>
            {
                sut.map<input_model>();
            };

            It should_create_an_instance_of_the_input_model = () =>
            {
            };

            It should_populate_the_input_model_from_the_http_request = () =>
            {

            };

            private static HttpRequest http_request;
        }

        private class input_model { }
    }
}