using Machine.Specifications;
using Machine.Specifications.DevelopWithPassion.Rhino;
using nothinbutdotnetstore.web.application;

namespace nothinbutdotnetstore.specs.web
{
    public class StoreDirectoryControllerSpecs
    {
        public abstract class concern : Observes<StoreDirectoryController>
        {
        }

        [Subject(typeof(StoreDirectoryController))]
        public class when_processing_the_request : concern
        {
        }
    }
}