﻿using System.Diagnostics;
using FluentAssertions.Numeric;

namespace FluentAssertions.Primitives
{
    /// <summary>
    /// Contains a number of methods to assert that a <see cref="ulong"/> is in the expected state.
    /// </summary>
    [DebuggerNonUserCode]
    public class ULongAssertions
        : NumericAssertions<ulong>
    {
        public ULongAssertions(ulong value)
            : base(value)
        {
        }

        private protected override ulong? CalculateDifference(ulong? actual, ulong expected) => actual - expected;

        private protected override ulong? CalculateDifference(ulong? actual, ulong? expected) => actual - expected;
    }
}
