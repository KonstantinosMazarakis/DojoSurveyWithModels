using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithModels.Models
{
    public class User
    {
        [Required]
        [MinLength(2)]
        public string Name {get;set;}

        [Required]
        public string Location {get;set;}

        [Required]
        public string Language {get;set;}

        [MaxLength(20)]
        public string Comment {get;set;}
    }

}