using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 07";

            int day;
            int month;
            int year;
            string message;

            do
            {
                Console.WriteLine("Ingrese dia");
                message = Console.ReadLine();
            } while (!int.TryParse(message, out day));

            do
            {
                Console.WriteLine("Ingrese mes");
                message = Console.ReadLine();
            } while (!int.TryParse(message, out month));

            do
            {
                Console.WriteLine("Ingrese año");
                message = Console.ReadLine();
            } while (!int.TryParse(message, out year));

            if(!VerifyDate(day, month, year))
            {
                Console.WriteLine("Fecha invalida");
                Console.ReadKey();
                Environment.Exit(0);
            }

            DateTime today = DateTime.Now;

            int todayDay;
            int todayMonth;
            int todayYear;
            todayDay = today.Day;
            todayMonth = today.Month;
            todayYear = today.Year;

            int totalDias = 0;
            totalDias += todayDay - day;
            if(todayYear == year)
            {
                for(int i = month; i < todayMonth; i++)
                {
                    totalDias += diasDelMes(i, year);
                }

            }else if(todayYear > year)
            {
                for (int i = 1; i < todayMonth; i++)
                {
                    totalDias += diasDelMes(i, todayYear);
                }
                for (int i = month; i <= 12; i++)
                {
                    totalDias += diasDelMes(i, year);
                }
                for(int i = year+1; i < todayYear; i++)
                {
                    totalDias += 365;
                    if (esBisiesto(i))
                    {
                        totalDias++;
                    }
                }

            }

            Console.WriteLine("dias de tu vida {0}", totalDias);

            Console.ReadKey();
        }

        public static bool VerifyDate(int day, int month, int year)
        {
            bool correct = false;
            if (year > 0 && month > 0 && month < 13 && day > 0)
            {
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if(day <= 31)
                        {
                            correct = true;
                        }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if(day <= 30)
                        {
                            correct = true;
                        }
                        break;
                    case 2:
                        if (esBisiesto(year) )
                        {
                            if(day <= 29)
                            {
                                correct = true;
                            }
                        }
                        else
                        {
                            if (day <= 28)
                            {
                                correct = true;
                            }
                        }

                        break;
                }
            }
            return correct;
        }
        public static bool esBisiesto(int year)
        {
            bool retorno = false;
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                retorno = true;
            }
            return retorno;
        }
        public static int diasDelMes(int month, int year)
        {
            int retorno = 0;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    retorno = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    retorno = 30;
                    break;
                case 2:
                    if (esBisiesto(year))
                    {
                        retorno = 29;
                    }
                    else
                    {
                        retorno = 28;
                    }

                    break;
            }
            return retorno;
        }

    }


}


