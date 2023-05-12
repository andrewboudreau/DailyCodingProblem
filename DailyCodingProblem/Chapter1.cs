namespace DailyCodingProblem
{
	public static class Chapter1
	{
		/// <summary>
		/// Problem 1.1
		/// </summary>
		/// <param name="inputs"></param>
		/// <returns></returns>
		public static int[] ProductExceptSelf(this IEnumerable<int> inputs)
		{
			var numbers = inputs.ToArray();
			int n = numbers.Length;

			// Initialize left and right auxiliary arrays
			int[] left = new int[n];
			int[] right = new int[n];

			// Initialize result array
			int[] output = new int[n];

			// Compute left array
			left[0] = 1;
			for (int i = 1; i < n; i++)
			{
				left[i] = numbers[i - 1] * left[i - 1];
			}

			// Compute right array
			right[n - 1] = 1;
			for (int i = n - 2; i >= 0; i--)
			{
				right[i] = numbers[i + 1] * right[i + 1];
			}

			// Compute output array
			for (int i = 0; i < n; i++)
			{
				output[i] = left[i] * right[i];
			}

			return output;
		}

		/// <summary>
		/// Problem 1.2, Given an array of integers that are out of order, determine the bounds of 
		/// the smallest window that must be sorted in order for the entire array to be sorted.
		/// </summary>
		public static (int, int) SmallestSortWindow(this IEnumerable<int> inputs)
		{
			var numbers = inputs.ToArray(); // Convert the input to an array
			int n = numbers.Length; // Get the length of the input array
			int start = -1; // Initialize start index of the smallest sort window
			int end = -1; // Initialize end index of the smallest sort window
			int maxSeen = int.MinValue; // Initialize maxSeen to track the maximum element seen so far
			int minSeen = int.MaxValue; // Initialize minSeen to track the minimum element seen so far

			// Loop through the array from the start
			for (int i = 0; i < n; i++)
			{
				maxSeen = Math.Max(maxSeen, numbers[i]); // Update maxSeen if the current number is greater
													  // If the current number is less than the maximum seen so far, it's out of order
													  // and we update the end index
				if (numbers[i] < maxSeen)
				{
					end = i;
				}
			}

			// Loop through the array from the end
			for (int i = n - 1; i >= 0; i--)
			{
				minSeen = Math.Min(minSeen, numbers[i]); // Update minSeen if the current number is smaller
													  // If the current number is greater than the minimum seen so far, it's out of order
													  // and we update the start index
				if (numbers[i] > minSeen)
				{
					start = i;
				}
			}

			// Return a tuple with the start and end indices of the smallest sort window
			return (start, end);
		}
	}
}
