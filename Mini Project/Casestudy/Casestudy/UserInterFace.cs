using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casestudy
{
    class UserInterFace : prg
    {
        AppEngine engine = new AppEngine();

        string res;
        public void showFirstScreen()
        {
            do
            {
                Console.WriteLine("Welcome To CodeLearning ");
                Console.WriteLine("\nTurn on Your User Mode : \n1. Student\n2. Admin");
                Console.WriteLine("\nEnter your choice Either \t 1  nor  2 ");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        showStudentScreen();
                        break;
                    case 2:
                        showAdminScreen();
                        break;
                    default:
                        Console.WriteLine("Choose Valid Option");
                        break;
                }
                Console.WriteLine("Do you want to continue Main Screen:Yes or No");
                res = Console.ReadLine();
            }
            while ((res == "Yes") || (res == "yes"));
        }

        public void showStudentScreen()
        {
            do
            {
                Console.WriteLine("Select: \n1. Student Registration \n2.Available Courses \n3.Enroll to Course in List");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {

                    case 1://New registration
                        this.showStudentRegistrationScreen();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 2:
                        //Showcase all available courses
                        Console.WriteLine("--------------------List of Courses------------------------");
                        engine.AllCoursesLists();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 3:
                        //Student enrolling to particular course
                        engine.EnrollStudent();
                        Console.WriteLine("You have successfully enrolled you may Exit the Screen now");
                        break;
                    default:
                        Console.WriteLine("Enter valid Option....!");
                        break;
                }
                Console.WriteLine("Do you want to continue Student Screen:Yes or No");
                res = Console.ReadLine();
            } while ((res == "Yes") || (res == "yes"));
        }
        public void showAdminScreen()
        {
            do
            {
                Console.WriteLine("Select: \n1.Introduce New Course\n\n2.Courses Available\n\n3.Update Course Details\n\n4.Select Particular Course\n \n5.Deleting Existing Student\n\n6.Delete Course\n \n7.Update Student Details \n\n8.All Registered Students \n\n9.All Enroll Lists \n\n10.Check Particular Student \n\n11.Delete Particular Enroller\n \n12.Update EnrollDetails");
                Console.WriteLine("\n\nEnter Your Option");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        //If any new course want to add for Organization
                        this.introduceNewCourseScreen();
                        Console.WriteLine("Completed\nYou may Close the tab.\n Thankyou!");
                        break;
                    case 2:
                        //list of existing courses
                        Console.WriteLine("****-------------Available Courses in Institute-------------------****");
                        showAllCoursesScreen();
                        Console.WriteLine("Completed\nYou may Close the tab.\n Thankyou!");
                        break;
                    case 3:
                        //updates in Course structure
                        engine.updateCourse();
                        Console.WriteLine("Successfully updated\nYou may Close the tab.\n Thankyou!");
                        break;
                    case 4:
                        //getting particular course details
                        engine.ParticularCourse();
                        Console.WriteLine("\nYou may Close the tab.\n Thankyou!");
                        break;
                    case 5:
                        //deletes particular student
                        engine.DeleteStudents();
                        Console.WriteLine("Sucessfully deleted Student data\nYou may Close the tab.\n Thankyou!");
                        break;
                    case 6:
                        //deletes existing course only that are not enrolled by any students
                        engine.DeleteCourse();
                        Console.WriteLine("\nCourse was deleted\nYou may Close the tab.\n Thankyou!");
                        break;
                    case 7:
                        //modify existing student details
                        engine.UpdateStudent();
                        Console.WriteLine("\nModification was sucessfull done\nYou may Exit....!");
                        break;
                    case 8:
                        //Gives ALL Students Details
                        showAllStudentsScreen();
                        break;
                    case 9:
                        Console.WriteLine("All Enrolls Lists..............");
                        engine.EnrollLists();
                        Console.WriteLine("Completed\nYou may Close the tab.\n Thankyou!");
                        break;
                    case 10:
                        // Checks  Particular student details
                        engine.ParticularStudent();
                        Console.WriteLine("\nYou may Close the tab.\n Thankyou!");
                        break;
                    case 11:
                        engine.DeleteParticularEnroll();
                        Console.WriteLine("Enrollment was deleted....!");
                        break;
                    case 12:
                        engine.UpdateEnroller();
                        Console.WriteLine("Enroller updated Sucessfully\n Thankyou!");
                        break;

                    default:
                        Console.WriteLine("Please Enter a valid Option....!");
                        break;
                }
                Console.WriteLine("Do you want to continue Admin Screen:Yes or NO");
                res = Console.ReadLine();
            } while ((res == "Yes") || (res == "yes"));

        }
        public void showAllStudentsScreen()
        {
            Console.WriteLine("List of All Student Details : ");
            engine.AllStudentDetails();
        }
        public void showStudentRegistrationScreen() // Execute the register method of AppEngine class
        {
            Console.WriteLine("You are Entering into Student Registration form :");
            Console.WriteLine("Enter the Student Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Student FullName:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Student Date of Birth:");
            string dob = Console.ReadLine();
            engine.register(new Student(id, name, dob));
        }

        public void introduceNewCourseScreen()
        {
            engine.insertingCourse();
        }
        public void showAllCoursesScreen()
        {
            Console.WriteLine("List of all courses : ");
            engine.AllCoursesLists();
        }
    }
}