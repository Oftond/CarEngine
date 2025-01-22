using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Stand
{
    public abstract int MaxWorkTime { get; }
    protected Engine _engine;
    protected ushort _workTime = 0;
    protected int _maxTime;

    protected Stand(ref Engine engine, int maxTime)
    {
        _engine = engine;
        _maxTime = maxTime;
        _engine.OnUpdate += Update;
    }

    public abstract void Update();

    public abstract float StartSimulation(float TAir);
}