namespace PracticaFinalPunto3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstOrigen = new System.Windows.Forms.ListBox();
            this.lstDestino = new System.Windows.Forms.ListBox();
            this.btnPasarUno = new System.Windows.Forms.Button();
            this.btnPasarTodos = new System.Windows.Forms.Button();
            this.btnRegresarUno = new System.Windows.Forms.Button();
            this.btnRegresarTodo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstOrigen
            // 
            this.lstOrigen.FormattingEnabled = true;
            this.lstOrigen.Location = new System.Drawing.Point(144, 138);
            this.lstOrigen.Name = "lstOrigen";
            this.lstOrigen.Size = new System.Drawing.Size(153, 251);
            this.lstOrigen.TabIndex = 0;
            // 
            // lstDestino
            // 
            this.lstDestino.FormattingEnabled = true;
            this.lstDestino.Location = new System.Drawing.Point(467, 138);
            this.lstDestino.Name = "lstDestino";
            this.lstDestino.Size = new System.Drawing.Size(153, 251);
            this.lstDestino.TabIndex = 1;
            // 
            // btnPasarUno
            // 
            this.btnPasarUno.Location = new System.Drawing.Point(344, 184);
            this.btnPasarUno.Name = "btnPasarUno";
            this.btnPasarUno.Size = new System.Drawing.Size(75, 23);
            this.btnPasarUno.TabIndex = 2;
            this.btnPasarUno.Text = ">";
            this.btnPasarUno.UseVisualStyleBackColor = true;
            this.btnPasarUno.Click += new System.EventHandler(this.btnPasarUno_Click);
            // 
            // btnPasarTodos
            // 
            this.btnPasarTodos.Location = new System.Drawing.Point(344, 213);
            this.btnPasarTodos.Name = "btnPasarTodos";
            this.btnPasarTodos.Size = new System.Drawing.Size(75, 23);
            this.btnPasarTodos.TabIndex = 3;
            this.btnPasarTodos.Text = ">=";
            this.btnPasarTodos.UseVisualStyleBackColor = true;
            this.btnPasarTodos.Click += new System.EventHandler(this.btnPasarTodos_Click);
            // 
            // btnRegresarUno
            // 
            this.btnRegresarUno.Location = new System.Drawing.Point(344, 242);
            this.btnRegresarUno.Name = "btnRegresarUno";
            this.btnRegresarUno.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarUno.TabIndex = 5;
            this.btnRegresarUno.Text = "<";
            this.btnRegresarUno.UseVisualStyleBackColor = true;
            this.btnRegresarUno.Click += new System.EventHandler(this.btnRegresarUno_Click);
            // 
            // btnRegresarTodo
            // 
            this.btnRegresarTodo.Location = new System.Drawing.Point(344, 271);
            this.btnRegresarTodo.Name = "btnRegresarTodo";
            this.btnRegresarTodo.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarTodo.TabIndex = 6;
            this.btnRegresarTodo.Text = "<=";
            this.btnRegresarTodo.UseVisualStyleBackColor = true;
            this.btnRegresarTodo.Click += new System.EventHandler(this.btnRegresarTodo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "BOTONES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hecho por: Lady Johana Torres Rios  - 2025";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PracticaFinalPunto3.Properties.Resources._74d4d07c_d1be_46ef_b265_7a3f5736fab2;
            this.pictureBox1.Location = new System.Drawing.Point(292, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(137)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(766, 507);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresarTodo);
            this.Controls.Add(this.btnRegresarUno);
            this.Controls.Add(this.btnPasarTodos);
            this.Controls.Add(this.btnPasarUno);
            this.Controls.Add(this.lstDestino);
            this.Controls.Add(this.lstOrigen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOrigen;
        private System.Windows.Forms.ListBox lstDestino;
        private System.Windows.Forms.Button btnPasarUno;
        private System.Windows.Forms.Button btnPasarTodos;
        private System.Windows.Forms.Button btnRegresarUno;
        private System.Windows.Forms.Button btnRegresarTodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

