// Fernando Aguilar
// 10-17-22
// GitHub Upload Mini Challenge #1 Say Hello - Endpoint
// Recreated our Mini Challenge 1 from the combine, including data validation.
// Peer Reviewed: 
//--------------------------------------------------------------------//
    Console.Clear();
    
    string closeProj = "yes";

    while(closeProj == "yes")
        {
    bool hiFriend = false;
    int noNum = 0;
    bool chooseNum;

    while(hiFriend == false)
        {
            Console.WriteLine(" watcher: hello traveler, i am the watcher of the woods.\nwhat is your name? ");
            string userInput = Console.ReadLine().ToLower();
            chooseNum = Int32.TryParse(userInput, out noNum);

    if(chooseNum == false)
        {
            hiFriend = true;
            Console.WriteLine(" watcher: salutations " + userInput + ". It is good to meet another child of the woods.\nstay a while.. ");
        }
        else
        {
            Console.WriteLine(" the watcher does not understand this language, please give us your true name.. ");
        }
        }

        Console.WriteLine(" after a few moments pass, the watcher eyes you curiously..\nwatcher: would you like to reintroduce yourself in a new form, a new name? yes? or no? ");
        closeProj = Console.ReadLine().ToLower();
        Console.WriteLine(" the watcher fades away from your sight in a shadowy mist.. ");

        }
