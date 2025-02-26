using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Bookshop
{
    //Qaleslar
    internal class Tools
    {
        public string Tab { get; } = "                              ";
        public string[,] Users { get; set; } = new string[10, 2];
        public bool CheckUser(string email)
        {
            for (int i = 0; i < Users.Length / 2; i++)
            {
                if (Users[i, 0] == email) return true;
            }
            return false;
        }
        public void AddUser(string email, string password)
        {
            for (int i = 0; i < Users.Length / 2; i++)
            {
                if (Users[i, 0] == null)
                {
                    Users[i, 0] += email;
                    Users[i, 1] += password;
                    return;
                }
            }
        }
        public int Checking(string email, string password)
        {
            for (int i = 0; i < Users.Length / 2; i++)
            {
                if (email == Users[i, 0] && password == Users[i, 1]) return 1;
                else if (email == Users[i, 0] && password != Users[i, 1]) return 2;
                else if (email != Users[i, 0] && password == Users[i, 1]) return 2;


            }
            return 0;
        }
        public void ShowBooks()
        {
            for (int i = 0; i < 100; i++)
            {
                if (BooksLib.Books[i, 0] != null)
                {
                    Console.WriteLine("\n               {0}. {1}" +
                                      "\n               {2}"
                                        , i + 1, BooksLib.Books[i, 0], BooksLib.Books[i, 1]);
                }
            }
        }
        public void ShowDetails(char choise)
        {
            int index = Convert.ToInt32(choise) - 49;
            Console.WriteLine(index);
            if (BooksLib.Books[index, 0] != null && BooksLib.Books[index, 1] != null)
            {
                Console.WriteLine("\n\n         {0}" +
                                  "\n\n         kitobni avto'ri : {1}"
                                  , BooksLib.Books[index, 0], BooksLib.Books[index, 1]);
                if (BooksLib.Books[index, 2] == null) Console.WriteLine("\n\n         kitob haqida : . . . .");
                else Console.WriteLine("\n\n         kitob haqida : {0}", BooksLib.Books[index, 2]);
                Console.WriteLine("\n\n             1. sotib olish");
                Console.WriteLine("\n\n             2. orqaga qaytish");
            }
            else Console.WriteLine("\n\n{0} nimadur noto'g'ri ketdi 3", Tab);
            Console.ReadKey();
            Console.Clear();


        }
        public void AddBook()
        {
            Console.Write("\n\n{0} kitobni nomini kiriting : ", Tab);
            string bookName = Console.ReadLine();
            Console.Write("{0} Yozuvchini kiriting : ", Tab);
            string bookAuthor = Console.ReadLine();
            Console.Write("{0} kitob haqida ma'lumot kiriting : ", Tab);
            string bookInfo = Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < 100; i++)
            {
                if (BooksLib.Books[i, 0] == null)
                {
                    BooksLib.Books[i, 0] = bookName;
                    BooksLib.Books[i, 1] = bookAuthor;
                    BooksLib.Books[i, 2] = bookInfo;
                    return;
                }
            }
        }

    }
}
