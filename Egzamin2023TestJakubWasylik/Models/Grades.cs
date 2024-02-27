using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Egzamin2023TestJakubWasylik.Models
{
    

    public class Grade
    {
        [Key]
        public int Id { get; set; }

        public int Ocena { get; set; }
        [MaxLength(5)]
        public string Przedmiot { get; set; }

        public int NumerStudenta { get; set; }

        public string ImieStudenta { get; set; }

        public DateTime Data { get; set; }
    }
}
