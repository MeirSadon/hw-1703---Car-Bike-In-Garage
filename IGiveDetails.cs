using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703__hw___CarInGarageWithNewException
{
    public interface IGiveDetails
    {
        string Brand { get; }
        int EngineVolume { get; }
        bool TotalLost { get; }
        bool NeedRepair { get; set; }

        bool CanFixTotalLost();
    }
}
