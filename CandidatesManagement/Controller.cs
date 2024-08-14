using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CandidatesManagement
{
    public class Controller // Hàm kiểm soát bao gồm tất cả các phương thức
    {
        List<Experience> experiences = new List<Experience>();
        List<Fresher> freshers = new List<Fresher>();
        List<Intern> interns = new List<Intern>();

        public void menuMain()
        {

            bool check = true;
            Console.ForegroundColor = ConsoleColor.Green;
            do
            {
                Console.WriteLine("*** CANDIDATE MANAGEMENT SYSTEM ***");
                Console.WriteLine("1. Experience");
                Console.WriteLine("2. Fresher   ");
                Console.WriteLine("3. Internship");
                Console.WriteLine("4. Searching ");
                Console.WriteLine("5. Exit      ");
                Console.WriteLine(" (Please choose 1 to Create Experience Candidate, 2 to Create Fresher Candidate, 3 to Internship Candidate, 4 to Searching and 5 to Exit program).");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        this.CreateExperience();
                        check = true;
                        break;
                    case 2:
                        this.CreateFresher();
                        break;
                    case 3:
                        this.CreateIntern();
                        break;
                    case 4:
                        this.searchFunction();
                        break;
                    case 5:
                        Console.WriteLine("You have exited the program !");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Valid input please try again with input from 1 -> 5");
                        check = false;
                        break;
                }
            }
            while (check == false);
        }
        public void CreateExperience() // Hàm tạo Experience
        {
            bool check = false;
            do
            {
                Console.WriteLine("*** Create Experience ***");
                Console.Write("Enter id: ");
                string id = Console.ReadLine();
                Console.Write("Enter first name: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter birth date: ");
                string birthDate = Console.ReadLine();
                Console.Write("Enter address: ");
                string address = Console.ReadLine();
                Console.Write("Enter phone number: ");
                int phone = int.Parse(Console.ReadLine());
                Console.Write("Enter email: ");
                string email = Console.ReadLine();               
                string type = "Experience";
                Console.Write("Enter year of experience: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Enter professional skill: ");
                string skill = Console.ReadLine();
                Experience newPerson1 = new Experience(id, firstName, lastName, birthDate, address, phone, email, type, year, skill);
                experiences.Add(newPerson1);
                Console.WriteLine("Create candidate Successfully!");
                Console.WriteLine("Do you want to continue (Y/N)?");
                Console.Write("Enter your choice: ");
                char choice = char.Parse(Console.ReadLine());
                if (choice == 'N' || choice == 'n')
                {
                    Console.WriteLine("*****  LIST OF EXPERIENCE  *****");
                    Console.WriteLine();
                    foreach (Experience save in experiences)
                    {
                        Console.WriteLine(save);
                    }
                    Console.WriteLine("Exit Successfully!");
                    this.menuMain();
                    check = false;

                }
                else if (choice == 'Y' || choice == 'y')
                {
                    check = true;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    this.menuMain();
                    check = false;
                }
            }
            while (check == true);

        }

        public void CreateFresher()
        {
            bool check = false;
            do
            {
                Console.WriteLine("*** Create Fresher ***");
            Console.Write("Enter id: ");
            string id = Console.ReadLine();
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter birth date: ");
            string birthDate = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();
            Console.Write("Enter phone number: ");
            int phone = int.Parse(Console.ReadLine());
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            string type = "Fresher";
            Console.Write("Enter graduated time: ");
            string graduated = Console.ReadLine();
            Console.Write("Enter rank of graduation: ");
            string rank = Console.ReadLine();
            Console.Write("Enter university where student graduated:  ");
            string university = Console.ReadLine();
            Fresher newPerson2 = new Fresher(id, firstName, lastName, birthDate, address, phone, email, type, graduated, rank, university);
            freshers.Add(newPerson2);
            Console.WriteLine("Create candidate Successfully!");
                Console.WriteLine("Do you want to continue (Y/N)?");
                Console.Write("Enter your choice: ");
                char choice = char.Parse(Console.ReadLine());
                if (choice == 'N' || choice == 'n')
                {
                    Console.WriteLine("****  List of Fresher  ****");
                    Console.WriteLine();
                    foreach (Fresher save in freshers)
                    {
                        Console.WriteLine(save);
                    }
                    Console.WriteLine("Exit Successfully!");
                    this.menuMain();
                    check = false;

                }
                else if (choice == 'Y' || choice == 'y')
                {
                    check = true;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    this.menuMain();
                    check = false;
                }
            }
            while (check == true);
        }

        public void CreateIntern()
        {
            bool check = false;
            do
            {
                Console.WriteLine("*** Create Intern ***");
                Console.Write("Enter id: ");
                string id = Console.ReadLine();
                Console.Write("Enter first name: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter birth date: ");
                string birthDate = Console.ReadLine();
                Console.Write("Enter address: ");
                string address = Console.ReadLine();
                Console.Write("Enter phone number: ");
                int phone = int.Parse(Console.ReadLine());
                Console.Write("Enter email: ");
                string email = Console.ReadLine();
                string type = "Intern";
                Console.Write("Enter major of intern: ");
                string major = Console.ReadLine();
                Console.Write("Enter semester: ");
                string semester = Console.ReadLine();
                Console.Write("Enter university:  ");
                string university = Console.ReadLine();
                Fresher newPerson2 = new Fresher(id, firstName, lastName, birthDate, address, phone, email, type, major, semester, university);
                freshers.Add(newPerson2);
                Console.WriteLine("Create candidate Successfully!");
                Console.WriteLine("Do you want to continue (Y/N)?");
                Console.Write("Enter your choice: ");
                char choice = char.Parse(Console.ReadLine());
                if (choice == 'N' || choice == 'n')
                {
                    Console.WriteLine("****  List of Intern  ****");
                    Console.WriteLine();
                    foreach (Intern save in interns)
                    {
                        Console.WriteLine(save);
                    }
                    Console.WriteLine("Exit Successfully!");
                    this.menuMain();
                    check = false;

                }
                else if (choice == 'Y' || choice == 'y')
                {
                    check = true;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    this.menuMain();
                    check = false;
                }
            }
            while (check == true);
        }

        public static List<Fresher> FindAndSortFresher(List<Fresher> freshers, string name, string type)
        {
            var listTempo1 = freshers.Where(p => ((p.firstName.Contains(name, StringComparison.OrdinalIgnoreCase) || p.lastName.Contains(name, StringComparison.OrdinalIgnoreCase)) && p.candidateType.Contains(type, StringComparison.OrdinalIgnoreCase))).ToList();
            listTempo1.Sort(new FresherComparer());
            return listTempo1;
        }

        public static List<Experience> FindAndSortExperience(List<Experience> experiences, string name, string type)
        {
            var listTempo2 = experiences.Where(p => ((p.firstName.Contains(name, StringComparison.OrdinalIgnoreCase) || p.lastName.Contains(name, StringComparison.OrdinalIgnoreCase)) && p.candidateType.Contains(type, StringComparison.OrdinalIgnoreCase))).ToList();
            listTempo2.Sort(new ExperienceComparer());
            return listTempo2;
        }

        public static List<Intern> FindAndSortIntern(List<Intern> interns, string name, string type)
        {
            var listTempo3 = interns.Where(p => ((p.firstName.Contains(name, StringComparison.OrdinalIgnoreCase) || p.lastName.Contains(name, StringComparison.OrdinalIgnoreCase)) && p.candidateType.Contains(type, StringComparison.OrdinalIgnoreCase))).ToList();
            listTempo3.Sort(new InternComparer());
            return listTempo3;
        }

        public void searchFunction() // Đã sửa được lỗi trống danh sách khi in ra bởi (Cách sửa cho menu vào lớp Controller bởi nếu gọi từ ngoài vào sẽ bị làm mới và làm trống LIST)
        {
            Console.WriteLine("===========EXPERIENCE CANDIDATE============");
            foreach(Experience person1 in experiences)
            {
                Console.WriteLine(person1.firstName+" " + person1.lastName);
            }
            Console.WriteLine();
            Console.WriteLine("==========FRESHER CANDIDATE==============");
            foreach (Fresher person2 in freshers)
            {
                Console.WriteLine(person2.firstName + " " + person2.lastName);
            }
            Console.WriteLine();
            Console.WriteLine("===========INTERN CANDIDATE==============");
            foreach (Intern person3 in interns)
            {
                Console.WriteLine(person3.firstName + " " + person3.lastName);
            }
            Console.WriteLine();
            Console.WriteLine("Input Candidate name (First name or Last name): ");
            string name = Console.ReadLine();
            Console.WriteLine("Input type of Candidate: ");
            string type = Console.ReadLine();
            var list1 = FindAndSortExperience(experiences, name, type);
            var list2 = FindAndSortFresher(freshers, name, type);
            var list3 = FindAndSortIntern(interns, name, type);
            Console.WriteLine("The candidates found: ");
            if ( list1.Count != 0 || list2.Count != 0 || list3.Count != 0)
            {
                foreach (Experience person in list1)
                {
                    Console.WriteLine(person.firstName + " " + person.lastName +" | "+ person.birthDate + " | " + person.address + " | " + person.phoneNumber + " | " + person.email + " | " + person.candidateType);
                }
                foreach (Intern person in list3)
                {
                    Console.WriteLine(person.firstName + " " + person.lastName + " | " + person.birthDate + " | " + person.address + " | " + person.phoneNumber + " | " + person.email + " | " + person.candidateType);
                }
                foreach (Fresher person in list2)
                {
                    Console.WriteLine(person.firstName + " " + person.lastName + " | " + person.birthDate + " | " + person.address + " | " + person.phoneNumber + " | " + person.email + " | " + person.candidateType);
                }

            }
            else {
                Console.WriteLine("Can not found this candidate!");
                this.menuMain();
            }

        }


    }
}
