﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    internal class Bar : Obj {
        public Bar(double x, double y)
            : base(x, y, @"Picture\bar.png") {

            MoveX = 10;
            MoveY = 0;
        }


        public override bool Move() {
            return true;
        }

        public override bool Move(Keys direction) {
            if (direction == Keys.Right) {
                if (PosX < 635) {
                    PosX += MoveX;
                }
            } else if (direction == Keys.Left) {
                if (PosX > 0) {
                    PosX -= MoveX;
                }
            }
            return true;

        }
    }
}
