using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace JonasConsoleApp
{
    internal class App
    {
        public static string TITLE = "Jonas Console App";

        static void Main(string[] args)
        {
            Console.WriteLine(TITLE);

            ShowMenu();

        }

        private static void ShowMenu()
        {
            try
            {
                Console.WriteLine("Programm Start");

                bool again = true;

                while(again)
                {
                    Console.WriteLine("Hauptmenu [1=Benutzerinfos ausgeben 2=Benutzer löschen 3=Benutzer anlegen 4=Programm beenden 5=Ueber] >");
                    int choice = 0;

                    if (choice == 1)
                    {
                        Console.WriteLine("Benutzerinfos ausgeben");
                        // Benutzername abfragen
                    } else if (choice == 2)
                    {
                       Console.WriteLine("Benutzer löschen");
                    } else if (choice == 3)
                    {
                        Console.WriteLine("Benutzer anlegen");
                    } else if (choice == 4)
                    {
                        again = false;
                        Console.WriteLine("Programm beendet");
                    }
                    else if (choice == 5)
                    {
                        Console.WriteLine("Copyright @ Jonas Ermert 2022");
                    }


                }
            }
            catch
            {
                Console.WriteLine("Dieses Feature gibt es nicht");
            }
        }
    }

    [Serializable]
    internal class User
    {
        public int UserId { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }


        public override string ToString()
        {
            return UserId + LoginName + Password + FirstName + Surname + BirthDate;
        }

        public static bool IsUserExist(string LoginName, string Password)
        {
            
        }
    }

    internal class Password
    {
        ValidatePassword(string Password)
        {
            
                
        }
    }
    }

}
