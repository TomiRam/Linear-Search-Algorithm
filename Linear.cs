using System;
using static.System.Console;

namespace Linear Search 
{ 
	class Program 
	{
		static void Main(string[] args)
		{
			int Search(int[] arr, int x)
			{
			var i= 0;
			var count= arr.Count();
			while(i<count)
			{
				if(arr[i]==x)
				{
					return i;
				}
			i++;	
			}
		 	var items = new[]{2,3,5,7,11,13,17}
		WriteLine(Search(items, 1));
		//print -1
		WriteLine(Search(items, 7));
		//print 3
		WriteLine(Search(items, 19));
		//print -1

		//simplified speed test

		items = (new int[10000000]).Select((v,i)=>i).ToArray();
		var count = 100;

		var start = DateTime Now;

		for(int i= 0; i< count; i++){
			Search(items, 7777777);
		}
		var delta = DateTime.Now - start;

		var milliseconds = delta.TotalMilliseconds / count;

		WriteLine(milliseconds);
		// about 37 milliseconds
		}
		
	}
}
