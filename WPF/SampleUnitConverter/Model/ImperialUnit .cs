using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    public class ImperialUnit :DistanceUnit{
        private static List<ImperialUnit> units = new List<ImperialUnit> {
            new ImperialUnit{Name = "in",coefficient = 1,},
            new ImperialUnit{Name = "ft",coefficient = 12,},
            new ImperialUnit{Name = "yd",coefficient = 12 * 3,},
            new ImperialUnit{Name = "ml",coefficient = 12 * 3 * 1760,},
        };
        public static ICollection<ImperialUnit> Units { get { return units; } }

        /// <summary>
        /// メートル単位からヤード単位に変換します
        /// </summary>
        /// <param name="unit">メートル単位</param>
        /// <param name="value">値</param>
        /// <returns></returns>
        public double FromMetricUnit(MetricUnit unit, double value) { 
            return (value * unit.coefficient)/ 25.4/ this.coefficient;
        }
    }
}
