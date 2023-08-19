using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTypes
{
    internal class PersonModel
    {
        public string FirstName { private get; set; }
        public string LastName { get; private set; }
        //public int Age { get; set; }

        private string _password;

        public string Password
        {
            set { _password = value; }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }


        private int _age;

        public int Age
        {
            get { 
                return _age; 
            }
            set { 
                if(value >= 0 && value < 126) 
                { 
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age needs to be in a valid range.");
                }
            }
        }

        //public string SSN { get; set; }

        private string _ssn;

        public string SSN
        {
            get 
            { 
                string output = "***-**-" + _ssn.Substring(_ssn.Length - 4);
                return output; 
            }
            set { _ssn = value; }
        }
        // overloading allows us to have the same method name
        // and pass in different values and we'll treat them as different methods
        public PersonModel()
        {
               
        }

        //constructors run when you build the class
        public PersonModel(string lastName)
        {
               LastName = lastName;
        }


    }
}
