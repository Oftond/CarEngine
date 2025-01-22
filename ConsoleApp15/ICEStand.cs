using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ICEStand : Stand
{
    public override int MaxWorkTime => _maxTime;

    public ICEStand(ref Engine _engine, int maxTime = 10000) : base(ref _engine, maxTime) { }

    public override float StartSimulation(float TAir)
    {
        _engine.Start(TAir);
        _engine.OnUpdate -= Update;
        return _workTime;
    }

    public override void Update()
    {
        _workTime++;
        if (_engine.EngineTemp >= _engine.MaxTemp || _workTime >= _maxTime)
            _engine.Stop();
    }
}