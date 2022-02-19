using System;
namespace cdStore.Models{
    public class Cd{

        //Properties
        public int CdId { get; set; }
        public string? CdName { get; set; }
        public int? Price { get; set; }
        
        //This class will be the model of the table Cd. It will have a one to many relationship to User and many o one relaionship to Artist. 


        public int? ArtistId { get; set; }
        public Artist? Artist { get; set; }

         public List<User>? User { get; set; }


    }
}