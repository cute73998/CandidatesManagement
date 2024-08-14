using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidatesManagement
{
    public class ExperienceComparer : IComparer<Experience>
    {
        public int Compare(Experience x, Experience y)
        {
            return (x.firstName + x.lastName + x.candidateType).CompareTo(y.firstName + y.lastName + y.candidateType);
        }
    }
}
