using System;

namespace Griffin_Larry_Conditional_Assignments
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*
			Larry Griffin 
			11/9/2015
			SDI Section 1
			Conditional Assignment
			*/

			//introduce the guest to the program

			Console.WriteLine ("Welcome to the Gift Wrap 5000 \r\n Its that time of year again to buy gifts for your loved ones. " +
			"After you purchase all of your gifts, you have to use wrapping paper to keep the item concealed until that special day. " +
			"\r\n And thats where I come in! \r\n" +
			"Just enter a few measurements and I'll let you know what size you will need to wrap your gift!\r\n" +
			" \r\n To get started, what shape box are you trying to cover? [Press 'A' for a rectlangular box , 'B' if the box is a cylinder or 'C' if the package has a different shape");
			//Collect information on what shape the box is that the user has
			string box = Console.ReadLine ();
			// check to see if user actually entered an answer
			if (string.IsNullOrWhiteSpace (box)) {
				// the user did not answer
				//explain whar happened and ask for response once again
				Console.WriteLine ("ERROR! Please enter 'A' if your box has rectangle sides or 'B' if it is a cylinder or 'C' if the package has a different shape");
				box = Console.ReadLine ();
			
			}
			// Make sure the only answer given was one of the answer choices
			if (!(box == "A" || box == "a" || box == "B" || box == "b" || box == "C" || box == "c")) {
				Console.WriteLine ("ERROR! Only enter 'A' if your box has rectangle sides or 'B' if it is a cylinder or 'C' if the package has a different shape");
				//give user another chance to enter the correct choice
				box = Console.ReadLine ();
			} else {
				Console.WriteLine ("Thinking...\r\n OK I've got it!");
			}

			//Check to see what tyoe of box the user has 
			if (box == "A" || box == "a") {
				Console.WriteLine ("It look like you have a rectanlular box! Now measure the sides of the box and enter the information as follows");
			} else if (box == "B" || box == "b") {
				Console.WriteLine ("It looks like you have a cylindrical box! Now lets collect some measurements:");
			} else if (box == "C" || box == "c") {
				Console.WriteLine ("It seems you may have a very oddly shaped box. Why not try using a nicely decorated bag?\r\n Thanks for trying the Gift Wrap 5000");
			}
		

			//Collect the measurements of the box
			if (box == "A" || box == "a") {
				//Prompt for measurements for the rectangular box
				Console.WriteLine ("What is the length, in inches ,of your box?");
				//store the measurements in a variable 
				string lengthString = Console.ReadLine ();
				//assign a desired variable to convert to 
				double length;
				// use tryParse to ensure that a usuable value was entered and convert to from a string to a decimal
				if (!(double.TryParse(lengthString, out length))){
					//if the value entered can not be converted notify the user of an error
					Console.WriteLine ("ERROR!!! Only enter a number for measurements. Please enter the length of your box");
					//prompt the user to make the correction
					lengthString = Console.ReadLine ();
					//try parse again
					double.TryParse (lengthString, out length);
				}
				//Prompt for height measurement
				Console.WriteLine ("How tall is the box?");
				//store measurement
				string heightString = Console.ReadLine ();
				//assign desired variable to convert to 
				double height;
				// use tryParse to ensure that a usuable value was entered and convert to from a string to a decimal
				if (!(double.TryParse(heightString, out height))){
					//if the value entered can not be converted notify the user of an error
					Console.WriteLine ("ERROR!!! Only enter a number for measurements. Please enter the height of your box");
					//prompt the user to make the correction
					heightString = Console.ReadLine ();
					//try parse again
					double.TryParse (heightString, out height);
				}
				//prompt for width measurement
				Console.WriteLine ("How wide is the box?");
				//store measurement
				string widthString = Console.ReadLine ();
				//assign desired variable to convert to 
				double width;
				// use tryParse to ensure that a usuable value was entered and convert to from a string to a decimal
				if (!(double.TryParse (widthString, out width))) {
					//if the value entered can not be converted notify the user o an error
					Console.WriteLine ("ERROR!!! Only enter a number for measurements. Please enter the width of your box");
					//prompt the user to make the correction
					widthString = Console.ReadLine ();
					//try parse again
					double.TryParse (widthString, out width);
				}
				//preform calculations for the perimeter of a rectangular box
				//surface area of a rectangular prisim  =2*(lw + hw + lh)
				double rectSA = 2*(length*width+ height*width + length*height);
				//round to the nearest hundredth decimal place
				double rectSARounded = Math.Round (rectSA, 2);
				//Provide answer with descriptive text
				Console.WriteLine ("Given your previous measurements, it looks like you will need enough wrapping paper to cover "
				+ rectSARounded + " squared inches, which is the surface area of your box.\r\n Happy Holidays \r\n Thanks for using Gift Wrap 5000!!");
				

				//repeat similar process if user has a cylindrical box
			} else if (box == "B" || box == "b") {
				//Prompt for measurements for the cylindrical box
				Console.WriteLine ("Stand the box on one of its circular faces.\r\n How tall, in inches ,is your box?");
				//store the measurements in a variable 
				string heightString = Console.ReadLine ();
				//assign a desired variable to convert to 
				double height;
				// use tryParse to ensure that a usuable value was entered and convert to from a string to a decimal
				if (!(double.TryParse(heightString, out height))){
					//if the value entered can not be converted notify the user of an error
					Console.WriteLine ("ERROR!!! Only enter a number for measurements. Please enter the height of your box");
					//prompt the user to make the correction
					heightString = Console.ReadLine ();
					//try parse again
					double.TryParse (heightString, out height);
			}
				//Prompt for measurements for the rectangular box
				Console.WriteLine ("Now measure the across the top of the box\r\n  What is the diameter of your box?");
				//store the measurements in a variable 
				string diameterString = Console.ReadLine ();
				//assign a desired variable to convert to 
				double diameter;
				// use tryParse to ensure that a usuable value was entered and convert to from a string to a decimal
				if (!(double.TryParse(diameterString, out diameter))){
					//if the value entered can not be converted notify the user of an error
					Console.WriteLine ("ERROR!!! Only enter a number for measurements. Please enter the diameter of your box");
					//prompt the user to make the correction
					diameterString = Console.ReadLine ();
					//try parse again
					double.TryParse (diameterString, out diameter);
		}
				//preform calculations 
				//divide the diamaeter by 2 to get the radius
				double radius = diameter/2;
		

				// surface area of a cylinder = 2 pi r^2+2 pi rh
				double cylinderSA = (2 * Math.PI * Math.Pow(radius,2)) + (2 * Math.PI * radius * height);
				//round to the nearest hundredth decimal place
				double cylinderSARounded = Math.Round (cylinderSA, 2);

				//Provide answer with descriptive text 
				Console.WriteLine ("Given your previous measurements, it looks like you will need enough wrapping paper to cover "
					+ cylinderSARounded + " squared inches, which is the surface area of your box.\r\n Happy Holidays \r\n Thanks for using Gift Wrap 5000!!");
				
				/*
				Test 1- C Gives else response- correct
				Test 2 : a length:14 width: 5 height 9 SA = 482 correct
				Test 3: b height 9 diameter 4 SA=138.23 correct
				Test 4 A, length 1.23 width: 4.56, height 7.89  SA 102.58 correct
				Test 5: B height 10.78 diameter 5.96 257.64 correct
				
				*/

}
}
}

}
