using System;

namespace coursework
{
    internal static class DataBase
    { 
        public static List<IPatient> listOfPatients = new List<IPatient>();
        public static List<IDoctor> listOfDoctors = new List<IDoctor>();
        public static List<IMedicalCard> listOfMedicalCards=new List<IMedicalCard>();
        static string pathToListOfPatients = @"/d/kpi/op-kp23-gusachenko/coursework/DataBase/DataBaseOfPatients.csv";
        static string pathToListOfDoctors = @"/d/kpi/op-kp23-gusachenko/coursework/DataBase/DataBaseOfDoctors.csv";
        static string pathToListOfMedicalCards = @"/d/kpi/op-kp23-gusachenko/coursework/DataBase/DataBaseOfMedicalCards.csv";

        static void ReadFromDataBase()
        {
            ReadDoctor();
            ReadPatients();
            ReadMedicalCards();
           
        }
        static void WriteToDataBase()
        {
            WriteToDoctor();
            WriteToPatients();
            WriteToMedicalCards();
            
        }
        static void ReadPatients()
        {
            using (StreamReader reader = new StreamReader(pathToListOfPatients))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');

                    CommonPatient person = new CommonPatient();
                    if (!Convert.ToBoolean(fields[7])) person = new PremiumPatient(); 
                    person.id = Convert.ToInt32(fields[0]);
                    person.name = fields[1];
                    person.surname = fields[2];
                    person.email = fields[3];
                    person.password = fields[4];
                    person.age = Convert.ToInt32(fields[5]);
                    person.balance = Convert.ToInt32(fields[6]);

                    listOfPatients.Add(person);
                }
            }
        }
        static void ReadDoctor()
        {

        }
        static void ReadMedicalCards()
        {

        }
        static void WriteToPatients()
        {
            using (StreamWriter writer = new StreamWriter(pathToListOfPatients))
            {
                foreach (var person in listOfPatients)
                {
                    string line = $"{person.id},{person.name},{person.surname},{person.email},{person.password},{person.age},{person.balance},{person is PremiumPatient}";
                    writer.WriteLine(line);
                }
            }

        }
        static void WriteToDoctor()
        {

        }
        static void WriteToMedicalCards()
        {

        }
    }
}
