using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Casa_de_Schimb_Valutar
{
    public class GraficLinie : Control
    {
        public class Serie
        {
            public string Nume;
            public Color Culoare;
            public List<double> Valori;
        }

        private List<Serie> serii;

        public GraficLinie()
        {
            this.ResizeRedraw = true;
            this.DoubleBuffered = true;
            this.BackColor = Color.White;
            serii = new List<Serie>();
        }

        public void SeteazaDate(List<Serie> seriiNoi)
        {
            serii = seriiNoi ?? new List<Serie>();
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle canvas = new Rectangle
            {
                X = this.ClientRectangle.X + 10,
                Y = this.ClientRectangle.Y + 10,
                Width = this.ClientRectangle.Width - 20,
                Height = this.ClientRectangle.Height - 20
            };
            g.DrawRectangle(Pens.Black, canvas);

            if (serii == null || serii.Count == 0) return;

            double maxv = double.MinValue, minv = double.MaxValue;
            int nrPuncte = 0;
            foreach (var s in serii)
            {
                if (s.Valori == null) continue;
                foreach (var v in s.Valori)
                {
                    if (v > maxv) maxv = v;
                    if (v < minv) minv = v;
                }
                if (s.Valori.Count > nrPuncte) nrPuncte = s.Valori.Count;
            }
            if (nrPuncte < 2) return;

            double interval = maxv - minv;
            if (interval == 0) return;

            float pas = (float)canvas.Width / (nrPuncte - 1);

            for (int idxSerie = 0; idxSerie < serii.Count; idxSerie++)
            {
                var s = serii[idxSerie];
                if (s.Valori == null || s.Valori.Count < 2) continue;

                PointF[] puncte = new PointF[s.Valori.Count];
                for (int i = 0; i < s.Valori.Count; i++)
                {
                    float x = canvas.X + i * pas;
                    float y = canvas.Y + canvas.Height
                              - (float)((s.Valori[i] - minv) / interval) * canvas.Height;
                    puncte[i] = new PointF(x, y);
                }

                using (Pen p = new Pen(s.Culoare, 2F))
                {
                    g.DrawLines(p, puncte);
                }
                using (Brush b = new SolidBrush(s.Culoare))
                using (Font fnt = new Font(this.Font.FontFamily, 7.5F, FontStyle.Bold))
                {
                    bool deasupra = idxSerie == 0;
                    for (int i = 0; i < puncte.Length; i++)
                    {
                        PointF pt = puncte[i];
                        g.FillEllipse(b, pt.X - 3F, pt.Y - 3F, 6F, 6F);

                        string txt = s.Valori[i].ToString("N4");
                        SizeF sz = g.MeasureString(txt, fnt);
                        float tx = pt.X - sz.Width / 2F;
                        float ty = deasupra ? pt.Y - sz.Height - 4F : pt.Y + 4F;
                        if (tx < canvas.X) tx = canvas.X;
                        if (tx + sz.Width > canvas.Right) tx = canvas.Right - sz.Width;
                        if (ty < canvas.Y) ty = pt.Y + 4F;
                        if (ty + sz.Height > canvas.Bottom) ty = pt.Y - sz.Height - 4F;
                        g.DrawString(txt, fnt, Brushes.Black, tx, ty);
                    }
                }
            }
        }
    }
}
