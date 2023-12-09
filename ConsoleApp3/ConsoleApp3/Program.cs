using Newtonsoft.Json;
using System.Collections;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace ConsoleApp3
{
    internal class Program
    {
        public class Student
        {
            public int id;
            public string Name;
        }
        delegate int Del(int id);
  
        
        static void Main(string[] args)
        {
            List<Audi> listA = new List<Audi>()
                                    {

                                        new Audi()
                                        {
                                            Name = "A1",
                                            NumberOfCilander=1
                                        },
                                        new Audi()
                                        {
                                            Name = "A2",
                                            NumberOfCilander=2
                                        },
                                       new Audi()
                                        {
                                            Name = "A3",
                                            NumberOfCilander=3
                                        },

                                    };
            Serialization<Audi> serA = new Serialization<Audi>();
            string FilePathAudi = @"D:\files\JFileAudi.txt";
            serA.SerializeListOfData(listA, FilePathAudi);

            List<Audi> Audies=serA.Deserialize(FilePathAudi);
           
            foreach (Audi au in Audies)
            {
                Console.WriteLine(au.Name);
            }
            Console.WriteLine("************");

            List<Motor> listM = new List<Motor>()
                                    {

                                        new Motor()
                                        {
                                            Name = "m1",
                                            NumberOfCilander=1
                                        },
                                        new Motor()
                                        {
                                            Name = "m2",
                                            NumberOfCilander=2
                                        },
                                       new Motor()
                                        {
                                            Name = "M3",
                                            NumberOfCilander=3
                                        },

                                    };
            Serialization<Motor> serM = new Serialization<Motor>();
            string FilePathMotor = @"D:\files\JFileMotor.txt";
            serM.SerializeListOfData(listM, FilePathMotor);
            //change
            List<Motor> Motorss = serM.Deserialize(FilePathMotor);
            Motor m = Motorss[0];
            m.Name = "new Motor";
            serM.SerializeListOfData(Motorss, FilePathMotor);
            List<Motor>motorx=serM.Deserialize(FilePathMotor);
            foreach (Motor au in motorx)
            {
                Console.WriteLine(au.Name);
            }








        }




    }
}