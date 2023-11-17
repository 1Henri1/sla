
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.rdbOne = new System.Windows.Forms.RadioButton();
            this.rdbTwo = new System.Windows.Forms.RadioButton();
            this.rdbThree = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.ComboBox();
            this.idade = new System.Windows.Forms.NumericUpDown();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblcasal = new System.Windows.Forms.Label();
            this.radio = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.idade)).BeginInit();
            this.radio.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpf
            // 
            this.cpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cpf.Location = new System.Drawing.Point(57, 105);
            this.cpf.Mask = "000.000.000-00";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(100, 20);
            this.cpf.TabIndex = 0;
            this.cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.cpf.ValidatingType = typeof(System.DateTime);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(57, 45);
            this.name.Name = "name";
            this.name.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // rdbOne
            // 
            this.rdbOne.AutoSize = true;
            this.rdbOne.Location = new System.Drawing.Point(6, 28);
            this.rdbOne.Name = "rdbOne";
            this.rdbOne.Size = new System.Drawing.Size(58, 17);
            this.rdbOne.TabIndex = 2;
            this.rdbOne.TabStop = true;
            this.rdbOne.Text = "solteiro";
            this.rdbOne.UseVisualStyleBackColor = true;
            this.rdbOne.CheckedChanged += new System.EventHandler(this.rdbOne_CheckedChanged);
            // 
            // rdbTwo
            // 
            this.rdbTwo.AutoSize = true;
            this.rdbTwo.Location = new System.Drawing.Point(6, 51);
            this.rdbTwo.Name = "rdbTwo";
            this.rdbTwo.Size = new System.Drawing.Size(60, 17);
            this.rdbTwo.TabIndex = 3;
            this.rdbTwo.TabStop = true;
            this.rdbTwo.Text = "casado";
            this.rdbTwo.UseVisualStyleBackColor = true;
            // 
            // rdbThree
            // 
            this.rdbThree.AutoSize = true;
            this.rdbThree.Location = new System.Drawing.Point(6, 74);
            this.rdbThree.Name = "rdbThree";
            this.rdbThree.Size = new System.Drawing.Size(51, 17);
            this.rdbThree.TabIndex = 4;
            this.rdbThree.TabStop = true;
            this.rdbThree.Text = "viuvo";
            this.rdbThree.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(244, 144);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(34, 13);
            this.age.TabIndex = 7;
            this.age.Text = "Idade";
            this.age.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estado de nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CPF";
            // 
            // state
            // 
            this.state.FormattingEnabled = true;
            this.state.Items.AddRange(new object[] {
            "São Paulo",
            "Rio de Janeiro",
            "Bahia",
            "Santa Catarina",
            "Parana",
            "Para",
            "Amapa",
            "Sergipe",
            "Goias",
            "Amazonas"});
            this.state.Location = new System.Drawing.Point(57, 175);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(121, 21);
            this.state.TabIndex = 10;
            // 
            // idade
            // 
            this.idade.Location = new System.Drawing.Point(241, 176);
            this.idade.Name = "idade";
            this.idade.Size = new System.Drawing.Size(120, 20);
            this.idade.TabIndex = 11;
            this.idade.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(170, 245);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(472, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "nome: ";
            this.lblNome.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(472, 79);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(33, 13);
            this.lblCPF.TabIndex = 14;
            this.lblCPF.Tag = "CPF";
            this.lblCPF.Text = "CPF: ";
            this.lblCPF.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(472, 144);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(46, 13);
            this.lblNascimento.TabIndex = 15;
            this.lblNascimento.Text = "Estado: ";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(633, 79);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(40, 13);
            this.lblage.TabIndex = 17;
            this.lblage.Text = "Idade: ";
            // 
            // lblcasal
            // 
            this.lblcasal.AutoSize = true;
            this.lblcasal.Location = new System.Drawing.Point(633, 18);
            this.lblcasal.Name = "lblcasal";
            this.lblcasal.Size = new System.Drawing.Size(66, 13);
            this.lblcasal.TabIndex = 18;
            this.lblcasal.Text = "estado civil: ";
            // 
            // radio
            // 
            this.radio.Controls.Add(this.rdbOne);
            this.radio.Controls.Add(this.rdbTwo);
            this.radio.Controls.Add(this.rdbThree);
            this.radio.Location = new System.Drawing.Point(241, 18);
            this.radio.Name = "radio";
            this.radio.Size = new System.Drawing.Size(109, 109);
            this.radio.TabIndex = 19;
            this.radio.TabStop = false;
            this.radio.Text = "estado civil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radio);
            this.Controls.Add(this.lblcasal);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.idade);
            this.Controls.Add(this.state);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cpf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idade)).EndInit();
            this.radio.ResumeLayout(false);
            this.radio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox cpf;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.RadioButton rdbOne;
        private System.Windows.Forms.RadioButton rdbTwo;
        private System.Windows.Forms.RadioButton rdbThree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox state;
        private System.Windows.Forms.NumericUpDown idade;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblcasal;
        private System.Windows.Forms.GroupBox radio;
    }
}

