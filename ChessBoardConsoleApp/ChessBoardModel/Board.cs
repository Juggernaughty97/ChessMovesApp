using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
    public class Board
    {
        // size of the board usually 8x8
        public int Size { get; set; }
        // 2d array of type cell
        public Cell[,] theGrid { get; set; }
        public Board(int s)
        {
            // initial size of the board is defined by s
            Size = s;

            // create a new 2D array of type cell
            theGrid = new Cell[Size, Size];

            // fill the 2D array with new cells, each with unique x and y coordinates
            
            for (int i = 0; i < Size; i++)
            {  
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j); 
                } 
            }
        }

        public void MarkNextLegalMoves(Cell currentCell, string chessPiece)
        {
            // step 1 - clear all previous legal moves

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j].LegalNextMove = false;
                    theGrid[i, j].CurrentlyOccupied = false;
                }
            }

            // step 2 - find all legal moves and mark the cells as "legal"

            switch (chessPiece)
            {
                case "Cavaleiro":
                    if (isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber + 2))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber - 2))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber + 2))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber - 2))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;

                    break;
                case "Rei":
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    break;
                    
                case "Torre":
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 3, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 4, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 5, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 6, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 7, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber].LegalNextMove = true;
                    
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 3, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 4, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 5, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 6, currentCell.ColumnNumber ))
                        theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 7, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 2))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 3))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 3].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 4))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 4].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 5))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 5].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 6))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 6].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 7))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 7].LegalNextMove = true;
                    
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 2))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 3))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 3].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 4))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 4].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 5))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 5].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 6))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 6].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 7))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 7].LegalNextMove = true;
                    break;
                case "Bispo":
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber + 2))
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 3, currentCell.ColumnNumber + 3))
                        theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber + 3].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 4, currentCell.ColumnNumber + 4))
                        theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber + 4].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 5, currentCell.ColumnNumber + 5))
                        theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber + 5].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 6, currentCell.ColumnNumber + 6))
                        theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber + 6].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 7, currentCell.ColumnNumber + 7))
                        theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber + 7].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber - 2))
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 3, currentCell.ColumnNumber - 3))
                        theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber - 3].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 4, currentCell.ColumnNumber - 4))
                        theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber - 4].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 5, currentCell.ColumnNumber - 5))
                        theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber - 5].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 6, currentCell.ColumnNumber - 6))
                        theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber - 6].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 7, currentCell.ColumnNumber - 7))
                        theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber - 7].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber - 2))
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 3, currentCell.ColumnNumber - 3))
                        theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber - 3].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 4, currentCell.ColumnNumber - 4))
                        theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber - 4].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 5, currentCell.ColumnNumber - 5))
                        theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber - 5].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 6, currentCell.ColumnNumber - 6))
                        theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber - 6].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 7, currentCell.ColumnNumber - 7))
                        theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber - 7].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber + 2))
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 3, currentCell.ColumnNumber + 3))
                        theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber + 3].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 4, currentCell.ColumnNumber + 4))
                        theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber + 4].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 5, currentCell.ColumnNumber + 5))
                        theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber + 5].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 6, currentCell.ColumnNumber + 6))
                        theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber + 6].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 7, currentCell.ColumnNumber + 7))
                        theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber + 7].LegalNextMove = true;
                    break;
                case "Rainha":
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber + 2))
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 3, currentCell.ColumnNumber + 3))
                        theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber + 3].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 4, currentCell.ColumnNumber + 4))
                        theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber + 4].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 5, currentCell.ColumnNumber + 5))
                        theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber + 5].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 6, currentCell.ColumnNumber + 6))
                        theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber + 6].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 7, currentCell.ColumnNumber + 7))
                        theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber + 7].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber - 2))
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 3, currentCell.ColumnNumber - 3))
                        theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber - 3].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 4, currentCell.ColumnNumber - 4))
                        theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber - 4].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 5, currentCell.ColumnNumber - 5))
                        theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber - 5].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 6, currentCell.ColumnNumber - 6))
                        theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber - 6].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 7, currentCell.ColumnNumber - 7))
                        theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber - 7].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber - 2))
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 3, currentCell.ColumnNumber - 3))
                        theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber - 3].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 4, currentCell.ColumnNumber - 4))
                        theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber - 4].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 5, currentCell.ColumnNumber - 5))
                        theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber - 5].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 6, currentCell.ColumnNumber - 6))
                        theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber - 6].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 7, currentCell.ColumnNumber - 7))
                        theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber - 7].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber + 2))
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 3, currentCell.ColumnNumber + 3))
                        theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber + 3].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 4, currentCell.ColumnNumber + 4))
                        theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber + 4].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 5, currentCell.ColumnNumber + 5))
                        theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber + 5].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 6, currentCell.ColumnNumber + 6))
                        theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber + 6].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 7, currentCell.ColumnNumber + 7))
                        theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber + 7].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 3, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 4, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 5, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 6, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 7, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 3, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 4, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 5, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 6, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 7, currentCell.ColumnNumber))
                        theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 2))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 3))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 3].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 4))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 4].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 5))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 5].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 6))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 6].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 7))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 7].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 2))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 3))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 3].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 4))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 4].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 5))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 5].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 6))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 6].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 7))
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 7].LegalNextMove = true;
                    break;

                
                default:
                    Console.WriteLine("Insira uma peça de xadrez válida.");
                    break;
            }
            theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
        }

        public bool isSafe(int chosenCellRow, int chosenCellColumn)
        {
            if (chosenCellRow < 0 || chosenCellRow > 7 || chosenCellColumn < 0 || chosenCellColumn > 7)
            {
                return false;
            }

            return true;
        }
    }
}
