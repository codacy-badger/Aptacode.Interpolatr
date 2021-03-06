﻿using System.Numerics;
using Aptacode.Interpolatr.Linear.Generic;

namespace Aptacode.Interpolatr.Linear
{
    public sealed class Vec2LinearInterpolator : GenericVec2Interpolator<Vector2>
    {
        public override Vector2 FromVector(Vector2 value)
        {
            return value;
        }

        public override Vector2 ToVector(Vector2 value)
        {
            return value;
        }
    }
}