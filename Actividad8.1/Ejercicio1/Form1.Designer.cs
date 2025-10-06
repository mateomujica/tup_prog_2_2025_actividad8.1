namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConfirmar = new Button();
            tbxNombre = new TextBox();
            tbxDni = new TextBox();
            tbxMonto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lsbDatos = new ListBox();
            btnActualizar = new Button();
            btnImportar = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnExportar = new Button();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(244, 71);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnProbar_Click;
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(125, 26);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(100, 23);
            tbxNombre.TabIndex = 1;
            // 
            // tbxDni
            // 
            tbxDni.Location = new Point(125, 70);
            tbxDni.Name = "tbxDni";
            tbxDni.Size = new Size(100, 23);
            tbxDni.TabIndex = 2;
            // 
            // tbxMonto
            // 
            tbxMonto.Location = new Point(125, 117);
            tbxMonto.Name = "tbxMonto";
            tbxMonto.Size = new Size(100, 23);
            tbxMonto.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 34);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 78);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 5;
            label2.Text = "Dni";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 117);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Monto";
            // 
            // lsbDatos
            // 
            lsbDatos.FormattingEnabled = true;
            lsbDatos.ItemHeight = 15;
            lsbDatos.Location = new Point(48, 167);
            lsbDatos.Name = "lsbDatos";
            lsbDatos.Size = new Size(235, 124);
            lsbDatos.TabIndex = 7;
            lsbDatos.SelectedValueChanged += lsbDatos_SelectedValueChanged;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(307, 167);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(307, 207);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(75, 23);
            btnImportar.TabIndex = 9;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(307, 249);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 23);
            btnExportar.TabIndex = 10;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExportar);
            Controls.Add(btnImportar);
            Controls.Add(btnActualizar);
            Controls.Add(lsbDatos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxMonto);
            Controls.Add(tbxDni);
            Controls.Add(tbxNombre);
            Controls.Add(btnConfirmar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private TextBox tbxNombre;
        private TextBox tbxDni;
        private TextBox tbxMonto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnActualizar;
        public ListBox lsbDatos;
        private Button btnImportar;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnExportar;
    }
}
