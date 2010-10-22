 using System;
 using Machine.Specifications;
 using Machine.Specifications.DevelopWithPassion.Rhino;
 using nothinbutdotnetstore.infrastructure.containers.basic;
 using nothinbutdotnetstore.specs.infrastructure;
 using nothinbutdotnetstore.web.core;
 using Rhino.Mocks;

namespace nothinbutdotnetstore.specs.web
 {   
     public class WebCommandFactorySpecs
     {
         public abstract class concern : Observes<WebCommandFactory,
                                             DefaultWebCommandFactory>
         {
        
         }

         [Subject(typeof(DefaultWebCommandFactory))]
         public class when_asked_to_create_a_web_command : concern
         {
             private Establish c = () =>
                                       {
                                           criteria = an<RequestCriteria>();
                                           dependency_factories = the_dependency<DependencyFactories>();
                                           dependency_factory = an<DependencyFactory>();
                                           command = new OurCommand();

                                           dependency_factory.Stub(x => x.create()).Return(command);
                                           dependency_factories.Stub(x => x.get_factory_that_can_create(typeof(OurCommand))).Return(
                                               dependency_factory);
                                       };

             private Because b = () =>
                    results = sut.create_web_command_for<OurCommand>(criteria);

             It should_return_a_new_web_command_with_supplied_criteria_and_application_command_type = () =>
                    results.ShouldBeAn<WebCommand>();


            static RequestCriteria criteria;
             static WebCommand results;
             private static DependencyFactories dependency_factories;
             private static DependencyFactory dependency_factory;
             private static OurCommand command;
         }
    
     internal class OurCommand : ApplicationCommand
     {
         public void process(Request request)
         {
             throw new NotImplementedException();
         }
     }

     }

 }
