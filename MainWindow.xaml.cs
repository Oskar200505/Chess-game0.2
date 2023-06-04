using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chess_game0._2
{
    public partial class MainWindow : Window
    {
        //Visar en lista med alla bilderna som tas till användning i spelet plus att den tar bildernas gridvalues från klassen gridvalue och kopplar rätt bild till rätt gridvalue
        private readonly Dictionary<Gridvalue, ImageSource> gridValToImage = new()
        {
            {Gridvalue.Empty,Images.Empty},
            {Gridvalue.SvartBonde, Images.SvartBonde },
            {Gridvalue.SvartDrottning, Images.SvartDrottning },
            {Gridvalue.SvartHäst, Images.SvartHäst},
            {Gridvalue.SvartKung, Images.SvartKung },
            {Gridvalue.SvartLöpare, Images.SvartLöpare},
            {Gridvalue.SvartTorn, Images.SvartTorn},
            {Gridvalue.VitBonde, Images.VitBonde },
            {Gridvalue.VitDrottning, Images.VitDrottning },
            {Gridvalue.VitHäst, Images.VitHäst },
            {Gridvalue.VitKung, Images.VitKung },
            {Gridvalue.VitLöpare, Images.VitLöpare },
            {Gridvalue.VitTorn, Images.VitTorn },
        };

        private readonly int rows = 8, cols = 8;
        private readonly Image[,] gridImage;
        private GameState gameState;


        public MainWindow()
        {
            InitializeComponent();
            gridImage = SetupGrid();
            gameState = new GameState(rows, cols);
            
        }
        //anropar draw så att gridet kan ritas upp detta sker när windows laddas upp

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Draw();
        }
        // Sätter ut empty till gridets alla rutor
        private Image[,] SetupGrid()
        {
            Image[,] images = new Image[rows, cols];    
            GameGrid.Rows = rows;
            GameGrid.Columns = cols;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Image image = new Image
                    {
                        Source = Images.Empty
                    };

                    images[r, c] = image;
                    GameGrid.Children.Add(image);
                }
            }
            return images;
        }
        //Kallar på drawgrid
        private void Draw()
        {
            DrawGrid();
        }
        //Denna funktion ritar upp gridet med gridvalue och pjäsernas start posetioner
        private void DrawGrid()
        {
            for(int r = 0; r < rows; r++)
            {
                for(int c = 0; c < cols; c++)
                {
                    Gridvalue gridVal = gameState.Grid[r, c];
                    gridImage[r, c].Source = gridValToImage[gridVal];
                }
            }
        }
    }
}
