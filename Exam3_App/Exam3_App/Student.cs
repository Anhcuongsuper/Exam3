using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3_App
{
    class Student
    {
        private long _studentid;
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;
        private string _email;
        public long studentid { get => _studentid; set => _studentid = value; }
        public string firstName { get => _firstName; set => _firstName = value; }
        public string lastName { get => _lastName; set => _lastName = value; }
        public string phoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string email { get =>_email; set => _email = value; }
    }
}
