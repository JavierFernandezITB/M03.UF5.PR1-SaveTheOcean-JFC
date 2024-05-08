namespace M03.UF5.PR1_SaveTheOcean_JFC
{
    partial class CharacterSelection
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
            components = new System.ComponentModel.Container();
            comboBoxWork = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBoxUsername = new TextBox();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxWork
            // 
            comboBoxWork.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxWork.FormattingEnabled = true;
            comboBoxWork.Location = new Point(99, 186);
            comboBoxWork.Name = "comboBoxWork";
            comboBoxWork.Size = new Size(121, 23);
            comboBoxWork.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(59, 32);
            label1.Name = "label1";
            label1.Size = new Size(203, 36);
            label1.TabIndex = 3;
            label1.Text = "Como te llamas?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F);
            label2.Location = new Point(56, 131);
            label2.Name = "label2";
            label2.Size = new Size(209, 36);
            label2.TabIndex = 4;
            label2.Text = "Cual es tu oficio?";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(62, 86);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(203, 23);
            textBoxUsername.TabIndex = 5;
            textBoxUsername.Leave += textBoxUsername_Leave;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(62, 251);
            button1.Name = "button1";
            button1.Size = new Size(188, 54);
            button1.TabIndex = 6;
            button1.Text = "Continuar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CharacterSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(319, 351);
            Controls.Add(button1);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxWork);
            Name = "CharacterSelection";
            Text = "Como te llamas?";
            Load += CharacterSelection_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxWork;
        private Label label1;
        private Label label2;
        private TextBox textBoxUsername;
        private Button button1;
        private ErrorProvider errorProvider1;
    }
}