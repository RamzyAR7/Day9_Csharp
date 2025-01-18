using System;

namespace Day9_Csharp
{
    public struct CircleStruct
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public CircleStruct(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }

        public override bool Equals(object obj)
        {
            if (obj is CircleStruct other)
            {
                return Radius == other.Radius && Color == other.Color;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Radius, Color);
        }

        public static bool operator ==(CircleStruct left, CircleStruct right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(CircleStruct left, CircleStruct right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return $"CircleStruct [Radius={Radius}, Color={Color}]";
        }
    }
}

