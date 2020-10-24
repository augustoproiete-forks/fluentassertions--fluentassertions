﻿using System.Diagnostics;
using FluentAssertions.Numeric;

namespace FluentAssertions.Primitives
{
    /// <summary>
    /// Contains a number of methods to assert that a nullable <see cref="float"/> is in the expected state.
    /// </summary>
    [DebuggerNonUserCode]
    public class NullableFloatAssertions
        : NullableNumericAssertions<float>
    {
        public NullableFloatAssertions(float? value)
            : base(value)
        {
        }

        private protected override float? CalculateDifference(float? actual, float expected) => actual - expected;

        private protected override float? CalculateDifference(float? actual, float? expected) => actual - expected;
    }
}
