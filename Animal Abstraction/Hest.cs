using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Abstraction
{
	internal class Hest : Landdyr, IPattedyr
	{
		internal override void Sound()
		{
			Console.WriteLine("*hestelyde*");
		}
		internal override void Move()
		{
			Console.WriteLine("*hestebevægelser*");
		}
	}
}
