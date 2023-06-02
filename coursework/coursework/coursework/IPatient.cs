using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework
{
    internal interface IPatient:IPerson
    {
        int balance { get; set; }
        IMedicalCard medicalCard { get; set; }

    }
}
