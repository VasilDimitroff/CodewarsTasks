namespace GoodVSEvil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Middle Earth is about to go to war. The forces of good will have many battles with the forces of evil.
            Different races will certainly be involved. Each race has a certain worth when battling against others.
           
            On the side of good we have the following races, with their associated worth:
            Hobbits: 1
            Men: 2
            Elves: 3
            Dwarves: 3
            Eagles: 4
            Wizards: 10

            On the side of evil we have:
            Orcs: 1
            Men: 2
            Wargs: 2
            Goblins: 2
            Uruk Hai: 3
            Trolls: 5
            Wizards: 10

            Although weather, location, supplies and valor play a part in any battle,
            if you add up the worth of the side of good and compare it with the worth of the side of evil, 
            the side with the larger worth will tend to win.

            Thus, given the count of each of the races on the side of good, 
            followed by the count of each of the races on the side of evil, determine which side wins.

            Input:
            The function will be given two parameters.
            Each parameter will be a string of multiple integers separated by a single space.
            Each string will contain the count of each race on the side of good and evil.

            The first parameter will contain the count of each race on the side of good in the following order:
            Hobbits, Men, Elves, Dwarves, Eagles, Wizards.

            The second parameter will contain the count of each race on the side of evil in the following order:
            Orcs, Men, Wargs, Goblins, Uruk Hai, Trolls, Wizards.

            All values are non-negative integers.
            The resulting sum of the worth for each side will not exceed the limit of a 32-bit integer.

            Output:
            "Battle Result: Good triumphs over Evil" if good wins, 
            "Battle Result: Evil eradicates all trace of Good" if evil wins, or 
            "Battle Result: No victor on this battle field" if it ends in a tie.
             */

            Console.WriteLine(GoodVsEvil("1 1 1 1 1 1", "1 1 1 1 1 1 1"));
            Console.WriteLine(GoodVsEvil("0 0 0 0 0 10", "0 1 1 1 1 0 0"));
            Console.WriteLine(GoodVsEvil("1 0 0 0 0 0", "1 0 0 0 0 0 0"));
        }

        public static string GoodVsEvil(string good, string evil)
        {  
            Dictionary<string, int> goodForces = new Dictionary<string, int>()
            {
                { "Hobbits", 1 },
                { "Men", 2 },
                { "Elves", 3 },
                { "Dwarves", 3 },
                { "Eagles", 4 },
                { "Wizards", 10 },
            };

            Dictionary<string, int> evilForces = new Dictionary<string, int>()
            {
                { "Orcs", 1},
                { "Men", 2},
                { "Wargs", 2},
                { "Goblins", 2},
                { "Uruk Hai", 3 },
                { "Trolls", 5 },
                { "Wizards", 10 },
            };

            var goodsArray = good
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();

            int goodsPoints = 0;

            for (int i = 0; i < goodsArray.Length; i++)
            {
                var currentSoldier = i;

                switch (currentSoldier)
                {
                    case  0:
                        goodsPoints += goodForces["Hobbits"] * goodsArray[currentSoldier];
                        break;
                    case 1:
                        goodsPoints += goodForces["Men"] * goodsArray[currentSoldier];
                        break;
                    case 2:
                        goodsPoints += goodForces["Elves"] * goodsArray[currentSoldier];
                        break;
                    case 3:
                        goodsPoints += goodForces["Dwarves"] * goodsArray[currentSoldier];
                        break;
                    case 4:
                        goodsPoints += goodForces["Eagles"] * goodsArray[currentSoldier];
                        break;
                    case 5:
                        goodsPoints += goodForces["Wizards"] * goodsArray[currentSoldier];
                        break;
                }
            }

            var evilsArray = evil
               .Split(' ')
               .Select(x => int.Parse(x))
               .ToArray();

            int evilsPoints = 0;

            for (int i = 0; i < evilsArray.Length; i++)
            {
                var currentSoldier = i;

                switch (currentSoldier)
                {
                    case 0:
                        evilsPoints += evilForces["Orcs"] * evilsArray[currentSoldier];
                        break;
                    case 1:
                        evilsPoints += evilForces["Men"] * evilsArray[currentSoldier];
                        break;
                    case 2:
                        evilsPoints += evilForces["Wargs"] * evilsArray[currentSoldier];
                        break;
                    case 3:
                        evilsPoints += evilForces["Goblins"] * evilsArray[currentSoldier];
                        break;
                    case 4:
                        evilsPoints += evilForces["Uruk Hai"] * evilsArray[currentSoldier];
                        break;
                    case 5:
                        evilsPoints += evilForces["Trolls"] * evilsArray[currentSoldier];
                        break;
                    case 6:
                        evilsPoints += evilForces["Wizards"] * evilsArray[currentSoldier];
                        break;
                }
            }

            if (goodsPoints > evilsPoints)
            {
                return "Battle Result: Good triumphs over Evil";
            }
            else if (goodsPoints < evilsPoints)
            {
                return "Battle Result: Evil eradicates all trace of Good";
            }
            else
            {
                return "Battle Result: No victor on this battle field";
            }     
        }
    }
}
