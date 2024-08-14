using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidatesManagement
{
    public class Intern : Candidate // Tạo đối tượng Intern kế thừa từ Candidate
    {
        string major;
        int semester;
        string university;

        public Intern(string id, string firstName, string lastName, string birthDate, string address, int phoneNumber, string email, string candidateType, string major, int semester, string university) : base(id, firstName, lastName, birthDate, address, phoneNumber, email, candidateType)
        {
            this.major = major;
            this.semester = semester;
            this.university = university;
        }
        public string getMajor() { return major; }
        public int getSemester() { return semester; }
        public string getUniversity() { return university; }

        public void setMajor(string major) { this.major = major; }
        public void setSemester(int semester) { this.semester = semester;}
        public void setUniversity(string university) { this.university=university;}

        public override string ToString()
        {
            return id + " | " + firstName + " | " + lastName + " | " + birthDate + " | " + address + " | " + phoneNumber + " | " + email + " | " + candidateType + " | " + major + " | " + semester + " | " + university;
        }
    }
}
