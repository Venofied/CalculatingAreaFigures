using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CalculatingAreaFigures.EnumListFigure;

namespace CalculatingAreaFigures
{
    public abstract class AbstractFigure
    {
        public abstract TypeFigure Type { get; }
        public abstract double GetAreaFigure();

    }
}
