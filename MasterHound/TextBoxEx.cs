using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterHound
{
    public partial class TextBoxEx : UserControl
    {
        #region -> Fields
        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private Color borderFocusedColor = Color.HotPink;
        private int borderSize = 2;
        private bool underLinedStyle = false;
        private bool isFocused = false;

        private int borderRadius = 0;

        //Events
        public event EventHandler _TextChanged;

        #endregion

        [Category("Advanced")]
        public string Texts
        {
            get { return CMB_BOX.Text; }
            set { CMB_BOX.Text = value;}
        }

        [Category("Advanced")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { 
                if(BorderRadius >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();
                }            
            }
        }

        [Category("Advanced")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate();}
        }


        public TextBoxEx()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e) 
        {
            base.OnPaint(e);            
            Graphics graphics= e.Graphics;

            if(borderRadius>1)//rounded textbox
            {
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize>0?borderSize:1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius)) 
                using(GraphicsPath pathBorder= GetFigurePath(rectBorder, borderRadius-borderSize))
                using(Pen penBorderSmooth= new Pen(this.Parent.BackColor,smoothSize))
                using(Pen penBorder = new Pen(borderColor,borderSize))
                {
                    this.Region = new Region(pathBorderSmooth);
                    if (BorderRadius > 15) SetTextBoxRoundedRegion();
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    penBorder.Alignment = PenAlignment.Center;
                    if (isFocused) { penBorder.Color = borderFocusedColor; }

                    if (underLinedStyle) 
                    {
                        graphics.DrawPath(penBorderSmooth,pathBorderSmooth);
                        graphics.SmoothingMode = SmoothingMode.None;
                        graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1); 
                    }
                    else
                    {
                        graphics.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graphics.DrawPath(penBorder, pathBorder);
                    }
                        
                }

            }
            else
            {
                graphics.Clear(borderColor);
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = PenAlignment.Inset;
                    if (isFocused) { penBorder.Color = borderFocusedColor; }

                    if (underLinedStyle) graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graphics.DrawRectangle(penBorder, 0, 0, this.Width - .05f, this.Height - .05f);
                }
            }            
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;

            pathTxt = GetFigurePath(CMB_BOX.ClientRectangle, 2*borderRadius);
            CMB_BOX.Region= new Region(pathTxt);
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2f;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);

            path.CloseFigure();

            return path;
        }
    }
}
