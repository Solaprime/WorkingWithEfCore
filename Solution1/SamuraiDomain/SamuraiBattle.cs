using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiDomain
{
    public class BattleSamurai
    {
        public int SamuraiId { get; set; }
        public int BattleId { get; set; }
        public DateTime DateJoined  { get; set; }


        // Initially we did not add BattleSamurai 
        // we added BattleSamurai becaue we want to be able to track when as samurai joined abatlled
        // Because we wanted additional Data in our Many-to-MANY realtionshipn we ahave ro 
        // create and Explicit Join Entity
        // this Join Entity is neded to house the PAYLOAD
        // the payload is the  DateJOined property cause it is an additional Property in our
        // Many-Many Relationship....



        // we need to configure our code i,e we need to make efCore awre of our Many-toMany Payload

    }
}
