using System.Drawing;

namespace _0110task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task1
            //Student student = new Student("Yusif", "Celilli", "AB104", 75, false);

            //student.GetInfo();
            //student.CheckGraduation();
            //student.GetDiplomDegree();
            //task 2
            //int[] Reshad = new int[3];
            //int[] Aydan = new int[3];
            //int reshadcount = 0;
            //int aydancount = 0;
            //for (int i = 0; i < Reshad.Length; i++)
            //{
            //    Reshad[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < Aydan.Length; i++)
            //{
            //    Aydan[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    if (Reshad[i] > Aydan[i])
            //    {
            //        reshadcount++;
            //    }
            //    else if (Reshad[i] < Aydan[i])
            //    {
            //        aydancount++;
            //    }
            //}
            //task3
            //string inputText = "Yusif backendci olacaq ";
            //string[] wordArray = CollectWords(inputText);
            //Console.WriteLine(string.Join(", ", wordArray));
        }

        //task1
        //class Student
        //{
        //    public string Name;
        //    public string Surname;
        //    public string Group;
        //    public int Point;
        //    public bool isGraduated;
        //    public Student(string name, string surname, string group, int point)
        //    {
        //        Name = name;
        //        Surname = surname;
        //        Group = group;
        //        Point = point;

        //    }
        //    public Student(string name, string surname, string group, int point, bool isGraduated) : this(name, surname, group, point)
        //    {
        //        isGraduated = true;
        //    }

        //    public Student(string name, string surname, string group, int point, string v) : this(name, surname, group, point)
        //    {
        //    }


        //    public void GetInfo()
        //    {
        //        Console.WriteLine($"{Name},{Surname},{Group},{Point},{isGraduated}");
        //    }
        //    public void CheckGraduation()

        //    {
        //        for (int i = Point; i < 80;)


        //        if (isGraduated == false)
        //        {
        //            Console.WriteLine("mezun olub");
        //                break;
        //        }

        //        else
        //        {
        //            Console.WriteLine("kesilib");
        //        }

        //    }



        //    public void GetDiplomDegree()
        //    {
        //        if (Point==75)
        //        {
        //            Console.WriteLine("adi");
        //        }

        //    }




        //   }
        //task3
        //public static string[] CollectWords(string inputText)
        //{
        //    string[] words = inputText.Split();
        //    return words;
        //}
    }
}

