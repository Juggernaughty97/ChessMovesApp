using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessBoardGuiApp
{
    public partial class Form1 : Form
    {
        // reference to the class Board. Contains the values of the board
        static Board myBoard = new Board(8);

        // 2D array of buttons whose values are determined by myBoard
        public Button[,] btnGrid = new Button[myBoard.Size, myBoard.Size];


        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }

        private void populateGrid()
        {
            // create buttons and place them into panel1
            int buttonSize = panel1.Width / myBoard.Size;

            // make the panel a perfect square
            panel1.Height = panel1.Width;

            // nested loops. create buttons and print them to the screen
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    btnGrid[i, j] = new Button();

                    btnGrid[i, j].Height = buttonSize;
                    btnGrid[i, j].Width = buttonSize;

                    // add a click event to each button
                    btnGrid[i, j].Click += Grid_Button_Click;

                    // add a new button to the panel
                    panel1.Controls.Add(btnGrid[i, j]);

                    // set the location of the new button
                    btnGrid[i, j].Location = new Point(i * buttonSize, j * buttonSize);

                    btnGrid[i, j].Text = i + "|" + j;
                    btnGrid[i, j].Tag = new Point(i, j);

                    comboBox1.SelectedIndex = 0;
                }
            }
        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            // get the row and col number of the button clicked
            Button clickedButton = (Button) sender;
            Point location = (Point) clickedButton.Tag;

            int x = location.X;
            int y = location.Y;

            Cell currentCell = myBoard.theGrid[x, y];

            // determine the next legal moves on the grid

            string chosenPiece = comboBox1.SelectedItem.ToString();

            myBoard.MarkNextLegalMoves(currentCell, chosenPiece);

            // update the text on each button
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    btnGrid[i, j].Text = "";
                    if (myBoard.theGrid[i, j].LegalNextMove == true)
                    {
                        btnGrid[i, j].Text = "Jogada";
                    }
                    else if (myBoard.theGrid[i, j].CurrentlyOccupied == true)
                    {
                        btnGrid[i, j].Text = chosenPiece;
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
