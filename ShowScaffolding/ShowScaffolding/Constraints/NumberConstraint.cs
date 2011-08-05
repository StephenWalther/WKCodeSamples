using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Text.RegularExpressions;

namespace ShowScaffolding.Constraints {
    public class NumberConstraint : IRouteConstraint {
        
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection) {
            return values[parameterName].ToString() == "1";
        }
    }
}