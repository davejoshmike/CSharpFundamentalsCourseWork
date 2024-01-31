var randomCoinFlip = new System.Random();
var output = randomCoinFlip.Next(0,2) == 1 ?
    "Heads" :
    "Tails";
Console.WriteLine(output.ToString());