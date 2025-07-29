using System.Runtime.Intrinsics.X86;

namespace OppAss3
{
	#region Part2Question1
	/*
	 * Define an interface named IShape with a property Area and a method 
	 * DisplayShapeInfo. Create two interfaces, ICircle and IRectangle, that inherit from 
	 * IShape. Implement these interfaces in classes Circle and Rectangle. Test your 
	 * implementation by creating instances of both classes and displaying their shape
	 * information
	 */
	internal interface IShape
	{
		double Area { get;}
		void DisplayShapeInfo();
	}
	interface ICircle : IShape
	{
		double Radius { get; }
	}
	interface IRectangle : IShape
	{
		double Length { get; }
		double Width { get; }
	}
	internal class Circle : ICircle
	{
		public double Radius { get; set; }

		public Circle(double radius)
		{
			Radius = radius;
		}

		public double Area
		{
			get { return Math.PI * Radius * Radius; }

		} 

		public void DisplayShapeInfo()
		{
			Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area}");
		}
	}
	internal class Rectangle : IRectangle
	{
		public double Length { get; set; }
		public double Width { get; set; }

		public Rectangle(double length, double width)
		{
			Length = length;
			Width = width;
		}

		public double Area {
			get { return Length * Width; }
		}

		public void DisplayShapeInfo()
		{
			Console.WriteLine($"Rectangle: Length = {Length}, Width = {Width}, Area = {Area}");
		}
	}
	#endregion
	#region Part2Question2
	/*
	 * In this example, we start by defining the IAuthenticationService interface with two 
	 * methods: AuthenticateUser and AuthorizeUser. The BasicAuthenticationService 
	 * class implements this interface and provides the specific implementation for these methods.
	 * In the BasicAuthenticationService class, the AuthenticateUser method compares 
	 * the provided username and password with the stored credentials. It returns true if 
	 * the user is authenticated and false otherwise. The AuthorizeUser method checks if 
	 * the user with the given username has the specified role. It returns true if the user is authorized and false otherwise. 
	 */
	internal interface IAuthenticationService
	{
		bool AuthenticateUser(string username, string password);
		bool AuthorizeUser(string username, string role);
	}
	internal class BasicAuthenticationService : IAuthenticationService
	{
        public string []  Username { get; set; }
		public string [] Password { get; set; }
		public string[] Roles { get; set; } = new string[] { "Admin", "User", "Guest" };
		public BasicAuthenticationService(string[] username, string[] password)
		{
			Username = username;
			Password = password;
		}
		public bool AuthenticateUser(string username, string password)
		{
			for (int i = 0; i < Username.Length; i++)
			{
				if (Username[i] == username && Password[i] == password)
				{
					return true;
				}
			}
			return false;
		}
		public bool AuthorizeUser(string username, string role)
		{
			for (int i = 0; i < Username.Length; i++)
			{
				if (Username[i] == username && Roles.Contains(role))
				{
					return true;
				}
			}
			return false;
		}
	}
	#endregion
	#region Part2Question3
	internal interface INotificationService {
		void SendNotification(string recipient, string message);
	}
	internal class EmailNotificationService : INotificationService
	{
        public void SendNotification(string recipient, string message)
		{
			Console.WriteLine($"Email sent to {recipient}: {message}");
		}
	}
	internal class SmsNotificationService : INotificationService
	{
		public void SendNotification(string recipient, string message)
		{
			Console.WriteLine($"SMS sent to {recipient}: {message}");
		}
	}
	internal class PushNotificationService : INotificationService
	{
		public void SendNotification(string recipient, string message)
		{
			Console.WriteLine($"Push notification sent to {recipient}: {message}");
		}
	}
	#endregion
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Part1
			#region Question1
			//What is the primary purpose of an interface in C#? 
			//a) To provide a way to implement multiple inheritance
			//b) To define a blueprint for a class
			//c) To declare abstract methods and properties
			//d) To create instances of objects
			//Answer: b) To define a blueprint for a class
			#endregion
			#region Question2
			//Which of the following is NOT a valid access modifier for interface members in C#? 
			//a) private
			//b) protected
			//c) internal
			//d) public
			//Answer: b) protected
			#endregion
			#region Question3
			//Can an interface contain fields in C#? 
			//a) Yes
			//b) No
			//c) Only if they are static
			//d) Only if they are readonly
			//Answer: a) Yes
			#endregion
			#region Question4
			//In C#, can an interface inherit from another interface? 
			//a) No, interfaces cannot inherit from each other
			//b) Yes, interfaces can inherit from multiple interfaces
			//c) Yes, but only if they have the same methods
			//d) Only if the interfaces are in the same namespace
			//Answer: b) Yes, interfaces can inherit from multiple interfaces
			#endregion
			#region Question5
			//Which keyword is used to implement an interface in a class in C#? 
			//a) inherit
			//b) use
			//c) extends
			//d) implements
			//Answer: d) implements
			#endregion
			#region Question6
			//Can an interface contain static methods in C#? 
			//a) Yes
			//b) No
			//c) Only if the interface is sealed
			//d) Only if the methods are private
			//Answer: a) Yes
			#endregion
			#region Question7
			//In C#, can an interface have explicit access modifiers for its members? 
			//a) Yes, for all members
			//b) No, all members are implicitly public
			//c) Yes, but only for abstract members
			//d) Only if the interface is sealed
			//Answer: b) No, all members are implicitly public
			#endregion
			#region Question8
			//What is the purpose of an explicit interface implementation in C#? 
			//a) To hide the interface members from outside access
			//b) To provide a clear separation between interface and class members
			//c) To allow multiple classes to implement the same interface
			//d) To speed up method resolution
			//Answer : b) To provide a clear separation between interface and class members
			#endregion
			#region Question9
			//In C#, can an interface have a constructor? 
			//a) Yes, but it must be private
			//b) No, interfaces cannot have constructors
			//c) Yes, but only if the interface is sealed
			//d) Only if the constructor is static
			//Answer: b) No, interfaces cannot have constructors
			#endregion
			#region Question10
			//How can a C# class implement multiple interfaces? 
			//a) By using the "implements" keyword
			//b) By using the "extends" keyword
			//c) By separating interface names with commas
			//d) A class cannot implement multiple interfaces
			//Answer: c) By separating interface names with commas
			#endregion
			#endregion
			#region TestPart2Question1
			Circle circle = new Circle(5);
			circle.DisplayShapeInfo();
			Rectangle rectangle = new Rectangle(4, 6);
			rectangle.DisplayShapeInfo();
			#endregion
			#region TestPart2Question2
			/*
			 * In the Main method, we create an instance of the BasicAuthenticationService class 
			 * and assign it to the authService variable of type IAuthenticationService. 
			 * We then call the AuthenticateUser and AuthorizeUser methods using this interface reference. 
			 * This implementation allows you to switch the authentication service 
			 * implementation easily by creating a new class that implements the 
			 * IAuthenticationService interface and providing the desired logic for authentication and authorization. 
			 */
			string[] usernames = { "user1", "user2", "admin" };
			string[] passwords = { "pass1", "pass2", "adminpass" };
			IAuthenticationService authService = new BasicAuthenticationService(usernames, passwords);
			string username = "user1";
			string password = "pass1";
			if (authService.AuthenticateUser(username, password)) {
				Console.WriteLine("User authenticated successfully.");
			}
			else
			{
                Console.WriteLine("User not authenticated successfully");
			}
			string role = "Admin";
			if (authService.AuthorizeUser(username, role))
			{
				Console.WriteLine("User is authorized.");
			}
			else
			{
				Console.WriteLine("User is not authorized.");
			}
			#endregion
			#region TestPart2Question3
			/*
			 * In the Main method, we create instances of each notification service class and call 
			 * the SendNotification method with sample recipient and message values. 
			 * This implementation allows you to easily switch between different notification 
			 * channels by creating new classes that implement the INotificationService interface and provide the specific logic for each channel. 
			 */
			INotificationService Service = new EmailNotificationService();
			Service.SendNotification("mohannad", "Hello , How are You");
			Service = new SmsNotificationService();
			Service.SendNotification("mohannad", "Hello , How are You");
			Service = new PushNotificationService();
			Service.SendNotification("mohannad", "Hello , How are You");
			#endregion

		}
	}
}
