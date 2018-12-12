namespace My_planner
{
    partial class Finance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finance));
            this.lblname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCOst = new System.Windows.Forms.TextBox();
            this.txthand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnpre = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblstatrt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblname.Font = new System.Drawing.Font("Lucida Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(228, 25);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(81, 28);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "[Goal]";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Cost";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCOst
            // 
            this.txtCOst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCOst.Location = new System.Drawing.Point(243, 78);
            this.txtCOst.Name = "txtCOst";
            this.txtCOst.Size = new System.Drawing.Size(195, 26);
            this.txtCOst.TabIndex = 2;
            this.txtCOst.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txthand
            // 
            this.txthand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthand.Location = new System.Drawing.Point(243, 118);
            this.txthand.Name = "txthand";
            this.txthand.Size = new System.Drawing.Size(195, 26);
            this.txthand.TabIndex = 4;
            this.txthand.TextChanged += new System.EventHandler(this.txthand_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Money In Hand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contingency plans for the rest";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(60, 185);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(441, 68);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 41;
            this.label5.Text = "Start Date:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnnext
            // 
            this.btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.Location = new System.Drawing.Point(381, 312);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(86, 35);
            this.btnnext.TabIndex = 46;
            this.btnnext.Text = "Next goal";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnpre
            // 
            this.btnpre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpre.Location = new System.Drawing.Point(147, 312);
            this.btnpre.Name = "btnpre";
            this.btnpre.Size = new System.Drawing.Size(87, 35);
            this.btnpre.TabIndex = 45;
            this.btnpre.Text = "Previous goal";
            this.btnpre.UseVisualStyleBackColor = true;
            this.btnpre.Click += new System.EventHandler(this.btnpre_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(259, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 35);
            this.button3.TabIndex = 48;
            this.button3.Text = "New goal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblstatrt
            // 
            this.lblstatrt.AutoSize = true;
            this.lblstatrt.BackColor = System.Drawing.Color.Transparent;
            this.lblstatrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblstatrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatrt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblstatrt.Location = new System.Drawing.Point(151, 268);
            this.lblstatrt.Name = "lblstatrt";
            this.lblstatrt.Size = new System.Drawing.Size(105, 24);
            this.lblstatrt.TabIndex = 49;
            this.lblstatrt.Text = "Start Date:";
            // 
            // Finance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblstatrt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnpre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txthand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCOst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblname);
            this.Name = "Finance";
            this.Size = new System.Drawing.Size(581, 371);
            this.Load += new System.EventHandler(this.Finance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCOst;
        private System.Windows.Forms.TextBox txthand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnpre;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblstatrt;
    }
}
