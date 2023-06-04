using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Chess_game0._2
{// detta laddar in alla olika bilder till spelet alltså pjäserna och en bakgrund   
    public static class Images
    {
        public readonly static ImageSource Empty = LoadImage("Empty.PNG");
        public readonly static ImageSource SvartBonde = LoadImage("svart bonde.PNG");
        public readonly static ImageSource SvartDrottning = LoadImage("svart drottning.PNG");
        public readonly static ImageSource SvartHäst = LoadImage("svart häst.PNG");
        public readonly static ImageSource SvartKung = LoadImage("svart kung.PNG");
        public readonly static ImageSource SvartLöpare = LoadImage("svart löpare.PNG");
        public readonly static ImageSource SvartTorn = LoadImage("svart torn.PNG");
        public readonly static ImageSource VitBonde = LoadImage("vit bonde.PNG");
        public readonly static ImageSource VitDrottning = LoadImage("vit drottning.PNG");
        public readonly static ImageSource VitHäst = LoadImage("vit häst.PNG");
        public readonly static ImageSource VitKung = LoadImage("vit kung.PNG");
        public readonly static ImageSource VitLöpare = LoadImage("vit löpare.PNG");
        public readonly static ImageSource VitTorn = LoadImage("vit torn.PNG");


        private static ImageSource LoadImage(string filename)
        {
            return new BitmapImage(new Uri($"Assets/{filename}", UriKind.Relative));
        }
    }
}
