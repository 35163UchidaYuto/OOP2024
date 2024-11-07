﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWeightUnitConverter {
    public class PoundUnit :WeightUnit{
        private static List<PoundUnit> units = new List<PoundUnit> {
            new PoundUnit{Name = "g",coefficient = 1,},
            new PoundUnit{Name = "kg",coefficient = 1000,},
            
        };
        public static ICollection<PoundUnit> Units { get { return units; } }

        /// <summary>
        /// ポンド単位からグラム単位に変換します
        /// </summary>
        /// <param name="unit">ポンド単位</param>
        /// <param name="value">値</param>
        /// <returns></returns>
        public double FromGramUnit(GramUnit unit, double value) { 
            return (value * unit.coefficient)* 28.35/ this.coefficient;
        }
    }
}
