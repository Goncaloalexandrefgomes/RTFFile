namespace RTFFile
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.abrir = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.eliminar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Maiusculas = new System.Windows.Forms.Button();
            this.Minusculas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Iniciais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // abrir
            // 
            this.abrir.BackColor = System.Drawing.Color.Transparent;
            this.abrir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.abrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abrir.ForeColor = System.Drawing.Color.Red;
            this.abrir.Location = new System.Drawing.Point(38, 140);
            this.abrir.Name = "abrir";
            this.abrir.Size = new System.Drawing.Size(83, 35);
            this.abrir.TabIndex = 0;
            this.abrir.Text = "MOSTRAR";
            this.abrir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abrir.UseVisualStyleBackColor = false;
            this.abrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.richTextBox1.Location = new System.Drawing.Point(163, 54);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(278, 386);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.Transparent;
            this.eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.ForeColor = System.Drawing.Color.Red;
            this.eliminar.Location = new System.Drawing.Point(38, 192);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(83, 35);
            this.eliminar.TabIndex = 4;
            this.eliminar.Text = "ELIMINAR";
            this.eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.Transparent;
            this.guardar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.ForeColor = System.Drawing.Color.Red;
            this.guardar.Location = new System.Drawing.Point(38, 245);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(83, 35);
            this.guardar.TabIndex = 5;
            this.guardar.Text = "GUARDAR";
            this.guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "Poemas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Created BY : Gonçalo Gomes";
            // 
            // Maiusculas
            // 
            this.Maiusculas.BackColor = System.Drawing.Color.Transparent;
            this.Maiusculas.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Maiusculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maiusculas.ForeColor = System.Drawing.Color.Red;
            this.Maiusculas.Location = new System.Drawing.Point(38, 351);
            this.Maiusculas.Name = "Maiusculas";
            this.Maiusculas.Size = new System.Drawing.Size(94, 35);
            this.Maiusculas.TabIndex = 8;
            this.Maiusculas.Text = "MAIUSCULAS";
            this.Maiusculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Maiusculas.UseVisualStyleBackColor = false;
            this.Maiusculas.Click += new System.EventHandler(this.Maiusculas_Click);
            // 
            // Minusculas
            // 
            this.Minusculas.BackColor = System.Drawing.Color.Transparent;
            this.Minusculas.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Minusculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minusculas.ForeColor = System.Drawing.Color.Red;
            this.Minusculas.Location = new System.Drawing.Point(38, 297);
            this.Minusculas.Name = "Minusculas";
            this.Minusculas.Size = new System.Drawing.Size(94, 35);
            this.Minusculas.TabIndex = 9;
            this.Minusculas.Text = "MINUSCULAS";
            this.Minusculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Minusculas.UseVisualStyleBackColor = false;
            this.Minusculas.Click += new System.EventHandler(this.Minusculas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(22, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 302);
            this.panel1.TabIndex = 10;
            // 
            // Iniciais
            // 
            this.Iniciais.BackColor = System.Drawing.Color.Transparent;
            this.Iniciais.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Iniciais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Iniciais.ForeColor = System.Drawing.Color.Red;
            this.Iniciais.Location = new System.Drawing.Point(38, 405);
            this.Iniciais.Name = "Iniciais";
            this.Iniciais.Size = new System.Drawing.Size(94, 35);
            this.Iniciais.TabIndex = 11;
            this.Iniciais.Text = "INICIAIS";
            this.Iniciais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Iniciais.UseVisualStyleBackColor = false;
            this.Iniciais.Click += new System.EventHandler(this.Iniciais_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 465);
            this.Controls.Add(this.Iniciais);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Minusculas);
            this.Controls.Add(this.Maiusculas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.abrir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button abrir;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Maiusculas;
        private System.Windows.Forms.Button Minusculas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Iniciais;
    }
}

