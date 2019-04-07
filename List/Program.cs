using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            people.Add(new Person() { Name = "Bohdan" , Id = 0 });
            people.Add(new Person() { Name = "Vadim" ,Id = 1});
            people.Add(new Person() { Name = "Oleh", Id = 2 });
            people.Add(new Person() { Name = "Bill", Id = 3 });
            people.Add(new Person() { Name = "Tom", Id = 4 });
            people.Add(new Person() { Name = "Andrew", Id = 5 });

            foreach (Person p in people)
            {
                Console.WriteLine("__________________________");
                Console.WriteLine(p);
            }
            Console.WriteLine("__________________________");
            Console.WriteLine("Choose person's Id to remove from list:");

            var choiceCR = Convert.ToInt32(Console.ReadLine());
            if (choiceCR <= 5 && choiceCR >= 0)
            {
                switch (choiceCR)
                {
                    case 0:
                        people.RemoveAt(0);
                        break;
                    case 1:
                        people.RemoveAt(1);
                        break;
                    case 2:
                        people.RemoveAt(2);
                        break;
                    case 3:
                        people.RemoveAt(3);
                        break;
                    case 4:
                        people.RemoveAt(4);
                        break;
                    case 5:
                        people.RemoveAt(5);
                        break;
                }
                foreach (Person p in people)
                {
                    Console.WriteLine("__________________________");
                    Console.WriteLine(p);
                }
            }
            else
            {
                Console.WriteLine("Incorrect input value!");
            }
            Console.ReadLine();
        }
    }
}
