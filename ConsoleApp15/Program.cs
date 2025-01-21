using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICE ice = new ICE(0.1f, new List<int> { 20, 75, 100, 105, 75, 0 }, new List<int> { 0, 75, 150, 200, 250, 300 }, 110, 0.01f, 0.0001f, 0.1f);
            Stand stand = new Stand(ref ice);
            stand.StartSimulation(50);
        }
    }
}