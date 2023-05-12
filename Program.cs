using System;

public class Profile 
{

	public static string name, username, followers, following, gender, starRating;
	public static string bio, courseYrSec, location;
	public static int rating, input;
 

	public static void Main(string[] args)
	{
		name = "Juan Dela Cruz";
		username = "juandelacruz";
        followers = "\n5 Followers";
        following ="/ 5 Following";
		gender = "he/him";
		rating = 5;
		bio = "Nothing lasts forever, we can change the future.   - Alucard";
		courseYrSec = "BSIT 2-1";
		location = "Binan City, Laguna";
		
		ViewProfile();
	}
	
	static void ViewProfile()
	{
		Console.WriteLine("{0}	{1}", name, gender);
		Console.WriteLine(username);
        Console.WriteLine("{0} {1}", followers, following);
		Console.WriteLine(GetStarRating(rating));
		
		Console.WriteLine();
		
		Console.WriteLine(bio);
		
		Console.WriteLine();
		
		Console.WriteLine("About: ");
		Console.WriteLine("Student of {0}", courseYrSec);
		Console.WriteLine("Lives in {0}", location);
		
		Console.WriteLine();
		Console.WriteLine();
		
		ShowMainMenu();
		GetUserInput();
	}
	
	static void ShowMainMenu()
	{
		Console.WriteLine("----Main Menu----");
		Console.WriteLine("1 | Edit Profile");
		Console.WriteLine("2 | Following");
		Console.WriteLine("3 | Followers");
		Console.WriteLine("4 | Options");
		Console.WriteLine("-----------------");
	}
	
	static int GetUserInput()
	{
		Console.Write("Your input: ");
		input = Convert.ToInt32(Console.ReadLine());
		
		return input;
	}

	static string GetStarRating(int rating)
	{
		switch (rating)
		{
			case 5 :
				starRating = "5.0 *****";
				break;
			
			case 4 :
				starRating = "4.0 ****";
				break;
			
			case 3 :
				starRating = "3.0 ***";
				break;
				
			case 2 :
				starRating = "2.0 **";
				break;
				
			case 1 :
				starRating = "1.0 *";
				break;
		}
		
		return starRating;	
	}
	
}