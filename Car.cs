using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703__hw___CarInGarageWithNewException
{
    public class Car : IGiveDetails
    {
        public string Brand { get;}
        public bool TotalLost { get; }
        public bool NeedRepair { get; set; }
        public int EngineVolume { get; }


        public Car(string brand, bool totalLost, bool needRepair)
        {
            Brand = brand;
            TotalLost = totalLost;
            NeedRepair = needRepair;
            if (TotalLost == true && NeedRepair == false)
                throw new RepairMisMatchException("Your Car Is Not Need Repair");
        }

        public bool CanFixTotalLost()
        {
            return false;
        }

        public override string ToString()
        {
            string isTotalLost = TotalLost ? "" : " Not";
            string isNeedRepair = NeedRepair ? "" : "Do Not ";
            return $"Car Brand: { Brand}.{isTotalLost} Total Lost. And {isNeedRepair}Need Repair.";
        }
    }
}
