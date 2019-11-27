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
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of SpecificEntropy.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class SpecificEntropyTestsBase
    {
        protected abstract double BtusPerPoundFahrenheitInOneJoulePerKilogramKelvin { get; }
        protected abstract double CaloriesPerGramKelvinInOneJoulePerKilogramKelvin { get; }
        protected abstract double JoulesPerKilogramDegreeCelsiusInOneJoulePerKilogramKelvin { get; }
        protected abstract double JoulesPerKilogramKelvinInOneJoulePerKilogramKelvin { get; }
        protected abstract double KilocaloriesPerGramKelvinInOneJoulePerKilogramKelvin { get; }
        protected abstract double KilojoulesPerKilogramDegreeCelsiusInOneJoulePerKilogramKelvin { get; }
        protected abstract double KilojoulesPerKilogramKelvinInOneJoulePerKilogramKelvin { get; }
        protected abstract double MegajoulesPerKilogramDegreeCelsiusInOneJoulePerKilogramKelvin { get; }
        protected abstract double MegajoulesPerKilogramKelvinInOneJoulePerKilogramKelvin { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double BtusPerPoundFahrenheitTolerance { get { return 1e-5; } }
        protected virtual double CaloriesPerGramKelvinTolerance { get { return 1e-5; } }
        protected virtual double JoulesPerKilogramDegreeCelsiusTolerance { get { return 1e-5; } }
        protected virtual double JoulesPerKilogramKelvinTolerance { get { return 1e-5; } }
        protected virtual double KilocaloriesPerGramKelvinTolerance { get { return 1e-5; } }
        protected virtual double KilojoulesPerKilogramDegreeCelsiusTolerance { get { return 1e-5; } }
        protected virtual double KilojoulesPerKilogramKelvinTolerance { get { return 1e-5; } }
        protected virtual double MegajoulesPerKilogramDegreeCelsiusTolerance { get { return 1e-5; } }
        protected virtual double MegajoulesPerKilogramKelvinTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificEntropy((double)0.0, SpecificEntropyUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_CreateQuantityAndAffectInfinityValue()
        {
            var positiveInfinityQuantity = new SpecificEntropy(double.PositiveInfinity, SpecificEntropyUnit.JoulePerKilogramKelvin);
            var negativeInfinityQuantity = new SpecificEntropy(double.NegativeInfinity, SpecificEntropyUnit.JoulePerKilogramKelvin);

            Assert.True(double.IsPositiveInfinity(positiveInfinityQuantity.Value));
            Assert.True(double.IsNegativeInfinity(negativeInfinityQuantity.Value));
        }

        [Fact]
        public void Ctor_WithNaNValue_CreateQuantityAndAffectNaNValue()
        {
            var nanQuantity = new SpecificEntropy(double.NaN, SpecificEntropyUnit.JoulePerKilogramKelvin);
            Assert.True(double.IsNaN(nanQuantity.Value));
        }

        [Fact]
        public void JoulePerKilogramKelvinToSpecificEntropyUnits()
        {
            SpecificEntropy jouleperkilogramkelvin = SpecificEntropy.FromJoulesPerKilogramKelvin(1);
            AssertEx.EqualTolerance(BtusPerPoundFahrenheitInOneJoulePerKilogramKelvin, jouleperkilogramkelvin.BtusPerPoundFahrenheit, BtusPerPoundFahrenheitTolerance);
            AssertEx.EqualTolerance(CaloriesPerGramKelvinInOneJoulePerKilogramKelvin, jouleperkilogramkelvin.CaloriesPerGramKelvin, CaloriesPerGramKelvinTolerance);
            AssertEx.EqualTolerance(JoulesPerKilogramDegreeCelsiusInOneJoulePerKilogramKelvin, jouleperkilogramkelvin.JoulesPerKilogramDegreeCelsius, JoulesPerKilogramDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(JoulesPerKilogramKelvinInOneJoulePerKilogramKelvin, jouleperkilogramkelvin.JoulesPerKilogramKelvin, JoulesPerKilogramKelvinTolerance);
            AssertEx.EqualTolerance(KilocaloriesPerGramKelvinInOneJoulePerKilogramKelvin, jouleperkilogramkelvin.KilocaloriesPerGramKelvin, KilocaloriesPerGramKelvinTolerance);
            AssertEx.EqualTolerance(KilojoulesPerKilogramDegreeCelsiusInOneJoulePerKilogramKelvin, jouleperkilogramkelvin.KilojoulesPerKilogramDegreeCelsius, KilojoulesPerKilogramDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(KilojoulesPerKilogramKelvinInOneJoulePerKilogramKelvin, jouleperkilogramkelvin.KilojoulesPerKilogramKelvin, KilojoulesPerKilogramKelvinTolerance);
            AssertEx.EqualTolerance(MegajoulesPerKilogramDegreeCelsiusInOneJoulePerKilogramKelvin, jouleperkilogramkelvin.MegajoulesPerKilogramDegreeCelsius, MegajoulesPerKilogramDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(MegajoulesPerKilogramKelvinInOneJoulePerKilogramKelvin, jouleperkilogramkelvin.MegajoulesPerKilogramKelvin, MegajoulesPerKilogramKelvinTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, SpecificEntropy.From(1, SpecificEntropyUnit.BtuPerPoundFahrenheit).BtusPerPoundFahrenheit, BtusPerPoundFahrenheitTolerance);
            AssertEx.EqualTolerance(1, SpecificEntropy.From(1, SpecificEntropyUnit.CaloriePerGramKelvin).CaloriesPerGramKelvin, CaloriesPerGramKelvinTolerance);
            AssertEx.EqualTolerance(1, SpecificEntropy.From(1, SpecificEntropyUnit.JoulePerKilogramDegreeCelsius).JoulesPerKilogramDegreeCelsius, JoulesPerKilogramDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(1, SpecificEntropy.From(1, SpecificEntropyUnit.JoulePerKilogramKelvin).JoulesPerKilogramKelvin, JoulesPerKilogramKelvinTolerance);
            AssertEx.EqualTolerance(1, SpecificEntropy.From(1, SpecificEntropyUnit.KilocaloriePerGramKelvin).KilocaloriesPerGramKelvin, KilocaloriesPerGramKelvinTolerance);
            AssertEx.EqualTolerance(1, SpecificEntropy.From(1, SpecificEntropyUnit.KilojoulePerKilogramDegreeCelsius).KilojoulesPerKilogramDegreeCelsius, KilojoulesPerKilogramDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(1, SpecificEntropy.From(1, SpecificEntropyUnit.KilojoulePerKilogramKelvin).KilojoulesPerKilogramKelvin, KilojoulesPerKilogramKelvinTolerance);
            AssertEx.EqualTolerance(1, SpecificEntropy.From(1, SpecificEntropyUnit.MegajoulePerKilogramDegreeCelsius).MegajoulesPerKilogramDegreeCelsius, MegajoulesPerKilogramDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(1, SpecificEntropy.From(1, SpecificEntropyUnit.MegajoulePerKilogramKelvin).MegajoulesPerKilogramKelvin, MegajoulesPerKilogramKelvinTolerance);
        }

        [Fact]
        public void FromJoulesPerKilogramKelvin_WithInfinityValue_CreateQuantityAndAffectInfinityValue()
        {
            var positiveInfinityQuantity = SpecificEntropy.FromJoulesPerKilogramKelvin(double.PositiveInfinity);
            var negativeInfinityQuantity = SpecificEntropy.FromJoulesPerKilogramKelvin(double.NegativeInfinity);

            Assert.True(double.IsPositiveInfinity(positiveInfinityQuantity.Value));
            Assert.True(double.IsNegativeInfinity(negativeInfinityQuantity.Value));
        }

        [Fact]
        public void FromJoulesPerKilogramKelvin_WithNanValue_CreateQuantityAndAffectNaNValue()
        {
            var nanQuantity = SpecificEntropy.FromJoulesPerKilogramKelvin(double.NaN);
            Assert.True(double.IsNaN(nanQuantity.Value));
        }

        [Fact]
        public void As()
        {
            var jouleperkilogramkelvin = SpecificEntropy.FromJoulesPerKilogramKelvin(1);
            AssertEx.EqualTolerance(BtusPerPoundFahrenheitInOneJoulePerKilogramKelvin, jouleperkilogramkelvin.As(SpecificEntropyUnit.BtuPerPoundFahrenheit), BtusPerPoundFahrenheitTolerance);
            AssertEx.EqualTolerance(CaloriesPerGramKelvinInOneJoulePerKilogramKelvin, jouleperkilogramkelvin.As(SpecificEntropyUnit.CaloriePerGramKelvin), CaloriesPerGramKelvinTolerance);
            AssertEx.EqualTolerance(JoulesPerKilogramDegreeCelsiusInOneJoulePerKilogramKelvin, jouleperkilogramkelvin.As(SpecificEntropyUnit.JoulePerKilogramDegreeCelsius), JoulesPerKilogramDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(JoulesPerKilogramKelvinInOneJoulePerKilogramKelvin, jouleperkilogramkelvin.As(SpecificEntropyUnit.JoulePerKilogramKelvin), JoulesPerKilogramKelvinTolerance);
            AssertEx.EqualTolerance(KilocaloriesPerGramKelvinInOneJoulePerKilogramKelvin, jouleperkilogramkelvin.As(SpecificEntropyUnit.KilocaloriePerGramKelvin), KilocaloriesPerGramKelvinTolerance);
            AssertEx.EqualTolerance(KilojoulesPerKilogramDegreeCelsiusInOneJoulePerKilogramKelvin, jouleperkilogramkelvin.As(SpecificEntropyUnit.KilojoulePerKilogramDegreeCelsius), KilojoulesPerKilogramDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(KilojoulesPerKilogramKelvinInOneJoulePerKilogramKelvin, jouleperkilogramkelvin.As(SpecificEntropyUnit.KilojoulePerKilogramKelvin), KilojoulesPerKilogramKelvinTolerance);
            AssertEx.EqualTolerance(MegajoulesPerKilogramDegreeCelsiusInOneJoulePerKilogramKelvin, jouleperkilogramkelvin.As(SpecificEntropyUnit.MegajoulePerKilogramDegreeCelsius), MegajoulesPerKilogramDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(MegajoulesPerKilogramKelvinInOneJoulePerKilogramKelvin, jouleperkilogramkelvin.As(SpecificEntropyUnit.MegajoulePerKilogramKelvin), MegajoulesPerKilogramKelvinTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var jouleperkilogramkelvin = SpecificEntropy.FromJoulesPerKilogramKelvin(1);

            var btuperpoundfahrenheitQuantity = jouleperkilogramkelvin.ToUnit(SpecificEntropyUnit.BtuPerPoundFahrenheit);
            AssertEx.EqualTolerance(BtusPerPoundFahrenheitInOneJoulePerKilogramKelvin, (double)btuperpoundfahrenheitQuantity.Value, BtusPerPoundFahrenheitTolerance);
            Assert.Equal(SpecificEntropyUnit.BtuPerPoundFahrenheit, btuperpoundfahrenheitQuantity.Unit);

            var caloriepergramkelvinQuantity = jouleperkilogramkelvin.ToUnit(SpecificEntropyUnit.CaloriePerGramKelvin);
            AssertEx.EqualTolerance(CaloriesPerGramKelvinInOneJoulePerKilogramKelvin, (double)caloriepergramkelvinQuantity.Value, CaloriesPerGramKelvinTolerance);
            Assert.Equal(SpecificEntropyUnit.CaloriePerGramKelvin, caloriepergramkelvinQuantity.Unit);

            var jouleperkilogramdegreecelsiusQuantity = jouleperkilogramkelvin.ToUnit(SpecificEntropyUnit.JoulePerKilogramDegreeCelsius);
            AssertEx.EqualTolerance(JoulesPerKilogramDegreeCelsiusInOneJoulePerKilogramKelvin, (double)jouleperkilogramdegreecelsiusQuantity.Value, JoulesPerKilogramDegreeCelsiusTolerance);
            Assert.Equal(SpecificEntropyUnit.JoulePerKilogramDegreeCelsius, jouleperkilogramdegreecelsiusQuantity.Unit);

            var jouleperkilogramkelvinQuantity = jouleperkilogramkelvin.ToUnit(SpecificEntropyUnit.JoulePerKilogramKelvin);
            AssertEx.EqualTolerance(JoulesPerKilogramKelvinInOneJoulePerKilogramKelvin, (double)jouleperkilogramkelvinQuantity.Value, JoulesPerKilogramKelvinTolerance);
            Assert.Equal(SpecificEntropyUnit.JoulePerKilogramKelvin, jouleperkilogramkelvinQuantity.Unit);

            var kilocaloriepergramkelvinQuantity = jouleperkilogramkelvin.ToUnit(SpecificEntropyUnit.KilocaloriePerGramKelvin);
            AssertEx.EqualTolerance(KilocaloriesPerGramKelvinInOneJoulePerKilogramKelvin, (double)kilocaloriepergramkelvinQuantity.Value, KilocaloriesPerGramKelvinTolerance);
            Assert.Equal(SpecificEntropyUnit.KilocaloriePerGramKelvin, kilocaloriepergramkelvinQuantity.Unit);

            var kilojouleperkilogramdegreecelsiusQuantity = jouleperkilogramkelvin.ToUnit(SpecificEntropyUnit.KilojoulePerKilogramDegreeCelsius);
            AssertEx.EqualTolerance(KilojoulesPerKilogramDegreeCelsiusInOneJoulePerKilogramKelvin, (double)kilojouleperkilogramdegreecelsiusQuantity.Value, KilojoulesPerKilogramDegreeCelsiusTolerance);
            Assert.Equal(SpecificEntropyUnit.KilojoulePerKilogramDegreeCelsius, kilojouleperkilogramdegreecelsiusQuantity.Unit);

            var kilojouleperkilogramkelvinQuantity = jouleperkilogramkelvin.ToUnit(SpecificEntropyUnit.KilojoulePerKilogramKelvin);
            AssertEx.EqualTolerance(KilojoulesPerKilogramKelvinInOneJoulePerKilogramKelvin, (double)kilojouleperkilogramkelvinQuantity.Value, KilojoulesPerKilogramKelvinTolerance);
            Assert.Equal(SpecificEntropyUnit.KilojoulePerKilogramKelvin, kilojouleperkilogramkelvinQuantity.Unit);

            var megajouleperkilogramdegreecelsiusQuantity = jouleperkilogramkelvin.ToUnit(SpecificEntropyUnit.MegajoulePerKilogramDegreeCelsius);
            AssertEx.EqualTolerance(MegajoulesPerKilogramDegreeCelsiusInOneJoulePerKilogramKelvin, (double)megajouleperkilogramdegreecelsiusQuantity.Value, MegajoulesPerKilogramDegreeCelsiusTolerance);
            Assert.Equal(SpecificEntropyUnit.MegajoulePerKilogramDegreeCelsius, megajouleperkilogramdegreecelsiusQuantity.Unit);

            var megajouleperkilogramkelvinQuantity = jouleperkilogramkelvin.ToUnit(SpecificEntropyUnit.MegajoulePerKilogramKelvin);
            AssertEx.EqualTolerance(MegajoulesPerKilogramKelvinInOneJoulePerKilogramKelvin, (double)megajouleperkilogramkelvinQuantity.Value, MegajoulesPerKilogramKelvinTolerance);
            Assert.Equal(SpecificEntropyUnit.MegajoulePerKilogramKelvin, megajouleperkilogramkelvinQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            SpecificEntropy jouleperkilogramkelvin = SpecificEntropy.FromJoulesPerKilogramKelvin(1);
            AssertEx.EqualTolerance(1, SpecificEntropy.FromBtusPerPoundFahrenheit(jouleperkilogramkelvin.BtusPerPoundFahrenheit).JoulesPerKilogramKelvin, BtusPerPoundFahrenheitTolerance);
            AssertEx.EqualTolerance(1, SpecificEntropy.FromCaloriesPerGramKelvin(jouleperkilogramkelvin.CaloriesPerGramKelvin).JoulesPerKilogramKelvin, CaloriesPerGramKelvinTolerance);
            AssertEx.EqualTolerance(1, SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(jouleperkilogramkelvin.JoulesPerKilogramDegreeCelsius).JoulesPerKilogramKelvin, JoulesPerKilogramDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(1, SpecificEntropy.FromJoulesPerKilogramKelvin(jouleperkilogramkelvin.JoulesPerKilogramKelvin).JoulesPerKilogramKelvin, JoulesPerKilogramKelvinTolerance);
            AssertEx.EqualTolerance(1, SpecificEntropy.FromKilocaloriesPerGramKelvin(jouleperkilogramkelvin.KilocaloriesPerGramKelvin).JoulesPerKilogramKelvin, KilocaloriesPerGramKelvinTolerance);
            AssertEx.EqualTolerance(1, SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(jouleperkilogramkelvin.KilojoulesPerKilogramDegreeCelsius).JoulesPerKilogramKelvin, KilojoulesPerKilogramDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(1, SpecificEntropy.FromKilojoulesPerKilogramKelvin(jouleperkilogramkelvin.KilojoulesPerKilogramKelvin).JoulesPerKilogramKelvin, KilojoulesPerKilogramKelvinTolerance);
            AssertEx.EqualTolerance(1, SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(jouleperkilogramkelvin.MegajoulesPerKilogramDegreeCelsius).JoulesPerKilogramKelvin, MegajoulesPerKilogramDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(1, SpecificEntropy.FromMegajoulesPerKilogramKelvin(jouleperkilogramkelvin.MegajoulesPerKilogramKelvin).JoulesPerKilogramKelvin, MegajoulesPerKilogramKelvinTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            SpecificEntropy v = SpecificEntropy.FromJoulesPerKilogramKelvin(1);
            AssertEx.EqualTolerance(-1, -v.JoulesPerKilogramKelvin, JoulesPerKilogramKelvinTolerance);
            AssertEx.EqualTolerance(2, (SpecificEntropy.FromJoulesPerKilogramKelvin(3)-v).JoulesPerKilogramKelvin, JoulesPerKilogramKelvinTolerance);
            AssertEx.EqualTolerance(2, (v + v).JoulesPerKilogramKelvin, JoulesPerKilogramKelvinTolerance);
            AssertEx.EqualTolerance(10, (v*10).JoulesPerKilogramKelvin, JoulesPerKilogramKelvinTolerance);
            AssertEx.EqualTolerance(10, (10*v).JoulesPerKilogramKelvin, JoulesPerKilogramKelvinTolerance);
            AssertEx.EqualTolerance(2, (SpecificEntropy.FromJoulesPerKilogramKelvin(10)/5).JoulesPerKilogramKelvin, JoulesPerKilogramKelvinTolerance);
            AssertEx.EqualTolerance(2, SpecificEntropy.FromJoulesPerKilogramKelvin(10)/SpecificEntropy.FromJoulesPerKilogramKelvin(5), JoulesPerKilogramKelvinTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            SpecificEntropy oneJoulePerKilogramKelvin = SpecificEntropy.FromJoulesPerKilogramKelvin(1);
            SpecificEntropy twoJoulesPerKilogramKelvin = SpecificEntropy.FromJoulesPerKilogramKelvin(2);

            Assert.True(oneJoulePerKilogramKelvin < twoJoulesPerKilogramKelvin);
            Assert.True(oneJoulePerKilogramKelvin <= twoJoulesPerKilogramKelvin);
            Assert.True(twoJoulesPerKilogramKelvin > oneJoulePerKilogramKelvin);
            Assert.True(twoJoulesPerKilogramKelvin >= oneJoulePerKilogramKelvin);

            Assert.False(oneJoulePerKilogramKelvin > twoJoulesPerKilogramKelvin);
            Assert.False(oneJoulePerKilogramKelvin >= twoJoulesPerKilogramKelvin);
            Assert.False(twoJoulesPerKilogramKelvin < oneJoulePerKilogramKelvin);
            Assert.False(twoJoulesPerKilogramKelvin <= oneJoulePerKilogramKelvin);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            SpecificEntropy jouleperkilogramkelvin = SpecificEntropy.FromJoulesPerKilogramKelvin(1);
            Assert.Equal(0, jouleperkilogramkelvin.CompareTo(jouleperkilogramkelvin));
            Assert.True(jouleperkilogramkelvin.CompareTo(SpecificEntropy.Zero) > 0);
            Assert.True(SpecificEntropy.Zero.CompareTo(jouleperkilogramkelvin) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            SpecificEntropy jouleperkilogramkelvin = SpecificEntropy.FromJoulesPerKilogramKelvin(1);
            Assert.Throws<ArgumentException>(() => jouleperkilogramkelvin.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            SpecificEntropy jouleperkilogramkelvin = SpecificEntropy.FromJoulesPerKilogramKelvin(1);
            Assert.Throws<ArgumentNullException>(() => jouleperkilogramkelvin.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = SpecificEntropy.FromJoulesPerKilogramKelvin(1);
            var b = SpecificEntropy.FromJoulesPerKilogramKelvin(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            var a = SpecificEntropy.FromJoulesPerKilogramKelvin(1);
            var b = SpecificEntropy.FromJoulesPerKilogramKelvin(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = SpecificEntropy.FromJoulesPerKilogramKelvin(1);
            Assert.True(v.Equals(SpecificEntropy.FromJoulesPerKilogramKelvin(1), JoulesPerKilogramKelvinTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(SpecificEntropy.Zero, JoulesPerKilogramKelvinTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            SpecificEntropy jouleperkilogramkelvin = SpecificEntropy.FromJoulesPerKilogramKelvin(1);
            Assert.False(jouleperkilogramkelvin.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            SpecificEntropy jouleperkilogramkelvin = SpecificEntropy.FromJoulesPerKilogramKelvin(1);
            Assert.False(jouleperkilogramkelvin.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(SpecificEntropyUnit.Undefined, SpecificEntropy.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(SpecificEntropyUnit)).Cast<SpecificEntropyUnit>();
            foreach(var unit in units)
            {
                if(unit == SpecificEntropyUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(SpecificEntropy.BaseDimensions is null);
        }
    }
}
