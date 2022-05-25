using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiDomain
{
    public class Battle
    {
        public int BattleId { get; set; }
        public string Name { get; set; }
        public List<Samurai> Samurais { get; set; } = new List<Samurai>();


        // A many to Many relationship occures between Samurai and Battle
        // In earlie version of EfCore when working with many-to-many relationship u need
        // to create a join entity class 

        // But now if u are working with a non complex  many-to-Many Relationship
        // skip Navigation isndone for us automatically i,e
        // ading a list of Samurai in a Battle Model and adding a list of Battle 
        // in a samurai Model efcore can infer that there is a simple many-to many between 
        // Samurai and Battle


        //If u check ur MIgration after adding the simmple many to many relationship efCore
        // will create a table named BattleSanurai
    }

}
