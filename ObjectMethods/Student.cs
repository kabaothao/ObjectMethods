using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods
{
    internal class Student
    {
        public string name;
        public string major;
        public double gpa;


        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        //create a method whether or not the students have honors.
        //when jim calls this method it will use his gpa vice versa Pam.
        //the methods are powerful because they can get different information depending on the value of their attributes.
        //you can make as many methods you want from line 27 - 34
        public bool HasHonors()
        {
            if (gpa >= 3.5) //you can change the gpa and now the students will be honors just by changing line 28. this all you to define different rules.
            {
                return true;
            }
            return false;
        }
    }
        






    
}



//I defined three attributes. a student will have a name, major, and gpa.
