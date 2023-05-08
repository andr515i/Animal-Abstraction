using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Abstraction
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Hest hest1 = new Hest();
			Tyr tyr1 = new Tyr();
			hest1.Sound();
			tyr1.Sound();



			Console.Read();

		}
	}
}
