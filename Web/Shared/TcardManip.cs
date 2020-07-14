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
            new DateTime(2020, 10, 1),
            new DateTime(2020, 10, 2),
            new DateTime(2020, 6, 1),
            new DateTime(2020, 2, 1),
        };

        private static readonly string[] Names = new[]
        {
            "Kitchen Service", "Cleanup", "Community Service", "Eating Ass",
        };

        private static readonly string[] Hashtagsx = new[]
        {
             "BLM", "Cooking", "Service", "Art",
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
                Hashtags = Hashtagsx[rng.Next(Hashtagsx.Length)]


            }).ToArray());
        }

        
    }
}
