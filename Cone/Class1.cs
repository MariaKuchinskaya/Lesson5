namespace Cone
{
    public class Cone
    {
        public int H { get; set; }
        public int R { get; set; }

        public Cone(int r, int h)
        {
            H = h;
            R = r;
        }

        public double CountSquareOfTheCone(double squareOfTheRound, int squareOfTheSide)
        {
            double squareOfTheCone = squareOfTheRound + squareOfTheSide;
            return squareOfTheCone;
        }

        public double CountSquareOfTheRound(double pi)

        {
            var squareOfTheRound = (R * R) + pi;
            return squareOfTheRound;
        }

    }

}
