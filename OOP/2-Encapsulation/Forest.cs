using System;

namespace Review
{
    class Forest
    {
        // FIELDS/PROPERTIES
        public string Name
        { get; set; }

        public int Trees
        { get; set; }

        private int age;
        public int Age
        {
            get { return age; }
            private set
            {
                if (value < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }

        private string biome;
        public string Biome
        {
            get { return biome; }
            set
            {
                string[] validBiomes = { "Tropical", "Temperate", "Boreal" };
                if (Array.IndexOf(validBiomes, value) >= 0)
                {
                    biome = value;
                }
                else
                {
                    biome = "Unknown";
                }
            }
        }

        public static int ForestsCreated
        {
            get; private set;
        }

        private static string forestFacts;
        private static string ForestFacts
        {
            get
            {
                return forestFacts;
            }
        }


        // CONSTRUCTORS
        public Forest(string name, string biome)
        {
            Name = name;
            Biome = biome;
            Age = 0;
            ForestsCreated++;
        }

        public Forest(string name) : this(name, "Unknown")
        { }

        static Forest()
        {
            forestFacts = "Forests provide a diversity of ecosystem services including:\n\taiding in regulating climate.\n\tpurifying water.\n\tmitigating natural hazards such as floods.\n";
            ForestsCreated = 0;
        }


        // METHODS
        public int Grow()
        {
            Trees += 30;
            Age += 1;
            return Trees;
        }

        public int Burn()
        {
            Trees -= 20;
            Age += 1;
            return Trees;
        }

        public static void PrintForestFacts()
        {
            Console.WriteLine(ForestFacts);
        }

    }
}