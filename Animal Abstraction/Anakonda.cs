using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Abstraction
{
	internal class Anakonda: Slange
	{
		internal override void Sound()
		{
			Console.WriteLine("*Anakondalyde*");
		}
		internal override void Move()
		{
			Console.WriteLine("*Anakondabevægelser*");
		}
	}
}
