using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOADIYAFIT.DATA.Entities
{
    public class Food
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string PortionSize { get; set; }
        public int Calorie { get; set; }
        public byte[] FoodImage { get; set; }
        public int MealTypeId { get; set; }
        public MealType MealType { get; set; }
        public virtual List<UserMeal> UserMeals { get; set; }
        public virtual List<User> Users { get; set; }
    }
}
