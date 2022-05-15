
namespace game_XO
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfir = new System.Windows.Forms.TextBox();
            this.txtsec = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Btnstartplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Second Player";
            // 
            // txtfir
            // 
            this.txtfir.Location = new System.Drawing.Point(169, 41);
            this.txtfir.Multiline = true;
            this.txtfir.Name = "txtfir";
            this.txtfir.Size = new System.Drawing.Size(257, 33);
            this.txtfir.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtfir, "First Player Name");
            // 
            // txtsec
            // 
            this.txtsec.Location = new System.Drawing.Point(169, 136);
            this.txtsec.Multiline = true;
            this.txtsec.Name = "txtsec";
            this.txtsec.Size = new System.Drawing.Size(257, 33);
            this.txtsec.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtsec, "Second Player Name");
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 10;
            this.toolTip1.AutoPopDelay = 9000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 2;
            // 
            // Btnstartplay
            // 
            this.Btnstartplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btnstartplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnstartplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnstartplay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btnstartplay.Location = new System.Drawing.Point(152, 206);
            this.Btnstartplay.Name = "Btnstartplay";
            this.Btnstartplay.Size = new System.Drawing.Size(135, 55);
            this.Btnstartplay.TabIndex = 5;
            this.Btnstartplay.Text = "Start Play";
            this.Btnstartplay.UseVisualStyleBackColor = false;
            this.Btnstartplay.Click += new System.EventHandler(this.Btnstartplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(438, 273);
            this.Controls.Add(this.Btnstartplay);
            this.Controls.Add(this.txtsec);
            this.Controls.Add(this.txtfir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "XO Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfir;
        private System.Windows.Forms.TextBox txtsec;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Btnstartplay;
    }
}

