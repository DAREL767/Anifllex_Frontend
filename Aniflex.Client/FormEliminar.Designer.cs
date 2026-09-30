namespace Aniflex.Client
{
    partial class FormEliminar
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
            btnEliminar = new Button();
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
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(574, 249);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(156, 42);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtRecaudacion
            // 
            txtRecaudacion.Location = new Point(278, 324);
            txtRecaudacion.Name = "txtRecaudacion";
            txtRecaudacion.Size = new Size(228, 31);
            txtRecaudacion.TabIndex = 33;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(266, 252);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(240, 31);
            txtDuracion.TabIndex = 32;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(170, 188);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(336, 31);
            txtTitulo.TabIndex = 31;
            // 
            // chkEsSaga
            // 
            chkEsSaga.AutoSize = true;
            chkEsSaga.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEsSaga.Location = new Point(70, 392);
            chkEsSaga.Name = "chkEsSaga";
            chkEsSaga.Size = new Size(144, 28);
            chkEsSaga.TabIndex = 30;
            chkEsSaga.Text = "¿Es Saga?";
            chkEsSaga.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(70, 331);
            label4.Name = "label4";
            label4.Size = new Size(202, 24);
            label4.TabIndex = 29;
            label4.Text = "Recaudación ($):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 259);
            label3.Name = "label3";
            label3.Size = new Size(190, 24);
            label3.TabIndex = 28;
            label3.Text = "Duración (min):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 195);
            label2.Name = "label2";
            label2.Size = new Size(94, 24);
            label2.TabIndex = 27;
            label2.Text = "Titulo:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(574, 165);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(156, 44);
            btnBuscar.TabIndex = 26;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(230, 122);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(276, 34);
            txtId.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 31);
            label1.Name = "label1";
            label1.Size = new Size(240, 28);
            label1.TabIndex = 24;
            label1.Text = "ELIMINAR CONTENIDO";
            // 
            // txtIdBuscar
            // 
            txtIdBuscar.AutoSize = true;
            txtIdBuscar.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdBuscar.Location = new Point(70, 132);
            txtIdBuscar.Name = "txtIdBuscar";
            txtIdBuscar.Size = new Size(154, 24);
            txtIdBuscar.TabIndex = 23;
            txtIdBuscar.Text = "Id a Cargar:";
            // 
            // FormEliminar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
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
            Name = "FormEliminar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
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
    }
}