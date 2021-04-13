namespace MinimumRotatedSortedArray
{
	public static class Solution
	{
		public static int FindMin(int[] nums)
		{
			var len = nums.Length;
			if (nums[len] >= nums[0])
				return nums[0];

			int min = nums[0];
			for (int i = 0; i <= len; i++)
			{
				if (min > nums[i])
					return nums[i];
			}
			return min;
		}
	}

}