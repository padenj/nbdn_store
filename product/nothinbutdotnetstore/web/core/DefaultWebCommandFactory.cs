using System;
using nothinbutdotnetstore.infrastructure.containers.basic;

namespace nothinbutdotnetstore.web.core
{
    public class DefaultWebCommandFactory : WebCommandFactory
    {
        DependencyFactories dependency_factories;

        public DefaultWebCommandFactory(DependencyFactories dependencyFactories)
        {
            dependency_factories = dependencyFactories;
        }

        public WebCommand create_web_command_for<T>(RequestCriteria criteria)
        {
            return new DefaultWebCommand(criteria, (ApplicationCommand)dependency_factories.get_factory_that_can_create(typeof(T)).create());
        }
    }
}