
function HasTeenButton() 
{ 			
	console.log(HasTeen(15, 22, 20));
	console.log(HasTeen(1, 12, 99));
	console.log(HasTeen(13, 2, 70));

	function HasTeen(one, two, three)
	{
		var isTeen = false;
			if(one >= 13 && one <= 19)
			{
				isTeen = true;
			}
			if (two >= 13 && two <= 19)
			{
				isTeen = true;
			}
			if(three >= 13 && three <= 19)
			{
				isTeen = true;
			}
		return isTeen;
	}
};

function SumDoubleButton() 
{ 			
	console.log(SumDouble(1, 2));
	console.log(SumDouble(3, 2));
	console.log(SumDouble(2, 2));

	function SumDouble(intOne, intTwo)
	{
		if (intOne == intTwo)
		{
			return ((intOne + intTwo) * 2);
		}
		else
		{
			return (intOne + intTwo);
		}
	}
};

function LastDigitButton() 
{ 			
	console.log(LastDigit(1, 2));
	console.log(LastDigit(3, 2));
	console.log(LastDigit(2, 2));

	function LastDigit(intOne, intTwo)
	{
		if (((intOne - intTwo) % 10) == 0)
		{
			return true;
		}
		else
		{
			return false;
		}
		
	}
};

function SeeColorButton() 
{ 			
	console.log(SeeColor("redxx"));
	console.log(SeeColor("xxred"));
	console.log(SeeColor("blueTimes"));

	function SeeColor(inputString)
	{
		if(inputString.substring(0,3) == "red")
		{
			return "red";
		}
		else if(inputString.substring(0,4) == "blue")
		{
			return "blue";
		}
		else
		{
			return "";
		}
	}
};

function MiddleThreeButton() 
{ 			
	console.log(MiddleThree("Candy"));
	console.log(MiddleThree("and"));
	console.log(MiddleThree("solving"));

	function MiddleThree(inputString)
	{
		var index = (inputString.length - 3) / 2;
		outputString = inputString.substring(index, index + 3)
		return outputString
	}
};

function FrontAgainButton() 
{ 			
	console.log(FrontAgain("edited"));
	console.log(FrontAgain("edit"));
	console.log(FrontAgain("ed"));

	function FrontAgain(inputString)
	{
		if(inputString.substring(0, 2) == inputString.substring(inputString.length - 2, inputString.length))
		{
			return true;
		}
		else
		{
			return false;
		}
	}
};

function AlarmClockButton() 
{ 			
	console.log(AlarmClock(1, false));
	console.log(AlarmClock(5, true));
	console.log(AlarmClock(0, false));

	function AlarmClock(day, isVacation)
	{
		var dayString = "";
		var time = "";
		var fullReturn = "";
		
		if(day == 0)
		{
			dayString = "Sunday";
		}
		if(day == 1)
		{
			dayString = "Monday";
		}
		if(day == 2)
		{
			dayString = "Tuesday";
		}
		if(day == 3)
		{
			dayString = "Wednesday";
		}
		if(day == 4)
		{
			dayString = "Thursday";
		}
		if(day == 5)
		{
			dayString = "Friday";
		}
		if(day == 6)
		{
			dayString = "Saturday";
		}

		if (day >= 1 && day <= 5 && isVacation == false)
		{
			time = "7:00";
		}
		else if((day == 6 || day == 0) && isVacation == true)
		{
			time = "off";
		}
		else
		{
			time = "10:00";
		}
		
		fullReturn = dayString + " " + time;
		return fullReturn;
	}
};

function MakeMiddleButton() 
{ 			
	console.log(MakeMiddle([1, 2, 3, 4]));
	console.log(MakeMiddle([7, 1, 2, 3, 4, 9]));
	console.log(MakeMiddle([1, 2]));

	function MakeMiddle(inputArray)
	{
		var returnArray;
		if(inputArray.length < 2 || inputArray.length % 2 != 0)
		{
			returnArray = [];
		}
		else
		{
			var index = (inputArray.length - 2 ) / 2;
			returnArray = [inputArray[index], inputArray[index + 1]];
		}
		return returnArray;
	}
};

function OddOnlyButton() 
{ 			
	console.log(OddOnly([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11]));
	console.log(OddOnly([2, 4, 8, 32, 256]));

	function OddOnly(inputArray)
	{
		var returnArray = [];
		for (var i = 0; i < inputArray.length; i++)
		{
			if(inputArray[i] % 2 != 0)
			{
				returnArray.push(inputArray[i]);
			}
		}
		return returnArray;
	}
};
function WeaveButton() 
{ 			
	console.log(Weave([1, 3, 5], [2, 4]));
	console.log(Weave([1, 3, 5], [2, 4, 6, 8]));

	function Weave(input1, input2)
	{
		var excessArray = [];
		var finalArray = [];
		if(input1.length > input2.length)
		{
			for(var i = input2.length; i < input1.length; i++)
			{
				excessArray.push(input1[i]);
			}
			input1.length = input2.length;
			for(var j = 0; j < input1.length; j++)
			{
				finalArray.push(input1[j]);
				finalArray.push(input2[j]);
			}
			for(var k = 0; k < excessArray.length; k++)
			{
				finalArray.push(excessArray[k]);
			}
			
		}
		else if(input1.length < input2.length)
		{
			for(var i = input1.length; i < input2.length; i++)
			{
				excessArray.push(input2[i]);
			}
			input2.length = input1.length;
			for(var j = 0; j < input2.length; j++)
			{
				finalArray.push(input1[j]);
				finalArray.push(input2[j]);
			}
			for(var k = 0; k < excessArray.length; k++)
			{
				finalArray.push(excessArray[k]);
			}
		}
		else
		{
			for(var i = 0; i < input2.length; i++)
			{
				finalArray.push(input1[i]);
				finalArray.push(input2[i]);
			}
		}
		return finalArray;
	}
};