
namespace WindowsFormsApp1
{
    partial class FormEditarElimnar_TiposEntidades
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CkbNo = new System.Windows.Forms.CheckBox();
            this.CkbYes = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(563, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CkbNo
            // 
            this.CkbNo.AutoSize = true;
            this.CkbNo.Location = new System.Drawing.Point(807, 192);
            this.CkbNo.Margin = new System.Windows.Forms.Padding(4);
            this.CkbNo.Name = "CkbNo";
            this.CkbNo.Size = new System.Drawing.Size(48, 21);
            this.CkbNo.TabIndex = 53;
            this.CkbNo.Text = "No";
            this.CkbNo.UseVisualStyleBackColor = true;
            this.CkbNo.CheckedChanged += new System.EventHandler(this.CkbNo_CheckedChanged);
            // 
            // CkbYes
            // 
            this.CkbYes.AutoSize = true;
            this.CkbYes.Location = new System.Drawing.Point(723, 192);
            this.CkbYes.Margin = new System.Windows.Forms.Padding(4);
            this.CkbYes.Name = "CkbYes";
            this.CkbYes.Size = new System.Drawing.Size(42, 21);
            this.CkbYes.TabIndex = 52;
            this.CkbYes.Text = "Si";
            this.CkbYes.UseVisualStyleBackColor = true;
            this.CkbYes.CheckedChanged += new System.EventHandler(this.CkbYes_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(605, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 18);
            this.label10.TabIndex = 51;
            this.label10.Text = "Eliminable:";
            // 
            // CmbStatus
            // 
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Location = new System.Drawing.Point(723, 149);
            this.CmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(132, 24);
            this.CmbStatus.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(605, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 49;
            this.label9.Text = "Status:";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(723, 108);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(4);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(132, 22);
            this.txtComentario.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(605, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 47;
            this.label1.Text = "Comentario: ";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(723, 72);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(132, 22);
            this.TxtDescripcion.TabIndex = 46;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.Location = new System.Drawing.Point(605, 75);
            this.lbDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(106, 18);
            this.lbDescripcion.TabIndex = 45;
            this.lbDescripcion.Text = "Descripcion: ";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(608, 263);
            this.DtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(265, 22);
            this.DtpFecha.TabIndex = 55;
            // 
            // FormEditarElimnar_TiposEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.CkbNo);
            this.Controls.Add(this.CkbYes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CmbStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormEditarElimnar_TiposEntidades";
            this.Text = "FormEditarElimnar_TiposEntidades";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox CkbNo;
        private System.Windows.Forms.CheckBox CkbYes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.DateTimePicker DtpFecha;
    }
}