using System;
using System.Collections;
using System.Collections.Generic;
using Week8.Equation.Core;
using Xunit;

namespace Week8.Equation.Test
{
    public class EquationTest
    {
        [Fact]
        public void TestCase1ResultEquation()
        {
            //ARRANGE
            EquationResolver equation = new EquationResolver();

            //ACT
            //var result = equation.ResolveSecondDegreeEquation(1, -3, 2);

            var result = new List<double[]> { 
                equation.ResolveSecondDegreeEquation(1, -3, 2), 
                equation.ResolveSecondDegreeEquation(1, -5, 6)
            };

            Assert.True(result[0].Length == 2);
            Assert.Equal(1, (double)result[0].GetValue(0));
            Assert.Equal(2, (double)result[0].GetValue(1));

            Assert.True(result[1].Length == 2);
            Assert.Equal(2.0, result[1].GetValue(0));
            Assert.Equal(3.0, result[1].GetValue(1));
            //ASSERT
            //Assert.True(result.Length == 2);
            //Assert.Equal(1, result[0]);
            //Assert.Equal(2, result[1]);
        }

        [Fact]
        public void TestCase2ResultEquation()
        {
            //ARRANGE
            EquationResolver equation = new EquationResolver();

            //ACT
            var result = equation.ResolveSecondDegreeEquation(1, 2, 1);

            //ASSERT            
            Assert.True(result.Length == 1);
            Assert.Equal(-1, result[0]);
        }

        [Fact]
        public void TestCase3ResultEquation()
        {
            //ARRANGE
            EquationResolver equation = new EquationResolver();

            //ACT
            var result = equation.ResolveSecondDegreeEquation(1, -3, 10);

            //ASSERT
            Assert.Null(result);
            Assert.False(result != null);
            Assert.True(result == null);
            
        }
    }
}
