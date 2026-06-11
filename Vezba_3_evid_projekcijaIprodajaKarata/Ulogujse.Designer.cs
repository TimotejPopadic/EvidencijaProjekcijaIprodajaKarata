namespace Vezba_3_evid_projekcijaIprodajaKarata
{
    partial class Ulogujse
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(155, 211);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 43);
            textBox2.TabIndex = 7;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(155, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 43);
            textBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F);
            label2.Location = new Point(29, 201);
            label2.Name = "label2";
            label2.Size = new Size(110, 54);
            label2.TabIndex = 5;
            label2.Text = "Sifra:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(41, 126);
            label1.Name = "label1";
            label1.Size = new Size(98, 54);
            label1.TabIndex = 4;
            label1.Text = "Ime:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(137, 24);
            label3.Name = "label3";
            label3.Size = new Size(164, 45);
            label3.TabIndex = 8;
            label3.Text = "Uloguj se";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(137, 322);
            button1.Name = "button1";
            button1.Size = new Size(140, 53);
            button1.TabIndex = 9;
            button1.Text = "Loguj se";
            button1.UseVisualStyleBackColor = true;
            // 
            // Ulogujse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ulogujse";
            Text = "Ulogujse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button button1;
    }
}