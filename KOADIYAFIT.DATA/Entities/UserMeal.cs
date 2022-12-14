using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOADIYAFIT.DATA.Entities
{
    public class UserMeal
    {
        public int UserMealId { get; set; }
        public int TotalCalorie { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int FoodId { get; set; }
        public Food Food { get; set; }
        public int Portion { get; set; }
    }
}
