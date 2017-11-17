using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kostenverdeling.Model.Settings
{
    public interface ICalculationSettingsLoader { 
        CalculationSettings Load();
    }
}
