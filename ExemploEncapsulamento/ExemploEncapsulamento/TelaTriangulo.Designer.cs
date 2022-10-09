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
            this.ttbCatetoB = new System.Windows.Forms.TextBox();
            this.ttbCatetoA = new System.Windows.Forms.TextBox();
            this.ttbHipotenusa = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calcularÁreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttbAltura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(221, 204);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cateto B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cateto A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hipotenusa";
            // 
            // ttbCatetoB
            // 
            this.ttbCatetoB.Location = new System.Drawing.Point(54, 205);
            this.ttbCatetoB.Name = "ttbCatetoB";
            this.ttbCatetoB.Size = new System.Drawing.Size(100, 23);
            this.ttbCatetoB.TabIndex = 4;
            // 
            // ttbCatetoA
            // 
            this.ttbCatetoA.Location = new System.Drawing.Point(54, 133);
            this.ttbCatetoA.Name = "ttbCatetoA";
            this.ttbCatetoA.Size = new System.Drawing.Size(100, 23);
            this.ttbCatetoA.TabIndex = 3;
            // 
            // ttbHipotenusa
            // 
            this.ttbHipotenusa.Location = new System.Drawing.Point(54, 62);
            this.ttbHipotenusa.Name = "ttbHipotenusa";
            this.ttbHipotenusa.Size = new System.Drawing.Size(100, 23);
            this.ttbHipotenusa.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularÁreaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(358, 24);
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
            this.trianguloToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.trianguloToolStripMenuItem.Text = "Triangulo";
            // 
            // retanguloToolStripMenuItem
            // 
            this.retanguloToolStripMenuItem.Name = "retanguloToolStripMenuItem";
            this.retanguloToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.retanguloToolStripMenuItem.Text = "Retangulo";
            this.retanguloToolStripMenuItem.Click += new System.EventHandler(this.retanguloToolStripMenuItem_Click);
            // 
            // ttbAltura
            // 
            this.ttbAltura.Location = new System.Drawing.Point(221, 133);
            this.ttbAltura.Name = "ttbAltura";
            this.ttbAltura.Size = new System.Drawing.Size(100, 23);
            this.ttbAltura.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Altura (Opcional)";
            // 
            // TelaTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 359);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ttbAltura);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ttbCatetoB);
            this.Controls.Add(this.ttbCatetoA);
            this.Controls.Add(this.ttbHipotenusa);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaTriangulo";
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
        private TextBox ttbCatetoB;
        private TextBox ttbCatetoA;
        private TextBox ttbHipotenusa;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem calcularÁreaToolStripMenuItem;
        private ToolStripMenuItem trianguloToolStripMenuItem;
        private ToolStripMenuItem retanguloToolStripMenuItem;
        private TextBox ttbAltura;
        private Label label4;
    }
}