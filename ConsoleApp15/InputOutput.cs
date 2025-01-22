using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InputOutput
{
    private Stand _stand;

    public InputOutput(Stand stand)
    {
        _stand = stand;
    }

    public void StartStend(float TAir)
    {
        ShowInfo(_stand.StartSimulation(TAir));
    }

    public void ShowInfo(float Time)
    {
        if (Time >= _stand.MaxWorkTime)
        {
            Console.WriteLine("Двигатель успешно закончил свою работу.");
            Console.WriteLine($"Двигатель проработал {Time} секунд.");
        }
        else
        {
            Console.WriteLine($"Двигатель проработал {Time} секунд и перегрелся.");
        }
    }
}