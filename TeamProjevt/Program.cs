using System;
using System.Linq.Expressions;
using System.Threading.Channels;


namespace Bookshop
{
    class Program
    {
        public static void Main()
        {
            var tools = new Tools();
            var books = new BooksLib();
            var t = tools.Tab;
            string userEmail = "";
            string userPassword = "";
            char choise;
            string[,] usersArr = tools.Users;
            bool vhod = false;
            usersArr[0, 0] = "user@gmail.com";
            usersArr[0, 1] = "0000";
            books.DefBooks();
           
            Console.Write("kartangizdagi mablag'ni kriting: ");
            tools.Summa = double.Parse(Console.ReadLine());
            

            while (true)
            {
                try
                {
                    Console.WriteLine("\n\n{0} 1. Akkauntga kirish", t);
                    Console.WriteLine("{0} 2. Akkaunt yaratish", t);
                    choise = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                    if (choise == '2')
                    {
                        Console.Write("\n\n{0} Emailingizni kiriting : ", t);
                        userEmail = Console.ReadLine();
                        Console.Clear();
                        if (tools.CheckUser(userEmail))
                        {
                            Console.Write("\n\n{0}bunday Email bilan akkaunt ochilgan !", t);
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        else if (!tools.CheckUser(userEmail))
                        {
                            Console.Write("\n\n{0} Emailingizni kiriting : {1}", t, userEmail);
                            Console.WriteLine();
                            Console.Write("{0} Parol yarating : ", t);
                            userPassword = Console.ReadLine();
                            Console.Clear();
                            bool checking = true;
                            while (checking)
                            {
                                Console.Write("\n\n{0} Emailingizni kiriting : {1}", t, userEmail);
                                Console.WriteLine();
                                Console.Write("{0} Parol yarating : {1}", t, userPassword);
                                Console.WriteLine();
                                Console.Write("{0} Parolni tasdiqlang : ", t);
                                if (userPassword == Console.ReadLine()) checking = false;
                                else Console.WriteLine("{0} Parolingiz tog'ri kelmayapti", t);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            Console.Clear();

                            tools.AddUser(userEmail, userPassword);
                            Console.WriteLine("\n\n{0} akkaunt yaratildi", t);
                            Console.ReadKey();
                            Console.Clear();
                        }


                    }
                    else if (choise == '1')
                    {
                        Console.Write("\n\n{0} Emailingizni kiriting : ", t);
                        userEmail = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("{0} Parol kiriting : ", t);
                        userPassword = Console.ReadLine();
                        switch (tools.Checking(userEmail, userPassword))
                        {
                            case 1:
                                vhod = true;
                                Console.WriteLine("\n\n{0} hush kelibsiz !", t);
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 2:
                                Console.WriteLine("\n\n{0} email yoki parol noto'gri kiritilgan !", t);
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 0:
                                Console.WriteLine("\n\n{0} bunday akkaunt mavjud emas !", t);
                                Console.ReadKey();
                                Console.Clear();
                                break;

                        }
                        Console.Clear();
                        while (vhod)
                        {
                            try
                            {
                                Console.WriteLine("\n\n{0} 1. kitoblarni korish ", t);
                                Console.WriteLine("{0} 2. kitob qo'shish ", t);
                                choise = Convert.ToChar(Console.ReadLine());
                                Console.Clear();
                                if (choise == '1')
                                {
                                    tools.ShowBooks();
                                    choise = Convert.ToChar(Console.ReadLine());
                                    Console.Clear();
                                    tools.ShowDetails(choise);
                                    choise = Convert.ToChar(Console.ReadLine());
                                    Console.Clear();
                                    if (choise == '2') continue;
                                    else if (choise == '1')
                                    {
                                        // logika qoshish kere
                                        Console.Write("Karta raqamingizni kriting: ");
                                        long sell = int.Parse(Console.ReadLine());
                                        string roomNumber = Convert.ToString(sell);
                                        if( roomNumber.Length == 16)
                                        { 
                                           tools.Sell(sell);   
                                            
                                        }



                                    }
                                }
                                else if (choise == '2')
                                {
                                    tools.AddBook();
                                }
                                else
                                {
                                    Console.WriteLine("\n\n{0} nimadur notogri ketdi 1", t);
                                    Console.ReadKey();
                                    Console.Clear();
                                    continue;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("\n\n{0} nimadur noto'g'ri ketdi 2", t);
                                Console.ReadKey();
                                Console.Clear();
                            }


                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n\n{0} nimadur notori ketdi", t);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
