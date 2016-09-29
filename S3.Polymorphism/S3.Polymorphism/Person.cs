using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3.Polymorphism
{
    public class Person
    {
        protected string firstname;
        protected string lastname;


        public Person()
        {

        }








        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
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
    }
}
