﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    internal class Tennisball : Obj {

        public Tennisball(double xp, double yp)
            : base(xp, yp, @"Picture\tennis_ball.png") {

            MoveX = 5; //移動量設定
            MoveY = 5;
        }

        public override bool Move() {
            PosX += MoveX;
            PosY += MoveY;

            if (PosX > 750 || PosX < 0) {
                MoveX =- MoveX;
            }
            if (PosY > 500 || PosY < 0) {
                MoveY =- MoveY;
            }

            return true;
        }
    }
}
