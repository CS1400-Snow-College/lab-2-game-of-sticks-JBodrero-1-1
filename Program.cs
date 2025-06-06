//  Jonathan Bodrero
// June 6, 2025

Console.Clear();  // Clear console and write instructions
Console.WriteLine(
@"-------------------------------
- Welcome to the Beaker Game! -
-------------------------------
Players will take turns adding between 1 and 5 mL of liquid to the beaker.
The player that adds the last milliliter loses.
"
);

// Set inital parameters 
int maxVol = 30;
int playerNum = 1;
int maxAdd = 5;
int amount = 0;
string addInput = "";
int toAdd = 0;
bool inputOK = false;

do
{

    if (amount > 25)
    {
        maxAdd = maxVol - amount;  // Check max amount near end of game.
    }

    do
    {
        Console.WriteLine($"The amount of liquid in the beaker is {amount} / {maxVol} ml.");
        Console.Write($"Player {playerNum}, how much liquid would you like to add? ");
        addInput = Console.ReadLine();

        int addInputCheck = Convert.ToInt32(addInput);  // Check if input is in bounds.
        if (addInputCheck >= 1 && addInputCheck <= (maxAdd))
        {
            inputOK = true;
            toAdd = addInputCheck;
        }
        else    // If out of bounds, show error and re-ask
        {
            inputOK = false;
            Console.WriteLine($"Oops, you entered an invalid amount. Enter an amount from 1 to {maxAdd} mililiters.");
        }
    }
    while (inputOK == false);


    amount = amount + toAdd;  // Update volume and change player.
    if (playerNum == 1)
    {
        playerNum = 2;
    }
    else if (playerNum == 2)
    {
        playerNum = 1;
    }
    Console.Clear();
    Console.WriteLine(
@"-------------------------------
- Welcome to the Beaker Game! -
-------------------------------
Players will take turns adding between 1 and 5 mL of liquid to the beaker.
The player that adds the last milliliter loses.
"
);


}
while (amount < 30);

Console.WriteLine($"The amount of liquid in the beaker is {amount} / {maxVol} ml.");  // End game & identify winner!
Console.WriteLine($"/----------------\\\n| Player {playerNum} wins! |\n\\----------------/");  