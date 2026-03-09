namespace ComputacaoGrafica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            btn_reta = new ToolStripButton();
            btn_elipse = new ToolStripButton();
            btn_poligono = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = SystemColors.ControlDark;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_reta, btn_elipse, btn_poligono });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1902, 50);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_reta
            // 
            btn_reta.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_reta.Image = (Image)resources.GetObject("btn_reta.Image");
            btn_reta.ImageTransparentColor = Color.Magenta;
            btn_reta.Name = "btn_reta";
            btn_reta.Size = new Size(29, 47);
            btn_reta.Text = "Reta";
            btn_reta.Click += btn_reta_Click;
            // 
            // btn_elipse
            // 
            btn_elipse.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_elipse.Image = (Image)resources.GetObject("btn_elipse.Image");
            btn_elipse.ImageTransparentColor = Color.Magenta;
            btn_elipse.Name = "btn_elipse";
            btn_elipse.Size = new Size(29, 47);
            btn_elipse.Text = "Elipse ou Circunferencia (+Shift)";
            btn_elipse.Click += btn_elipse_Click;
            // 
            // btn_poligono
            // 
            btn_poligono.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_poligono.Image = (Image)resources.GetObject("btn_poligono.Image");
            btn_poligono.ImageTransparentColor = Color.Magenta;
            btn_poligono.Name = "btn_poligono";
            btn_poligono.Size = new Size(29, 47);
            btn_poligono.Text = "Polígono";
            btn_poligono.Click += btn_poligono_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Desenho";
            WindowState = FormWindowState.Maximized;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btn_reta;
        private ToolStripButton btn_elipse;
        private ToolStripButton btn_poligono;
    }
}
