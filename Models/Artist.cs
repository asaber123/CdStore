using System;
namespace cdStore.Models{
        public class Artist{
        //Properties
        public int ArtistId { get; set; }
        public string? ArtistName { get; set; }
        public string? ArtistOrigin { get; set; }
        //This class will be the model of the table Artis. It will have a one to many relationship to the table Cd. 
        public List<Cd>? Cd { get; set; }
  
        //Class that handle the communication with enity framework.
     
        
    }
}