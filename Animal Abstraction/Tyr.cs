using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Abstraction
{
	internal class Tyr: Landdyr, IPattedyr
	{
		internal override void Sound()
		{
			Console.WriteLine("*Tyrelyde*");
		}
		internal override void Move()
		{
			Console.WriteLine("*Tyrebevægelser*");
		}
	}
}
