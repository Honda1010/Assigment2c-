namespace OPPAssCourse
{
	internal class Program
	{
		#region Qustion1Enum
		/*
		 * Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. 
		 * Then, write a C# program that prints out all the days of the week using this enum
		 */
		enum WeekDays
		{
			Monday,
			Tuesday,
			Wednesday,
			Thursday,
			Friday,
			Saturday,
			Sunday
		}

		#endregion
		#region Question2Struct
		/*
		 * Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data.
		 * Then, write a C# program to display the details of all the persons in the array. 
		 */
		struct person
		{
			public string Name { get; set; }
			public int Age { get; set; }
			public person(string name, int age)
			{
				Name = name;
				Age = age;
			}
		}
		#endregion
		#region Question3Enum
		/*
		 * Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. 
		 * Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
		 */
		enum Seasons
		{
			Spring,
			Summer,
			Autumn,
			Winter
		}
		#endregion
		#region Question4Enum
		/*
		 * Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
		 * Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
		 */
		[Flags]
		enum Permissions
		{
			Read = 1,
			Write = 2,
			Delete = 4,
			Execute = 8
		}
		#endregion
		#region Question5Enum
		/*
		 * Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
		 * Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not
		 */
		enum Colors
		{
			Red,
			Green,
			Blue
		}
		#endregion
		#region Question6Struct
		/*
		 * Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
		 * Write a C# program that takes two points as input from the user and calculates the distance between them.
		 */

		struct Point
		{
			public double X { get; set; }
			public double Y { get; set; }

			public Point(double x, double y)
			{
				X = x;
				Y = y;
			}

			public double DistanceTo(Point other)
			{
				return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
			}
		}
		#endregion
		#region	Question7Struct
		/*
		 * Create a struct called "Person" with properties "Name" and "Age".
		 * Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person
		 */
		struct Person
		{
			public string Name { get; set; }
			public int Age { get; set; }

			public Person(string name, int age)
			{
				Name = name;
				Age = age;
			}
		}

		#endregion
		#region Part2Question1
		/*
		 * Design and implement a Class for the employees in a company:
		 * Employee is identified by an ID, Name, security level, salary, hire date and Gender
		 */
		class Employee
		{
			public string Name { get; set; }
			public int Age { get; set; }
			public string ID { get; set; }
			public SecurityPrivileges SecurityLevel { get; set; }
			public decimal Salary { get; set; }
			public HiringDate HireDate { get; set; }
			public Gender Gender { get; set; }

			public Employee(String name , int age , string id, SecurityPrivileges securitylevel,decimal salary,HiringDate hiringDate,Gender gender) {
				Name = name;
				Age = age;
				ID = id;
				SecurityLevel = securitylevel;
				Salary = salary;
				HireDate = hiringDate;
				Gender = gender;
			}
			#region Part2Question5
			/*
			 * We want to provide the Employee Class to represent Employee data 
			 * in a string Form (override ToString ()), display employee salary in a currency format. [ use String.Format Function]
			 */
			public override string ToString()
			{
				return $"Name: {Name} , Age: {Age} , ID:{ID} , Salary: {Salary}"; 
			}
			public string GetFormattedSalary()
			{
				return Salary.ToString("C");
			}
			#endregion

		}
		#endregion
		#region Part2Question2
		//Develop a Class to represent the Hiring Date Data: consisting of fields to hold the day, month and Years
		class HiringDate
		{
			public int Day { get; set; }
			public int Month { get; set; }
			public int Year { get; set; }

			public HiringDate(int day, int month, int year)
			{
				Day = day;
				Month = month;
				Year = year;
			}
		}
		#endregion
		#region Part2Question3
		//We need to restrict the Gender field to be only M or F [Male or Female] 
		enum Gender
		{
			Male,
			Female
		}
		#endregion
		#region Part2Question4
		/*
		 * Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum
		 */
		[Flags]
		enum SecurityPrivileges
		{
			Guest = 1,
			Developer = 2,
			Secretary = 4,
			DBA = 8,

		}
		#endregion



		static void Main(string[] args)
		{
			#region Question1Test
			// Test the WeekDays enum by printing all the days of the week
			foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
			{
				Console.WriteLine(day);
			}
			#endregion
			#region Question2Test
			// Create an array of three Person objects and populate it with data
			person[] persons = new person[3];
			persons[0] = new person("Alice", 6);
			persons[1] = new person("Omar", 4);
			persons[2] = new person("Mai", 32);
			foreach (var person in persons)
			{
				Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
			}
			#endregion
			#region Question3Test
			// Take a season name as input from the user and display the corresponding month range
			Console.WriteLine("Enter a season: ");
			string inputSeason = Console.ReadLine();
			Seasons season;
			if (Enum.TryParse(inputSeason, true, out season))
			{
				switch (season)
				{
					case Seasons.Spring:
						Console.WriteLine("Spring: March to May");
						break;
					case Seasons.Summer:
						Console.WriteLine("Summer: June to August");
						break;
					case Seasons.Autumn:
						Console.WriteLine("Autumn: September to November");
						break;
					case Seasons.Winter:
						Console.WriteLine("Winter: December to February");
						break;
					default:
						Console.WriteLine("Invalid season entered.");
						break;
				}
			}
			else
			{
				Console.WriteLine("Invalid season entered.");
			}
			#endregion
			#region Question4Test
			Permissions userPermissions = Permissions.Read | Permissions.Write; // Assign Read and Write permissions
			Console.WriteLine("Current Permissions: " + userPermissions);
			userPermissions |= Permissions.Delete;
			Console.WriteLine("After adding Delete permission: " + userPermissions);
			if ((userPermissions & Permissions.Execute) == Permissions.Execute)
			{
				Console.WriteLine("Execute permission exists.");
			}
			else
			{
				Console.WriteLine("Execute permission does not exist.");
			}
			userPermissions &= ~Permissions.Write;
			Console.WriteLine("After removing Write permission: " + userPermissions);
			#endregion
			#region Question5Test
			// Take a color name as input from the user and check if it is a primary color or not
			Console.WriteLine("Enter a color : ");
			string inputColor = Console.ReadLine();
			Colors color;
			if (Enum.TryParse(inputColor,true,out color)) {
				if (color == Colors.Red || color ==Colors.Blue || color == Colors.Green) {
					Console.WriteLine($"{inputColor} is a primary color.");
				}
			}
			else
			{
				Console.WriteLine("color entered is not primary.");
			}
			#endregion
			#region Question6Test
			// Take two points as input from the user and calculate the distance between them
			Console.WriteLine("Enter the X of the first point : ");
			double x1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter the Y of the first point : ");
			double y1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter the X of the second point : ");
			double x2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter the Y of the second point : ");
			double y2 = Convert.ToDouble(Console.ReadLine());
			Point point1 = new Point(x1, y1);
			Point point2 = new Point(x2, y2);
			double distance = point1.DistanceTo(point2);
			Console.WriteLine($"The distance between the points ({point1.X}, {point1.Y}) and ({point2.X}, {point2.Y}) is: {distance}");
			#endregion
			#region Question7Test
			// Take details of 3 persons as input from the user and display the name and age of the oldest person
			Person[] people = new Person[3];
			people[0] = new Person("Mai", 33);
			people[1] = new Person("Alice", 8);
			people[2] = new Person("Omar", 22);
			Person oldest = people[0];
			foreach (var person in people)
			{
				if (person.Age > oldest.Age)
				{
					oldest = person;
				}
			}
			Console.WriteLine($"The oldest person is {oldest.Name} with age {oldest.Age}.");
			#endregion
			#region Part2Question6
			/*
			 * Create an array of Employees with size three a DBA, Guest and the third one is security officer 
			 * who have full permissions. (Employee [] EmpArr;)
			 */
			Employee[] EmpArr = new Employee[3];
			EmpArr[0] = new Employee("Mohannad",22,"0",SecurityPrivileges.DBA,2000,new HiringDate(15,7,2003),Gender.Male);
			EmpArr[1] = new Employee("Mai", 32, "1", SecurityPrivileges.Guest, 3000, new HiringDate(20, 12, 1992), Gender.Female);
			SecurityPrivileges fullPermissions = SecurityPrivileges.Guest | SecurityPrivileges.Developer | SecurityPrivileges.Secretary | SecurityPrivileges.DBA;
			EmpArr[2] = new Employee("Mohamed",62,"2",fullPermissions,5000,new HiringDate(7,4,1964),Gender.Male);
			Console.WriteLine(EmpArr[2].SecurityLevel);
			#endregion
		}

	}
}
