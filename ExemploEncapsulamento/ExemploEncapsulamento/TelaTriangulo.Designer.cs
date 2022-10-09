namespace ExemploEncapsulamento
{
    partial class TelaTriangulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ttbLadoC = new System.Windows.Forms.TextBox();
            this.ttbLadoB = new System.Windows.Forms.TextBox();
            this.ttbLadoA = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calcularÁreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(245, 199);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lado C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lado B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lado A";
            // 
            // ttbLadoC
            // 
            this.ttbLadoC.Location = new System.Drawing.Point(54, 199);
            this.ttbLadoC.Name = "ttbLadoC";
            this.ttbLadoC.Size = new System.Drawing.Size(100, 23);
            this.ttbLadoC.TabIndex = 9;
            // 
            // ttbLadoB
            // 
            this.ttbLadoB.Location = new System.Drawing.Point(54, 125);
            this.ttbLadoB.Name = "ttbLadoB";
            this.ttbLadoB.Size = new System.Drawing.Size(100, 23);
            this.ttbLadoB.TabIndex = 8;
            // 
            // ttbLadoA
            // 
            this.ttbLadoA.Location = new System.Drawing.Point(54, 62);
            this.ttbLadoA.Name = "ttbLadoA";
            this.ttbLadoA.Size = new System.Drawing.Size(100, 23);
            this.ttbLadoA.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularÁreaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(349, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calcularÁreaToolStripMenuItem
            // 
            this.calcularÁreaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trianguloToolStripMenuItem,
            this.retanguloToolStripMenuItem});
            this.calcularÁreaToolStripMenuItem.Name = "calcularÁreaToolStripMenuItem";
            this.calcularÁreaToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.calcularÁreaToolStripMenuItem.Text = "Calcular Área";
            // 
            // trianguloToolStripMenuItem
            // 
            this.trianguloToolStripMenuItem.Name = "trianguloToolStripMenuItem";
            this.trianguloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trianguloToolStripMenuItem.Text = "Triangulo";
            // 
            // retanguloToolStripMenuItem
            // 
            this.retanguloToolStripMenuItem.Name = "retanguloToolStripMenuItem";
            this.retanguloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.retanguloToolStripMenuItem.Text = "Retangulo";
            this.retanguloToolStripMenuItem.Click += new System.EventHandler(this.retanguloToolStripMenuItem_Click);
            // 
            // Triangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 266);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ttbLadoC);
            this.Controls.Add(this.ttbLadoB);
            this.Controls.Add(this.ttbLadoA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Triangulo";
            this.Text = "Triangulo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalcular;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox ttbLadoC;
        private TextBox ttbLadoB;
        private TextBox ttbLadoA;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem calcularÁreaToolStripMenuItem;
        private ToolStripMenuItem trianguloToolStripMenuItem;
        private ToolStripMenuItem retanguloToolStripMenuItem;
    }
}