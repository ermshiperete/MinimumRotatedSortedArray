using System;
using NUnit.Framework;

namespace MinimumRotatedSortedArray
{
	[TestFixture]
	public class SolutionTests
	{
		[TestCase(new[] { 1, 3, 5 }, ExpectedResult = 1)]
		[TestCase(new[] { 2, 2, 2, 0, 1 }, ExpectedResult = 0)]
		[TestCase(new[] { 2, 2, 0, 1, 2 }, ExpectedResult = 0)]
		[TestCase(new[] { 1, 2, 2, 0 }, ExpectedResult = 0)]
		public int Test1(int[] nums)
		{
			return Solution.FindMin(nums);
		}
	}
}
