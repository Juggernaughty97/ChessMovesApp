using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardConsoleApp
{
    public class Program
    {
        static Board myBoard = new Board(8);
        static void Main(string[] args)
        {

            // show the empy chess board

            printBoard(myBoard);

            // ask the user for an x and y coordinates where we will place a piece

            Cell currentCell = setCurrentCell();

            if (currentCell == null)
            {
                Environment.Exit(0);
            }

            currentCell.CurrentlyOccupied = true;



            // calculate all legal moves for that piece

            Console.WriteLine("Insira uma peça de xadrez:");
            Console.WriteLine("Cavaleiro | Rei | Rainha | Bispo | Torre");

            string chessPiece = Console.ReadLine();

            myBoard.MarkNextLegalMoves(currentCell, chessPiece);

            // print the chess board. Use an X for occupied square. Use a + for a legal move. Use . for empty cell

            printBoard(myBoard);

            // wait for another enter key press before ending the program

            Console.ReadLine();
        }

        private static Cell setCurrentCell()
        {
            // get x and y coordinates from the user, return a cell location

            try
            {
                Console.WriteLine("Insira uma linha: (0-7)");
                int currentRow = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira uma coluna: (0-7)");
                int currentColumn = int.Parse(Console.ReadLine());

                return myBoard.theGrid[currentRow, currentColumn];
            }
            catch (Exception)
            {
                Console.WriteLine("\nPor favor insira um número válido (0-7)");
                Console.WriteLine("Pressione uma tecla qualquer");
                Console.ReadKey();
                return null;
                
            }
        }

        private static void printBoard(Board myBoard)
        {
            // print the chess board to the console. Use X for the piece location. + for legal move . for the empty square

            Console.WriteLine("+---+---+---+---+---+---+---+---+");
            for (int i = 0; i < myBoard.Size; i++)
            {
                
                for (int j = 0; j < myBoard.Size; j++)
                {
                    Cell c = myBoard.theGrid[i, j];

                    if(c.CurrentlyOccupied == true)
                    {
                        Console.Write("| ");
                        Console.Write("@ ");
                    }
                    else if(c.LegalNextMove == true)
                    {
                        Console.Write("| ");
                        Console.Write("+ ");
                    }
                    else
                    {
                        Console.Write("| ");
                        Console.Write("  ");
                    }
                }
                Console.WriteLine("|");
                Console.Write("+---+---+---+---+---+---+---+---+");
                
                Console.WriteLine();
            }
            Console.WriteLine("=================================");
        }
    }
}
