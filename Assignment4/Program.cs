using System.Xml.Linq;

namespace Assignment4
{

    enum Weekdays 
    {
        Sunday,Monday, Tuesday, Wednesday,Thursday, Friday,Saturday
    }

    enum Season
    {
        Spring, Summer, Autumn, Winter
    }

    [Flags]
    enum Permissions
    {
        None = 0,Read = 1, Write = 2, Delete = 4, Execute = 8
    }

    enum Colors
    {
        Red, Green, Blue
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Weekdays 1
            //foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Person
            //Person[] gente = new Person[3];
            //gente[0] = new Person { name = "Assem", age = 25 };
            //gente[1] = new Person { name = "Mohamed", age = 23 };
            //gente[2] = new Person { name = "Raof", age = 24};

            //foreach (var soul in gente)
            //{
            //   Console.WriteLine($"Name : {soul.name} , Age: {soul.age}");
            //}
            #endregion

            #region Seasons
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season name.");
            //}
            #endregion

            #region Permissions
                Permissions userPermissions = Permissions.Read | Permissions.Write;

                Console.WriteLine($"Current Permissions: {userPermissions}");

                userPermissions |= Permissions.Execute;
                Console.WriteLine($"After Adding Execute: {userPermissions}");

                userPermissions &= ~Permissions.Write;
                Console.WriteLine($"After Removing Write: {userPermissions}");

                bool hasReadPermission = (userPermissions & Permissions.Read) != 0;
                Console.WriteLine($"Has Read Permission: {hasReadPermission}");
            #endregion

            #region Colors
                Console.WriteLine("Enter a color:");

                string input = Console.ReadLine();

                if (Enum.TryParse(input, true, out Colors color))
                {
                    Console.WriteLine($"{color} is a primary color.");
                }
                else
                {
                    Console.WriteLine($"{input} is not a primary color.");
                }

            #endregion


            #region 2D Points
                Console.WriteLine("Enter coordinates for Point 1 :");

                Point point1 = new Point();
                Console.Write("Enter X for Point 1: ");
                point1.X = int.Parse(Console.ReadLine());
                Console.Write("Enter Y for Point 1: ");
                point1.Y = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the coordinates for Point 2:");
                Point point2 = new Point();
                Console.Write("Enter X for Point 2: ");
                point2.X = int.Parse(Console.ReadLine());
                Console.Write("Enter Y for Point 2: ");
                point2.Y = int.Parse(Console.ReadLine());

                double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
            #endregion


            #region oldest one

                Person[] people = new Person[3];
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Enter details for person {i + 1}:");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Age: ");
                    int age = int.Parse(Console.ReadLine());
                    people[i] = new Person { name = name, age = age };
                }

                Person oldest = people[0];
                foreach (var person in people)
                {
                    if (person.age > oldest.age)
                    {
                        oldest = person;
                    }
                }

                Console.WriteLine($"The oldest person is {oldest.name}, Age: {oldest.age}");
            #endregion

        }
    }
}
