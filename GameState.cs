using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_game0._2
{   //detta är de olika ställen som kan finnas i ala rutor
    public class GameState
    {
        public int Rows { get; }
        public int Cols { get; }
        public Gridvalue[,] Grid { get; }
        public Direction Dir { get; private set; }

        private readonly LinkedList<Position> piecePosition = new LinkedList<Position>();
        //detta anropar Add så att bilderna läggs till på våran bräda genom vårt grid
        public GameState(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            Grid = new Gridvalue[rows, cols];

            EmptyPositions();
            AddEmpty();

            AddSvartBonde();
            AddSvartTorn();
            AddSvartHäst();
            AddSvartLöpare();
            AddSvartDrottning();
            AddSvartKung();

            AddVitBonde();
            AddVitTorn();
            AddVitHäst();
            AddVitLöpare();
            AddVitDrottning();
            AddVitKung();

        }
        //Lägger in empty i bilder på row och col 0-7
        private void AddEmpty()
        {
            for (int r = 0; r <=7; r++)
            {
                for(int c = 0; c<=7; c++)
                {
                    Grid[r, c] = Gridvalue.Empty;
                }
            }
        }

        //på rad 1 så lägger den ut en forloop som sätter in bilden i hela columen med olika positioner och bildens hämtas in genom bildens grindvalur
        private void AddSvartBonde()
        {
            int r = 1;

            for ( int c = 0; c <=7; c++)
            {
                Grid[r, c] = Gridvalue.SvartBonde;
            }
        }
        //Sätter ut 2 st svarta torn på 2 ställer genom att bildernas grindvalue och ge ut rätt bild till rätt posetion
        private void AddSvartTorn()
        {
            Grid[0, 0] = Gridvalue.SvartTorn;
            Grid[0, 7] = Gridvalue.SvartTorn;
        }
        //sätter ut 2 st svarta hästar på 2 ställen genom att ta bildernas grindvalue 
        private void AddSvartHäst()
        {
            Grid[0, 1] = Gridvalue.SvartHäst;
            Grid[0, 6] = Gridvalue.SvartHäst;
        }
        //Samma som för hästarna
        private void AddSvartLöpare()
        {
            Grid[0, 2] = Gridvalue.SvartLöpare;
            Grid[0, 5] = Gridvalue.SvartLöpare;
        }
        //sätter ut en posetion, sedans så ger den oss ett grindvalue och posetionerar bilden 
        private void AddSvartDrottning()
        {
            Grid[0, 3] = Gridvalue.SvartDrottning;
        }
        //Samma som fär drottning
        private void AddSvartKung()
        {
            Grid[0, 4] = Gridvalue.SvartKung;
        }
        //Lägger ut en hel rad med vita bönder  och en forlop sör att sätta ut bilderna i hela columen
        private void AddVitBonde()
        {
            int r = 6;

            for ( int c = 0; c <=7; c++)
            {
                Grid[r, c] = Gridvalue.VitBonde;
            }
        }
        //Sätter ut 2 st vita torn på 2 ställer genom att bildernas grindvalue och ge ut rätt bild till rätt posetion
        private void AddVitTorn()
        {
            Grid[7, 0] = Gridvalue.VitTorn;
            Grid[7, 7] = Gridvalue.VitTorn;
        }
        //samma som för vit torn
        private void AddVitHäst()
        {
            Grid[7, 1] = Gridvalue.VitHäst;
            Grid[7, 6] = Gridvalue.VitHäst;
        }
        //samma som för vit torn
        private void AddVitLöpare()
        {
            Grid[7, 2] = Gridvalue.VitLöpare;
            Grid[7, 5] = Gridvalue.VitLöpare;
        }
        //Samma som svart drottning
        private void AddVitDrottning()
        {
            Grid[7, 3] = Gridvalue.VitDrottning;
        }
        //samma som svart drottning
        private void AddVitKung()
        {
            Grid[7, 4] = Gridvalue.VitKung;
        }

        // Detta skapar en lista som innehåller alla posetioner och tillhörande grindvalue  
        private IEnumerable <Position> EmptyPositions()
        {
            for(int r = 0; r < Rows; r++)
            {
                for(int c = 0; c < Cols; c++)
                {
                    if (Grid[r, c] == Gridvalue.Empty)
                    {
                        yield return new Position(r, c);
                    }
                }
            }
        }
    }
}
