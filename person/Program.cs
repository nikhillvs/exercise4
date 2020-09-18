using System;

namespace person
{
    class person
    {
        private string firstname;
        private string lastname;
        private string emailid;
        private DateTime dob;

        public person(string firstname, string lastname, string emailid)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.emailid = emailid;
        }

        public person(string firstname, string lastname, DateTime dob)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.dob = dob;
        }

        public person(string firstname, string lastname, string emailid, DateTime dob)
        {
            this.dob = dob;
            this.firstname = firstname;
            this.lastname = lastname;
            this.emailid = emailid;
        }

        public string DOB { get => dob.ToString(); set => dob = new DateTime(Convert.ToInt32(value.Substring(0, 4)),Convert.ToInt32(value.Substring(4,2)),Convert.ToInt32(value.Substring(6,2))); }
        public string EmailAdress { get => emailid; set => emailid = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Firstname { get => firstname; set => firstname = value; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
