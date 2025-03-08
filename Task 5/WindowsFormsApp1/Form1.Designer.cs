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
            this.btnTransparency = new System.Windows.Forms.Button();
            this.btnBackground = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnMega = new System.Windows.Forms.Button();
            this.checkBoxTransp = new System.Windows.Forms.CheckBox();
            this.checkBoxHello = new System.Windows.Forms.CheckBox();
            this.checkBoxBackgr = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnTransparency
            // 
            this.btnTransparency.Location = new System.Drawing.Point(50, 53);
            this.btnTransparency.Name = "btnTransparency";
            this.btnTransparency.Size = new System.Drawing.Size(134, 40);
            this.btnTransparency.TabIndex = 0;
            this.btnTransparency.Text = "Transparency";
            this.btnTransparency.UseVisualStyleBackColor = true;
            this.btnTransparency.Click += new System.EventHandler(this.btnTransparency_Click);
            // 
            // btnBackground
            // 
            this.btnBackground.Location = new System.Drawing.Point(302, 53);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(134, 40);
            this.btnBackground.TabIndex = 1;
            this.btnBackground.Text = "Background Color";
            this.btnBackground.UseVisualStyleBackColor = true;
            this.btnBackground.Click += new System.EventHandler(this.btnBackground_Click);
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(551, 53);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(134, 40);
            this.btnHello.TabIndex = 2;
            this.btnHello.Text = "Hello World";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnMega
            // 
            this.btnMega.Location = new System.Drawing.Point(182, 115);
            this.btnMega.Name = "btnMega";
            this.btnMega.Size = new System.Drawing.Size(361, 40);
            this.btnMega.TabIndex = 3;
            this.btnMega.Text = "Super mega button";
            this.btnMega.UseVisualStyleBackColor = true;
            this.btnMega.Click += new System.EventHandler(this.btnMega_Click);
            // 
            // checkBoxTransp
            // 
            this.checkBoxTransp.AutoSize = true;
            this.checkBoxTransp.Location = new System.Drawing.Point(35, 193);
            this.checkBoxTransp.Name = "checkBoxTransp";
            this.checkBoxTransp.Size = new System.Drawing.Size(246, 20);
            this.checkBoxTransp.TabIndex = 4;
            this.checkBoxTransp.Text = "mega button absorb \"Transparency\"";
            this.checkBoxTransp.UseVisualStyleBackColor = true;
            this.checkBoxTransp.CheckedChanged += new System.EventHandler(this.checkBoxTransp_CheckedChanged);
            // 
            // checkBoxHello
            // 
            this.checkBoxHello.AutoSize = true;
            this.checkBoxHello.Location = new System.Drawing.Point(35, 245);
            this.checkBoxHello.Name = "checkBoxHello";
            this.checkBoxHello.Size = new System.Drawing.Size(95, 20);
            this.checkBoxHello.TabIndex = 5;
            this.checkBoxHello.Text = "checkBox2";
            this.checkBoxHello.UseVisualStyleBackColor = true;
            this.checkBoxHello.CheckedChanged += new System.EventHandler(this.checkBoxHello_CheckedChanged);
            // 
            // checkBoxBackgr
            // 
            this.checkBoxBackgr.AutoSize = true;
            this.checkBoxBackgr.Location = new System.Drawing.Point(32, 219);
            this.checkBoxBackgr.Name = "checkBoxBackgr";
            this.checkBoxBackgr.Size = new System.Drawing.Size(235, 20);
            this.checkBoxBackgr.TabIndex = 6;
            this.checkBoxBackgr.Text = "mega button absorb \"Background\"";
            this.checkBoxBackgr.UseVisualStyleBackColor = true;
            this.checkBoxBackgr.CheckedChanged += new System.EventHandler(this.checkBoxBackgr_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.checkBoxBackgr);
            this.Controls.Add(this.checkBoxHello);
            this.Controls.Add(this.checkBoxTransp);
            this.Controls.Add(this.btnMega);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.btnBackground);
            this.Controls.Add(this.btnTransparency);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransparency;
        private System.Windows.Forms.Button btnBackground;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnMega;
        private System.Windows.Forms.CheckBox checkBoxTransp;
        private System.Windows.Forms.CheckBox checkBoxHello;
        private System.Windows.Forms.CheckBox checkBoxBackgr;
    }
}

