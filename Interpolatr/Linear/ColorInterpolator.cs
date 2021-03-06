﻿using System.Drawing;
using System.Numerics;
using Aptacode.Interpolatr.Linear.Generic;

namespace Aptacode.Interpolatr.Linear
{
    public sealed class ColorInterpolator : GenericVec4Interpolator<Color>
    {
        public override Vector4 ToVector(Color value)
        {
            return new Vector4(value.A, value.R, value.G, value.B);
        }

        public override Color FromVector(Vector4 value)
        {
            return Color.FromArgb((byte) value.X, (byte) value.Y, (byte) value.Z, (byte) value.W);
        }
    }
}