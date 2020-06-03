using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab4._3_
{
    class Program
    {
     
        static void Main(string[] args)
        {
            List<Cloakroom> tp = new List<Cloakroom>();
            using (StreamReader rd = new StreamReader("E:save.txt"))
            {
                string p;
                string[] array;
                while (rd.EndOfStream == false)
                {
                   p = rd.ReadLine();
                    if (p != " " && p != "")
                    {
                        array = p.Split("|");
                        tp.Add(new Cloakroom(array[0], array[1], array[2],array[3], array[4]));

                    }
                }
            }
            Console.WriteLine("|Keys----------------- Description                      |");
            Console.WriteLine("|A  ------------------ All Clients                      |");
            Console.WriteLine("|N  ------------------ Add Client                       |");
            Console.WriteLine("|D  ------------------ Del Client                       |");
            Console.WriteLine("|E  ------------------ Edit Client                      |");
            Console.WriteLine("|F  ------------------ Search Client by Inventory number|");
            Console.WriteLine("|S  ------------------ Sort Clients by DeliveryDate     |");
            Console.WriteLine("|C  ------------------ CleanScreen                      |");
            if (Console.ReadKey().Key == ConsoleKey.A)
            {
                Console.Clear();
                Console.WriteLine("Clients of Cloakroom:");
                foreach (Cloakroom t in tp)
                {
                    Console.WriteLine(t.ToString());
                }
            }
            if (Console.ReadKey().Key == ConsoleKey.C)
            {
                Console.Clear();
            }
            if (Console.ReadKey().Key == ConsoleKey.D)
            {
                Console.Clear();
                Console.WriteLine("Do you want to delete client from Database(press y to do it)?");
                string q = Console.ReadLine();
                if (q == "y")
                {
                    Console.WriteLine("Enter the number of client you want to remove ");
                    int r = int.Parse(Console.ReadLine());
                    tp.RemoveAt(r - 1);
                    Console.WriteLine("Client number: " + r + "removed");
                    Rewrite("E:save.txt", tp);
                }
            }

            if (Console.ReadKey().Key == ConsoleKey.C)
            {
                Console.Clear();
            }

            if (Console.ReadKey().Key == ConsoleKey.A)
                {
                    Console.Clear();
                    Console.WriteLine(" Clients of Cloakroom:");
                    foreach (Cloakroom t in tp)
                    {
                        Console.WriteLine(t.ToString());
                    }
                }
            if (Console.ReadKey().Key == ConsoleKey.C)
            {
                Console.Clear();
            }

            if (Console.ReadKey().Key == ConsoleKey.N)
            {
                Console.Clear();
                Console.WriteLine(" Do you want to add new client(press y to do it)?");
                string a = Console.ReadLine();
                if (a == "y")
                {
                    Console.WriteLine("Enter Lastname:");
                    string q = Console.ReadLine();
                    Console.WriteLine("Enter DeliveryDate:");
                    string t = Console.ReadLine();
                    Console.WriteLine("Enter Time of storege:");
                    string l = Console.ReadLine();
                    Console.WriteLine("Enter Inventory number:");
                    string k = Console.ReadLine();
                    Console.WriteLine("Enter Thing:");
                    string r = Console.ReadLine();

                    if (q != null && t != null && l != null && k != null && r != null)
                    {
                        tp.Add(new Cloakroom() { Lastname = q, Deliverydate = t, Timeofstorage = l, Inventorynumber = k, Thing = r });
                        Console.WriteLine("Client Added");
                        Rewrite("E:save.txt", tp);


                    }
                    else
                        Console.WriteLine("You don't add new client");
                }
            }
            if (Console.ReadKey().Key == ConsoleKey.C)
            {
                Console.Clear();
            }

            if (Console.ReadKey().Key == ConsoleKey.A)
                {
                    Console.Clear();
                    Console.WriteLine(" Clients of Cloakroom:");
                    foreach (Cloakroom t in tp)
                    {
                        Console.WriteLine(t.ToString());
                    }
                }
            if (Console.ReadKey().Key == ConsoleKey.F)
            {
                Console.Clear();
                Console.WriteLine("Enter the deliverydate to find the client you want: ");
                string del = Console.ReadLine();
                Cloakroom search = tp.Find(search => search.Deliverydate == del);
                if (search != null)
                {
                    Console.WriteLine("|" + search.Lastname + "|" + search.Deliverydate + "|" + search.Timeofstorage + "|" + search.Inventorynumber + "|" + search.Thing + "|");
                }
                else
                {
                    Console.WriteLine("OOps problem");
                }
            }
            if (Console.ReadKey().Key == ConsoleKey.C)
            {
                Console.Clear();
            }
            if (Console.ReadKey().Key == ConsoleKey.A)
                {
                    Console.Clear();
                    Console.WriteLine(" Clients of Cloakroom:");
                    foreach (Cloakroom t in tp)
                    {
                        Console.WriteLine(t.ToString());
                    }
                }

            if (Console.ReadKey().Key == ConsoleKey.S)
            {
                Console.Clear();
                Console.WriteLine("Do you want to sort Clients(press y to do it)?");
                string q = Console.ReadLine();
                if (q == "y")
                {

                    Console.Clear();
                    Console.WriteLine("Your Clients:");
                    foreach (Cloakroom r in tp)
                    {
                        Console.WriteLine(r.ToString());
                    }
                    Console.WriteLine("Your clients after sort:");
                    var result = from Cloakroom in tp orderby Cloakroom.Deliverydate select Cloakroom;
                    foreach (Cloakroom r in result)
                    {
                        Console.WriteLine(r.ToString());
                    }
                }

            }
            if (Console.ReadKey().Key == ConsoleKey.E)
            {
                Console.Clear();
                Console.WriteLine("Do you want to edit information about client(press y to do it)?");
                string g = Console.ReadLine();
                if (g == "y")
                {
                    Cloakroom tp2 = new Cloakroom();
                    Console.WriteLine("Which client you want to edit(Enter number)?");
                    int w = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Lastname:");
                    string s = Console.ReadLine();
                    tp2.Lastname = s;
                    Console.WriteLine("Enter DeliveryDate:");
                    string p = Console.ReadLine();
                    tp2.Deliverydate = p;
                    Console.WriteLine("Enter Time of storege:");
                    string o = Console.ReadLine();
                    tp2.Timeofstorage = o;
                    Console.WriteLine("Enter Inventory number:");
                    string k = Console.ReadLine();
                    tp2.Inventorynumber = k;
                    Console.WriteLine("Enter Thing:");
                    string r = Console.ReadLine();
                    tp2.Thing = r;

                    tp.RemoveAt(w - 1);
                    tp.Insert(w - 1, tp2);
                    Console.WriteLine("Client  " + w + "edited");
                    Rewrite("E:save.txt", tp);
                }
              }
            if (Console.ReadKey().Key == ConsoleKey.C)
            {
                Console.Clear();
            }

            Console.WriteLine("Press Enter to exit");
            Console.ReadKey();
            }
        static public void Rewrite(string path, List<Cloakroom> clients)
        {
            File.WriteAllText(path, String.Empty);
            using (StreamWriter rn = new StreamWriter(path))
            {
                foreach (Cloakroom inform in clients)
                {
                    rn.WriteLine(inform.ToString());
                }
            }
        }
    }
    }
