using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

class ICE : Engine
{
    private float _curTemp = 0;
    private bool _isWorking = false;

    public override event Action OnUpdate;

    public override float EngineTemp => _curTemp;

    public override float MaxTemp => _t;

    public override bool EngineStatus => _isWorking;

    public ICE(float I, List<int> M, List<int> V, float T, float HM, float HV, float C)
    {
        _i = I;
        _m = M;
        _v = V;
        _hm = HM;
        _hv = HV;
        _c = C;
        _t = T;
    }

    public override void Start(float TAir)
    {
        _isWorking = true;
        _curTemp = TAir;

        float a, Vh, Vc, M, V;

        for (int i = 0; i < _m.Count - 1; i++)
        {
            M = _m[i];
            V = _v[i];
            while(V < _v[i + 1])
            {
                if (!_isWorking)
                    return;
                a = M * _i;
                Vh = M * _hm + V * V * _hv;
                Vc = _c * (TAir - _curTemp);

                _curTemp += Vh + Vc;
                V += a;
                M = (V - _v[i]) * (_m[i + 1] - _m[i]) / (_v[i + 1] - _v[i]) + _m[i];
                OnUpdate?.Invoke();
            }
        }
    }

    public override void Stop() => _isWorking = false;
}