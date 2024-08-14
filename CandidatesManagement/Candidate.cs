using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CandidatesManagement
{
    public class Candidate
    {
        public string id;
       public  string firstName;
       public  string lastName;
      public  string birthDate;
     public  string address;
      public  int phoneNumber;
     public   string email;
    public    string candidateType;

        public Candidate(string id, string firstName, string lastName, string birthDate, string address, int phoneNumber, string email, string candidateType)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.candidateType = candidateType;
        }
        public string getId() { return id; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getBirthDate() { return birthDate; }
        public string getAddress() { return address; }
        public int getPhoneNumber() { return phoneNumber; }
        public string getEmail() { return email; }
        public string getCandidateType() { return candidateType; }

        public void setId(string id) { this.id = id; } 
        public void setFirstName(string firstName) { this.firstName = firstName; }
        public void setLastName(string lastName) { this.lastName = lastName; }
        public void setBirthDate(string birthDate) { this.birthDate = birthDate;}

        public void setAddress(string address) { this.address = address; }
        public void setPhoneNumber(int phoneNumber) { this.phoneNumber = phoneNumber; }
        public void setEmail(string email) { this.email = email; }
        public void setCandidateType(string candidateType) { this.candidateType = candidateType; }
        
        public override string ToString() { 
         return id + " | " + firstName + " | " + lastName + " | " + birthDate + " | " + address + " | " + phoneNumber + " | " + email + " | " + candidateType;
        }
    }
}
