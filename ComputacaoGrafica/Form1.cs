using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ComputacaoGrafica
{
    public partial class Form1 : Form
    {
        private List<ToolStripButton> btns = new List<ToolStripButton>();


        private Point p1;
        private bool primeiroClique = true;
        private Bitmap imagemPrincipal;
        private string ferramentaAtiva = "";
        private string algoritmoReta = "";

        public Form1()
        {
            InitializeComponent();

            btns.Add(btn_elipse);
            btns.Add(btn_poligono);
            btns.Add(btn_reta);

            imagemPrincipal = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                         Screen.PrimaryScreen.Bounds.Height);

            this.BackgroundImage = imagemPrincipal;
            this.BackgroundImageLayout = ImageLayout.None;

            this.MouseClick += new MouseEventHandler(Form1_MouseClick);
        }

        private void select_tool(ToolStripButton button)
        {
            foreach (var btn in btns)
            {
                if (btn == button)
                {
                    btn.BackColor = Color.Blue;
                    ferramentaAtiva = btn.Name;
                }
                else
                {
                    btn.BackColor = SystemColors.ControlDark;
                }
            }

            primeiroClique = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (ferramentaAtiva == "btn_reta")
            {
                if (primeiroClique)
                {
                    p1 = e.Location;
                    primeiroClique = false;
                }
                else
                {
                    Point p2 = e.Location;

                    if (algoritmoReta == "DDA")
                    {
                        imagemPrincipal = DDA(imagemPrincipal, p1.X, p1.Y, p2.X, p2.Y, Color.Black);
                    }
                    else if (algoritmoReta == "Bresenham")
                    {
                        imagemPrincipal = Bresenham(imagemPrincipal, p1.X, p1.Y, p2.X, p2.Y, Color.Black);
                    }

                    this.BackgroundImage = imagemPrincipal;
                    this.Invalidate();

                    primeiroClique = true;
                }
            }
        }

        // ALGORITMO DDA
        public static Bitmap DDA(Bitmap img, int x1, int y1, int x2, int y2, Color cor)
        {
            Bitmap btm = new Bitmap(img);

            int comprimento = Math.Max(Math.Abs(x2 - x1), Math.Abs(y2 - y1));

            if (comprimento == 0)
            {
                Pintar.Desenhar(btm, x1, y1, cor);
                return btm;
            }

            double xInc = (double)(x2 - x1) / comprimento;
            double yInc = (double)(y2 - y1) / comprimento;

            double x = x1;
            double y = y1;

            for (int i = 0; i <= comprimento; i++)
            {
                Pintar.Desenhar(btm, (int)Math.Round(x), (int)Math.Round(y), cor);
                x += xInc;
                y += yInc;
            }

            return btm;
        }

        // ALGORITMO BRESENHAM
        public static Bitmap Bresenham(Bitmap img, int x1, int y1, int x2, int y2, Color cor)
        {
            Bitmap btm = new Bitmap(img);

            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);

            int sx = (x1 < x2) ? 1 : -1;
            int sy = (y1 < y2) ? 1 : -1;

            int err = dx - dy;

            int x = x1;
            int y = y1;

            while (x != x2 || y != y2)
            {
                Pintar.Desenhar(btm, x, y, cor);

                int e2 = 2 * err;

                if (e2 > -dy)
                {
                    err -= dy;
                    x += sx;
                }

                if (e2 < dx)
                {
                    err += dx;
                    y += sy;
                }
            }

            // desenha o último ponto
            Pintar.Desenhar(btm, x2, y2, cor);

            return btm;
        }

        public static class Pintar
        {
            public static void Desenhar(Bitmap btm, int x, int y, Color cor)
            {
                if (x >= 0 && x < btm.Width && y >= 0 && y < btm.Height)
                {
                    btm.SetPixel(x, y, cor);
                }
            }
        }


        private void btn_reta_Click(object sender, EventArgs e)
        {
            select_tool(btn_reta);
            groupBoxReta.Visible = true;
            groupBoxCircunferenciaElipse.Visible = false;
        }

        private void btn_elipse_Click(object sender, EventArgs e)
        {
            select_tool(btn_elipse);
            groupBoxReta.Visible = false;
            groupBoxCircunferenciaElipse.Visible = true;
        }

        private void btn_poligono_Click(object sender, EventArgs e)
        {
            select_tool(btn_poligono);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            algoritmoReta = "DDA";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            algoritmoReta = "Bresenham";
        }
    }


}