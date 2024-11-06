using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    public class MetricUnit :DistanceUnit{
        private static List<MetricUnit> units = new List<MetricUnit> {
            new MetricUnit{Name = "mm",coefficient = 1,},
            new MetricUnit{Name = "cm",coefficient = 10,},
            new MetricUnit{Name = "m",coefficient = 10*100,},
            new MetricUnit{Name = "km",coefficient = 10*100*1000,},
        };
        public static ICollection<MetricUnit> Units { get { return units; } }

        /// <summary>
        /// ヤード単位からメートル単位に変換します
        /// </summary>
        /// <param name="unit">ヤード単位</param>
        /// <param name="value">値</param>
        /// <returns></returns>
        public double FromImperialUnit(ImperialUnit unit, double value) { 
            return (value * unit.coefficient)* 25.4/ this.coefficient;
        }
    }
}
