﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    internal class Tennisball : Obj {
        Random random = new Random();//乱数インスタンス
        public static int Count {  get; set; }

        public Tennisball(double xp, double yp)
            : base(xp, yp, @"Picture\tennis_ball.png") {

            MoveX = random.Next(-25,25); //移動量設定
            MoveY = random.Next(-25,25);
           

            Count++; 
        }

        public override bool Move(PictureBox pbBar, PictureBox pbBall) {
            Rectangle rBar = new Rectangle(pbBar.Location.X, pbBar.Location.Y,
                                                            pbBar.Width, pbBar.Height);

            Rectangle rBall = new Rectangle(pbBall.Location.X, pbBall.Location.Y,
                                                             pbBall.Width, pbBall.Height);
           

            if (PosX > 750 || PosX < 0) {
                MoveX =- MoveX;
            }
            if (PosY > 500 || PosY < 0 || rBar.IntersectsWith(rBall)) {
                MoveY =- MoveY;
            }
            PosX += MoveX;
            PosY += MoveY;
            return true;
        }

        public override bool Move(Keys direction) {
            return true;
        }
    }
}
