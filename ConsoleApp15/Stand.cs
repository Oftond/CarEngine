using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Stand
{
    ushort TimeToWork;
    public static ICE _Ice;

    public Stand(ref ICE _ice)
    {
        _ice.OnUpdate += Check;
        _Ice = _ice;
        TimeToWork = 0;
    }

    public void StartSimulation(float _temAir)
    {
        _Ice.Start(_temAir);
    }

    public void Check()
    {
        TimeToWork++;
        if (_Ice.EngineTemp >= 110)
        {
            Console.WriteLine("Двигатель перегрелся!");
            Console.WriteLine($"Двигатель проработал {TimeToWork} секунд!");
            _Ice.Stop();
        }
    }
}