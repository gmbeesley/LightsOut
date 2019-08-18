using System;
using System.Linq;

namespace LightsOut
{
    public class LightGrid
    {
        public int Columns { get; set; }
        public int Rows { get; set; }
        public int LightsOnCount { get; set; }
        public bool[,] LightsOnGrid { get; set; }

        /// <summary>
        /// Constructor method generates a random puzzle.
        /// Optional parameters to allow for expansion to make variable grid size.
        /// </summary>
        /// <param name="cols"></param>
        /// <param name="rows"></param>
        public LightGrid(int cols = 5, int rows = 5)
        {
            Columns = cols;
            Rows = rows;
            LightsOnCount = 0;
            LightsOnGrid = new bool[cols, rows];
        }

        /// <summary>
        /// Set up light pattern
        /// </summary>
        public void InitialiseLightGrid()
        {
            LightsOnCount = 0;
            while (LightsOnCount == 0)
            {
                int minButtonPress = Math.Min(Columns, Rows);
                int maxButtonPress = Columns * Rows;

                // Generate random number of starting button presses to set initial game state
                Random r = new Random();
                int ButtonPresses = r.Next(minButtonPress, maxButtonPress + 1);
                for (int i = 0; i <= ButtonPresses; i++)
                {
                    int col = r.Next(0, Columns);
                    int row = r.Next(0, Rows);

                    ProcessLightSwitch(col, row);
                }
            }
        }

        /// <summary>
        /// Process lights switching on and off
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        public void ProcessLightSwitch(int col, int row)
        {
            ToggleLight(col, row);

            if (col > 0)
            {
                ToggleLight(col - 1, row);
            }

            if (col < Columns - 1)
            {
                ToggleLight(col + 1, row);
            }

            if (row > 0)
            {
                ToggleLight(col, row - 1);
            }

            if (row < Rows - 1)
            {
                ToggleLight(col, row + 1);
            }

            LightsOnCount = LightsOnGrid.Cast<bool>().ToArray().Count(x => x.Equals(true));
        }

        /// <summary>
        /// Flip light state between on and off
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        private void ToggleLight(int col, int row)
        {
            LightsOnGrid[col, row] = !LightsOnGrid[col, row];
        }
    }
}