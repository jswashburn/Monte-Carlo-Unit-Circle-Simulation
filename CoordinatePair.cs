using System;

namespace MonteCarloUnitCircleSimulation
{
    class CoordinatePair
    {
        // Represents a top-right quadrant co-ordinate pair (positive X and Y).

        float X { get; }
        float Y { get; }
        float Hypotenuse => (float)Math.Sqrt((X * X) + (Y * Y));

        public CoordinatePair(float x, float y)
        {
            X = x;
            Y = y;
        }

        // The pair overlaps the inner area of a circle if its hypotenuse is less than or equal to the circle's radius.
        public bool OverlapsCircle(float radius) => Hypotenuse <= radius;

        public override string ToString() => $"({X}, {Y}) Hyp: {Hypotenuse}";
    }
}
