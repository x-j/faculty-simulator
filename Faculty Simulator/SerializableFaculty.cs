using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty_Simulator {

    //had to create this class because Faculty uses BigIntegers, which are not xmlserializable
    [Serializable]
    public class SerializableFaculty {
        //the values below have nothing to do with the Faculty itself, but it makes my life easier when loading a saved state   
        public int SpeedMultiplier { get; set; }
        public int PricesMultiplier { get; set; }
        public int ProductionMultiplier { get; set; }
        public double SecondsElapsed { get; set; }

        public string totalEducation;
        public string totalScience;
        public string totalGrants;

        public int[] production = { 2, 2, 1 };

        public List<List<string[]>> allWorkers;

        //upgrade costs are the same everywhere, fortunately:
        public string[] upgradeCosts = { "10000", "1000", "100" };
        public class Cost {
            public string educations;
            public string sciences;
            public string grants;

            public Cost() {
                educations = "0";
                sciences = "0";
                grants = "0";
            }
            public Cost(Faculty.Cost fc) {
                educations = fc.educations.ToString();
                sciences = fc.sciences.ToString();
                grants = fc.grants.ToString();
            }

        }

        public List<Cost[]> allCosts;

        public SerializableFaculty(Faculty f, double secondsElapsed, int prodMultiplier, int priceMultiplier, int speedMultiplier) {

            this.SecondsElapsed = secondsElapsed;
            this.ProductionMultiplier = prodMultiplier;
            this.PricesMultiplier = priceMultiplier;
            this.SpeedMultiplier = speedMultiplier;

            totalEducation = f.totalEducation.ToString();
            totalScience = f.totalScience.ToString();
            totalGrants = f.totalGrants.ToString();

            production = f.production;

            for (int i = 0; i < f.upgradeCosts.Length; i++)
                upgradeCosts[i] = f.upgradeCosts[i].ToString();

            allWorkers = new List<List<string[]>>();
            for (int i = 0; i < f.allWorkers.Count; i++) {
                allWorkers.Add(new List<string[]>());
                for (int j = 0; j < f.allWorkers[i].Count; j++) {
                    string[] temp = new string[2];
                    temp[0] = f.allWorkers[i][j][0].ToString();
                    temp[1] = f.allWorkers[i][j][1].ToString();
                    allWorkers[i].Add(temp);
                }
            }

            allCosts = new List<Cost[]>();
            for (int i = 0; i < f.allCosts.Count; i++) {
                allCosts.Add(new Cost[f.allCosts[i].Length]);
                for (int j = 0; j < f.allCosts[i].Length; j++) 
                    allCosts[i][j] = new Cost(f.allCosts[i][j]);
            }

        }

        public SerializableFaculty() {}

    }
}
