using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Engine
{
    protected float _i;
    protected List<int> _m;
    protected List<int> _v;
    protected float _t;
    protected float _hm;
    protected float _hv;
    protected float _c;

    public abstract float EngineTemp {  get; }
    public abstract float MaxTemp { get; }
    public abstract bool EngineStatus { get; }

    public abstract void Start(float TAir);
    public abstract void Stop();
}