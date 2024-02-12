using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2semFunkcijas_2_1_MGrITIA3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uztaisa divus double masīvus

            int garums = 4;

            double[] mas1 = new double[garums];
            double[] mas2 = new double[garums];


            // For cikli priekš random vērtībām

            Random rand = new Random();
            for (int i = 0; i < garums; i++)
            {
                mas1[i] = rand.Next(1, 10);
                mas2[i] = rand.Next(1, 10);
            }

            // Cikls izvada abus masīvus ar atstarpēm
            foreach (var item in mas1)
            {
                Console.Write(item + "          ");
            }
            Console.WriteLine();


            foreach (var item in mas2)
            {
                Console.Write(item + "          ");
            }
            Console.WriteLine();


            // User izvēle)) Paņēmu no savējā 1. semestra praktiņa
            char izvele;
            do
            {
                Console.WriteLine("\n1 - saskaitīt");
                Console.WriteLine("2 - atņemt");
                Console.WriteLine("3 - reizināt");
                Console.WriteLine("4 - dalīt");
                Console.WriteLine("5 - Vid aritm");
                Console.WriteLine("0 - iziet");

                Console.Write("\nJūsu izvēle: ");
                izvele = Console.ReadKey().KeyChar;

                if (izvele != '0')
                {
                    
                    switch (izvele)
                    {
                        case '1':
                            
                            Summet(mas1, mas2);
                            break;
                        case '2':
                            Atnemt(mas1, mas2); 
                            break;

                        case '3':
                            Reizinat(mas1, mas2);
                            break;

                        case '4':
                            Dalit(mas1, mas2);
                            break;

                        case '5':
                            VidejaisAritmetiskais(mas1, mas2);
                            break;

                            // Neliels EasterEgg ja izvēlies nepareizo opciju... :)
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nNepareiza izvēle...");
                            Console.WriteLine("███████▀▀▀░░░░░░░▀▀▀███████");
                            Console.WriteLine("████▀░░░░░░░░░░░░░░░░░▀████");
                            Console.WriteLine("███│░░░░░░░░░░░░░░░░░░░│███");
                            Console.WriteLine("██▌│░░░░░░░░░░░░░░░░░░░│▐██");
                            Console.WriteLine("██░└┐░░░░░░░░░░░░░░░░░┌┘░██");
                            Console.WriteLine("██░░└┐░░░░░░░░░░░░░░░┌┘░░██");
                            Console.WriteLine("██░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██");
                            Console.WriteLine("██▌░│██████▌░░░▐██████│░▐██");
                            Console.WriteLine("███░│▐███▀▀░░▄░░▀▀███▌│░███");
                            Console.WriteLine("██▀─┘░░░░░░░▐█▌░░░░░░░└─▀██");
                            Console.WriteLine("██▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄██");
                            Console.WriteLine("████▄─┘██▌░░░░░░░▐██└─▄████");
                            Console.WriteLine("█████░░▐█─┬┬┬┬┬┬┬─█▌░░█████");
                            Console.WriteLine("████▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐████");
                            Console.WriteLine("█████▄░░░└┴┴┴┴┴┴┴┘░░░▄█████");
                            Console.WriteLine("███████▄░░░░░░░░░░░▄███████");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                }

            } while (izvele != '0');
        }

        static void Summet(double[] mas1, double[] mas2)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Rezultāts:");

            // Cikls pārbauda vai abi masīvi vienādā garumā (Pieliku, jo... Just in case) Varbūt + punktiņi? :D
            if (mas1.Length != mas2.Length)    
                return;

            double[] mas3 = new double[mas2.Length];

            Random rand = new Random();

            for (int i = 0; i < mas3.Length; i++)
            {
                mas3[i]= mas1[i] + mas2[i];
                Console.Write(mas3[i] + " ");
            }
            Console.WriteLine();

        }

        static void Atnemt(double[] mas1, double[] mas2)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Rezultāts:");

            // Masīvu garuma pārbaude 

            if (mas1.Length != mas2.Length)
                return;
            double[] mas3 = new double[mas2.Length];



            Random rand = new Random();

            for (int i = 0; i < mas3.Length; i++)
            {
                mas3[i] = mas1[i] - mas2[i];
                Console.Write(mas3[i] + " ");
            }
            Console.WriteLine();
        }

        static void Reizinat(double[] mas1, double[] mas2)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Rezultāts:");

            // Masīvu garuma pārbaude

            if (mas1.Length != mas2.Length)
                return;
            double[] mas3 = new double[mas2.Length];

            Random rand = new Random();

            for (int i = 0; i < mas3.Length; i++)
            {
                mas3[i] = mas1[i] * mas2[i];
                Console.Write(mas3[i] + " ");
            }
            Console.WriteLine();
        }

        static void Dalit(double[] mas1, double[] mas2)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Rezultāts:");

            if (mas1.Length != mas2.Length)
                return;
            double[] mas3 = new double[mas2.Length];

            Random rand = new Random();

            // Šis cikls izdara atņemšanu un izvada rezultātu

            for (int i = 0; i < mas3.Length; i++)
            {
                mas3[i] = mas1[i] / mas2[i];
                Console.Write(mas3[i] + " ");
            }
        }

        static void VidejaisAritmetiskais(double[] mas1, double[] mas2)
        { 
            double vid1 = 0;
            double vid2 = 0;

            for (int i = 0; i < mas1.Length; i++)
            {
            vid1 += mas1[i];
            vid2 += mas2[i];    
            }

            //Izrēķina vidējo
            vid1 = vid1 / (mas1.Length);
            vid2 = vid2 / (mas2.Length);

            //Izvada visu prasīto 

            Console.WriteLine("\nPirma masīva vidēja aritmētiskā ir " +vid1+ " otrā masīva vidējā aritmētiskā ir " +vid2);

            if (vid1 > vid2)
            {
                Console.WriteLine($"Pirmā masīva vid vērtība ir lielāka par otrā masīva vid vērtību par {vid1 - vid2}");
            }
            if (vid2 > vid1)
            {
                Console.WriteLine($"Otrā masīva vid vērtība ir lielāka par pirmā masīva vid vērtību par {vid1 - vid2}");
            }
        }
    }
}
