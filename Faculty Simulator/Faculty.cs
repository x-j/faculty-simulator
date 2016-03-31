using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty_Simulator {
    class Faculty {

        public string name;
        public int totalEducation;

        //education bar info: 
        //first element in the arrays is count, the second is number of upgrades.
        public List<int[]> educationWorkers;
        public int[] seniorLectInfo = { 0, 0 };
        public int[] regularLectsInfo = { 0, 0 };
        public int[] juniorLectsInfo = { 0, 0 };

        //education costs only, so twodimensional, later on twodimensional:
        public int[] buyCosts = { 1000, 100, 10 };
        public int[] upgradeCosts = { 10000, 1000, 100 };
                
        public Faculty(string v) {
            name = v;
            totalEducation = 0;
            educationWorkers = new List<int[]>();
            educationWorkers.Add(seniorLectInfo);
            educationWorkers.Add(regularLectsInfo);
            educationWorkers.Add(juniorLectsInfo);
        }

        public void Increment() {

            //hire new staff, gather the education:
            regularLectsInfo[0] += seniorLectInfo[0] * 2 * (seniorLectInfo[1] + 1);
            juniorLectsInfo[0] += regularLectsInfo[0] * (regularLectsInfo[1] + 1);
            totalEducation += juniorLectsInfo[0] * (juniorLectsInfo[1] + 1);

            //TODO: science and grants

        }
    }
}
