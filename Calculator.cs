class Calculator
    {

        static double Penambahan(double a, double b)
        {
            return a + b;
        }

        static double Pengurangan(double a, double b)
        {
            return a - b;
        }

        static double Perkalian(double a, double b)
        {
            return a * b;
        }

        static double Pembagian(double a, double b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            int pilihan;
            double a, b;
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("Pilih menu Calculator: ");
            Console.WriteLine("\n");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("\n");
            Console.WriteLine("Inputkan nomor menu [1..4]: ");
            pilihan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            if (pilihan == 1)
            {
                Console.WriteLine("Inputkan nilai a = ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b = ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("Hasil Penambahan {0} + {1} = {2}", a, b, Penambahan(a, b));

            }

            else if (pilihan == 2)
            {
                Console.WriteLine("Inputkan nilai a = ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b = ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));

            }

            else if (pilihan == 3)
            {
                Console.WriteLine("Inputkan nilai a = ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b = ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));



            }

            else if (pilihan == 4)
            {
                Console.WriteLine("Inputkan nilai a = ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b = ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));

            }

            else
            {
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
            }


            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
       

        }



    }

