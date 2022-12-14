using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOADIYAFIT.DATA.Entities
{
    public class PersonelNote
    {
        [Key]
        public int PersonalNoteId { get; set; }
        public string Note { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
