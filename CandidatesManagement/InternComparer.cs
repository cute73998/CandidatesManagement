using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidatesManagement
{
    public class InternComparer : IComparer<Intern>
    {
        public int Compare(Intern x, Intern y)
        {
            return (x.firstName + x.lastName + x.candidateType).CompareTo(y.firstName + y.lastName + y.candidateType);
        }
    }
}
