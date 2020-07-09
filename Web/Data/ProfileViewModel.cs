using System;
namespace HereIAmAPI.Model
{
    public class ProfileViewModel
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime Bday { get; set; }
        public string ImagePath { get; set; }

        
    }
}
