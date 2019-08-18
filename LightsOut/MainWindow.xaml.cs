using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LightsOut
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LightGrid lightGrid;
        private int movesTaken;

        public MainWindow()
        {
            InitializeComponent();
            InitialiseLightGrid();
        }

        /// <summary>
        /// Light switch button click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            int col = Grid.GetColumn(btn);
            int row = Grid.GetRow(btn);

            lightGrid.ProcessLightSwitch(col, row);
            UpdateBoardState();
            lblMoves.Content = "Moves Taken: " + ++movesTaken;

            if (lightGrid.LightsOnCount == 0)
            {
                MessageBox.Show("You've won!");
            }
        }

        /// <summary>
        /// New Game button click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            InitialiseLightGrid();
        }

        /// <summary>
        /// Create the grid of lights (done dynamically to allow for variable puzzle sizes)
        /// </summary>
        private void InitialiseLightGrid()
        {
            // Clear any existing grid elements
            Lights.Children.Clear();

            // Create new of lightGrid
            lightGrid = new LightGrid();
            lightGrid.InitialiseLightGrid();

            // Create grid column for each column in lightGrid
            for (int i = 0; i < lightGrid.Columns; i++)
            {
                ColumnDefinition col = new ColumnDefinition
                {
                    Width = new GridLength(50, GridUnitType.Pixel)
                };
                Lights.ColumnDefinitions.Add(col);
            }

            // Create grid row for each row in lightGrid
            for (int j = 0; j < lightGrid.Rows; j++)
            {
                RowDefinition row = new RowDefinition
                {
                    Height = new GridLength(50, GridUnitType.Pixel)
                };
                Lights.RowDefinitions.Add(row);
            }

            // Add a button to every row and column in the grid
            for (int i = 0; i < lightGrid.Columns; i++)
            {
                for (int j = 0; j < lightGrid.Rows; j++)
                {
                    GenerateButton(i, j, lightGrid.LightsOnGrid[i, j]);
                }
            }

            movesTaken = 0;
            lblMoves.Content = "Moves Taken: " + movesTaken;
        }

        /// <summary>
        /// Create the buttons, including initial on/off state
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        /// <param name="on"></param>
        private void GenerateButton(int col, int row, bool on)
        {
            Thickness margin = new Thickness(3);
            Button light = new Button
            {
                HorizontalAlignment = HorizontalAlignment.Center,
                MinWidth = 44,
                Background = on ? Brushes.LightGreen : Brushes.DarkGreen,
                Margin = margin
            };
            Grid.SetColumn(light, col);
            Grid.SetRow(light, row);
            light.Click += new RoutedEventHandler(Button_Click);
            Lights.Children.Add(light);
        }

        /// <summary>
        /// Update the display state of each button after a button click
        /// </summary>
        private void UpdateBoardState()
        {
            for (int i = 0; i < lightGrid.Columns; i++)
            {
                for (int j = 0; j < lightGrid.Rows; j++)
                {
                    Button btn = Lights.Children.Cast<UIElement>().First(x => Grid.GetColumn(x) == i && Grid.GetRow(x) == j) as Button;
                    btn.Background = lightGrid.LightsOnGrid[i, j] ? Brushes.LightGreen : Brushes.DarkGreen;
                }
            }
        }
    }
}