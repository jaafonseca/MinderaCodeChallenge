// <copyright file="MinderaCodeChallengeTest.cs">Copyright ©  2017</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinderaCodeChallenge;

namespace MinderaCodeChallenge.Tests
{
    /// <summary>This class contains parameterized unit tests for MinderaCodeChallenge</summary>
    [PexClass(typeof(global::MinderaCodeChallenge.MinderaCodeChallenge))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class MinderaCodeChallengeTest
    {
        /// <summary>Test stub for GetClosestClusterIndex(List`1&lt;Cluster&gt;, Int32)</summary>
        [PexMethod]
        public int GetClosestClusterIndexTest(List<Cluster> clusters, int value)
        {
            int result
               = global::MinderaCodeChallenge.MinderaCodeChallenge.GetClosestClusterIndex
                     (clusters, value);
            return result;
        }

        /// <summary>Test stub for Group(Int32[], Int32)</summary>
        [PexMethod(MaxConstraintSolverTime = 2)]
        public int[][] GroupTest(int[] values, int groups)
        {
            int[][] result
               = global::MinderaCodeChallenge.MinderaCodeChallenge.Group(values, groups);
            return result;
        }
    }
}
