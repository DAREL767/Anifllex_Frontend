namespace Aniflex.Client
{
    partial class FormActualizar
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
            txtRecaudacion = new TextBox();
            txtDuracion = new TextBox();
            txtTitulo = new TextBox();
            chkEsSaga = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnBuscar = new Button();
            txtId = new TextBox();
            label1 = new Label();
            txtIdBuscar = new Label();
            btnActualizar = new Button();
            label5 = new Label();
            dtpFechaEstreno = new DateTimePicker();
            SuspendLayout();
            // 
            // txtRecaudacion
            // 
            txtRecaudacion.Location = new Point(278, 313);
            txtRecaudacion.Name = "txtRecaudacion";
            txtRecaudacion.Size = new Size(228, 31);
            txtRecaudacion.TabIndex = 21;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(266, 241);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(240, 31);
            txtDuracion.TabIndex = 20;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(170, 177);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(336, 31);
            txtTitulo.TabIndex = 19;
            // 
            // chkEsSaga
            // 
            chkEsSaga.AutoSize = true;
            chkEsSaga.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEsSaga.Location = new Point(70, 381);
            chkEsSaga.Name = "chkEsSaga";
            chkEsSaga.Size = new Size(144, 28);
            chkEsSaga.TabIndex = 18;
            chkEsSaga.Text = "¿Es Saga?";
            chkEsSaga.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(70, 320);
            label4.Name = "label4";
            label4.Size = new Size(202, 24);
            label4.TabIndex = 17;
            label4.Text = "Recaudación ($):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 248);
            label3.Name = "label3";
            label3.Size = new Size(190, 24);
            label3.TabIndex = 16;
            label3.Text = "Duración (min):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 184);
            label2.Name = "label2";
            label2.Size = new Size(94, 24);
            label2.TabIndex = 15;
            label2.Text = "Titulo:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(574, 154);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(156, 44);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(230, 111);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(276, 34);
            txtId.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 20);
            label1.Name = "label1";
            label1.Size = new Size(286, 28);
            label1.TabIndex = 12;
            label1.Text = "ACTUALIZACIÓN DE DATOS";
            // 
            // txtIdBuscar
            // 
            txtIdBuscar.AutoSize = true;
            txtIdBuscar.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdBuscar.Location = new Point(70, 121);
            txtIdBuscar.Name = "txtIdBuscar";
            txtIdBuscar.Size = new Size(154, 24);
            txtIdBuscar.TabIndex = 11;
            txtIdBuscar.Text = "Id a Cargar:";
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(574, 238);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(156, 42);
            btnActualizar.TabIndex = 22;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(70, 445);
            label5.Name = "label5";
            label5.Size = new Size(214, 24);
            label5.TabIndex = 26;
            label5.Text = "Fecha de Estreno:";
            // 
            // dtpFechaEstreno
            // 
            dtpFechaEstreno.Location = new Point(290, 439);
            dtpFechaEstreno.Name = "dtpFechaEstreno";
            dtpFechaEstreno.Size = new Size(222, 31);
            dtpFechaEstreno.TabIndex = 25;
            // 
            // FormActualizar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 537);
            Controls.Add(label5);
            Controls.Add(dtpFechaEstreno);
            Controls.Add(btnActualizar);
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
            Name = "FormActualizar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormActualizar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRecaudacion;
        private TextBox txtDuracion;
        private TextBox txtTitulo;
        private CheckBox chkEsSaga;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnBuscar;
        private TextBox txtId;
        private Label label1;
        private Label txtIdBuscar;
        private Button btnActualizar;
        private Label label5;
        private DateTimePicker dtpFechaEstreno;
    }
}