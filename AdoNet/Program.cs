using AdoNet.Queries;
using System;

namespace AdoNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("1-Genres\n2-Actors\n3-FilmGenres\n4-FilmActors\n5-Hall\n6-Films\n7-Customer\n8-Sessionss\n9-Tickets\n0-Cıxış");
            Console.WriteLine("====================================");
            int choise;
            do
            {
             choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        Console.WriteLine("===========================");
                        Console.WriteLine("1-Create\n2-Update\n3-Read\n4-Delete\n5-All\n0-Cıxış");
                        Console.WriteLine("===========================");
                        int choise2;
                        do
                        {

                            choise2 = int.Parse(Console.ReadLine());
                            switch (choise2)
                            {
                                case 1:
                                    Console.WriteLine("===========================");
                                    Genres.Create(Console.ReadLine());
                                    break;
                                case 2:
                                    Genres.Update(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 3:
                                    Genres.Read(Console.ReadLine());
                                    break;
                                case 4:
                                    Genres.Delete(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 5:
                                    Genres.Select();
                                    break;
                                case 0:
                                    Console.WriteLine("Good Bye!");
                                    break;
                                 default:
                                    Console.WriteLine("You entered an incorrect");
                                    break;
                            }
                        } while (choise2!=0);
                        break;
                    case 2:
                        Console.WriteLine("1-Create\n2-Update\n3-Read\n4-Delete\n5-All\n0-Cıxış");
                        int choise3;
                        do
                        {
                            choise3 = int.Parse(Console.ReadLine());
                            switch (choise3)
                            {
                                case 1:
                                    Actors.Create(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 2:
                                    Actors.Update(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 3:
                                    Actors.Read(Console.ReadLine());
                                    break;
                                case 4:
                                    Actors.Delete(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 5:
                                    Actors.Select();
                                    break;
                                case 0:
                                    Console.WriteLine("Good Bye!");
                                    break;
                                default:
                                    Console.WriteLine("You entered an incorrect");
                                    break;
                            }
                        } while (choise3 != 0);
                        break;
                    case 3:
                        Console.WriteLine("1-Create\n2-Update\n3-Delete\n4-All\n0-Cıxış");
                        int choise4;
                        do
                        {
                            choise4 = int.Parse(Console.ReadLine());
                            switch (choise4)
                            {
                                case 1:
                                    FilmGenres.Create(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 2:
                                    FilmGenres.Update(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 3:
                                    FilmGenres.Delete(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 4:
                                    FilmGenres.Select();
                                    break;
                                case 0:
                                    Console.WriteLine("Good Bye!");
                                    break;
                                default:
                                    Console.WriteLine("You entered an incorrect");
                                    break;
                            }
                        } while (choise4 !=0);
                        break;
                    case 4:
                        Console.WriteLine("1-Create\n2-Update\n3-Delete\n4-All\n0-Cıxış");
                        int choise5;
                        do
                        {
                            choise5 = int.Parse(Console.ReadLine());
                            switch (choise5)
                            {
                                case 1:
                                    FilmActors.Create(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 2:
                                    FilmActors.Update(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 3:
                                    FilmActors.Delete(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 4:
                                    FilmActors.Select();
                                    break;
                                case 0:
                                    Console.WriteLine("Good Bye!");
                                    break;
                                default:
                                    Console.WriteLine("You entered an incorrect");
                                    break;
                            }
                        } while (choise5 != 0);
                        break;
                    case 5:
                        Console.WriteLine("1-Create\n2-Update\n3-Read\n4-Delete\n5-All\n0-Cıxış");
                        int choise6;
                        do
                        {
                            choise6 = int.Parse(Console.ReadLine());
                            switch (choise6)
                            {
                                case 1:
                                    Hall.Create(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                                break;
                                case 2:
                                    Hall.Update(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 3:
                                    Hall.Read(Console.ReadLine());
                                    break;
                                case 4:
                                    Hall.Delete(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 5:
                                    Hall.Select();
                                    break;
                                case 0:
                                    Console.WriteLine("Good Bye!");
                                    break;
                                default:
                                    Console.WriteLine("You entered an incorrect");
                                    break;
                            }
                        } while (choise6!=0);
                        break;
                    case 6:
                        Console.WriteLine("1-Create\n2-Update\n3-Read\n4-Delete\n5-All\n0-Cıxış");
                        int choise7;
                        do
                        {
                            choise7 = int.Parse(Console.ReadLine());
                            switch (choise7)
                            {
                                case 1:
                                    Films.Create(Console.ReadLine(), DateTime.Now);
                                    break;
                                case 2:
                                    Films.Update(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 3:
                                    Films.Read(Console.ReadLine());
                                    break;
                                case 4:
                                    Films.Delete(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 5:
                                    Films.Select();
                                    break;
                                case 0:
                                    Console.WriteLine("Good Bye!");
                                    break;
                                default:
                                    Console.WriteLine("You entered an incorrect");
                                    break;
                            }
                        } while (choise7 != 0);
                        break;
                    case 7:
                        Console.WriteLine("1-Create\n2-Update\n3-Read\n4-Delete\n5-All\n0-Cıxış");
                        int choise8;
                        do
                        {
                            choise8 = int.Parse(Console.ReadLine());
                            switch (choise8)
                            {
                                case 1:
                                    Customer.Create(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 2:
                                    Customer.Update(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 3:
                                    Customer.Read(Console.ReadLine());
                                    break;
                                case 4:
                                    Customer.Delete(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 5:
                                    Customer.Select();
                                    break;
                                case 0:
                                    Console.WriteLine("Good Bye!");
                                    break;
                                default:
                                    Console.WriteLine("You entered an incorrect");
                                    break;
                            }
                        } while (choise8 != 0);
                        break;
                    case 8:
                        Console.WriteLine("1-Create\n2-Update\n3-Delete\n4-All\n0-Cıxış");
                        int choise9;
                        do
                        {
                            choise9 = int.Parse(Console.ReadLine());
                            switch (choise9)
                            {
                                case 1:
                                    Sessionss.Create(DateTime.Now );
                                    break;
                                case 2:
                                    Sessionss.Update(DateTime.Now, Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 3:
                                    Sessionss.Delete(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 4:
                                    Sessionss.Select();
                                    break;
                                case 0:
                                    Console.WriteLine("Good Bye!");
                                    break;
                                default:
                                    Console.WriteLine("You entered an incorrect");
                                    break;
                            }
                        } while (choise9 != 0);
                        break;
                    case 9:
                        Console.WriteLine("1-Create\n2-Update\n3-Delete\n4-All\n0-Cıxış");
                        int choise1;
                        do
                        {
                            choise1 = int.Parse(Console.ReadLine());
                            switch (choise1)
                            {
                                case 1:
                                    Tickets.Create(DateTime.Now,Convert.ToDecimal(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 2:
                                    Tickets.Update(Convert.ToDecimal(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 3:
                                    Tickets.Delete(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 4:
                                    Tickets.Select();
                                    break;
                                case 0:
                                    Console.WriteLine("Good Bye!");
                                    break;
                                default:
                                    Console.WriteLine("You entered an incorrect");
                                    break;
                            }
                        } while (choise1 != 0);
                        break;
                    case 0:
                        Console.WriteLine("Good Bye!");
                        break;
                    default:
                        Console.WriteLine("You entered an incorrect");
                        break;
                }
            } while (choise !=0);
        }
    }
}
