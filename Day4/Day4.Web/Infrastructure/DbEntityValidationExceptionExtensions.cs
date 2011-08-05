using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Validation;

namespace Day4.Web.Infrastructure {
    public static class DbEntityValidationExceptionExtensions {

        public static ModelStateDictionary GetModelErrors(this DbEntityValidationException ex) {
            var results = new ModelStateDictionary();

            foreach (var model in ex.EntityValidationErrors) {
                foreach (var error in model.ValidationErrors) {
                    results.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }
            return results;
        }
    }
}