namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TelaAtualizacaoItemTarefa
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
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            labelTituloTarefa = new Label();
            listItensTarefa = new CheckedListBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Font = new Font("Segoe UI", 11.25F);
            button2.Location = new Point(204, 311);
            button2.Name = "button2";
            button2.Size = new Size(100, 37);
            button2.TabIndex = 11;
            button2.Text = "Gravar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnGravar_Click;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Font = new Font("Segoe UI", 11.25F);
            button1.Location = new Point(310, 311);
            button1.Name = "button1";
            button1.Size = new Size(100, 37);
            button1.TabIndex = 12;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 13;
            label1.Text = "Tarefa:";
            // 
            // labelTituloTarefa
            // 
            labelTituloTarefa.AutoSize = true;
            labelTituloTarefa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloTarefa.Location = new Point(70, 9);
            labelTituloTarefa.Name = "labelTituloTarefa";
            labelTituloTarefa.Size = new Size(110, 20);
            labelTituloTarefa.TabIndex = 14;
            labelTituloTarefa.Text = "[Título Tarefa]";
            // 
            // listItensTarefa
            // 
            listItensTarefa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listItensTarefa.FormattingEnabled = true;
            listItensTarefa.Location = new Point(12, 32);
            listItensTarefa.Name = "listItensTarefa";
            listItensTarefa.Size = new Size(398, 268);
            listItensTarefa.TabIndex = 15;
            // 
            // TelaAtualizacaoItemTarefa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 360);
            Controls.Add(listItensTarefa);
            Controls.Add(labelTituloTarefa);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "TelaAtualizacaoItemTarefa";
            Text = "TelaAtualizacaoItemTarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label1;
        private Label labelTituloTarefa;
        private CheckedListBox listItensTarefa;
    }
}