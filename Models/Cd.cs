using System;
namespace cdStore.Models{
    public class Cd{

        //Properties
        public int Id { get; set; }
        public string? CdName { get; set; }
        public string? Artist { get; set; }
        public int? Price { get; set; }

    }
}