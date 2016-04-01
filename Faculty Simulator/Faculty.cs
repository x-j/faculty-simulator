using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty_Simulator {
    class Faculty {

        public string name;
        public int totalEducation;
        public int totalScience;
        public int totalGrants;

        public int[] production = {2, 2, 1};

        public List<List<int[]>> allWorkers;

        //education bar info: 
        //first element in the arrays is count, the second is number of upgrades.
        public List<int[]> educationWorkers;
        public int[] seniorLectInfo = { 0, 0 };
        public int[] regularLectsInfo = { 0, 0 };
        public int[] juniorLectsInfo = { 0, 0 };

        //science bar info: 
        public List<int[]> scienceWorkers;
        public int[] seniorSciInfo = { 0, 0 };
        public int[] regularSciInfo = { 0, 0 };
        public int[] juniorSciInfo = { 0, 0 };

        //grants bar info: 
        public List<int[]> grantWorkers;
        public int[] seniorProfInfo = { 0, 0 };
        public int[] regularProfInfo = { 0, 0 };
        public int[] juniorProfInfo = { 0, 0 };

        public class Cost {
            public int educations;
            public int sciences;
            public int grants;

            public Cost(int e, int s, int g) {
                educations = e;
                sciences = s;
                grants = g;
            }
        }

        //education costs only, so twodimensional, later on twodimensional:
        public List<Cost[]> allCosts;
        public Cost[] eduCosts = { new Cost(1000, 0, 0), new Cost(100, 0, 0), new Cost(10, 0, 0) };
        public Cost[] sciCosts = { new Cost(1000, 40, 0), new Cost(200, 20, 0), new Cost(100, 0, 0) };
        public Cost[] graCosts = { new Cost(2000, 500, 100), new Cost(400, 200, 10), new Cost(200, 100, 0) };

        //upgrade costs are the same everywhere, fortunately:
        public int[] upgradeCosts = { 10000, 1000, 100 };

        public Faculty(string v) {
            name = v;
            totalEducation = 0;
            totalScience = 0;
            totalGrants = 0;
            educationWorkers = new List<int[]>();
            educationWorkers.Add(seniorLectInfo);
            educationWorkers.Add(regularLectsInfo);
            educationWorkers.Add(juniorLectsInfo);

            scienceWorkers = new List<int[]>();
            scienceWorkers.Add(seniorSciInfo);
            scienceWorkers.Add(regularSciInfo);
            scienceWorkers.Add(juniorSciInfo);

            grantWorkers = new List<int[]>();
            grantWorkers.Add(seniorProfInfo);
            grantWorkers.Add(regularProfInfo);
            grantWorkers.Add(juniorProfInfo);

            allWorkers = new List<List<int[]>>();
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
            totalGrants+= juniorProfInfo[0] * (juniorProfInfo[1] + 1);

        }
    }
}
