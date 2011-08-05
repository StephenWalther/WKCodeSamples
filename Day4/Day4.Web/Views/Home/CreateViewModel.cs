using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Day4.Web.Views.Home {
    public class CreateViewModel {

        [Required]
        public string Title { get; set; }

        [Required]
        public string Director { get; set; }

    }
}