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

                    imagemPrincipal = DDA(imagemPrincipal, p1.X, p1.Y, p2.X, p2.Y, Color.Black);

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
    }


}