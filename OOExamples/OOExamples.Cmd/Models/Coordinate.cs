using OOExamples.Cmd.Data;

namespace OOExamples.Cmd.Models
{
    struct Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void DoSomethingWithCoords()
        {
            X++;
        }

        public override string ToString()
        {
            return "Coords: " + X + ", " + Y;
        }
    }
}
