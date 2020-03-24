using System.Collections.Generic;
using System.Linq;

namespace RSRP478020
{
    public class Foo
    {
        public IOrderedEnumerable<Pub> Bar(IList<Pub> pubs)
        {
            var bestPubs =
                from pub in pubs
                where pub.GetRating() > 4
                // Start 16
#nullable enable
                orderby pub.Name
                select pub;
            // Finish 16
#nullable disable
            return bestPubs;
        }
    }

    public class Pub
    {
        public Pub(string name)
        {
            Rating = 0;
            Name = name;
        }

        private int Rating { get; set; }

        public string Name { get; set; }

        public void Rate(int i)
        {
            Rating = i;
        }

        public int GetRating()
        {
            return Rating;
        }
    }
}