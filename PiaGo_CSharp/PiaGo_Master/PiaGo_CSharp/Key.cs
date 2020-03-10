﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Midi;

namespace PiaGo_CSharp
{
    enum KeyType    { BLACK_KEY, WHITE_KEY, L_KEY, RL_KEY, T_KEY }
    enum KeyColor   { BLACK, RED, GREEN, BLUE, YELLOW, WHITE }

    abstract class Key
    {

        public int KeyName { get; set; }

        public Pen Color
        {
            get
            {
                return new Pen(System.Drawing.Color.Black);
            }
        }

        public void MakeSound(int freq,int duration, Clock clock, OutputDevice outputDevice)
        {
            //Console.Beep(freq, duration);
            clock.Schedule(new NoteOnMessage(outputDevice, Channel.Channel1, (Pitch)(53 + freq), 80, clock.Time));
            clock.Schedule(new NoteOffMessage(outputDevice, Channel.Channel1, (Pitch)(53 + freq), 80, clock.Time + 1));
        }

        public virtual void Clear()
        {
            this.SetKeyFill(KeyColor.WHITE);
        }


        private System.Drawing.SolidBrush fill;

        public void SetKeyFill(KeyColor inputColor)
        {
            switch (inputColor)
            {
                case KeyColor.BLACK:
                    fill = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                    break;
                case KeyColor.RED:
                    fill = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                    break;
                case KeyColor.GREEN:
                    fill = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
                    break;
                case KeyColor.BLUE:
                    fill = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
                    break;
                case KeyColor.YELLOW:
                    fill = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
                    break;
                default:
                    fill = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                    break;
            }
        }

        public System.Drawing.SolidBrush GetKeyFill()
        {
            return fill;
        }

        public KeyType Type { get; }
        public int X { get; }
        public int Y { get; }

        public Key(KeyType inputType,int inputX,int inputY,KeyColor inputColor)
         {
            this.Type = inputType;
            this.X = inputX;
            this.Y = inputY;
         }
        public abstract void Draw(Graphics g,int multiplier);

        

    }
}
