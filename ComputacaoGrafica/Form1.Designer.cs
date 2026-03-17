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
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBoxCircunferenciaElipse = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
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
            toolStrip1.Size = new Size(1664, 38);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_reta
            // 
            btn_reta.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_reta.Image = (Image)resources.GetObject("btn_reta.Image");
            btn_reta.ImageTransparentColor = Color.Magenta;
            btn_reta.Name = "btn_reta";
            btn_reta.Size = new Size(24, 35);
            btn_reta.Text = "Reta";
            btn_reta.Click += btn_reta_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // btn_elipse
            // 
            btn_elipse.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_elipse.Image = (Image)resources.GetObject("btn_elipse.Image");
            btn_elipse.ImageTransparentColor = Color.Magenta;
            btn_elipse.Name = "btn_elipse";
            btn_elipse.Size = new Size(24, 35);
            btn_elipse.Text = "Elipse ou Circunferencia (+Shift)";
            btn_elipse.Click += btn_elipse_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 38);
            // 
            // btn_poligono
            // 
            btn_poligono.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_poligono.Image = (Image)resources.GetObject("btn_poligono.Image");
            btn_poligono.ImageTransparentColor = Color.Magenta;
            btn_poligono.Name = "btn_poligono";
            btn_poligono.Size = new Size(24, 35);
            btn_poligono.Text = "Polígono";
            btn_poligono.Click += btn_poligono_Click;
            // 
            // groupBoxReta
            // 
            groupBoxReta.Controls.Add(radioButton3);
            groupBoxReta.Controls.Add(radioButton2);
            groupBoxReta.Controls.Add(radioButton1);
            groupBoxReta.Location = new Point(10, 40);
            groupBoxReta.Margin = new Padding(3, 2, 3, 2);
            groupBoxReta.Name = "groupBoxReta";
            groupBoxReta.Padding = new Padding(3, 2, 3, 2);
            groupBoxReta.Size = new Size(144, 94);
            groupBoxReta.TabIndex = 1;
            groupBoxReta.TabStop = false;
            groupBoxReta.Text = "Opções Reta";
            groupBoxReta.Visible = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(23, 66);
            radioButton3.Margin = new Padding(3, 2, 3, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Ponto Médio";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(23, 44);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(49, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "DDA";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(23, 21);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(96, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Equação Reta";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBoxCircunferenciaElipse
            // 
            groupBoxCircunferenciaElipse.Controls.Add(radioButton6);
            groupBoxCircunferenciaElipse.Controls.Add(radioButton5);
            groupBoxCircunferenciaElipse.Controls.Add(radioButton4);
            groupBoxCircunferenciaElipse.Location = new Point(160, 40);
            groupBoxCircunferenciaElipse.Margin = new Padding(3, 2, 3, 2);
            groupBoxCircunferenciaElipse.Name = "groupBoxCircunferenciaElipse";
            groupBoxCircunferenciaElipse.Padding = new Padding(3, 2, 3, 2);
            groupBoxCircunferenciaElipse.Size = new Size(198, 94);
            groupBoxCircunferenciaElipse.TabIndex = 2;
            groupBoxCircunferenciaElipse.TabStop = false;
            groupBoxCircunferenciaElipse.Text = "Opções Circunferência / Elipse";
            groupBoxCircunferenciaElipse.Visible = false;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(5, 66);
            radioButton6.Margin = new Padding(3, 2, 3, 2);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(113, 19);
            radioButton6.TabIndex = 2;
            radioButton6.TabStop = true;
            radioButton6.Text = "[C] Ponto Médio";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(5, 44);
            radioButton5.Margin = new Padding(3, 2, 3, 2);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(119, 19);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "[C] Trigonometria";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(5, 21);
            radioButton4.Margin = new Padding(3, 2, 3, 2);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(169, 19);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "[C] Equação Circunferência";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1664, 775);
            Controls.Add(groupBoxCircunferenciaElipse);
            Controls.Add(groupBoxReta);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 2, 3, 2);
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
