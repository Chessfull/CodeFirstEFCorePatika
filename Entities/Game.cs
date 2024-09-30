using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEFCorePatika.Entities
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Platform { get; set; }
       
        [Range(0, 10)]
        public decimal Rating { get; set; }
    }
}
