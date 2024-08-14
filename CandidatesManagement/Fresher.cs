using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CandidatesManagement
{
    public class Fresher : Candidate
    {
        string graduatedTime;
        string rankOfGraduation;
        string university;
        public Fresher(string id, string firstName, string lastName, string birthDate, string address, int phoneNumber, string email, string candidateType, string graduatedTime, string rankOfGraduation, string university) : base(id, firstName, lastName, birthDate, address, phoneNumber, email, candidateType)
        {
            this.graduatedTime = graduatedTime;
            this.rankOfGraduation = rankOfGraduation;
            this.university = university;
        }
        public string GetGraduatedTime()
        {
            return graduatedTime;
        }
        public string GetRankOfGraduation()
        {
            return rankOfGraduation;
        }
        public string GetUniversity()
        {
            return university;
        }
        public void SetGraduatedTime(string graduatedTime)
        {
            this.graduatedTime = graduatedTime;
        }
        public void SetRankOfGraduation(string rankOfGraduation)
        {
            this.rankOfGraduation= rankOfGraduation;
        }
        public void SetUniversity(string university)
        {
            this.university= university;
        }
        public override string ToString()
        {
            return id + " | " + firstName + " | " + lastName + " | " + birthDate + " | " + address + " | " + phoneNumber + " | " + email + " | " + candidateType + " | " + graduatedTime + " | " + rankOfGraduation + " | " + university;
        }
    }
}
