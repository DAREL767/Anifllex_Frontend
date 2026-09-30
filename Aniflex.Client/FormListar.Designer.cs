namespace Aniflex.Client
{
    partial class FormListar
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
            dgvPeliculas = new DataGridView();
            btnCargar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            SuspendLayout();
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliculas.Location = new Point(22, 43);
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.RowHeadersWidth = 62;
            dgvPeliculas.Size = new Size(754, 341);
            dgvPeliculas.TabIndex = 0;
            // 
            // btnCargar
            // 
            btnCargar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargar.Location = new Point(299, 393);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(193, 45);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar Películas";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += FormListar_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(268, 9);
            label1.Name = "label1";
            label1.Size = new Size(242, 26);
            label1.TabIndex = 2;
            label1.Text = "PELICULAS DISPONIBLES";
            // 
            // FormListar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnCargar);
            Controls.Add(dgvPeliculas);
            Name = "FormListar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormListar";
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPeliculas;
        private Button btnCargar;
        private Label label1;
    }
}