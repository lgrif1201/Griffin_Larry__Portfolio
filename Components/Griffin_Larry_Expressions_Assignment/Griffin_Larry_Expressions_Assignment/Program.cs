using System;

namespace Griffin_Larry_Expressions_Assignment
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*
			 * Larry Griffin
			 * SDI section 1 
			 * 11/2/2015
			 * Expressions Assignment 
			*/

			//Prompt user for his/her name 
			Console.WriteLine ("Type in your name and press enter");
			//listen for users name 
			string userName = Console.ReadLine();
			// Introduce the user to the program and explain what we are about to do 
			Console.WriteLine ("Welcome "+ userName+ "!! This is the Friend Calculator! We will help you determine how popular you are by " +
				"calculating on average many friends you have across the various social media platforms! \r\n To begin enter the name of a " +
				"social media platform that you use:" );
			//Capture the name of social media platform 1
			string social1 = Console.ReadLine ();
			// Prompt user for number of friends/followers they have on social media platform 1
			Console.WriteLine ("How many friends or followers do you have on " + social1+ "?");

			//Capture number of friends/followers on 1st social media platform 
			string friends1 = Console.ReadLine ();
			//Prompt and capture the name and number of friends for a second media platforms
			Console.WriteLine ("What is the name of a second social media website that you like to use?");
			string social2 = Console.ReadLine ();
			Console.WriteLine ("How many friends or followers do you have on " + social2+ "?");
			string friends2 = Console.ReadLine ();

			//Prompt and capture the name and number of friends for a third media platforms
			Console.WriteLine ("What is the name of a third and final social platform that you use?");
			string social3 = Console.ReadLine ();
			Console.WriteLine ("How many friends or followers do you have on " + social3 + "?");
			string friends3 = Console.ReadLine ();

			//Parse the number of friends entered to convert them from a string to a number that can be used for calculations
			//int is used because a person can have millions of friends on one social media account
			int friendsInt1 =int.Parse (friends1);
			int friendsInt2 = int.Parse (friends2);
			int friendsInt3 = int.Parse (friends3);

			//Collect the number of friends into an array 
			int[]friends= new int[] { friendsInt1, friendsInt2,friendsInt3};

			//Add the total number of friends accross each platform
			int friendsTotal = friends[0]+ friends[1] +friends[2];

			//Divide the total number of friends by 3 to find the average 
			friendsTotal/=3;

			//Give the final answer with descriptive text
			Console.WriteLine (userName + " thanks for providing info from your "+ social1 + " " + social2+" and " + social3 + " accounts. \r\n" +
				"It looks like you have an average of " + friendsTotal + " friends accross your three social media sites!! \r\n" +
				" Wow you're pretty popular!!!");

			/*TEST STATISTICS
			 * Test 1: 10,20,30 average 20 correct
			 * test 2 5000, 2000000, 50000000 average=17335000 correct
			 * test 3: 1234,567,890 average: 897 correct
			*/
	
		
		}
	}
}
