using System;

namespace Griffin_Larry_Function_Assignment
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*
			Larry Griffin
			11/18/2015
			Section 1 
			Function Assigntment
			*/

			// Greet guest and let them know what we are about to do and collect value of the budget

			Console.WriteLine ("Welcome to the GIFT BUDGET ANALYZER! I'm here to help you deermine if you have enough money for your gifts thsi holiday season!\r\n To start, how much do you expect to spend on three gifts?");
			// capture budget
			string budgetString = Console.ReadLine();
			// create variable to capure converted value 
			double budget;
			//validate that correct value was entered
			while (!double.TryParse(budgetString, out budget)){
				Console.WriteLine ("Only type in a number and do not leave blank \r\n How much do you expect to spend on three gifts this holiday season?");
				budgetString = Console.ReadLine ();
			}
			// Ask for the name of the first item to be purchased 
			Console.WriteLine ("What is the first item that you intend to purchase?");
			//Capture item name
			string item1= Console.ReadLine();
			//validate
			while (string.IsNullOrWhiteSpace(item1)){
				//tell user what went wrong and give option to correct it
				Console.WriteLine ("You did not tell me the name of your first gift \r\n Please type the name of your first gift");
				item1= Console.ReadLine();
				}

			//ask for the first item's price 
			Console.WriteLine("How much do you plan to spend on the {0}", item1);
			string item1CostString = Console.ReadLine ();
			double item1Cost;
			//validate 
			while (!double.TryParse(item1CostString, out item1Cost)){
				//Tell user what went wrong and give option to correct it 
				Console.WriteLine ("Only type in a number and do not leave blank \r\n How much do you expect to spend on the {0}", item1);
				budgetString = Console.ReadLine ();
			}

			// Ask for the name of the second item to be purchased 
			Console.WriteLine ("What is the second item that you intend to purchase?");
			//Capture item name
			string item2= Console.ReadLine();
			//validate
			while (string.IsNullOrWhiteSpace(item2)){
				//tell user what went wrong and give option to correct it
				Console.WriteLine ("You did not tell me the name of your first gift \r\n Please type the name of your third gift");
				item2= Console.ReadLine();
			}
			//ask for the second item's price 
			Console.WriteLine("How much do you plan to spend on {0}", item2);
			string item2CostString = Console.ReadLine ();
			double item2Cost;
			//validate 
			while (!double.TryParse (item2CostString, out item2Cost)) {
				Console.WriteLine ("Only type in a number and do not leave blank \r\n How much do you expect to spend on the {0}", item2);
				budgetString = Console.ReadLine ();
			}

			// Ask for the name of the third item to be purchased 
			Console.WriteLine ("What is the third item that you intend to purchase?");
			//Capture item name
			string item3= Console.ReadLine();
			//validate
			while (string.IsNullOrWhiteSpace(item3)){
				//tell user what went wrong and give option to correct it
				Console.WriteLine ("You did not tell me the name of your first gift \r\n Please type the name of your third gift");
				item3= Console.ReadLine();
			}
			//ask for the third item's price 
			Console.WriteLine("How much do you plan to spend on the {0}", item3);
			string item3CostString = Console.ReadLine ();
			double item3Cost;
			//validate 
			while (!double.TryParse (item3CostString, out item3Cost)) {
				Console.WriteLine ("Only type in a number and do not leave blank \r\n How much do you expect to spend on the {0}", item3);
				budgetString = Console.ReadLine ();
			}

			//Create a method to add the cost of the three items

			// Call method 
			double giftTotal = Gifts(item1Cost, item2Cost, item3Cost);

			// create a method that calculates the difference between the given budget and the cost of the gifts

			//call method
			double difference = Difference (budget, giftTotal);



	

			if (difference > 0) {
				// If the the total for the gifts is less than or equal to the budget
				Console.WriteLine ("It looks like if your budget is ${0}, you will have enough money to buy the {1}, {2} , and the {3}!! You can expect to have ${4} remaining\r\n Go buy yourself something nice!! \r\n Happy Shopping!", budget, item1, item2, item3, difference);
			} else if (difference== 0 ){
				// IF the total of the gifts is the same as the budget
				Console.WriteLine("With your budget of ${0}, you will have just enough money to purchase the {1}, {2}, and {3}! \r\n Great budgeting!!! \r\n Happy Shopping!!", budget, item1 , item2, item3);
			}else  {
				//give the response if the the total for the gits is more than the budget
				Console.WriteLine ("If you expect to buy the {0}, {1}, and the  {2}, you will be over budget by ${3}. You may need to increase your ${4} budget. \r\n Happy Shopping!!", item1, item2, item3, difference, budget);
			}


			/*
			TEST 1
			Budget 12345
			price 1 199
			price 2 99
			price 3 1456
			Calculated difference 10591 CORRECT

			TEST 2
			Budget 1500
			price 1 134.99
			price 2 507.75
			price 3 935.76
			Calculated diffrence 78.50 CORRECT

			TEST 3
			Budget 500
			price 1 166.66
			price 2 166.66
			price 3 166.68
			Calculated Differnce 500 


			
			*/


		
		}


		public static double Gifts (double i1, double i2, double i3){
			// determine the total of all three items
			double giftsCost= i1+i2+i3;
			//return item
			return giftsCost;
		}

		public static double Difference (double budg, double gift){
			// find differnce between the budget and cost of gifts
			double diff =Math.Round( budg - gift,2);
			//return item 
			return diff;
		}

		
	}
}
