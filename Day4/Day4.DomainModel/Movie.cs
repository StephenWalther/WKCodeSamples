
namespace Day4.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Movie : IValidatableObject
    {
        public long Id { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Director { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
            
            var results = new List<ValidationResult>();
            if (this.Director == "Stephen") {
                results.Add( new ValidationResult("Director cannot be Stephen", new List<string> {"Director"})); 
            }

            return results;
        }
    }
}
