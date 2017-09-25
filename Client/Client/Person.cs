using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Person
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private long _contactNumber;


        public Person(string fname, string mname, string lname, long contact)
        {
            _firstName = fname;
            _middleName = mname;
            _lastName = lname;
            _contactNumber = contact;
        }

        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                this._firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this._middleName;
            }
            set
            {
                this._middleName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this._lastName;
            }
            set
            {
                this._lastName = value;
            }
        }
        public long Contact
        {
            get
            {
                return this._contactNumber;
            }
            set
            {
                this._contactNumber = value;
            }
        }
    }
}
