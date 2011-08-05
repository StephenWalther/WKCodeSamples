using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EFOldAndBad.Models {

    [MetadataType(typeof(MovieMD))]
    public partial class Movie {


    }

    public class MovieMD {

        
        public object Title { get; set; }


    }


}