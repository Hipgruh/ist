using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace lessons
{
    class Program
    {
        static void Main()
        {




            //try
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(num);
            //}
            //catch (FormatException) {
            //    Console.WriteLine("Ne to");
            //}
            //try
            //{
            //    int a, b, res;
            //    Console.Write("enter num: ");
            //    a = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("enter num: ");
            //    b = Convert.ToInt32(Console.ReadLine());
            //    res = a / b;
            //    Console.WriteLine("Res" + res);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("null");
            //}
            //catch (FormatException) {
            //    Console.WriteLine("nooo");
            //}
            //finally { Console.WriteLine("stupid"); }




            ////Json
            //Console.WriteLine("Write Text");
            //string text = Console.ReadLine();
            //using (FileStream stream = new FileStream("input.json", FileMode.OpenOrCreate))
            //{
            //    byte[] array = System.Text.Encoding.Default.GetBytes(text);
            //    stream.Write(array, 0, array.Length);
            //}

            //using (FileStream stream1 = File.OpenRead("input.json"))
            //{
            //    byte[] array = new byte[stream1.Length];
            //    stream1.Read(array, 0, array.Length);

            //    string textfromfile = System.Text.Encoding.Default.GetString(array);
            //    Console.WriteLine(textfromfile);
            //}

            Console.ReadKey();
        }
        //Main{

        //string word = "Hey";
        //word += "!";

        ////word = String.Concat(word, "!!");

        //Console.WriteLine(String.Compare(word, "Hey!"));

        //string people = "1, 2, 3";
        //string[] name = people.Split(new char[] {','});
        //people = String.Join(" ", name);
        //Console.WriteLine(people);


        //byte[] nums = { 1, 2, 3, 4, };
        //byte res1 = Summa(nums);
        //Console.WriteLine("Res: " + res1);

        //byte[] nums1 = { 12, 2, 3, 4, };
        //byte res2 = Summa(nums1);
        //Console.WriteLine("Res: " + res2);}


        //public static byte Summa(byte[] digital)
        //{
        //    byte summ = 0;
        //    foreach (byte el in digital)  
        //        summ += el;
        //        return summ;

        //}

        //public static void Print(string word)
        //{
        //    Console.WriteLine(word);
        //}
        //public static int Summa(int x, int y)
        //{
        //  return x + y;
        //}




        //char[,] chars = new char[2,4];
        //chars[0,0] = 'a';
        //Console.WriteLine(chars[0, 0]);

        //int[,] nums = 
        //{
        //    {4, 5, 7 },
        //    {4, 5, 3 },
        //    {4, 5, 7 }
        //};
        //nums[1, 2] = 5;




        //short [] numbers = new short [10];
        //short suma = 0;
        //Random random = new Random();
        //for (byte i = 0; i < numbers.Length; i++)
        //{
        //    numbers[i] = Convert.ToInt16(random.Next(-15, 15));
        //    Console.WriteLine("El: " + numbers[i]);
        //    suma += numbers[i];
        //}
        //Console.WriteLine("Suma" + suma);





        // byte[] nums = new byte[5];
        // nums[0] = 240;
        // nums[1] = 24;
        // nums[2] = 40;
        // nums[3] = 4;
        // nums[4] = 25;

        //// Console.WriteLine("El " + nums[0]);

        // string[] words = new string[] { "1", "2", "3", "4", };
        // words[1] = "k";

        // for (byte i = 0; i < words.Length; i++) {
        //     Console.WriteLine("El: " + words[i]);
        // }







        //for (float i = 200; i > 10; i /= 2) {
        //    Console.WriteLine("Element: {0}", i);
        //}
        //byte i = 10;
        //while (i >= 1)
        //{
        //    Console.WriteLine("Element {0}", i);
        //    i--;
        //}

        //bool car = true;
        //while (car) { 
        //    string end = Console.ReadLine();
        //    if( end == "end")
        //        car = false;
        //}
        //byte i = 100;
        //do
        //{
        //    Console.WriteLine("Element:" + i);
        //} while (i < 200);

        //for (short i = 0; i < 10; i++) {
        //    //if (i > 5)
        //    //    break;
        //    if (i % 2 == 0)
        //        continue;
        //    Console.WriteLine("El: " + i);
        //}





        //short user_input = Convert.ToInt16(Console.ReadLine());

        //switch (user_input)
        //{
        //    case 5:
        //        Console.WriteLine("nUMBER 5 ");
        //        break;
        //    case 15:
        //        Console.WriteLine("nUMBER 15 ");
        //        break;
        //    case 55:
        //        Console.WriteLine("nUMBER 55 ");
        //        break;
        //    default: 
        //        Console.WriteLine("dont know number");
        //        break;
        //}







        //Console.Write("Name");
        //string role = Console.ReadLine();


        //if(role == "Admin")
        //{
        //    Console.Write("Enter name");
        //    string userName = Console.ReadLine();
        //    Console.Write("Enter {0} age");
        //    short age = Convert.ToInt16(Console.ReadLine());   

        //    if (age <= 0 || age > 99)
        //    {
        //        Console.Write("Enter {0} age", userName);
        //        age = Convert.ToInt16(Console.ReadLine());
        //    }
        //    if (age <= 0 || age > 99)
        //    {

        //        Console.Write("ERROR");
        //    }
        //    else
        //        Console.WriteLine("User age is " + age);

        //} else
        //    Console.WriteLine("You are not admin");



    }
}
