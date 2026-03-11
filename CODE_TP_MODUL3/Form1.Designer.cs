namespace CODE_TP_MODUL3
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
            txtNama = new TextBox();
            btnKirim = new Button();
            lblOutput = new Label();
            SuspendLayout();
            // 
            // txtNama
            // 
            txtNama.Location = new Point(339, 147);
            txtNama.Multiline = true;
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(166, 34);
            txtNama.TabIndex = 0;
            // 
            // btnKirim
            // 
            btnKirim.Location = new Point(375, 218);
            btnKirim.Name = "btnKirim";
            btnKirim.Size = new Size(94, 29);
            btnKirim.TabIndex = 1;
            btnKirim.Text = "KIRIM";
            btnKirim.UseVisualStyleBackColor = true;
            btnKirim.Click += btnKirim_Click;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(339, 295);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(146, 20);
            lblOutput.TabIndex = 2;
            lblOutput.Text = "Output muncul disini";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 510);
            Controls.Add(lblOutput);
            Controls.Add(btnKirim);
            Controls.Add(txtNama);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNama;
        private Button btnKirim;
        private Label lblOutput;
    }
}
