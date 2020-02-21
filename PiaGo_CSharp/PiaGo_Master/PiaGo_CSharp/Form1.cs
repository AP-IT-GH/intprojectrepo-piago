﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiaGo_CSharp
{
    public partial class Form1 : Form
    {
        //CODE FOR GRAPHICAL PIANO
        int multiplier = 4;
        int whiteKeySpace = 12;
        int blackKeySpace = 5;
        static int keyboardX = 35;
        static int keyboardY = 35;
        Brush blackBrush = new SolidBrush(Color.Black);
        Graphics g = null;
        List<Key> keyBoard = new List<Key>();
        //------------------------
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CODE FOR GRAPHICAL PIANO
            whiteKeySpace *= multiplier;
            blackKeySpace *= multiplier;
            CreateKeyboard();
            canvas.Refresh();
            //------------------------
        }
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;            
            DrawKeyboard();
        }
        private void DrawKeyboard()
        {
            for (int i = 0; i < keyBoard.Count; i++)
            {
                keyBoard[i].Draw(g, multiplier);
            }
        }
        void CreateKeyboard()
        {
            int whiteKeys = 0;
            keyBoard.Add(new L_Key(keyboardX + (whiteKeySpace * whiteKeys), keyboardY, KeyColor.BLACK)); whiteKeys++;
                keyBoard.Add(new BlackKey(keyboardX + (whiteKeySpace * whiteKeys)-blackKeySpace, keyboardY, KeyColor.BLACK));
            keyBoard.Add(new T_Key(keyboardX + (whiteKeySpace * whiteKeys), keyboardY, KeyColor.BLACK)); whiteKeys++;
                keyBoard.Add(new BlackKey(keyboardX + (whiteKeySpace * whiteKeys) - blackKeySpace, keyboardY, KeyColor.BLACK));
            keyBoard.Add(new T_Key(keyboardX + (whiteKeySpace * whiteKeys), keyboardY, KeyColor.BLACK)); whiteKeys++;
                keyBoard.Add(new BlackKey(keyboardX + (whiteKeySpace * whiteKeys) - blackKeySpace, keyboardY, KeyColor.BLACK));
            keyBoard.Add(new RL_Key(keyboardX + (whiteKeySpace * whiteKeys), keyboardY, KeyColor.BLACK)); whiteKeys++;

            keyBoard.Add(new L_Key(keyboardX + (whiteKeySpace * whiteKeys), keyboardY, KeyColor.BLACK)); whiteKeys++;
                keyBoard.Add(new BlackKey(keyboardX + (whiteKeySpace * whiteKeys) - blackKeySpace, keyboardY, KeyColor.BLACK));
            keyBoard.Add(new T_Key(keyboardX + (whiteKeySpace * whiteKeys), keyboardY, KeyColor.BLACK)); whiteKeys++;
                keyBoard.Add(new BlackKey(keyboardX + (whiteKeySpace * whiteKeys) - blackKeySpace, keyboardY, KeyColor.BLACK));
            keyBoard.Add(new RL_Key(keyboardX + (whiteKeySpace * whiteKeys), keyboardY, KeyColor.BLACK)); whiteKeys++;

            keyBoard.Add(new L_Key(keyboardX + (whiteKeySpace * whiteKeys), keyboardY, KeyColor.BLACK)); whiteKeys++;
                keyBoard.Add(new BlackKey(keyboardX + (whiteKeySpace * whiteKeys) - blackKeySpace, keyboardY, KeyColor.BLACK));
            keyBoard.Add(new T_Key(keyboardX + (whiteKeySpace * whiteKeys), keyboardY, KeyColor.BLACK)); whiteKeys++;
                keyBoard.Add(new BlackKey(keyboardX + (whiteKeySpace * whiteKeys) - blackKeySpace, keyboardY, KeyColor.BLACK));
            keyBoard.Add(new T_Key(keyboardX + (whiteKeySpace * whiteKeys), keyboardY, KeyColor.BLACK)); whiteKeys++;
                keyBoard.Add(new BlackKey(keyboardX + (whiteKeySpace * whiteKeys) - blackKeySpace, keyboardY, KeyColor.BLACK));
            keyBoard.Add(new RL_Key(keyboardX + (whiteKeySpace * whiteKeys), keyboardY, KeyColor.BLACK)); whiteKeys++;

            keyBoard.Add(new L_Key(keyboardX + (whiteKeySpace * whiteKeys), keyboardY, KeyColor.BLACK)); whiteKeys++;
                keyBoard.Add(new BlackKey(keyboardX + (whiteKeySpace * whiteKeys) - blackKeySpace, keyboardY, KeyColor.BLACK));
            keyBoard.Add(new T_Key(keyboardX + (whiteKeySpace * whiteKeys), keyboardY, KeyColor.BLACK)); whiteKeys++;
                keyBoard.Add(new BlackKey(keyboardX + (whiteKeySpace * whiteKeys) - blackKeySpace, keyboardY, KeyColor.BLACK));
            keyBoard.Add(new RL_Key(keyboardX + (whiteKeySpace * whiteKeys), keyboardY, KeyColor.BLACK)); whiteKeys++;

            keyBoard.Add(new L_Key(keyboardX + (whiteKeySpace * whiteKeys), keyboardY, KeyColor.BLACK)); whiteKeys++;
                keyBoard.Add(new BlackKey(keyboardX + (whiteKeySpace * whiteKeys) - blackKeySpace, keyboardY, KeyColor.BLACK));
            keyBoard.Add(new T_Key(keyboardX + (whiteKeySpace * whiteKeys), keyboardY, KeyColor.BLACK)); whiteKeys++;
                keyBoard.Add(new BlackKey(keyboardX + (whiteKeySpace * whiteKeys) - blackKeySpace, keyboardY, KeyColor.BLACK));
            keyBoard.Add(new T_Key(keyboardX + (whiteKeySpace * whiteKeys), keyboardY, KeyColor.BLACK)); whiteKeys++;
                keyBoard.Add(new BlackKey(keyboardX + (whiteKeySpace * whiteKeys) - blackKeySpace, keyboardY, KeyColor.BLACK));
            keyBoard.Add(new RL_Key(keyboardX + (whiteKeySpace * whiteKeys), keyboardY, KeyColor.BLACK)); whiteKeys++;

            keyBoard.Add(new WhiteKey(keyboardX + (whiteKeySpace * whiteKeys), keyboardY, KeyColor.BLACK));            
        }
    }
}