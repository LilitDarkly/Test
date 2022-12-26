
namespace Test
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnProg = new System.Windows.Forms.Button();
            this.btnMaths = new System.Windows.Forms.Button();
            this.btnPhis = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(172, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnProg
            // 
            this.btnProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnProg.Location = new System.Drawing.Point(42, 168);
            this.btnProg.Name = "btnProg";
            this.btnProg.Size = new System.Drawing.Size(126, 40);
            this.btnProg.TabIndex = 1;
            this.btnProg.Text = "button1";
            this.btnProg.UseVisualStyleBackColor = true;
            this.btnProg.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMaths
            // 
            this.btnMaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnMaths.Location = new System.Drawing.Point(201, 168);
            this.btnMaths.Name = "btnMaths";
            this.btnMaths.Size = new System.Drawing.Size(124, 40);
            this.btnMaths.TabIndex = 2;
            this.btnMaths.Text = "button2";
            this.btnMaths.UseVisualStyleBackColor = true;
            this.btnMaths.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPhis
            // 
            this.btnPhis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPhis.Location = new System.Drawing.Point(370, 168);
            this.btnPhis.Name = "btnPhis";
            this.btnPhis.Size = new System.Drawing.Size(120, 40);
            this.btnPhis.TabIndex = 3;
            this.btnPhis.Text = "button3";
            this.btnPhis.UseVisualStyleBackColor = true;
            this.btnPhis.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClose.Location = new System.Drawing.Point(527, 168);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "button4";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPhis);
            this.Controls.Add(this.btnMaths);
            this.Controls.Add(this.btnProg);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Тестирование";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProg;
        private System.Windows.Forms.Button btnMaths;
        private System.Windows.Forms.Button btnPhis;
        private System.Windows.Forms.Button btnClose;
    }
}