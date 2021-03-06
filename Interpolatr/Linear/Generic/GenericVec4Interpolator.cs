﻿using System.Numerics;

namespace Aptacode.Interpolatr.Linear.Generic
{
    public abstract class GenericVec4Interpolator<T> : GenericVectorInterpolator<T, Vector4>
    {
        public override Vector4 Subtract(Vector4 from, Vector4 to)
        {
            return from - to;
        }

        public override Vector4 Normalize(Vector4 from)
        {
            return Vector4.Normalize(from);
        }

        public override float GetLength(Vector4 vector)
        {
            return vector.Length();
        }

        public override Vector4 Add(Vector4 from, Vector4 to)
        {
            return Vector4.Add(from, to);
        }

        public override Vector4 Multiply(Vector4 from, float value)
        {
            return Vector4.Multiply(from, value);
        }
    }
}