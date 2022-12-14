using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOADIYAFIT.DATA.Entities
{
    public class MealType
    {
        public int MealTypeId { get; set; }
        public string MealTypeName { get; set; }
        public byte[] MealTypeImage { get; set; }
    }
}
