using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOADIYAFIT.DATA.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public double BMI { get; set; }
        public string WeightStatus { get; set; }
        public int Age { get; set; }
        public string DiabetType { get; set; }
        public string? MemberType { get; set; }
        public virtual List<UserMeal> UserMeals { get; set; }
        public virtual List<Food> Foods { get; set; }

        public int? PersonaNotId { get; set; }
        public List<PersonelNote>? PersonalNotes { get; set; }
    }
}
