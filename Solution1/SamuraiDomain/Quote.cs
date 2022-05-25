using System;

namespace SamuraiDomain
{
    public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Samurai Samurai { get; set; }
        public int SamuraiId { get; set; }
    }
}



// IN a Database a one to many relationship is reperesented if there is a forign key in the childtable 
// pointing to the ParentTable 



// inefcore wo far we have the List of Quote in Samurai EfCore Can comprehend the One to Many relationshio
// the Samurail property(a Navif=gation Property) and SamuraiId  property are not
// needed for efcore to infer the One to MANY Relationship betwen samurai and WQuote


// the Samurai serve as a Navigation property and the Samurai Id serve as the Foreighn KEy

//note in our Project by Conveention EfCore will recognize SamuraiId has a ForeignkEY ,
// IF We renmae SamuraiId to something else like SamuraiFk. SamuraiFk will only be cosideres
// as random int Column in our Table . and EfCore will iNfer SamuraiId has A Fk in it scheama

// always note the Convention though we can Always overide this Convention 


// By Defaul we place onLY SamuraiID AND remove Listof quote in Samurai and thr samursiNavigaytion
// property ef core will still infer the One yto Many relationship deu ot the presence of 
// SamuraiID

// Likewise SamuraiNavigation property can function has AnAvigstion property haas well