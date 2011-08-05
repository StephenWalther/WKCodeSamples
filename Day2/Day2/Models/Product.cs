using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Day2.Models {
    public class Product : IValidatableObject {

        public long Id { get; set; }

        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public bool OnSale { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
            
            //var objecttoValidate = (Product)validationContext.ObjectInstance;
            var valResults = new List<ValidationResult>();

            // Validate name property
            if (String.IsNullOrWhiteSpace(this.Name)) {
                valResults.Add( new ValidationResult("Name is required!", new List<string> {"Name"}));
            }

            return valResults;
        }
    }


    //public class ProductValidator {
    //    public static ValidationResult ValidateName(string name, ValidationContext context) {
    //        if (!name.StartsWith("s")) {
    //            return new ValidationResult("Bad Name!", new List<string>{ "Name"});
    //        }

    //        return ValidationResult.Success;
    //    }
    //}
}























