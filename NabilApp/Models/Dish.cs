using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NabilApp.Models
{
    public class Dish
    {
        public int Id { get; set; }

        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Display(Name = "Waga Dania")]
        public double Weight { get; set; }

        [Display(Name = "Kaloryczność")]
        public byte Kcal { get; set; }

        [Display(Name = "Zdjęcie")]
        public byte[] Img { get; set; }

    }
}