namespace eAgenda.WinApp.ModuloCompromissos
{
    partial class TelaCompromissoForm
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
            txtId = new TextBox();
            label2 = new Label();
            txtAssunto = new TextBox();
            label3 = new Label();
            txtData = new DateTimePicker();
            label4 = new Label();
            txtHoraInicio = new DateTimePicker();
            label5 = new Label();
            txtHoraTermino = new DateTimePicker();
            checkMarcarContato = new CheckBox();
            cmbContatos = new ComboBox();
            groupBox1 = new GroupBox();
            txtLocal = new TextBox();
            txtLink = new TextBox();
            rdbPresencial = new RadioButton();
            rdbRemoto = new RadioButton();
            btnGravar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(49, 31);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "Id: ";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F);
            txtId.Location = new Point(84, 28);
            txtId.Name = "txtId";
            txtId.Size = new Size(98, 27);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(10, 64);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 0;
            label2.Text = "Assunto: ";
            // 
            // txtAssunto
            // 
            txtAssunto.Font = new Font("Segoe UI", 11.25F);
            txtAssunto.Location = new Point(84, 61);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(339, 27);
            txtAssunto.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(30, 97);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 0;
            label3.Text = "Data: ";
            // 
            // txtData
            // 
            txtData.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(84, 94);
            txtData.Name = "txtData";
            txtData.Size = new Size(135, 27);
            txtData.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(26, 130);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 0;
            label4.Text = "Início: ";
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.CustomFormat = "HH:mm";
            txtHoraInicio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoraInicio.Format = DateTimePickerFormat.Custom;
            txtHoraInicio.Location = new Point(84, 127);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.ShowUpDown = true;
            txtHoraInicio.Size = new Size(112, 27);
            txtHoraInicio.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(244, 132);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 0;
            label5.Text = "Termino: ";
            // 
            // txtHoraTermino
            // 
            txtHoraTermino.CustomFormat = "HH:mm";
            txtHoraTermino.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoraTermino.Format = DateTimePickerFormat.Custom;
            txtHoraTermino.Location = new Point(320, 130);
            txtHoraTermino.Name = "txtHoraTermino";
            txtHoraTermino.ShowUpDown = true;
            txtHoraTermino.Size = new Size(103, 27);
            txtHoraTermino.TabIndex = 3;
            // 
            // checkMarcarContato
            // 
            checkMarcarContato.AutoSize = true;
            checkMarcarContato.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkMarcarContato.Location = new Point(84, 160);
            checkMarcarContato.Name = "checkMarcarContato";
            checkMarcarContato.Size = new Size(210, 24);
            checkMarcarContato.TabIndex = 3;
            checkMarcarContato.Text = "Deseja marcar um contato?";
            checkMarcarContato.UseVisualStyleBackColor = true;
            checkMarcarContato.CheckedChanged += checkMarcarContato_CheckedChanged;
            // 
            // cmbContatos
            // 
            cmbContatos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContatos.Enabled = false;
            cmbContatos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbContatos.FormattingEnabled = true;
            cmbContatos.Location = new Point(85, 190);
            cmbContatos.Name = "cmbContatos";
            cmbContatos.Size = new Size(189, 28);
            cmbContatos.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLocal);
            groupBox1.Controls.Add(txtLink);
            groupBox1.Controls.Add(rdbPresencial);
            groupBox1.Controls.Add(rdbRemoto);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(84, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 101);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Localização";
            // 
            // txtLocal
            // 
            txtLocal.Enabled = false;
            txtLocal.Location = new Point(118, 59);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(215, 27);
            txtLocal.TabIndex = 1;
            // 
            // txtLink
            // 
            txtLink.Location = new Point(118, 26);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(215, 27);
            txtLink.TabIndex = 1;
            // 
            // rdbPresencial
            // 
            rdbPresencial.AutoSize = true;
            rdbPresencial.Location = new Point(19, 60);
            rdbPresencial.Name = "rdbPresencial";
            rdbPresencial.Size = new Size(93, 24);
            rdbPresencial.TabIndex = 0;
            rdbPresencial.Text = "Presencial";
            rdbPresencial.UseVisualStyleBackColor = true;
            rdbPresencial.CheckedChanged += rdbPresencial_CheckedChanged;
            // 
            // rdbRemoto
            // 
            rdbRemoto.AutoSize = true;
            rdbRemoto.Checked = true;
            rdbRemoto.Location = new Point(19, 26);
            rdbRemoto.Name = "rdbRemoto";
            rdbRemoto.Size = new Size(80, 24);
            rdbRemoto.TabIndex = 0;
            rdbRemoto.TabStop = true;
            rdbRemoto.Text = "Remoto";
            rdbRemoto.UseVisualStyleBackColor = true;
            rdbRemoto.CheckedChanged += rdbRemoto_CheckedChanged;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(211, 345);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 37);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(317, 345);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 37);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 408);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(cmbContatos);
            Controls.Add(checkMarcarContato);
            Controls.Add(txtHoraTermino);
            Controls.Add(label5);
            Controls.Add(txtHoraInicio);
            Controls.Add(label4);
            Controls.Add(txtData);
            Controls.Add(label3);
            Controls.Add(txtAssunto);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCompromissoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Compromisso";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtAssunto;
        private Label label3;
        private DateTimePicker txtData;
        private Label label4;
        private DateTimePicker txtHoraInicio;
        private Label label5;
        private DateTimePicker txtHoraTermino;
        private CheckBox checkMarcarContato;
        private ComboBox cmbContatos;
        private GroupBox groupBox1;
        private TextBox txtLocal;
        private TextBox txtLink;
        private RadioButton rdbPresencial;
        private RadioButton rdbRemoto;
        private Button btnGravar;
        private Button btnCancelar;
    }
}