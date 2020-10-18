using System.Web.Http;
using System.Web.Http.Routing;
using Microsoft.AspNetCore.Mvc.Routing;

namespace EmployeeApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web api configuration and services - Register Constraint
            var constraintResolver = new DefaultInlineConstraintResolver();
            constraintResolver.ConstraintMap.Add("apiVersionConstraint", typeof(ApiVersionRouteConstraint));

            // Web api routes
            config.MapHttpAttributeRoutes(constraintResolver);
        }
    }
}
