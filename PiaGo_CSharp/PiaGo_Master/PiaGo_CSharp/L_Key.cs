﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiaGo_CSharp
{
    class L_Key : Key
    {

        public L_Key(int inputX, int inputY, KeyColor inputColor)
            : base(KeyType.T_KEY, inputX, inputY, inputColor)
        {
            ChangeColor(inputColor);
        }
        public override void Draw(Graphics g, int multiplier)
        {
            g.DrawLine(this.Color, X, Y, X, Y + 42 * multiplier);
            g.DrawLine(this.Color, X, Y + 42 * multiplier, X + 12 * multiplier, Y + 42 * multiplier);
            g.DrawLine(this.Color, X + 12 * multiplier, Y + 42 * multiplier, X + 12 * multiplier, Y + 29 * multiplier);
            g.DrawLine(this.Color, X + 12 * multiplier, Y + 29 * multiplier, X + 7 * multiplier, Y + 29 * multiplier);
            g.DrawLine(this.Color, X + 7 * multiplier, Y + 29 * multiplier, X + 7 * multiplier, Y);
            g.DrawLine(this.Color, X + 7 * multiplier, Y, X, Y);
        }
        public override void ChangeColor(KeyColor color)
        {
            switch (color)
            {
                case KeyColor.BLACK:
                    this.Color = new Pen(System.Drawing.Color.Black);
                    break;
                case KeyColor.RED:
                    this.Color = new Pen(System.Drawing.Color.Red);
                    break;
                case KeyColor.GREEN:
                    this.Color = new Pen(System.Drawing.Color.Green);
                    break;
                case KeyColor.BLUE:
                    this.Color = new Pen(System.Drawing.Color.Blue);
                    break;
            }
        }
    }

}
