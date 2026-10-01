namespace Aniflex.Client
{
    partial class FormAgregar
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
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            label3 = new Label();
            txtTitulo = new TextBox();
            label4 = new Label();
            txtDuracion = new TextBox();
            label5 = new Label();
            txtRecaudacion = new TextBox();
            chkEsSaga = new CheckBox();
            btnGuardar = new Button();
            dtpFechaEstreno = new DateTimePicker();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(266, 9);
            label1.Name = "label1";
            label1.Size = new Size(217, 28);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR PELICULA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 91);
            label2.Name = "label2";
            label2.Size = new Size(46, 24);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(127, 85);
            txtId.Name = "txtId";
            txtId.Size = new Size(412, 30);
            txtId.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(75, 156);
            label3.Name = "label3";
            label3.Size = new Size(94, 24);
            label3.TabIndex = 3;
            label3.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(175, 149);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(364, 30);
            txtTitulo.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(75, 219);
            label4.Name = "label4";
            label4.Size = new Size(190, 24);
            label4.TabIndex = 5;
            label4.Text = "Duración (min):";
            // 
            // txtDuracion
            // 
            txtDuracion.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDuracion.Location = new Point(271, 212);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(268, 30);
            txtDuracion.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(75, 282);
            label5.Name = "label5";
            label5.Size = new Size(202, 24);
            label5.TabIndex = 7;
            label5.Text = "Recaudación ($):";
            // 
            // txtRecaudacion
            // 
            txtRecaudacion.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRecaudacion.Location = new Point(283, 275);
            txtRecaudacion.Name = "txtRecaudacion";
            txtRecaudacion.Size = new Size(256, 30);
            txtRecaudacion.TabIndex = 8;
            // 
            // chkEsSaga
            // 
            chkEsSaga.AutoSize = true;
            chkEsSaga.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEsSaga.Location = new Point(75, 336);
            chkEsSaga.Name = "chkEsSaga";
            chkEsSaga.Size = new Size(144, 28);
            chkEsSaga.TabIndex = 9;
            chkEsSaga.Text = "¿Es Saga?";
            chkEsSaga.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(293, 500);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(168, 37);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar Película";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dtpFechaEstreno
            // 
            dtpFechaEstreno.Location = new Point(295, 401);
            dtpFechaEstreno.Name = "dtpFechaEstreno";
            dtpFechaEstreno.Size = new Size(244, 31);
            dtpFechaEstreno.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(75, 408);
            label6.Name = "label6";
            label6.Size = new Size(214, 24);
            label6.TabIndex = 12;
            label6.Text = "Fecha de Estreno:";
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 549);
            Controls.Add(label6);
            Controls.Add(dtpFechaEstreno);
            Controls.Add(btnGuardar);
            Controls.Add(chkEsSaga);
            Controls.Add(txtRecaudacion);
            Controls.Add(label5);
            Controls.Add(txtDuracion);
            Controls.Add(label4);
            Controls.Add(txtTitulo);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAgregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAgregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtId;
        private Label label3;
        private TextBox txtTitulo;
        private Label label4;
        private TextBox txtDuracion;
        private Label label5;
        private TextBox txtRecaudacion;
        private CheckBox chkEsSaga;
        private Button btnGuardar;
        private DateTimePicker dtpFechaEstreno;
        private Label label6;
    }
}