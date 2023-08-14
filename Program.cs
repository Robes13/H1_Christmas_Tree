using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Christmas_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking user for input on how high they want the tree
            Console.WriteLine("Enter how heigh you want your christmas tree to be: ");
            int tree_Height = Convert.ToByte(Console.ReadLine());
            // Declaring the intial star starting amount
            int starsamount = 1;
            // This variable is used for placing spaces, and knowing how many spaces to place
            int numberOf_Spaces = tree_Height - 1;
            // A couple cw's to make it look prettier
            Console.WriteLine("\n");
            // Loop that runs until the tree's height is done
            for (int i = 0; i < tree_Height; i++)
            {
                // Placing our spaces
                for(int s = 0; s < numberOf_Spaces; s++)
                {
                    Console.Write(" ");
                }
                // Removing one from our spaces, so next line will have one less.
                numberOf_Spaces--;
                // This loops runs until all stars in the current line has been placed.
                for (int j = 0; j < starsamount; j++)
                {
                    /* This modulus module checks if I is divisible by 2, and where 1 is left. 
                     * This way we can ensure that we only place red lights when the number of stars is odd.  
                     */ 
                    if (i % 2 == 1)
                    {
                        if (j % 2 == 1) // Again using modulus to figure out if there should be a light yet or not.
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("*");
                        }
                        else // Else just placing a *
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("*");
                        }
                    }
                    // Else just placing a *
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("*");
                    }
                }
                // Going to newline after a whole row of stars has been printed.
                Console.WriteLine();
                // Adding two more stars to the total amount of stars being printed.
                starsamount += 2;
            }
            // Console readline, so we're able to observe our christmass tree.
            Console.ReadLine();
        }
    }
}
