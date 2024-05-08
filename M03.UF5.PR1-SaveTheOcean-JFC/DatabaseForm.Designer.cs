namespace M03.UF5.PR1_SaveTheOcean_JFC
{
    partial class DatabaseForm
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
            dataGridView = new DataGridView();
            label1 = new Label();
            buttonCreateSelf = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 58);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(491, 342);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 36);
            label1.TabIndex = 4;
            label1.Text = "Selecciona un animal";
            // 
            // buttonCreateSelf
            // 
            buttonCreateSelf.Location = new Point(12, 415);
            buttonCreateSelf.Name = "buttonCreateSelf";
            buttonCreateSelf.Size = new Size(159, 23);
            buttonCreateSelf.TabIndex = 5;
            buttonCreateSelf.Text = "Crear un nuevo animal";
            buttonCreateSelf.UseVisualStyleBackColor = true;
            buttonCreateSelf.Click += buttonCreateSelf_Click;
            // 
            // button1
            // 
            button1.Location = new Point(344, 415);
            button1.Name = "button1";
            button1.Size = new Size(159, 23);
            button1.TabIndex = 6;
            button1.Text = "Mostrar rescates";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DatabaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(515, 450);
            Controls.Add(button1);
            Controls.Add(buttonCreateSelf);
            Controls.Add(label1);
            Controls.Add(dataGridView);
            Name = "DatabaseForm";
            Text = "DatabaseForm";
            Load += DatabaseForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Label label1;
        private Button buttonCreateSelf;
        private Button button1;
    }
}