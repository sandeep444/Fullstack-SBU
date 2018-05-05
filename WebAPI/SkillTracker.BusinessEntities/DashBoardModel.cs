using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTracker.BusinessEntities
{
    public class DashBoardModel
    {
        public List<GraphModel> GraphDetails { get; set; }
        public int RegistredCandidate { get; set; }
        public double FemaleCandidate { get; set; }
        public double MaleCandidate { get; set; }
        public double FresherCandidate { get; set; }
        public int RatedCandidate { get; set; }
        public double FemaleRatedCandidate { get; set; }
        public double MaleRatedCandidate { get; set; }
        public double Level1Candidate { get; set; }
        public double Level2Candidate { get; set; }
        public double Level3Candidate { get; set; }

        public List<AssociateModel> AssociateDetails { get; set; }

    }
}
