
namespace WindowsFormsApp1
{
    partial class FormAgregarTipoEntidades
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CkbNo = new System.Windows.Forms.CheckBox();
            this.CkbYes = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbGrupo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 107);
            this.panel1.TabIndex = 7;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(104, 146);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.TxtDescripcion.TabIndex = 32;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.Location = new System.Drawing.Point(16, 148);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(92, 15);
            this.lbDescripcion.TabIndex = 31;
            this.lbDescripcion.Text = "Descripcion: ";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(104, 175);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(100, 20);
            this.txtComentario.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Comentario: ";
            // 
            // CmbStatus
            // 
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Items.AddRange(new object[] {
            "Activa",
            "Inactiva"});
            this.CmbStatus.Location = new System.Drawing.Point(70, 207);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(100, 21);
            this.CmbStatus.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Status:";
            // 
            // CkbNo
            // 
            this.CkbNo.AutoSize = true;
            this.CkbNo.Location = new System.Drawing.Point(157, 298);
            this.CkbNo.Name = "CkbNo";
            this.CkbNo.Size = new System.Drawing.Size(40, 17);
            this.CkbNo.TabIndex = 44;
            this.CkbNo.Text = "No";
            this.CkbNo.UseVisualStyleBackColor = true;
            this.CkbNo.CheckedChanged += new System.EventHandler(this.CkbNo_CheckedChanged);
            // 
            // CkbYes
            // 
            this.CkbYes.AutoSize = true;
            this.CkbYes.Location = new System.Drawing.Point(106, 298);
            this.CkbYes.Name = "CkbYes";
            this.CkbYes.Size = new System.Drawing.Size(35, 17);
            this.CkbYes.TabIndex = 43;
            this.CkbYes.Text = "Si";
            this.CkbYes.UseVisualStyleBackColor = true;
            this.CkbYes.CheckedChanged += new System.EventHandler(this.CkbYes_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 15);
            this.label10.TabIndex = 42;
            this.label10.Text = "Eliminable:";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(292, 188);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(200, 20);
            this.DtpFecha.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(290, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 15);
            this.label11.TabIndex = 45;
            this.label11.Text = "Fecha: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Grupo:";
            // 
            // CmbGrupo
            // 
            this.CmbGrupo.FormattingEnabled = true;
            this.CmbGrupo.Location = new System.Drawing.Point(76, 250);
            this.CmbGrupo.Name = "CmbGrupo";
            this.CmbGrupo.Size = new System.Drawing.Size(121, 21);
            this.CmbGrupo.TabIndex = 50;
            // 
            // FormAgregarTipoEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 379);
            this.Controls.Add(this.CmbGrupo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CkbNo);
            this.Controls.Add(this.CkbYes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CmbStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAgregarTipoEntidades";
            this.Text = "FormAgregarTipoEntidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox CkbNo;
        private System.Windows.Forms.CheckBox CkbYes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbGrupo;
    }
}