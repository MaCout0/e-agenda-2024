namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TelaCadastroItemTarefa
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
            labelTituloTarefa = new Label();
            label3 = new Label();
            txtTituloItem = new TextBox();
            btnAdicionar = new Button();
            listItensTarefa = new ListBox();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Tarefa:";
            // 
            // labelTituloTarefa
            // 
            labelTituloTarefa.AutoSize = true;
            labelTituloTarefa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloTarefa.Location = new Point(76, 9);
            labelTituloTarefa.Name = "labelTituloTarefa";
            labelTituloTarefa.Size = new Size(114, 20);
            labelTituloTarefa.TabIndex = 0;
            labelTituloTarefa.Text = "[Título Tarefa] ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(16, 44);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "Título:";
            // 
            // txtTituloItem
            // 
            txtTituloItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTituloItem.Location = new Point(76, 41);
            txtTituloItem.Name = "txtTituloItem";
            txtTituloItem.Size = new Size(112, 27);
            txtTituloItem.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(221, 41);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(106, 27);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // listItensTarefa
            // 
            listItensTarefa.FormattingEnabled = true;
            listItensTarefa.ItemHeight = 15;
            listItensTarefa.Location = new Point(18, 74);
            listItensTarefa.Name = "listItensTarefa";
            listItensTarefa.Size = new Size(309, 214);
            listItensTarefa.TabIndex = 3;
            // 
            // button4
            // 
            button4.DialogResult = DialogResult.OK;
            button4.Font = new Font("Segoe UI", 11.25F);
            button4.Location = new Point(121, 309);
            button4.Name = "button4";
            button4.Size = new Size(100, 37);
            button4.TabIndex = 9;
            button4.Text = "Gravar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.DialogResult = DialogResult.Cancel;
            button3.Font = new Font("Segoe UI", 11.25F);
            button3.Location = new Point(227, 309);
            button3.Name = "button3";
            button3.Size = new Size(100, 37);
            button3.TabIndex = 10;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Font = new Font("Segoe UI", 11.25F);
            button1.Location = new Point(227, 309);
            button1.Name = "button1";
            button1.Size = new Size(100, 37);
            button1.TabIndex = 10;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Font = new Font("Segoe UI", 11.25F);
            button2.Location = new Point(121, 309);
            button2.Name = "button2";
            button2.Size = new Size(100, 37);
            button2.TabIndex = 9;
            button2.Text = "Gravar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnGravar_Click;
            // 
            // TelaCadastroItemTarefa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 358);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(listItensTarefa);
            Controls.Add(btnAdicionar);
            Controls.Add(txtTituloItem);
            Controls.Add(label3);
            Controls.Add(labelTituloTarefa);
            Controls.Add(label1);
            Name = "TelaCadastroItemTarefa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaCadastroItemTarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelTituloTarefa;
        private Label label3;
        private TextBox txtTituloItem;
        private Button btnAdicionar;
        private ListBox listItensTarefa;
        private Button button4;
        private Button button3;
        private Button button1;
        private Button button2;
    }
}