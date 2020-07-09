using System;
using System.Linq;
using System.Threading.Tasks;
using Web.Data;


namespace Web.Shared
{
    public class TcardManip
    {
        public TcardManip()
        {
        }

        private static readonly DateTime[] EventDates = new[]
        {
            new DateTime(2010, 10, 1),
            new DateTime(2010, 10, 2),
            new DateTime(1995, 6, 1),
            new DateTime(1994, 2, 1),
        };

        private static readonly string[] Names = new[]
        {
            "Kitchen Service", "Cleanup", "Community Service", "Choir Practice",
        };

        private static readonly string[] Hashtagsx = new[]
        {
             "BLM", "Cooking", "Service", "Art",
        };


        private static readonly string[] Images = new[]
        {
            "./images/cards/cade-chapel1.jpeg","./images/cards/church-image.jpeg","./images/cards/cleanup.jpeg","./images/cards/community-service.jpg","./images/cards/kitchen-service.jpg"
        };
        

         TCard Info1 = new TCard()
         {
            EventDate = new DateTime(2008, 3, 15), Name = "Kitchen Service", Hashtags = "BLM",
            
         };

        
        
    
 
        public async Task<TCard[]> GetInfoAsync()
        {
            var rng = new Random();

            return await Task.FromResult(Enumerable.Range(1, 5).Select(index => new TCard
            {
                EventDate = EventDates[rng.Next(EventDates.Length)],
                Name = Names[rng.Next(Names.Length)],
                Hashtags = Hashtagsx[rng.Next(Hashtagsx.Length)],
                Image = Images[rng.Next(Images.Length)]


            }).ToArray());
        }

        
    }
}
