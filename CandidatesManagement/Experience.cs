using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CandidatesManagement
{
    public class Experience : Candidate
    {
        int ExpInYear;
        string proSkill;

        public Experience(string id, string firstName, string lastName, string birthDate, string address, int phoneNumber, string email, string candidateType, int expInYear, string proSkill) : base(id, firstName, lastName, birthDate, address, phoneNumber, email, candidateType)
        {
           this.ExpInYear = expInYear;
            this.proSkill = proSkill;
        }
        public int getExpInYear() { return ExpInYear; }
        public string getProSkill() { return proSkill; }
        public void setExpInYear(int ExpInYear) { this.ExpInYear = ExpInYear; }
        public void setProSkill(string proSkill) { this.proSkill = proSkill; }

        public override string ToString()
        {
            return id + " | " + firstName + " | " + lastName + " | " + birthDate + " | " + address + " | " + phoneNumber + " | " + email + " | " + candidateType + " | " + ExpInYear + " | " + proSkill;
        }
    }
}
