namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TelaTarefaForm
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
            lblId = new Label();
            txtId = new TextBox();
            label1 = new Label();
            txtTitulo = new TextBox();
            label2 = new Label();
            cmbPrioridades = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 11.25F);
            lblId.Location = new Point(62, 15);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F);
            txtId.Location = new Point(93, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(37, 48);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 11.25F);
            txtTitulo.Location = new Point(93, 45);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(335, 27);
            txtTitulo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(37, 92);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "Título:";
            // 
            // cmbPrioridades
            // 
            cmbPrioridades.FormattingEnabled = true;
            cmbPrioridades.Location = new Point(93, 89);
            cmbPrioridades.Name = "cmbPrioridades";
            cmbPrioridades.Size = new Size(121, 23);
            cmbPrioridades.TabIndex = 9;
            // 
            // button3
            // 
            button3.DialogResult = DialogResult.Cancel;
            button3.Font = new Font("Segoe UI", 11.25F);
            button3.Location = new Point(328, 148);
            button3.Name = "button3";
            button3.Size = new Size(100, 37);
            button3.TabIndex = 8;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.DialogResult = DialogResult.OK;
            button4.Font = new Font("Segoe UI", 11.25F);
            button4.Location = new Point(222, 148);
            button4.Name = "button4";
            button4.Size = new Size(100, 37);
            button4.TabIndex = 7;
            button4.Text = "Gravar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnGravar_Click;
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 197);
            Controls.Add(cmbPrioridades);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "TelaTarefaForm";
            Text = "TelaTarefaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private Label label1;
        private TextBox txtTitulo;
        private Label label2;
        private ComboBox cmbPrioridades;
        private Button button3;
        private Button button4;
    }
}