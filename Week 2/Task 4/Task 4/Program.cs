using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Task 4

{

    class Program

    {

        static void Main(string[] args)

        {

            string pathString = "C:/Users/Пользователь/Desktop/papka/path/Adil.txt";

            string fileName = "Adil.txt";

            if (!System.IO.File.Exists(pathString))

            {

                using (System.IO.FileStream fs = System.IO.File.Create(pathString))

                {

                    for (byte i = 0; i < 100; i++)

                    {

                        fs.WriteByte(i);

                    }

                }

            }

            else

            {

                Console.WriteLine("File \"{0}\" already exists.", fileName);

                return;

            }

            string destFile = "C:/Users/Пользователь/Desktop/papka/path1/Adil.txt";

            string sourceFile = "C:/Users/Пользователь/Desktop/papka/path/Adil.txt";

            System.IO.File.Copy(sourceFile, destFile, true);

            if (System.IO.File.Exists("C:/Users/Пользователь/Desktop/papka/path/Adil.txt"))

            {



                try

                {

                    System.IO.File.Delete("C:/Users/Пользователь/Desktop/papka/path/Adil.txt");

                }

                catch (System.IO.IOException e)

                {

                    Console.WriteLine(e.Message);

                    return;

                }

            }



        }

    }

}
