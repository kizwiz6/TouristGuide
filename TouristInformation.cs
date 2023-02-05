using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristGuide
{
    public class TouristInformation
    {
        public string GetAttractionDetails(string attractionName)
        {
            // Returns details of the attraction based on the name
            switch (attractionName)
            {
                case "Eiffel Tower":
                    return "The Eiffel Tower is a landmark and an iron lattice tower located in Paris, France. Built in 1889, it stands 324 meters tall.";
                case "Big Ben":
                    return "Big Ben is the nickname for the Great Bell of the clock at the north end of the Palace of Westminster in London, England.";
                case "Colosseum":
                    return "The Colosseum is an oval amphitheatre in the center of Rome, Italy. It was built in 70-80 AD and is the largest amphitheatre ever built.";
                default:
                    return "Attraction not found.";
            }
        }
    }

    // Open-Closed Principle
    public interface IAttraction
    {
         string Name { get; set; }
        string GetDescription();
    }

    public class EiffelTower : IAttraction
    {
        public string Name { get; set; }

        public EiffelTower()
        {
            Name = "Eiffel Tower";
        }

        public string GetDescription()
        {
            return "The Eiffel Tower is a landmark and an iron lattice tower located in Paris, France. Built in 1889, it stands 324 meters tall.";
        }
    }

    public class BigBen : IAttraction
    {
        public string Name { get; set; }

        public BigBen()
        {
            Name = "Big Ben";
        }

        public string GetDescription()
        {
            return "Big Ben is the nickname for the Great Bell of the clock at the north end of the Palace of Westminster in London, England.";
        }
    }

    public class Colosseum : IAttraction
    {
        public string Name { get; set; }

        public Colosseum()
        {
            Name = "Colosseum";
        }

        public string GetDescription()
        {
            return "The Colosseum is an oval amphitheatre in the center of Rome, Italy. It was built in 70-80 AD and is the largest amphitheatre ever built.";
        }
    }

    public class AttractionPrinter
    {
        public void PrintAttractionDetails(IAttraction attraction)
        {
            Console.WriteLine(attraction.GetDescription);
        }
    }

    public interface ITouristGuide
    {
        IEnumerable<IAttraction> GetAttractions();
        void PrintAttractions();
    }
}
