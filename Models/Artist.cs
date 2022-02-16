using System;
namespace cdStore.Models{
        public class Artist{
        //Properties
        public int ArtistId { get; set; }
        public string? ArtistName { get; set; }
        public string? ArtistOrigin { get; set; }

        public List<Cd>? Cd { get; set; }
  
        //Class that handle the communication with enity framework. 
        
    }
}