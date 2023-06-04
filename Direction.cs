using System;
using System.Collections.Generic;

namespace Chess_game0._2
{// detta gör så att pjäserna har möjlighet att röra sig i olika riktignar
    public class Direction
    {
        //Bestämmer de olika riktningarna som pjäserna kan röra sig i, up, ner , höger, vänster
        public readonly static Direction Left = new Direction(0, -1);
        public readonly static Direction Right = new Direction(1, -1);
        public readonly static Direction Up = new Direction(-1, 0);
        public readonly static Direction Down = new Direction(1, 0);
        //Ändringen i rikningen för rows och cols
        public int RowOffset { get; }
        public int ColumnOffset { get; }

        private Direction(int rowOffset, int columnOffset)
        {
            RowOffset = rowOffset;
            ColumnOffset = columnOffset;
        }
        // returnerar den motsatta riktining som givits
        public Direction Oppiste()
        {
            return new Direction(-RowOffset, -ColumnOffset);
        }

        public override bool Equals(object? obj)
        {
            return obj is Direction direction &&
                   RowOffset == direction.RowOffset &&
                   ColumnOffset == direction.ColumnOffset;
        }
        // skapar en hashcode för förändningen av rows och cols
        public override int GetHashCode()
        {
            return HashCode.Combine(RowOffset, ColumnOffset);
        }

        public static bool operator ==(Direction? left, Direction? right)
        {
            return EqualityComparer<Direction>.Default.Equals(left, right);
        }

        public static bool operator !=(Direction? left, Direction? right)
        {
            return !(left == right);
        }
    }
}
