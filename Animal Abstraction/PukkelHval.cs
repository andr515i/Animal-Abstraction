using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Abstraction
{
	internal class PukkelHval : Hval
	{
		internal override void Sound()
		{
			Console.WriteLine("womp womp");
		}
		internal override void Move()
		{
			Console.WriteLine("Swims");
		}
	}
}
