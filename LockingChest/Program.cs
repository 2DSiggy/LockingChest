string input = ""; //Empty String
BoxStates boxCurrent = BoxStates.Closed;
while (input != "quit")
{
    Console.WriteLine("The box is currently " + boxCurrent + ".");
    input = Console.ReadLine();
    switch (input)
    {
        case "open":
            if (boxCurrent == BoxStates.Closed)
                boxCurrent = BoxStates.Open;
            else
                Console.WriteLine("Cannot do that. Box is not unlocked.");
            break;
        case "close":
            if (boxCurrent == BoxStates.Open)
                boxCurrent = BoxStates.Closed;
            else
                Console.WriteLine("Cannot do that. Box is not open.");
            break;
        case "lock":
            if (boxCurrent == BoxStates.Closed)
                boxCurrent = BoxStates.Locked;
            else
                Console.WriteLine("Cannot do that. Box is not closed.");
            break;
        case "unlock":
            if (boxCurrent == BoxStates.Locked)
                boxCurrent = BoxStates.Closed;
            else
                Console.WriteLine("Cannot do that. Box is not locked.");
            break;
    }
}

enum BoxStates
{
    Locked,
    Closed,
    Open
}