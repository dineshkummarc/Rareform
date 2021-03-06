﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rareform.Extensions;
using Rareform.Reflection;

namespace Rareform.Tests.Extensions
{
    [TestClass]
    public class IComparableExtensionsTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowIfGreaterThan_LimitIsLessAndParameterNameIsExpression_ThrowsArgumentOutOfRangeException()
        {
            int value = 10;
            int limit = 9;

            try
            {
                value.ThrowIfGreaterThan(limit, () => value);
            }

            //Assert that the reflection works properly
            catch (ArgumentOutOfRangeException e)
            {
                Assert.AreEqual(Reflector.GetMemberName(() => value), e.ParamName);

                throw;
            }
        }

        [TestMethod]
        public void ThrowIfGreaterThan_LimitIsLessAndParameterNameIsExpression_ThrowsNothing()
        {
            int value = 9;
            int limit = 10;

            value.ThrowIfGreaterThan(limit, () => value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowIfGreaterThan_LimitIsLessAndParameterNameIsString_ThrowsArgumentOutOfRangeException()
        {
            int value = 10;
            int limit = 9;

            string parameterName = "value";

            value.ThrowIfGreaterThan(limit, parameterName);
        }

        [TestMethod]
        public void ThrowIfGreaterThan_LimitIsLessAndParameterNameIsString_ThrowsNothing()
        {
            int value = 9;
            int limit = 10;

            string parameterName = "value";

            value.ThrowIfGreaterThan(limit, parameterName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowIfLessThan_LimitIsLessAndParameterNameIsExpression_ThrowsArgumentOutOfRangeException()
        {
            int value = 9;
            int limit = 10;

            try
            {
                value.ThrowIfLessThan(limit, () => value);
            }

            //Assert that the reflection works properly
            catch (ArgumentOutOfRangeException e)
            {
                Assert.AreEqual(Reflector.GetMemberName(() => value), e.ParamName);

                throw;
            }
        }

        [TestMethod]
        public void ThrowIfLessThan_LimitIsLessAndParameterNameIsExpression_ThrowsNothing()
        {
            int value = 10;
            int limit = 9;

            value.ThrowIfLessThan(limit, () => value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowIfLessThan_LimitIsLessAndParameterNameIsString_ThrowsArgumentOutOfRangeException()
        {
            int value = 9;
            int limit = 10;

            string parameterName = "value";

            value.ThrowIfLessThan(limit, parameterName);
        }

        [TestMethod]
        public void ThrowIfLessThan_LimitIsLessAndParameterNameIsString_ThrowsNothing()
        {
            int value = 10;
            int limit = 9;

            string parameterName = "value";

            value.ThrowIfLessThan(limit, parameterName);
        }
    }
}