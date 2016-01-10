
using System;

namespace Griffin_Larry_Project1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Greet the guest 
			Console.WriteLine ("Its that time of the year again! Time to round up all the documents you need for your taxes! " +
			"I'm here to make the process a little easier for you and take the guess work out of taxes. \r\n First start off by telling me your name.");
			//collect users name 
			string userName = Console.ReadLine ();
			while (string.IsNullOrWhiteSpace (userName)) {
				//tell user what went wrong and give option to correct it
				Console.WriteLine ("You did not tell me the name of your name. \r\n Please type you're name.");
				userName = Console.ReadLine ();
			}


				Console.WriteLine ("Welcome {0}! \r\n First thing first, were you employed at anyime during the previous year? Enter Y for yes or N for no ", userName);
				//collect answer
				string employment = Console.ReadLine ();
				//check for response
				while (string.IsNullOrWhiteSpace (employment)) {
					//tell user what went wrong and give option to correct it
					Console.WriteLine ("ERROR! You did not respond to the previous question. \r\n Were you employed at anyime during the previous year? Enter Y for yes or N for no.");
					employment = Console.ReadLine ();
				}
			//Check for correct response 
			if (employment == "Y" || employment == "y") {
				Console.WriteLine ("Its great the you were employeed this previous year. Don't forget to collect your W2 from your employer");
			} if (employment == "N" || employment == "n") {
				Console.WriteLine ("That's ok. There will be other oppurtunities for employement in the year to come");
			} else {
				//Give gyest another chance to enter corrrect response
				Console.WriteLine ("ERROR! PLease type the correct response. Enter Y for yes or N for no. \r\n Were you employeed in the previous year");
				employment = Console.ReadLine ();
				if (employment == "Y" || employment == "y") {
					Console.WriteLine ("Its great the you were employeed this previous year. Don't forget to collect your W2 from your employer");
				} if (employment == "N" || employment == "n") {
					Console.WriteLine ("That's ok. There will be other oppurtunities for employement in the year to come");
				}
			}
			//ask a new question 
			Console.WriteLine ("Next question: Did you attend school at a college or university this past year ?\r\n Enter Y for yes or N for no");
			string school = Console.ReadLine ();
			//check for response
			while (string.IsNullOrWhiteSpace (school)) {
				// tell user what went wrong and try to fix it 
				Console.WriteLine ("ERROR! You did not respond to the previous question\r\n Did you attend school at a college or university this past year ?\r\n Enter Y for yes or N for no");
			}
			// verify answers
			if (school == "Y" || school == "y") {
				Console.WriteLine ("Its great the you furthered your education this previous year. Don't forget to collect your 1098-T from your school");
			} if (school == "N" || school == "n") {
				Console.WriteLine ("That's perfectly fine. College isn't for everyone!");
			} else {
				//Give gyest another chance to enter corrrect response
				Console.WriteLine ("ERROR! PLease type the correct response. Enter Y for yes or N for no. \r\n Did you attend school at a college or university this past year?");
				school = Console.ReadLine ();
				if (school == "Y" || school == "y") {
					Console.WriteLine ("Its great the you furthered your education this previous year. Don't forget to collect your 1098-T from your school");
				} if (school == "N" || school == "n") {
					Console.WriteLine ("That's perfectly fine. College isn't for everyone!");
				}
			}

		//ask final question
			Console.WriteLine ("Did you make any charitable donations last year? \r\n Enter Y for yes or N for no. ");
			//capture response 
			string charity = Console.ReadLine ();
			//check for response 
			while (string.IsNullOrWhiteSpace (charity)) {
				// tell yser what went wrong and try to fix it 
				Console.WriteLine ("ERROR! It looks like you did not answer the previous question \r\n Did you make any charitable donations last year? \r\n Enter Y for yes or N for no");
			}

			// verify answers
			if (charity == "Y" || charity == "y") {
				Console.WriteLine ("Charitable donations are always a good thing! Don't forget to find your receipts for your donations!");
			} if (charity == "N" || charity == "n") {
				Console.WriteLine ("Its great to find a charity or nonprofit organization to support!");
			} else {
				//Give gyest another chance to enter corrrect response
				Console.WriteLine ("ERROR! PLease type the correct response. Enter Y for yes or N for no. \r\n Did you make any charitable donations last year?");
				charity = Console.ReadLine ();
				if (charity == "Y" || charity == "y") {
					Console.WriteLine ("Charitable donations are always a good thing! Don't forget to find your receipts for your donations");
				} if (charity == "N" || charity == "n") {
					Console.WriteLine ("Its great to find a charity or nonprofit organization to support!!");
				}
			}

			//conclude 
			Console.WriteLine ("Thank you for submit that information. Tax season can be very stressful and it can be very hard to remember some of the formes and documents that you mean need." +
				"\r\n I hope this quick form helped to jog your memory on what you many need for your taxes\r\n HAPPY FILING!");
			}
			}
}
