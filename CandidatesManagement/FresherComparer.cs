using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidatesManagement
{
    public class FresherComparer : IComparer<Fresher>
    {
        public int Compare(Fresher x, Fresher y)
        {
            return (x.firstName + x.lastName + x.candidateType).CompareTo(y.firstName + y.lastName + y.candidateType);
        }
    }
}
