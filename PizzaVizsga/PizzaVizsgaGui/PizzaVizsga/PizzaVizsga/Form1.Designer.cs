namespace PizzaVizsga
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
            this.listBox_futars = new System.Windows.Forms.ListBox();
            this.textBox_fazon = new System.Windows.Forms.TextBox();
            this.textBox_fnev = new System.Windows.Forms.TextBox();
            this.textBox_ftel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_futars
            // 
            this.listBox_futars.FormattingEnabled = true;
            this.listBox_futars.Location = new System.Drawing.Point(74, 24);
            this.listBox_futars.Name = "listBox_futars";
            this.listBox_futars.Size = new System.Drawing.Size(647, 134);
            this.listBox_futars.TabIndex = 0;
            this.listBox_futars.SelectedIndexChanged += new System.EventHandler(this.listBox_futars_SelectedIndexChanged);
            // 
            // textBox_fazon
            // 
            this.textBox_fazon.Location = new System.Drawing.Point(74, 209);
            this.textBox_fazon.Name = "textBox_fazon";
            this.textBox_fazon.ReadOnly = true;
            this.textBox_fazon.Size = new System.Drawing.Size(37, 20);
            this.textBox_fazon.TabIndex = 1;
            // 
            // textBox_fnev
            // 
            this.textBox_fnev.Location = new System.Drawing.Point(116, 209);
            this.textBox_fnev.Name = "textBox_fnev";
            this.textBox_fnev.ReadOnly = true;
            this.textBox_fnev.Size = new System.Drawing.Size(147, 20);
            this.textBox_fnev.TabIndex = 1;
            // 
            // textBox_ftel
            // 
            this.textBox_ftel.Location = new System.Drawing.Point(269, 209);
            this.textBox_ftel.Name = "textBox_ftel";
            this.textBox_ftel.Size = new System.Drawing.Size(177, 20);
            this.textBox_ftel.TabIndex = 1;
            this.textBox_ftel.TextChanged += new System.EventHandler(this.textBox_ftel_TextChanged);
            this.textBox_ftel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ftel_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Futár neve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tel.:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Módosítás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ftel);
            this.Controls.Add(this.textBox_fnev);
            this.Controls.Add(this.textBox_fazon);
            this.Controls.Add(this.listBox_futars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_futars;
        private System.Windows.Forms.TextBox textBox_fazon;
        private System.Windows.Forms.TextBox textBox_fnev;
        private System.Windows.Forms.TextBox textBox_ftel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

