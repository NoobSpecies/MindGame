// See https://aka.ms/new-console-template for more information

Console.WriteLine("\n\n                                __   _,,--¬.     ,--¬__   __");
Console.WriteLine("                              /   _|  /   __|   |,   |. |_   \\");
Console.WriteLine("                             |  _  |  \\_,   \\   /   --’ |   __|");
Console.WriteLine("                           ,--;    /   ___   \\ |        \\.    \\-.");
Console.WriteLine("                          |      _|  ,,----__/ \\_,---._  |__  |  |");
Console.WriteLine("                          |_ , ,  ^-,/ _/_  |  |   \\   \\_/  \\   ,^_");
Console.WriteLine("                        / __|  |    ^ /     |  |   ^--\\_     | |   \\");
Console.WriteLine("                       |    \\__/     / _/    | |   \\__  \\    ^\\/  ^ |");
Console.WriteLine("                       | __ /  ^---^    \\   /  \\    /    ---^  \\  _ /");
Console.WriteLine("             __    __   _\\  _   _  _|____| \\    _/__|    /_     __  /\\__  _____");
Console.WriteLine("            |  \\  /  | | | |  \\| | |  __ \\  \\ / ____\\    / \\   |  \\  /  || ____|");
Console.WriteLine("            | | \\/ | | | | | \\ \\ | | |  \\ |  | /   __   / ^ \\  | | \\/ | ||  __|");
Console.WriteLine("            | |\\  /| | | | | |\\  | | |__/ |  | \\___| | / ___ \\ | |\\  /| || |___");
Console.WriteLine("            |_| -- |_| |_| |_| \\_| |_____/    \\______//_/,__\\_\\|_| -- |_||_____|");
Console.WriteLine("                     / __\\     ^   |     __/\\  / \\__    |    ^    /\\__ \\");
Console.WriteLine("                    |   |  \\_  ,      |    \\_| |/     |      , __/  /  |");
Console.WriteLine("                     \\_  --   |    ^--^-\\_  |  |  _/--|--^   |   --^  /");
Console.WriteLine("                       |  |   ^--^\\______/   | |  \\______--__-   |   |");
Console.WriteLine("                      |--- \\            |    | |   ,|           / --^\\");
Console.WriteLine("                      |      -------^    ^   / \\        \\______/     |");
Console.WriteLine("                       \\        /   |__     /\\ /\\    ___/           /");
Console.WriteLine("                         ^----^  -\\/   \\_____/ \\____/   ^,--  \\____/");
Console.WriteLine("                           |  ^-- |__|     _/  |\\_    | _| ---’ /");
Console.WriteLine("                            \\_______/ \\_    |  |    -’  ^\\_____/");
Console.WriteLine("                                    \\_____/_/   \\_______/");
Console.WriteLine("\n\n   Press enter...  ");
Console.ReadLine();


string mainChoice = "";

for (; mainChoice != "e";)
{
	Console.WriteLine("  --------------------------");
	Console.WriteLine("\n            Welcome\n");
	Console.Write("  To see the rules, type 'r'\n  To play the game, type 'p'\n  To exit the game, type 'e'\n  ");
	mainChoice = Console.ReadLine();


	if (mainChoice == "r")
	{
		// Rules
		Console.WriteLine("  --------------------------");
		Console.WriteLine("\n             Rules\n");
		Console.Write("  The aim of the game is to guess the 3 hidden letters.\n  Each letter will be either an 'a', 'b' or 'c'.\n  Type your guesses and see how many letters you got right.\n  Use the information to guess the letters as fast as you can.\n  ");
		mainChoice = Console.ReadLine();

	}
	else if (mainChoice == "p")
	{
	//Play

		Random rnd = new Random();

		int[] generatedNum = new int[3];
		generatedNum[0] = rnd.Next(3) + 97;
		generatedNum[1] = rnd.Next(3) + 97;
		generatedNum[2] = rnd.Next(3) + 97;

		char[] generatedChar = new char[3];
		generatedChar[0] = (char)generatedNum[0];
		generatedChar[1] = (char)generatedNum[1];
		generatedChar[2] = (char)generatedNum[2];
		string generatedString = new string(generatedChar);

		char[] userChar = { ' ', ' ', ' ' };
		string userString = "   ";

		Console.WriteLine("  ----------------------------------------------------------------------------------\n");
		Console.Write("  LAST GUESS        CORRECT CHARACTERS         CORRECT POSITION   ");

		int guesses = 1;
		while (generatedString != userString)
		{
			if (generatedString == userString)
			{
				break;
			}
			bool userGuessValid = false;
			int generatedACount = 0;
			int generatedBCount = 0;
			int generatedCCount = 0;
			int userACount = 0;
			int userBCount = 0;
			int userCCount = 0;

			do
			{
			// Loop - Calculate if input is valid.. true/false?
				

				Console.Write("      Guess " + guesses + ": ");
				userString = Console.ReadLine();
				userChar = userString.ToCharArray();
				int userStringLength = userString.Length;
				userGuessValid = false;
				if ((userStringLength == 3) && ((userChar[0] == 'a') || (userChar[0] == 'b') || (userChar[0] == 'c')) && ((userChar[1] == 'a') || (userChar[1] == 'b') || (userChar[1] == 'c')) && ((userChar[2] == 'a') || (userChar[2] == 'b') || (userChar[2] == 'c')))
					{
					userGuessValid = true;
					guesses++;
				}
				if (userGuessValid == false)
				{
					Console.Write("  Invalid entry.                                                  ");
					userString = "   ";
				}


				// Loop end

			}
			while (userGuessValid == false);

			if (userGuessValid == true)
			{
				// Generated Letter Count
				generatedACount = 0;
				for (int i = 0; i < 3; i++)
				{
					if (generatedChar[i] == 'a')
					{ generatedACount++; }
				}
				generatedBCount = 0;
				for (int i = 0; i < 3; i++)
				{
					if (generatedChar[i] == 'b')
					{ generatedBCount++; }
				}
				generatedCCount = 0;
				for (int i = 0; i < 3; i++)
				{
					if (generatedChar[i] == 'c')
					{ generatedCCount++; }
				}

				// User Letter Count
				userACount = 0;
				for (int i = 0; i < 3; i++)
				{
					if (userChar[i] == 'a')
					{ userACount++; }
				}
				userBCount = 0;
				for (int i = 0; i < 3; i++)
				{
					if (userChar[i] == 'b')
					{ userBCount++; }
				}
				userCCount = 0;
				for (int i = 0; i < 3; i++)
				{
					if (userChar[i] == 'c')
					{ userCCount++; }
				}

				int aCount = 0;
				int multipliedACount = generatedACount * userACount;
				if (multipliedACount == 0)
				{ aCount = 0; }
				if ((multipliedACount >= 1) && (multipliedACount <= 3))
				{ aCount = 1; }
				if ((multipliedACount >= 4) && (multipliedACount <= 6))
				{ aCount = 2; }
				if (multipliedACount == 9)
				{ aCount = 3; }

				int bCount = 0;
				int multipliedBCount = generatedBCount * userBCount;
				if (multipliedBCount == 0)
				{ bCount = 0; }
				if ((multipliedBCount >= 1) && (multipliedBCount <= 3))
				{ bCount = 1; }
				if ((multipliedBCount >= 4) && (multipliedBCount <= 6))
				{ bCount = 2; }
				if (multipliedBCount == 9)
				{ bCount = 3; }

				int cCount = 0;
				int multipliedCCount = generatedCCount * userCCount;
				if (multipliedCCount == 0)
				{ cCount = 0; }
				if ((multipliedCCount >= 1) && (multipliedCCount <= 3))
				{ cCount = 1; }
				if ((multipliedCCount >= 4) && (multipliedCCount <= 6))
				{ cCount = 2; }
				if (multipliedCCount == 9)
				{ cCount = 3; }
				int correctCharCount = aCount + bCount + cCount;

				int positionCount = 0;
				for (int i = 0; i < 3; i++)
				{
					if (userChar[i] == generatedChar[i])
					{ positionCount++; }
				}

				Console.Write("     " + userString + "           " + correctCharCount + " characters correct");
				Console.Write("      " + positionCount + " in correct position");
			}

		}
		Console.WriteLine("\n\n           You win!!\n");
		Console.WriteLine("  It took you " + (guesses - 1) + " guesses.\n");

	}


	else
	{
		if (mainChoice != "e")
		{
			Console.WriteLine("Invalid choice. Try again.\n");
		}
	}


	

}

Console.WriteLine("  Game terminated");