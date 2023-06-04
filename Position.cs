using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_game0._2
{
    //Denna ger en position på brädan
    public class Position
    {
        //Bestämmer raden där pjäserna ska vara
       public int Row { get; }
       //Bestämmer inom vilken colum pjässerna ska vara
       public int Col { get; }
       
       public Position (int row, int col)
        {
            Row = row;
            Col = col;
        }
        //Denna gör om en pjäs position till en riktning detta görs genom klassen direction
        public Position Translate(Direction dir)
        {
            return new Position (Row + dir.RowOffset, Col + dir.RowOffset);        
        }

        public override bool Equals(object obj)
        {
            //kontrollerar ifall flera pjäser befinner sig på samma rad och colum
            return obj is Position position && 
                Row == position.Row &&
                 Col == position.Col;
        }
        //Skapar hahcode av värderna på rad och colum   
        public override int GetHashCode()
        {
            return HashCode.Combine (Row, Col);
        }

        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Position>.Default.Equals (left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }


    }
}
