namespace PracticaFinalPunto1
{
    partial class lstPedidos
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cmbPlato = new System.Windows.Forms.ComboBox();
            this.gbBebida = new System.Windows.Forms.GroupBox();
            this.rbGaseosa = new System.Windows.Forms.RadioButton();
            this.rbJugo = new System.Windows.Forms.RadioButton();
            this.rbCerveza = new System.Windows.Forms.RadioButton();
            this.chkPropina = new System.Windows.Forms.CheckBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.listPedidos = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.gbBebida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(588, 128);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(156, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular total";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cmbPlato
            // 
            this.cmbPlato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlato.FormattingEnabled = true;
            this.cmbPlato.Location = new System.Drawing.Point(75, 158);
            this.cmbPlato.Name = "cmbPlato";
            this.cmbPlato.Size = new System.Drawing.Size(159, 21);
            this.cmbPlato.TabIndex = 2;
            this.cmbPlato.SelectedIndexChanged += new System.EventHandler(this.cmbPlato_SelectedIndexChanged);
            // 
            // gbBebida
            // 
            this.gbBebida.Controls.Add(this.rbGaseosa);
            this.gbBebida.Controls.Add(this.rbJugo);
            this.gbBebida.Controls.Add(this.rbCerveza);
            this.gbBebida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbBebida.Location = new System.Drawing.Point(75, 200);
            this.gbBebida.Name = "gbBebida";
            this.gbBebida.Size = new System.Drawing.Size(200, 100);
            this.gbBebida.TabIndex = 3;
            this.gbBebida.TabStop = false;
            this.gbBebida.Text = "Seleccione la bebida";
            this.gbBebida.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // rbGaseosa
            // 
            this.rbGaseosa.AutoSize = true;
            this.rbGaseosa.Location = new System.Drawing.Point(6, 65);
            this.rbGaseosa.Name = "rbGaseosa";
            this.rbGaseosa.Size = new System.Drawing.Size(106, 17);
            this.rbGaseosa.TabIndex = 6;
            this.rbGaseosa.TabStop = true;
            this.rbGaseosa.Text = "Gaseosa ($2000)";
            this.rbGaseosa.UseVisualStyleBackColor = true;
            // 
            // rbJugo
            // 
            this.rbJugo.AutoSize = true;
            this.rbJugo.Location = new System.Drawing.Point(6, 42);
            this.rbJugo.Name = "rbJugo";
            this.rbJugo.Size = new System.Drawing.Size(87, 17);
            this.rbJugo.TabIndex = 5;
            this.rbJugo.TabStop = true;
            this.rbJugo.Text = "Jugo ($3000)";
            this.rbJugo.UseVisualStyleBackColor = true;
            // 
            // rbCerveza
            // 
            this.rbCerveza.AutoSize = true;
            this.rbCerveza.Location = new System.Drawing.Point(6, 19);
            this.rbCerveza.Name = "rbCerveza";
            this.rbCerveza.Size = new System.Drawing.Size(103, 17);
            this.rbCerveza.TabIndex = 4;
            this.rbCerveza.TabStop = true;
            this.rbCerveza.Text = "Cerveza ($5000)";
            this.rbCerveza.UseVisualStyleBackColor = true;
            // 
            // chkPropina
            // 
            this.chkPropina.AutoSize = true;
            this.chkPropina.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkPropina.Location = new System.Drawing.Point(81, 315);
            this.chkPropina.Name = "chkPropina";
            this.chkPropina.Size = new System.Drawing.Size(166, 17);
            this.chkPropina.TabIndex = 4;
            this.chkPropina.Text = "¿Desea incluir propina? (10%)";
            this.chkPropina.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(588, 205);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(156, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(588, 165);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(156, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar pedido";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(588, 239);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(156, 23);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar pedidos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // listPedidos
            // 
            this.listPedidos.FormattingEnabled = true;
            this.listPedidos.Location = new System.Drawing.Point(588, 299);
            this.listPedidos.Name = "listPedidos";
            this.listPedidos.Size = new System.Drawing.Size(156, 212);
            this.listPedidos.TabIndex = 9;
            this.listPedidos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotal.Location = new System.Drawing.Point(77, 406);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(20, 24);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "$";
            this.lblTotal.Click += new System.EventHandler(this.txtTotal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(77, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total a pagar ($):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(217, 27);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(393, 55);
            this.label2.TabIndex = 11;
            this.label2.Text = "RESTAURANTE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(70, 119);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "SELECCIONE";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::PracticaFinalPunto1.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(290, 158);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(270, 238);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 13;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lstPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(52)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(812, 544);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPedidos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chkPropina);
            this.Controls.Add(this.gbBebida);
            this.Controls.Add(this.cmbPlato);
            this.Controls.Add(this.btnCalcular);
            this.Name = "lstPedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbBebida.ResumeLayout(false);
            this.gbBebida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cmbPlato;
        private System.Windows.Forms.GroupBox gbBebida;
        private System.Windows.Forms.RadioButton rbCerveza;
        private System.Windows.Forms.RadioButton rbGaseosa;
        private System.Windows.Forms.RadioButton rbJugo;
        private System.Windows.Forms.CheckBox chkPropina;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListBox listPedidos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

