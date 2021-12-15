using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{

	/*
	 * Complete the 'compareTriplets' function below.
	 *
	 * The function is expected to return an INTEGER_ARRAY.
	 * The function accepts following parameters:
	 *  1. INTEGER_ARRAY a
	 *  2. INTEGER_ARRAY b
	 */

	public static List<int> compareTriplets(List<int> a, List<int> b)
	{
		List<int> scores = new List<int>();
		scores.Add(0);
		scores.Add(0);
		foreach (var item in a)
		{
			if (a[0] > b[0])
			{
				scores[0] = +1;
			}
			else if (a[0] < b[0])
			{
				scores[1] = +1;
			}
		}
		return scores;
	}
}

class Solution
{
	public static void Main(string[] args)
	{
		int[] A = { 4, 10, 5, 4, 2, 10 };
		//var r = MySolution(A);
		var e = UniqueElem(A);

		TextWriter textWriter = new StreamWriter(@"C:\Users\Aura\source\repos\HackerrankChallenges\Class1.txt", true);

		List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

		List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

		List<int> result = Result.compareTriplets(a, b);

		textWriter.WriteLine(String.Join(" ", result));

		textWriter.Flush();
		textWriter.Close();
	}

	// https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/
	public void Rotate()
	{
		int n = 3;
		int[] a = { 3, 8, 9, 7, 6 };
		int[] temp = new int[a.Length];


		for (int j = 0; j < a.Length; j++)
		{
			int k = j;
			for (int i = 0; i < n; i++)
			{
				k++;
				if (k >= a.Length)
				{
					k = 0;
				}
			}
			temp[k] = a[j];
		}

		Console.Write("[");
		foreach (var item in temp)
		{
			Console.Write(item.ToString() + " ");
		}
		Console.Write("]");
	}

	public static int UniqueElem(int[] A)
	{
		int occure = 0;
		for (int i = 0; i < A.Length; i++)
		{
			for (int j = 0; j < A.Length; j++)
			{
				if ((A[i] == A[j] && i == j) || A[i] != A[j])
				{
					continue;
				}
				else if (A[i] == A[j])
				{
					occure++;
				}
			}
			if (occure == 0)
			{
				return A[i];
			}
			else
			{
				occure = 0;
			}
		}
		return -1;
	}

	public static int AsAndBs(int A, int B)
	{
		string str = "";
		for (int i = 0; i < A; i++)
		{
			if (i<2)
			{

			}
			for (int j = 0; j < B; j++)
			{
			
			}
			if (occure == 0)
			{
				return A[i];
			}
			else
			{
				occure = 0;
			}
		}
		return -1;
	}


	public static int[] SortArray(int[] A)
	{

		for (int i = 1; i < A.Length; i++)
		{
			for (int j = 0; j < A.Length; j++)
			{
				if ((j + 1 < A.Length) && A[j] > A[j + 1])
				{
					var temp = A[j + 1];
					A[j + 1] = A[j];
					A[j] = temp;
				}
			}
		}
		return A;
	}

}// Todo: needs review
