using System;

namespace ms_tutorial_2
{
    class Program
    {
        static void Main(string[] args)
        {
			String[] names = { "Eugene", "Katherina", "John", "Stephen", "Phil", "Joe", "Alex" };
			int[] times = { 172, 169, 191, 202, 181, 191, 201 };
			int max = times[0];
			int index = 0;
			for (int i = 0; i < times.Length; ++i) 
			{
				if (max < times[i])
				{
					max = times[i];
					index = i;

				}
			}

			Console.WriteLine("Name = {0} Height: {1}", names[index], max);
			//while (true) { }
		}   
    }
}
