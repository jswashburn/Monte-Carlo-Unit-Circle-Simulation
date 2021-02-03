using System;

namespace MonteCarloUnitCircleSimulation
{
    // Represents a first-quadrant co-ordinate pair.
    class CoordinatePair
    {  
        float _x, _y;
        float _hypotenuse => (float)Math.Sqrt((_x * _x) + (_y * _y));

        public CoordinatePair(float x, float y)
        {
            _x = x;
            _y = y;
        }

        // The pair overlaps the inner area of a circle if its hypotenuse is less than or equal to the circle's radius.
        public bool OverlapsCircle(float radius) => _hypotenuse <= radius;
    }
}
