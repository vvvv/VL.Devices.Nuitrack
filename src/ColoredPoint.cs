using System;
using Stride.Core.Mathematics;

namespace VL.Devices.Nuitrack
{
    public readonly struct ColoredPoint : IEquatable<ColoredPoint>
    {
        public readonly Vector3 Position;
        public readonly Color Color;

        public ColoredPoint(Vector3 position, Color color)
        {
            Position = position;
            Color = color;
        }

        public bool Equals(ColoredPoint other)
        {
            return Position == other.Position && Color == other.Color;
        }

        public override bool Equals(object obj) => obj is ColoredPoint p ? Equals(p) : false;

        public override int GetHashCode()
        {
            var hashCode = -866678350;
            hashCode = hashCode * -1521134295 + Position.GetHashCode();
            hashCode = hashCode * -1521134295 + Color.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"Position: {Position}, Color: {Color}";
        }

        public static bool operator ==(ColoredPoint a, ColoredPoint b) => a.Equals(b);

        public static bool operator !=(ColoredPoint a, ColoredPoint b) => !(a == b);
    }
}
