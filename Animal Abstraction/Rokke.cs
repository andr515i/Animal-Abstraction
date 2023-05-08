using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Abstraction
{
	internal class Rokke : Vanddyr 
	{
		internal override void Sound()
		{
			Console.WriteLine("you own me money");
		}
		internal override void Move()
		{
			Console.WriteLine("Swims");
		}
	}
}
