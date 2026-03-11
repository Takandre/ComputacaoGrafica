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
            toolStripSeparator1 = new ToolStripSeparator();
            btn_elipse = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btn_poligono = new ToolStripButton();
            groupBoxReta = new GroupBox();
            groupBoxCircunferenciaElipse = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            toolStrip1.SuspendLayout();
            groupBoxReta.SuspendLayout();
            groupBoxCircunferenciaElipse.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = SystemColors.ControlDark;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_reta, toolStripSeparator1, btn_elipse, toolStripSeparator2, btn_poligono });
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
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 50);
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
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 50);
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
            // groupBoxReta
            // 
            groupBoxReta.Controls.Add(radioButton3);
            groupBoxReta.Controls.Add(radioButton2);
            groupBoxReta.Controls.Add(radioButton1);
            groupBoxReta.Location = new Point(12, 53);
            groupBoxReta.Name = "groupBoxReta";
            groupBoxReta.Size = new Size(165, 125);
            groupBoxReta.TabIndex = 1;
            groupBoxReta.TabStop = false;
            groupBoxReta.Text = "Opções Reta";
            groupBoxReta.Visible = false;
            // 
            // groupBoxCircunferenciaElipse
            // 
            groupBoxCircunferenciaElipse.Controls.Add(radioButton6);
            groupBoxCircunferenciaElipse.Controls.Add(radioButton5);
            groupBoxCircunferenciaElipse.Controls.Add(radioButton4);
            groupBoxCircunferenciaElipse.Location = new Point(183, 53);
            groupBoxCircunferenciaElipse.Name = "groupBoxCircunferenciaElipse";
            groupBoxCircunferenciaElipse.Size = new Size(226, 125);
            groupBoxCircunferenciaElipse.TabIndex = 2;
            groupBoxCircunferenciaElipse.TabStop = false;
            groupBoxCircunferenciaElipse.Text = "Opções Circunferência / Elipse";
            groupBoxCircunferenciaElipse.Visible = false;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(6, 88);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(138, 24);
            radioButton6.TabIndex = 2;
            radioButton6.TabStop = true;
            radioButton6.Text = "[C] Ponto Médio";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 58);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(147, 24);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "[C] Trigonometria";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 28);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(208, 24);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "[C] Equação Circunferência";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(26, 88);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(115, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Ponto Médio";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(26, 58);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(62, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "DDA";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(26, 28);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(121, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Equação Reta";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(groupBoxCircunferenciaElipse);
            Controls.Add(groupBoxReta);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Desenho";
            WindowState = FormWindowState.Maximized;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBoxReta.ResumeLayout(false);
            groupBoxReta.PerformLayout();
            groupBoxCircunferenciaElipse.ResumeLayout(false);
            groupBoxCircunferenciaElipse.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btn_reta;
        private ToolStripButton btn_elipse;
        private ToolStripButton btn_poligono;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private GroupBox groupBoxReta;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBoxCircunferenciaElipse;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
    }
}
