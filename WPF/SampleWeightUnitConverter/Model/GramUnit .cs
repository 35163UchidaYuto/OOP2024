using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWeightUnitConverter {
    public class GramUnit :WeightUnit{
        private static List<GramUnit> units = new List<GramUnit> {
            new GramUnit{Name = "oz",coefficient = 1,},
            new GramUnit{Name = "lb",coefficient = 16,},
        };
        public static ICollection<GramUnit> Units { get { return units; } }
        
        /// <summary>
        /// グラム単位からポンド単位に変換します
        /// </summary>
        /// <param name="unit">グラム単位</param>
        /// <param name="value">値</param>
        /// <returns></returns>
        public double FromPoundUnit(PoundUnit unit, double value) { 
            return (value * unit.coefficient)/ 28.35/ this.coefficient;
        }
    }
}
