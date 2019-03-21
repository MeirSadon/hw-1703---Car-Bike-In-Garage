using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703__hw___CarInGarageWithNewException
{
    public class Bike : IGiveDetails
    {
        public string Brand { get; }
        public bool TotalLost { get; set; }
        public bool NeedRepair { get; set; }
        public int EngineVolume { get; }


        public Bike(string brand, int engineVolume, bool totalLost, bool needRepair)
        {
            Brand = brand;
            EngineVolume = engineVolume;
            TotalLost = totalLost;
            NeedRepair = needRepair;
        }
        public bool CanFixTotalLost()
        {
            return true;
        }
        public override string ToString()
        {
            string isTotalLost = TotalLost ? "" : " Not";
            string isNeedRepair = NeedRepair ? "" : "Do Not ";
            return $"Bike Brand: { Brand}. Engine Volume: {EngineVolume}. {isTotalLost} Total Lost. And {isNeedRepair}Need Repair.";
        }
    }
}
