namespace Cassetta_Sicurezza
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
            Aggiunta = new Button();
            Cassetta = new ListBox();
            label1 = new Label();
            button2 = new Button();
            comboBox1 = new ComboBox();
            Stato = new Label();
            textBox1 = new TextBox();
            Apri = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Aggiunta
            // 
            Aggiunta.Location = new Point(232, 155);
            Aggiunta.Name = "Aggiunta";
            Aggiunta.Size = new Size(132, 23);
            Aggiunta.TabIndex = 0;
            Aggiunta.Text = "AGGIUNGI";
            Aggiunta.UseVisualStyleBackColor = true;
            // 
            // Cassetta
            // 
            Cassetta.FormattingEnabled = true;
            Cassetta.ItemHeight = 15;
            Cassetta.Location = new Point(410, 117);
            Cassetta.Name = "Cassetta";
            Cassetta.Size = new Size(218, 214);
            Cassetta.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(373, 82);
            label1.Name = "label1";
            label1.Size = new Size(297, 32);
            label1.TabIndex = 2;
            label1.Text = "CASSETTA DI SICUREZZA";
            // 
            // button2
            // 
            button2.Location = new Point(410, 337);
            button2.Name = "button2";
            button2.Size = new Size(218, 23);
            button2.TabIndex = 3;
            button2.Text = "RIMUOVI";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Generico", "Gioiello", "Chiave", "Documento" });
            comboBox1.Location = new Point(232, 126);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 23);
            comboBox1.TabIndex = 4;
            // 
            // Stato
            // 
            Stato.AutoSize = true;
            Stato.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Stato.Location = new Point(634, 199);
            Stato.Name = "Stato";
            Stato.Size = new Size(69, 21);
            Stato.TabIndex = 5;
            Stato.Text = "APERTA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 247);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(92, 23);
            textBox1.TabIndex = 6;
            // 
            // Apri
            // 
            Apri.Location = new Point(102, 276);
            Apri.Name = "Apri";
            Apri.Size = new Size(75, 23);
            Apri.TabIndex = 7;
            Apri.Text = "APRI";
            Apri.UseVisualStyleBackColor = true;
            Apri.Click += Apri_Click;
            // 
            // button4
            // 
            button4.Location = new Point(194, 276);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "CHIUDI";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 229);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 9;
            label2.Text = "INSERISCI IL PIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(461, 387);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 10;
            label3.Text = "VALORE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(536, 392);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 11;
            label4.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(Apri);
            Controls.Add(textBox1);
            Controls.Add(Stato);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(Cassetta);
            Controls.Add(Aggiunta);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Aggiunta;
        private ListBox Cassetta;
        private Label label1;
        private Button button2;
        private ComboBox comboBox1;
        private Label Stato;
        private TextBox textBox1;
        private Button Apri;
        private Button button4;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
