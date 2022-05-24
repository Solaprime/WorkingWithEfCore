using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiDomain
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; } = new List<Quote>();

       
    }
}
// one to many relationship between Samurai And Quoote