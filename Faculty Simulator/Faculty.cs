using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty_Simulator {

    class Faculty {

        private const long STARTING_EDUCATION = 10;

        public string Name { get; set; }
        public long totalEducation;
        public long totalScience;
        public long totalGrants;

        public int[] production = { 2, 2, 1 };

        public List<List<long[]>> allWorkers;

        //education bar info: 
        //first element in the arrays is count, the second is number of upgrades.
        public List<long[]> educationWorkers;
        public long[] seniorLectInfo = { 0, 0 };
        public long[] regularLectsInfo = { 0, 0 };
        public long[] juniorLectsInfo = { 0, 0 };

        //science bar info: 
        public List<long[]> scienceWorkers;
        public long[] seniorSciInfo = { 0, 0 };
        public long[] regularSciInfo = { 0, 0 };
        public long[] juniorSciInfo = { 0, 0 };

        //grants bar info: 
        public List<long[]> grantWorkers;
        public long[] seniorProfInfo = { 0, 0 };
        public long[] regularProfInfo = { 0, 0 };
        public long[] juniorProfInfo = { 0, 0 };

        public class Cost {
            public long educations;
            public long sciences;
            public long grants;

            public Cost(long e, long s, long g) {
                educations = e;
                sciences = s;
                grants = g;
            }

            public Cost(Cost cost) {
                educations = cost.educations;
                sciences = cost.sciences;
                grants = cost.grants;
            }

            public static Cost Multiply(int scalar, Cost cost) {
                Cost newcost = new Cost(cost);
                newcost.educations *= scalar;
                newcost.grants *= scalar;
                newcost.sciences *= scalar;
                return newcost;
            }

        }

        public List<Cost[]> allCosts;
        public Cost[] eduCosts = { new Cost(1000, 0, 0), new Cost(100, 0, 0), new Cost(10, 0, 0) };
        public Cost[] sciCosts = { new Cost(1000, 40, 0), new Cost(200, 20, 0), new Cost(100, 0, 0) };
        public Cost[] graCosts = { new Cost(2000, 500, 100), new Cost(400, 200, 10), new Cost(200, 100, 0) };

        //upgrade costs are the same everywhere, fortunately:
        public long[] upgradeCosts = { 10000, 1000, 100 };

        public Faculty(string v) {
            Name = v;
            totalEducation = STARTING_EDUCATION;
            totalScience = 0;
            totalGrants = 0;
            educationWorkers = new List<long[]>();
            educationWorkers.Add(seniorLectInfo);
            educationWorkers.Add(regularLectsInfo);
            educationWorkers.Add(juniorLectsInfo);

            scienceWorkers = new List<long[]>();
            scienceWorkers.Add(seniorSciInfo);
            scienceWorkers.Add(regularSciInfo);
            scienceWorkers.Add(juniorSciInfo);

            grantWorkers = new List<long[]>();
            grantWorkers.Add(seniorProfInfo);
            grantWorkers.Add(regularProfInfo);
            grantWorkers.Add(juniorProfInfo);

            allWorkers = new List<List<long[]>>();
            allWorkers.Add(educationWorkers);
            allWorkers.Add(scienceWorkers);
            allWorkers.Add(grantWorkers);

            allCosts = new List<Cost[]>();
            allCosts.Add(eduCosts);
            allCosts.Add(sciCosts);
            allCosts.Add(graCosts);

        }

        public void Increment() {

            //hire new staff:
            regularLectsInfo[0] += seniorLectInfo[0] * production[0] * (seniorLectInfo[1] + 1);
            juniorLectsInfo[0] += regularLectsInfo[0] * production[1] * (regularLectsInfo[1] + 1);

            regularSciInfo[0] += seniorSciInfo[0] * production[0] * (seniorSciInfo[1] + 1);
            juniorSciInfo[0] += regularSciInfo[0] * production[1] * (regularSciInfo[1] + 1);

            regularProfInfo[0] += seniorProfInfo[0] * production[0] * (seniorProfInfo[1] + 1);
            juniorProfInfo[0] += regularProfInfo[0] * production[1] * (regularProfInfo[1] + 1);

            //gather the edu, sci and gra:
            totalEducation += juniorLectsInfo[0] * (juniorLectsInfo[1] + 1);
            totalScience += juniorSciInfo[0] * (juniorSciInfo[1] + 1);
            totalGrants += juniorProfInfo[0] * (juniorProfInfo[1] + 1);

        }
        public bool CanAfford(Cost cost) {
            if (totalEducation < cost.educations) return false;
            if (totalScience < cost.sciences) return false;
            if (totalGrants < cost.grants) return false;
            return true;
        }

        //this method below should only be called when we want to compare the cost of education alone
        public bool CanAfford(long educationCost) {
            return totalEducation >= educationCost;
        }

        //we basically divide our total resources by cost of one unit and get something
        public long GetAffordableWorkers(int selectedTab, int selectedItem) {
            Cost cost = allCosts[selectedTab][selectedItem];
            long maxEdu = totalEducation / cost.educations;
            if (cost.sciences != 0) {
                long maxSci = totalScience / cost.sciences;
                if (cost.grants != 0) {
                    long maxGra = totalGrants / cost.grants;
                    return Math.Min(maxEdu, Math.Min(maxSci, maxGra));
                } else
                    return Math.Min(maxEdu, maxSci);
            } else
                return maxEdu;
        }
        public long GetAffordableUpgrades(int selectedItem) {
            //assume upgrades only cost education:
            return (totalEducation / upgradeCosts[selectedItem]);
        }

        //Buy method returns true if we broke the game:
        public bool Buy(int selectedTab, int selectedItem, string buttonTag) {
            Cost cost = allCosts[selectedTab][selectedItem];
            long howManyUnits = 1;
            if (buttonTag == "1") howManyUnits = GetAffordableWorkers(selectedTab, selectedItem) / 2;
            if (buttonTag == "2") howManyUnits = GetAffordableWorkers(selectedTab, selectedItem);

            totalEducation -= cost.educations * howManyUnits;
            totalScience -= cost.sciences * howManyUnits;
            totalGrants -= cost.grants * howManyUnits;

            allWorkers[selectedTab][selectedItem][0] += howManyUnits;

            if (totalEducation < 0 || totalScience < 0 || totalGrants < 0) return true;
            else return false;
        }

        //Upgrade method also returns true if game broken
        public bool Upgrade(int selectedTab, int selectedItem, string buttonTag) {
            long eduCost = upgradeCosts[selectedItem];
            long howManyUpgrades = 1;
            if (buttonTag == "1") howManyUpgrades = GetAffordableUpgrades(selectedItem) / 2;
            if (buttonTag == "2") howManyUpgrades = GetAffordableUpgrades(selectedItem);

            totalEducation -= eduCost * howManyUpgrades;

            allWorkers[selectedTab][selectedItem][1] += howManyUpgrades;

            if (totalEducation < 0) return true;
            else return false;

        }

        //checks if the amount of knowledge ammassed within the faculty became too big:
        public bool Exploded() {
            if (totalEducation < 0 || totalScience < 0 || totalGrants < 0) return true;
            else return false;

        }
    }
}
