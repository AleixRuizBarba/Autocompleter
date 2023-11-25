var wordlist = new List<string> {
    "Pandora", "Pinterest", "Paypal", "Pg&e", "Project free tv", "Priceline", "Press democrat", "Progressive", "Project runway", 
    "Proactive", "Programming", "Progeria", "Progesterone", "Progenex", "Procurable", "Processor", "Proud", "Print", "Prank", 
    "Bowl", "Owl", "River", "Phone", "Kayak", "Stamps", "Reprobe"
}; //Create the list.

//Create a list with the words that we're looking for.
List<string> GetWords(string init)
{
    //Use a LINQ expression to check the words that start with init variable in the wordList list.
    var outputWords = 
        wordlist.Where(word => word.StartsWith(init, StringComparison.OrdinalIgnoreCase)).ToList();
    //The Sort() function sorts the list alphabetically.
    outputWords.Sort();
    //Return the complete list.
    return outputWords;
}

//Check if the program received an argument.
if (args.Length <= 0) {
    Console.WriteLine("ERROR: No arguments.");
    return;
}
var keyword = args[0]; //Get the first argument given to the program.
var wordsFound = GetWords(keyword); //Get a list with the words that start with the given keyword.
//Check if there are words starting with the given keyword.
Console.WriteLine(wordsFound.Count <= 0 ? $"There are no words starting with {keyword}." : $"Words that start with {keyword}:");
//If the words in the list are more that 4, print only 4 words. Else, print the list.
for (var i = 0; i < (wordsFound.Count > 4 ? 4 : wordsFound.Count); i++) {
    Console.WriteLine(wordsFound[i]);
}