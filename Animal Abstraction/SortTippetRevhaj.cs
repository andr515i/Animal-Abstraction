using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Abstraction
{
	internal class SortTippetRevhaj : Haj
	{
		internal override void Sound()
		{
			Console.WriteLine("Waahh shark sound");
		}
		internal override void Move()
		{
			Console.WriteLine("Swims");
		}
	}
}
