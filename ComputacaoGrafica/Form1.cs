using System.Collections;

namespace ComputacaoGrafica
{
    public partial class Form1 : Form
    {
        private List<ToolStripButton> btns = new List<ToolStripButton>();
        public Form1()
        {
            InitializeComponent();

            btns.Add(btn_elipse);
            btns.Add(btn_poligono);
            btns.Add(btn_reta);
        }

        private void select_tool(ToolStripButton button)
        {
            for (int i = 0; i < btns.Count; i++)
            {
                if (btns[i] == button)
                {
                    btns[i].BackColor = Color.Blue;
                }
                else
                {
                    btns[i].BackColor = SystemColors.ControlDark;
                }
            }
        }

        private void btn_reta_Click(object sender, EventArgs e)
        {
            select_tool(btn_reta);
        }

        private void btn_elipse_Click(object sender, EventArgs e)
        {
            select_tool(btn_elipse);
        }

        private void btn_poligono_Click(object sender, EventArgs e)
        {
            select_tool(btn_poligono);
        }
    }
}
