namespace BossBattleOfManticore
{
    public class BattleOfManticore 
    {
        public static void Main(string[] args)
        {
            //game variables
            int cityHealth = 15;
            int manticoreHealth = 10;
            int round = 1;

            //get the starting distance for the Manticore
            int range = AskForNumberInRange("Player 1, how far away from the city do you want to station the Manticore?", 0, 100);
            Console.Clear();

            Console.WriteLine("Player 2, it is your turn.");

            //Looping through the game
            while (cityHealth > 0 && manticoreHealth > 0)
            {
                //Display the status for the round
                Console.WriteLine("-----------------------------------------");
                DisplayStatus(round, cityHealth, manticoreHealth);

                //Display the amount of damage expected on a hit.
                int damage = DamageForRound(round);
                Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");

                //Get a number from the player.
                int targetRange = AskForNumber("Enter desired cannon range:");

                // Display the outcome of the number.
                DisplayOverOrUnder(targetRange, range);

                // Deal damage to the Manticore if it was a hit.
                if (targetRange == range) manticoreHealth -= damage;

                // Deal damage to the city of the Manticore is still alive.
                if (manticoreHealth > 0) cityHealth--;

                // Go on to the next round.
                round++;

            }

            // Display the outcome of the game.
            bool won = cityHealth > 0;
            DisplayWinOrLose(won);

            //METHODS

            void DisplayWinOrLose(bool won)
            {
                if(won)
                {
                    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
                }
                else
                {
                    Console.WriteLine("The city has been destroyed. The Manticore and the Uncoded One have won.");

                }

            }

            //Tells the player if they fell short, overshot, or hit their target.
            void DisplayOverOrUnder(int targetRange, int Range)
            {
                if (targetRange < range) Console.WriteLine("That round FELL SHORT of the target.");
                else if (targetRange > range) Console.WriteLine("That round OVERSHOT the target.");
                else
                {
                    Console.WriteLine("That round was a DIRECT HIT!");
                }
            }

            //Display the status
            void DisplayStatus(int round, int cityHealth, int manticoreHealth)
            {
                Console.WriteLine($"STATUS: Round: {round}  City: {cityHealth}/15   Manticore: {manticoreHealth}/10");

            }

            // Computing the damage done
            int DamageForRound(int roundNumber)
            {
                if (roundNumber % 5 == 0 && roundNumber % 3 == 0) return 10;
                else if (roundNumber % 5 == 0) return 3;
                else if (roundNumber % 3 == 0) return 3;
                else return 1;
            }

            //Getting a number from the user.
            int AskForNumber (string text)
            {
                Console.Write(text + " ");
                int number = Convert.ToInt32(Console.ReadLine());
                return number;
            }

            // Ensuring the user's number is within the given range
            int AskForNumberInRange(string text, int min, int max)
            {
                while (true)
                {
                    int number = AskForNumber(text);
                    if (number >= min && number < max)
                        return number;
                }
            }
        }
    }
}
