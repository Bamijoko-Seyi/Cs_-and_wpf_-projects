using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino_chain
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool CanChain(IEnumerable<(int top, int bottom)> dominoes)
        {
            //for no dominoes
            if(dominoes.Count() == 0)
            {
                return false;
            }

            //for one domino
            if(dominoes.Count() == 1)
            {
                if (dominoes.First().top == dominoes.First().bottom)
                {
                    return true;
                }
                return false;
            }

            foreach ((int top,int bottom) domino in dominoes)
            {

                for(int i = 0; i < dominoes.Count(); i++)
                {
                    if(domino.top == dominoes[i].top)
                }
            }
            return true;
        }
    }
}
