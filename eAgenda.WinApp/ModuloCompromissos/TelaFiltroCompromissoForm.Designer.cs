namespace eAgenda.WinApp.ModuloCompromissos
{
    partial class TelaFiltroCompromissoForm
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
            btnGravar = new Button();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            txtTerminoPeriodo = new DateTimePicker();
            label2 = new Label();
            txtInicioPeriodo = new DateTimePicker();
            label1 = new Label();
            rdbCompromissosPeriodo = new RadioButton();
            rdbCompromissosFuturos = new RadioButton();
            rdbCompromissosPassados = new RadioButton();
            rdbTodosCompromissos = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(226, 264);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 37);
            btnGravar.TabIndex = 9;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(332, 264);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 37);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTerminoPeriodo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtInicioPeriodo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rdbCompromissosPeriodo);
            groupBox1.Controls.Add(rdbCompromissosFuturos);
            groupBox1.Controls.Add(rdbCompromissosPassados);
            groupBox1.Controls.Add(rdbTodosCompromissos);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 246);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecione um Filtro:";
            // 
            // txtTerminoPeriodo
            // 
            txtTerminoPeriodo.Enabled = false;
            txtTerminoPeriodo.Format = DateTimePickerFormat.Short;
            txtTerminoPeriodo.Location = new Point(270, 153);
            txtTerminoPeriodo.Name = "txtTerminoPeriodo";
            txtTerminoPeriodo.Size = new Size(116, 27);
            txtTerminoPeriodo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 156);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Termino:";
            // 
            // txtInicioPeriodo
            // 
            txtInicioPeriodo.Enabled = false;
            txtInicioPeriodo.Format = DateTimePickerFormat.Short;
            txtInicioPeriodo.Location = new Point(76, 153);
            txtInicioPeriodo.Name = "txtInicioPeriodo";
            txtInicioPeriodo.Size = new Size(116, 27);
            txtInicioPeriodo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 156);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 2;
            label1.Text = "Início:";
            // 
            // rdbCompromissosPeriodo
            // 
            rdbCompromissosPeriodo.AutoSize = true;
            rdbCompromissosPeriodo.Location = new Point(25, 125);
            rdbCompromissosPeriodo.Name = "rdbCompromissosPeriodo";
            rdbCompromissosPeriodo.Size = new Size(232, 24);
            rdbCompromissosPeriodo.TabIndex = 1;
            rdbCompromissosPeriodo.TabStop = true;
            rdbCompromissosPeriodo.Text = "Compromissos em um periodo";
            rdbCompromissosPeriodo.UseVisualStyleBackColor = true;
            rdbCompromissosPeriodo.CheckedChanged += rdbCompromissosPeriodo_CheckedChanged;
            // 
            // rdbCompromissosFuturos
            // 
            rdbCompromissosFuturos.AutoSize = true;
            rdbCompromissosFuturos.Location = new Point(25, 95);
            rdbCompromissosFuturos.Name = "rdbCompromissosFuturos";
            rdbCompromissosFuturos.Size = new Size(177, 24);
            rdbCompromissosFuturos.TabIndex = 0;
            rdbCompromissosFuturos.Text = "Compromissos Futuros";
            rdbCompromissosFuturos.UseVisualStyleBackColor = true;
            // 
            // rdbCompromissosPassados
            // 
            rdbCompromissosPassados.AutoSize = true;
            rdbCompromissosPassados.Location = new Point(25, 65);
            rdbCompromissosPassados.Name = "rdbCompromissosPassados";
            rdbCompromissosPassados.Size = new Size(188, 24);
            rdbCompromissosPassados.TabIndex = 0;
            rdbCompromissosPassados.Text = "Compromissos Passados";
            rdbCompromissosPassados.UseVisualStyleBackColor = true;
            // 
            // rdbTodosCompromissos
            // 
            rdbTodosCompromissos.AutoSize = true;
            rdbTodosCompromissos.Checked = true;
            rdbTodosCompromissos.Location = new Point(25, 35);
            rdbTodosCompromissos.Name = "rdbTodosCompromissos";
            rdbTodosCompromissos.Size = new Size(188, 24);
            rdbTodosCompromissos.TabIndex = 0;
            rdbTodosCompromissos.TabStop = true;
            rdbTodosCompromissos.Text = "Todos os Compromissos";
            rdbTodosCompromissos.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 313);
            Controls.Add(groupBox1);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroCompromissoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Filtro de Registros";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private RadioButton rdbCompromissosFuturos;
        private RadioButton rdbCompromissosPassados;
        private RadioButton rdbTodosCompromissos;
        private RadioButton rdbCompromissosPeriodo;
        private DateTimePicker txtTerminoPeriodo;
        private Label label2;
        private DateTimePicker txtInicioPeriodo;
        private Label label1;
    }
}