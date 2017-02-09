using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person
    {
        //protected string first_name;
        private string firstname;
        private string lastname;
        private int age;
        private int Id;

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
               firstname = value; }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

           public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public int ID
        {
            get
            {
                return Id;
            }
            set
            {
                Id= value;
            }
        }
        public Person(){ }
        public Person(string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }
        public string print
        {
            get
            {
               return firstname+" "+lastname+" "+age;
            }
        }


    } 
}
