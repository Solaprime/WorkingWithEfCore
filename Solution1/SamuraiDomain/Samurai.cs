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
        public List<Battle> Battles { get; set; } = new List<Battle>();
        public Horse Horse { get; set; }


    }
}
// one to many relation ship between Samurai And Quoote