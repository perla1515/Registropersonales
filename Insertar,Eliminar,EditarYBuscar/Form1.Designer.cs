namespace Registropersonales
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
            this.ValidarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreTxtBox = new System.Windows.Forms.TextBox();
            this.ApellidoTxtBox = new System.Windows.Forms.TextBox();
            this.CedulaTxtBox = new System.Windows.Forms.TextBox();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.ImprimirBtn = new System.Windows.Forms.Button();
            this.ModificarBtn = new System.Windows.Forms.Button();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EdadTxtBox = new System.Windows.Forms.TextBox();
            this.SexoTxtBox = new System.Windows.Forms.TextBox();
            this.EmpleadoDataGridView = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.RecuperarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ValidarBtn
            // 
            this.ValidarBtn.BackColor = System.Drawing.Color.Cyan;
            this.ValidarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ValidarBtn.Location = new System.Drawing.Point(158, 485);
            this.ValidarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ValidarBtn.Name = "ValidarBtn";
            this.ValidarBtn.Size = new System.Drawing.Size(234, 54);
            this.ValidarBtn.TabIndex = 0;
            this.ValidarBtn.Text = "Validar";
            this.ValidarBtn.UseVisualStyleBackColor = false;
            this.ValidarBtn.Click += new System.EventHandler(this.ValidarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(34, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 344);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cedula";
            // 
            // NombreTxtBox
            // 
            this.NombreTxtBox.BackColor = System.Drawing.Color.MistyRose;
            this.NombreTxtBox.Location = new System.Drawing.Point(160, 60);
            this.NombreTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.NombreTxtBox.Multiline = true;
            this.NombreTxtBox.Name = "NombreTxtBox";
            this.NombreTxtBox.Size = new System.Drawing.Size(232, 44);
            this.NombreTxtBox.TabIndex = 6;
            this.NombreTxtBox.TextChanged += new System.EventHandler(this.NombreTxtBox_TextChanged);
            // 
            // ApellidoTxtBox
            // 
            this.ApellidoTxtBox.BackColor = System.Drawing.Color.MistyRose;
            this.ApellidoTxtBox.Location = new System.Drawing.Point(158, 156);
            this.ApellidoTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.ApellidoTxtBox.Multiline = true;
            this.ApellidoTxtBox.Name = "ApellidoTxtBox";
            this.ApellidoTxtBox.Size = new System.Drawing.Size(232, 42);
            this.ApellidoTxtBox.TabIndex = 7;
            // 
            // CedulaTxtBox
            // 
            this.CedulaTxtBox.BackColor = System.Drawing.Color.MistyRose;
            this.CedulaTxtBox.Location = new System.Drawing.Point(160, 248);
            this.CedulaTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.CedulaTxtBox.Multiline = true;
            this.CedulaTxtBox.Name = "CedulaTxtBox";
            this.CedulaTxtBox.Size = new System.Drawing.Size(232, 48);
            this.CedulaTxtBox.TabIndex = 8;
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.BackColor = System.Drawing.Color.Cyan;
            this.AgregarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AgregarBtn.Location = new System.Drawing.Point(404, 485);
            this.AgregarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(247, 54);
            this.AgregarBtn.TabIndex = 11;
            this.AgregarBtn.Text = "Insertar";
            this.AgregarBtn.UseVisualStyleBackColor = false;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // ImprimirBtn
            // 
            this.ImprimirBtn.BackColor = System.Drawing.Color.Cyan;
            this.ImprimirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimirBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ImprimirBtn.Location = new System.Drawing.Point(1563, 485);
            this.ImprimirBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ImprimirBtn.Name = "ImprimirBtn";
            this.ImprimirBtn.Size = new System.Drawing.Size(247, 54);
            this.ImprimirBtn.TabIndex = 12;
            this.ImprimirBtn.Text = "Imprimir";
            this.ImprimirBtn.UseVisualStyleBackColor = false;
            this.ImprimirBtn.Click += new System.EventHandler(this.ImprimirBtn_Click);
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.BackColor = System.Drawing.Color.Cyan;
            this.ModificarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModificarBtn.Location = new System.Drawing.Point(688, 485);
            this.ModificarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Size = new System.Drawing.Size(247, 54);
            this.ModificarBtn.TabIndex = 13;
            this.ModificarBtn.Text = "Modificar";
            this.ModificarBtn.UseVisualStyleBackColor = false;
            this.ModificarBtn.Click += new System.EventHandler(this.ModificarBtn_Click);
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.BackColor = System.Drawing.Color.Cyan;
            this.EliminarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EliminarBtn.Location = new System.Drawing.Point(973, 485);
            this.EliminarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(247, 54);
            this.EliminarBtn.TabIndex = 14;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = false;
            this.EliminarBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 433);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sexo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // EdadTxtBox
            // 
            this.EdadTxtBox.BackColor = System.Drawing.Color.MistyRose;
            this.EdadTxtBox.Location = new System.Drawing.Point(160, 335);
            this.EdadTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.EdadTxtBox.Multiline = true;
            this.EdadTxtBox.Name = "EdadTxtBox";
            this.EdadTxtBox.Size = new System.Drawing.Size(232, 48);
            this.EdadTxtBox.TabIndex = 18;
            // 
            // SexoTxtBox
            // 
            this.SexoTxtBox.BackColor = System.Drawing.Color.MistyRose;
            this.SexoTxtBox.Location = new System.Drawing.Point(160, 423);
            this.SexoTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.SexoTxtBox.Multiline = true;
            this.SexoTxtBox.Name = "SexoTxtBox";
            this.SexoTxtBox.Size = new System.Drawing.Size(232, 48);
            this.SexoTxtBox.TabIndex = 19;
            // 
            // EmpleadoDataGridView
            // 
            this.EmpleadoDataGridView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.EmpleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpleadoDataGridView.Location = new System.Drawing.Point(404, 60);
            this.EmpleadoDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.EmpleadoDataGridView.Name = "EmpleadoDataGridView";
            this.EmpleadoDataGridView.RowHeadersWidth = 82;
            this.EmpleadoDataGridView.Size = new System.Drawing.Size(1406, 415);
            this.EmpleadoDataGridView.TabIndex = 21;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // RecuperarBtn
            // 
            this.RecuperarBtn.BackColor = System.Drawing.Color.Cyan;
            this.RecuperarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecuperarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RecuperarBtn.Location = new System.Drawing.Point(1269, 485);
            this.RecuperarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RecuperarBtn.Name = "RecuperarBtn";
            this.RecuperarBtn.Size = new System.Drawing.Size(247, 54);
            this.RecuperarBtn.TabIndex = 22;
            this.RecuperarBtn.Text = "Recuperar";
            this.RecuperarBtn.UseVisualStyleBackColor = false;
            this.RecuperarBtn.Click += new System.EventHandler(this.RecuperarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1864, 610);
            this.Controls.Add(this.RecuperarBtn);
            this.Controls.Add(this.EmpleadoDataGridView);
            this.Controls.Add(this.SexoTxtBox);
            this.Controls.Add(this.EdadTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.ModificarBtn);
            this.Controls.Add(this.ImprimirBtn);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.CedulaTxtBox);
            this.Controls.Add(this.ApellidoTxtBox);
            this.Controls.Add(this.NombreTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValidarBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ValidarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreTxtBox;
        private System.Windows.Forms.TextBox ApellidoTxtBox;
        private System.Windows.Forms.TextBox CedulaTxtBox;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.Button ImprimirBtn;
        private System.Windows.Forms.Button ModificarBtn;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EdadTxtBox;
        private System.Windows.Forms.TextBox SexoTxtBox;
        private System.Windows.Forms.DataGridView EmpleadoDataGridView;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button RecuperarBtn;
    }
}

