using System;
namespace cdStore.Models{
    public class Cd{

        //Properties
        public int CdId { get; set; }
        public string? CdName { get; set; }
        public int? Price { get; set; }


        public int ArtistId { get; set; }
        public Artist? Artist { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }

    }
}