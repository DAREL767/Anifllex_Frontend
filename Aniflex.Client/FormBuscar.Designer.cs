namespace Aniflex.Client
{
    partial class FormBuscar
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
            txtIdBuscar = new Label();
            label1 = new Label();
            txtId = new TextBox();
            btnBuscar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chkEsSaga = new CheckBox();
            txtTitulo = new TextBox();
            txtDuracion = new TextBox();
            txtRecaudacion = new TextBox();
            SuspendLayout();
            // 
            // txtIdBuscar
            // 
            txtIdBuscar.AutoSize = true;
            txtIdBuscar.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdBuscar.Location = new Point(35, 101);
            txtIdBuscar.Name = "txtIdBuscar";
            txtIdBuscar.Size = new Size(154, 24);
            txtIdBuscar.TabIndex = 0;
            txtIdBuscar.Text = "Id a Buscar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 21);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 1;
            label1.Text = "BUSQUEDA";
            // 
            // txtId
            // 
            txtId.Location = new Point(195, 91);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(276, 34);
            txtId.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(539, 89);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(156, 44);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 164);
            label2.Name = "label2";
            label2.Size = new Size(94, 24);
            label2.TabIndex = 4;
            label2.Text = "Titulo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 228);
            label3.Name = "label3";
            label3.Size = new Size(190, 24);
            label3.TabIndex = 5;
            label3.Text = "Duración (min):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 300);
            label4.Name = "label4";
            label4.Size = new Size(202, 24);
            label4.TabIndex = 6;
            label4.Text = "Recaudación ($):";
            // 
            // chkEsSaga
            // 
            chkEsSaga.AutoSize = true;
            chkEsSaga.Enabled = false;
            chkEsSaga.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEsSaga.Location = new Point(35, 361);
            chkEsSaga.Name = "chkEsSaga";
            chkEsSaga.Size = new Size(144, 28);
            chkEsSaga.TabIndex = 7;
            chkEsSaga.Text = "¿Es Saga?";
            chkEsSaga.UseVisualStyleBackColor = true;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(135, 157);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(336, 31);
            txtTitulo.TabIndex = 8;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(231, 221);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.ReadOnly = true;
            txtDuracion.Size = new Size(240, 31);
            txtDuracion.TabIndex = 9;
            // 
            // txtRecaudacion
            // 
            txtRecaudacion.Location = new Point(243, 293);
            txtRecaudacion.Name = "txtRecaudacion";
            txtRecaudacion.ReadOnly = true;
            txtRecaudacion.Size = new Size(228, 31);
            txtRecaudacion.TabIndex = 10;
            // 
            // FormBuscar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRecaudacion);
            Controls.Add(txtDuracion);
            Controls.Add(txtTitulo);
            Controls.Add(chkEsSaga);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(txtIdBuscar);
            Name = "FormBuscar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBuscar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtIdBuscar;
        private Label label1;
        private TextBox txtId;
        private Button btnBuscar;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox chkEsSaga;
        private TextBox txtTitulo;
        private TextBox txtDuracion;
        private TextBox txtRecaudacion;
    }
}