﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToMolarMass
{
    /// <summary>
    /// A number to MolarMass Extensions
    /// </summary>
    public static class NumberToMolarMassExtensions
    {
        /// <inheritdoc cref="MolarMass.FromCentigramsPerMole(UnitsNet.QuantityValue)" />
        public static MolarMass CentigramsPerMole<T>(this T value) =>
            MolarMass.FromCentigramsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromDecagramsPerMole(UnitsNet.QuantityValue)" />
        public static MolarMass DecagramsPerMole<T>(this T value) =>
            MolarMass.FromDecagramsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromDecigramsPerMole(UnitsNet.QuantityValue)" />
        public static MolarMass DecigramsPerMole<T>(this T value) =>
            MolarMass.FromDecigramsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromGramsPerMole(UnitsNet.QuantityValue)" />
        public static MolarMass GramsPerMole<T>(this T value) =>
            MolarMass.FromGramsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromHectogramsPerMole(UnitsNet.QuantityValue)" />
        public static MolarMass HectogramsPerMole<T>(this T value) =>
            MolarMass.FromHectogramsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromKilogramsPerMole(UnitsNet.QuantityValue)" />
        public static MolarMass KilogramsPerMole<T>(this T value) =>
            MolarMass.FromKilogramsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromKilopoundsPerMole(UnitsNet.QuantityValue)" />
        public static MolarMass KilopoundsPerMole<T>(this T value) =>
            MolarMass.FromKilopoundsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromMegapoundsPerMole(UnitsNet.QuantityValue)" />
        public static MolarMass MegapoundsPerMole<T>(this T value) =>
            MolarMass.FromMegapoundsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromMicrogramsPerMole(UnitsNet.QuantityValue)" />
        public static MolarMass MicrogramsPerMole<T>(this T value) =>
            MolarMass.FromMicrogramsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromMilligramsPerMole(UnitsNet.QuantityValue)" />
        public static MolarMass MilligramsPerMole<T>(this T value) =>
            MolarMass.FromMilligramsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromNanogramsPerMole(UnitsNet.QuantityValue)" />
        public static MolarMass NanogramsPerMole<T>(this T value) =>
            MolarMass.FromNanogramsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromPoundsPerMole(UnitsNet.QuantityValue)" />
        public static MolarMass PoundsPerMole<T>(this T value) =>
            MolarMass.FromPoundsPerMole(Convert.ToDouble(value));

    }
}