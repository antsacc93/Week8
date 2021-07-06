using System;
using System.Linq;
using Week8.Master.Core.BusinessLayer;
using Week8.Master.Core.Repositories;
using Week8.Master.RepositoryEF;
using Week8.Master.RepositoryMock;

namespace Week8.Master
{
    class Program
    {
        //private static readonly IBusinessLayer bl = new MainBusinessLayer(new RepositoryCourseEF(), 
        //    new RepositoryLessonEF(), new RepositoryStudentEF(), new RepositoryTeacherEF());
        private static readonly IBusinessLayer bl = new MainBusinessLayer(new RepositoryCourseMock(), 
            new RepositoryLessonMock(), new RepositoryStudentMock(), new RepositoryTeacherMock());
        static void Main(string[] args)
        {           
            bool continua = true;
            while (continua)
            {
                continua = SchermoMenu();
            }
        }

        private static bool SchermoMenu()
        {
            Console.WriteLine("1. Inserisci Lezione");
            Console.WriteLine("2. Cancella Lezione");
            Console.WriteLine("3. Assegna docente ad una lezione");
            Console.WriteLine("4. Visualizza Corsi");
            Console.WriteLine("5. Visualizza Partecipanti di un corso");
            int scelta = Helper.VerificaInput(5);
            var esito = AnalizzaScelta(scelta);
            return esito;
        }

        private static bool AnalizzaScelta(int scelta)
        {
            bool go = true;
            switch (scelta)
            {
                case 1:
                    //INSERISCI LEZIONE;
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    VisualizzaPartecipanti();
                    break;
                default:
                    go = false;
                    break;
            }
            return go;
        }

        private static void VisualizzaPartecipanti()
        {
            Console.WriteLine("Inserisci il codice del corso da visualizzare");
            var code = Console.ReadLine();
            //var master = RepositoryManager.CreateMasterCourse(code);
            //IRepositoryCourse repoCourse = new RepositoryCourseEF();
            var master = bl.GetCourseWithStudents().FirstOrDefault(x => x.Code.Equals(code));
            Console.WriteLine(master);
            foreach (var student in master.Students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
