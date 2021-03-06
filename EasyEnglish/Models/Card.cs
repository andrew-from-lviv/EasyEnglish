﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using EasyEnglish.Validations;
using System.ComponentModel;

namespace EasyEnglish.Models {
    public class Card {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int UserId { get; set; }

        [Required]
        [StringLength(maximumLength: 256)]
        [Unique("Question", userEach:true, editMode:true, ErrorMessage = "The question already exists.")]
        [DisplayName("Word or phrase")]
        public string Question { get; set; }        
        
        [Required]
        [StringLength(maximumLength: 256)]
        [DisplayName("Translation or explanation")]
        public string Answer { get; set; }

        [DisplayName("Hint")]
        [StringLength(maximumLength: 512)]
        public string Note { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime ReviewedAt { get; set; }

        [Display(Name = "Review Level")]
        [Range(0, 5, ErrorMessage = "Please enter a revew lebel between 0 and 5")]
        public int ReviewLevel { get; set; }
    }
}
