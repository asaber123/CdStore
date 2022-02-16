using System;
namespace cdStore.Models
{
    public class User
    {


        //Properties
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? UserPhone { get; set; }

        public List<Cd>? Cd { get; set; }



        //Class that handle the communication with enity framework. 

    }
}