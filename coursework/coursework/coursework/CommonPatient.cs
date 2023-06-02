using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework
{
    internal class CommonPatient:IPatient
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        public int balance { get; set; }
        public IMedicalCard medicalCard { get; set; }
        public void AddBalance(int sum)
        {
            balance += sum;
        }
        public void GoToExamenation(string fachOfDoctor)
        {

        }
    }
}
