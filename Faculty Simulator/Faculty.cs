using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Faculty_Simulator {

    public class Faculty {

        private static BigInteger STARTING_EDUCATION = 50;

        public string Name { get; set; }
        public BigInteger totalEducation;
        public BigInteger totalScience;
        public BigInteger totalGrants;

        public int[] production = { 2, 2, 1 };

        public List<List<BigInteger[]>> allWorkers;

        //education bar info: 
        //first element in the arrays is count, the second is number of upgrades.
        public List<BigInteger[]> educationWorkers;
        public BigInteger[] seniorLectInfo = { 0, 0 };
        public BigInteger[] regularLectsInfo = { 0, 0 };
        public BigInteger[] juniorLectsInfo = { 0, 0 };

        //science bar info: 
        public List<BigInteger[]> scienceWorkers;
        public BigInteger[] seniorSciInfo = { 0, 0 };
        public BigInteger[] regularSciInfo = { 0, 0 };
        public BigInteger[] juniorSciInfo = { 0, 0 };

        //grants bar info: 
        public List<BigInteger[]> grantWorkers;
        public BigInteger[] seniorProfInfo = { 0, 0 };
        public BigInteger[] regularProfInfo = { 0, 0 };
        public BigInteger[] juniorProfInfo = { 0, 0 };

        //upgrade costs are the same everywhere, fortunately:
        public BigInteger[] upgradeCosts = { 10000, 1000, 100 };
        public class Cost {
            public BigInteger educations;
            public BigInteger sciences;
            public BigInteger grants;

            public Cost() {
                educations = 0;
                sciences = 0;
                grants = 0;
            }
            public Cost(BigInteger e, BigInteger s, BigInteger g) {
                educations = e;
                sciences = s;
                grants = g;
            }

            public Cost(Cost cost) {
                educations = cost.educations;
                sciences = cost.sciences;
                grants = cost.grants;
            }

            public Cost(SerializableFaculty.Cost sfc) {
                educations = BigInteger.Parse(sfc.educations);
                sciences = BigInteger.Parse(sfc.sciences);
                grants = BigInteger.Parse(sfc.grants);
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

        public Faculty() {
            PrepareForWork();
        }

        public Faculty(SerializableFaculty sf) {

            totalEducation = BigInteger.Parse(sf.totalEducation);
            totalScience = BigInteger.Parse(sf.totalScience);
            totalGrants = BigInteger.Parse(sf.totalGrants);

            production = sf.production;

            for (int i = 0; i < sf.upgradeCosts.Length; i++)
                upgradeCosts[i] = BigInteger.Parse(sf.upgradeCosts[i]);

            allWorkers = new List<List<BigInteger[]>>();
            for (int i = 0; i < sf.allWorkers.Count; i++) {
                allWorkers.Add(new List<BigInteger[]>());
                for (int j = 0; j < sf.allWorkers[i].Count; j++) {
                    BigInteger[] temp = new BigInteger[2];
                    temp[0] = BigInteger.Parse(sf.allWorkers[i][j][0]);
                    temp[1] = BigInteger.Parse(sf.allWorkers[i][j][1]);
                    allWorkers[i].Add(temp);
                }
            }

            allCosts = new List<Cost[]>();
            for (int i = 0; i < sf.allCosts.Count; i++) {
                allCosts.Add(new Cost[sf.allCosts[i].Length]);
                for (int j = 0; j < sf.allCosts[i].Length; j++)
                    allCosts[i][j] = new Cost(sf.allCosts[i][j]);
            }

        }

        public void Increment() {

            for (int i = 0; i < allWorkers.Count; i++) {
                var seniorWorkers = allWorkers[i][0];
                var regularWorkers = allWorkers[i][1];
                var juniorWorkers = allWorkers[i][2];
                //hire new staff:
                regularWorkers[0] += seniorWorkers[0] * production[0] * (1 + seniorWorkers[1]);
                juniorWorkers[0] += regularWorkers[0] * production[1] * (1 + regularWorkers[1]);
            }
            
            //gather the edu, sci and gra:
            totalEducation += allWorkers[0][2][0] * production[2] * (allWorkers[0][2][1] + 1);
            totalScience += allWorkers[1][2][0] * production[2] * (allWorkers[1][2][1] + 1);
            totalGrants += allWorkers[2][2][0] * production[2] * (allWorkers[2][2][1] + 1);

        }
        public bool CanAfford(Cost cost) {
            if (totalEducation < cost.educations) return false;
            if (totalScience < cost.sciences) return false;
            if (totalGrants < cost.grants) return false;
            return true;
        }

        //this method below should only be called when we want to compare the cost of education alone
        public bool CanAfford(BigInteger educationCost) {
            return totalEducation >= educationCost;
        }

        //we basically divide our total resources by cost of one unit and get something
        public BigInteger GetAffordableWorkers(int selectedTab, int selectedItem) {
            Cost cost = allCosts[selectedTab][selectedItem];
            BigInteger maxEdu = totalEducation / cost.educations;
            if (cost.sciences != 0) {
                BigInteger maxSci = totalScience / cost.sciences;
                if (cost.grants != 0) {
                    BigInteger maxGra = totalGrants / cost.grants;
                    return BigInteger.Min(maxEdu, BigInteger.Min(maxSci, maxGra));
                } else
                    return BigInteger.Min(maxEdu, maxSci);
            } else
                return maxEdu;
        }
        public BigInteger GetAffordableUpgrades(int selectedItem) {
            //assume upgrades only cost education:
            return (totalEducation / upgradeCosts[selectedItem]);
        }

        //Buy method returns true if we broke the game:
        public bool Buy(int selectedTab, int selectedItem, string buttonTag) {
            Cost cost = allCosts[selectedTab][selectedItem];
            BigInteger howManyUnits = 1;
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
            BigInteger eduCost = upgradeCosts[selectedItem];
            BigInteger howManyUpgrades = 1;
            if (buttonTag == "1") howManyUpgrades = GetAffordableUpgrades(selectedItem) / 2;
            if (buttonTag == "2") howManyUpgrades = GetAffordableUpgrades(selectedItem);

            totalEducation -= eduCost * howManyUpgrades;

            allWorkers[selectedTab][selectedItem][1] += howManyUpgrades;

            if (totalEducation < 0) return true;
            else return false;

        }

        //checks if the amount of knowledge ammassed within the faculty became too big:
        //but now that i think about it, it probably will never return true
        public bool Exploded() {
            if (totalEducation < 0 || totalScience < 0 || totalGrants < 0) return true;
            else return false;

        }

        public void UpdateProduction(int newProductionMultiplier) {

            for (int i = 0; i < production.Length; i++)
                production[i] *= newProductionMultiplier;

        }

        public void UpdatePrices(int newPricesMultiplier) {

            for (int i = 0; i < allCosts.Count; i++) {
                for (int j = 0; j < allCosts[i].Length; j++) {
                    allCosts[i][j] = Cost.Multiply(newPricesMultiplier, allCosts[i][j]);
                }
            }

        }

        public void PrepareForWork() {
            totalEducation = STARTING_EDUCATION;
            totalScience = 0;
            totalGrants = 0;
            educationWorkers = new List<BigInteger[]>();
            educationWorkers.Add(seniorLectInfo);
            educationWorkers.Add(regularLectsInfo);
            educationWorkers.Add(juniorLectsInfo);

            scienceWorkers = new List<BigInteger[]>();
            scienceWorkers.Add(seniorSciInfo);
            scienceWorkers.Add(regularSciInfo);
            scienceWorkers.Add(juniorSciInfo);

            grantWorkers = new List<BigInteger[]>();
            grantWorkers.Add(seniorProfInfo);
            grantWorkers.Add(regularProfInfo);
            grantWorkers.Add(juniorProfInfo);

            allWorkers = new List<List<BigInteger[]>>();
            allWorkers.Add(educationWorkers);
            allWorkers.Add(scienceWorkers);
            allWorkers.Add(grantWorkers);

            ResetCostsAndProduction();
        }

        //useful for when we change the settings:
        public void ResetCostsAndProduction() {
            allCosts = new List<Cost[]>();
            Cost[] eduCosts = { new Cost(1000, 0, 0), new Cost(100, 0, 0), new Cost(10, 0, 0) };
            Cost[] sciCosts = { new Cost(1000, 40, 0), new Cost(200, 20, 0), new Cost(100, 0, 0) };
            Cost[] graCosts = { new Cost(2000, 500, 100), new Cost(400, 200, 10), new Cost(200, 100, 0) };
            allCosts.Add(eduCosts);
            allCosts.Add(sciCosts);
            allCosts.Add(graCosts);

            production[0] = 2;
            production[1] = 2;
            production[2] = 1;
        }
    }
}