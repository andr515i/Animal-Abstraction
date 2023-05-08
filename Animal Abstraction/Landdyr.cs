using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Abstraction
{
	internal abstract class Landdyr: Dyr
	{
		internal abstract override void Sound();
		internal abstract override void Move();

	}
}
