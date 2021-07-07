using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooCorrection
{
    class FuckingTouriste : IHunter
    {
        public void Hunt(Animal prey)
        {
            Console.WriteLine("Avec mon super fusil je butte tout ce qui bouge y compris " + prey.GetType().Name);
        }
    }
}
