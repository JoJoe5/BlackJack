namespace BlackJack_20191118
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.B_label = new System.Windows.Forms.Label();
            this.P_label = new System.Windows.Forms.Label();
            this.B_decklabel = new System.Windows.Forms.Label();
            this.B_add_btn = new System.Windows.Forms.Button();
            this.P_add_btn = new System.Windows.Forms.Button();
            this.B_pass_btn = new System.Windows.Forms.Button();
            this.P_pass_btn = new System.Windows.Forms.Button();
            this.Shuffle_btn = new System.Windows.Forms.Button();
            this.Start_btn = new System.Windows.Forms.Button();
            this.P_decklabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Counter_label = new System.Windows.Forms.Label();
            this.B_value_label = new System.Windows.Forms.Label();
            this.P_value_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_label
            // 
            this.B_label.AutoSize = true;
            this.B_label.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.B_label.Location = new System.Drawing.Point(48, 38);
            this.B_label.Name = "B_label";
            this.B_label.Size = new System.Drawing.Size(123, 61);
            this.B_label.TabIndex = 0;
            this.B_label.Text = "莊家";
            // 
            // P_label
            // 
            this.P_label.AutoSize = true;
            this.P_label.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P_label.Location = new System.Drawing.Point(672, 38);
            this.P_label.Name = "P_label";
            this.P_label.Size = new System.Drawing.Size(123, 61);
            this.P_label.TabIndex = 1;
            this.P_label.Text = "閒家";
            // 
            // B_decklabel
            // 
            this.B_decklabel.AutoSize = true;
            this.B_decklabel.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.B_decklabel.Location = new System.Drawing.Point(56, 112);
            this.B_decklabel.Name = "B_decklabel";
            this.B_decklabel.Size = new System.Drawing.Size(114, 33);
            this.B_decklabel.TabIndex = 2;
            this.B_decklabel.Text = "莊家牌";
            // 
            // B_add_btn
            // 
            this.B_add_btn.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.B_add_btn.Location = new System.Drawing.Point(59, 298);
            this.B_add_btn.Name = "B_add_btn";
            this.B_add_btn.Size = new System.Drawing.Size(120, 54);
            this.B_add_btn.TabIndex = 4;
            this.B_add_btn.Text = "要牌";
            this.B_add_btn.UseVisualStyleBackColor = true;
            this.B_add_btn.Click += new System.EventHandler(this.B_add_btn_Click);
            // 
            // P_add_btn
            // 
            this.P_add_btn.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P_add_btn.Location = new System.Drawing.Point(767, 298);
            this.P_add_btn.Name = "P_add_btn";
            this.P_add_btn.Size = new System.Drawing.Size(120, 54);
            this.P_add_btn.TabIndex = 5;
            this.P_add_btn.Text = "要牌";
            this.P_add_btn.UseVisualStyleBackColor = true;
            this.P_add_btn.Click += new System.EventHandler(this.P_add_btn_Click);
            // 
            // B_pass_btn
            // 
            this.B_pass_btn.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.B_pass_btn.Location = new System.Drawing.Point(59, 372);
            this.B_pass_btn.Name = "B_pass_btn";
            this.B_pass_btn.Size = new System.Drawing.Size(120, 54);
            this.B_pass_btn.TabIndex = 6;
            this.B_pass_btn.Text = "PASS!";
            this.B_pass_btn.UseVisualStyleBackColor = true;
            this.B_pass_btn.Click += new System.EventHandler(this.B_pass_btn_Click);
            // 
            // P_pass_btn
            // 
            this.P_pass_btn.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P_pass_btn.Location = new System.Drawing.Point(767, 372);
            this.P_pass_btn.Name = "P_pass_btn";
            this.P_pass_btn.Size = new System.Drawing.Size(120, 54);
            this.P_pass_btn.TabIndex = 7;
            this.P_pass_btn.Text = "PASS!";
            this.P_pass_btn.UseVisualStyleBackColor = true;
            this.P_pass_btn.Click += new System.EventHandler(this.P_pass_btn_Click);
            // 
            // Shuffle_btn
            // 
            this.Shuffle_btn.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Shuffle_btn.Location = new System.Drawing.Point(389, 112);
            this.Shuffle_btn.Name = "Shuffle_btn";
            this.Shuffle_btn.Size = new System.Drawing.Size(120, 54);
            this.Shuffle_btn.TabIndex = 8;
            this.Shuffle_btn.Text = "洗牌";
            this.Shuffle_btn.UseVisualStyleBackColor = true;
            this.Shuffle_btn.Click += new System.EventHandler(this.Shuffle_btn_Click);
            // 
            // Start_btn
            // 
            this.Start_btn.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Start_btn.Location = new System.Drawing.Point(389, 200);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(120, 54);
            this.Start_btn.TabIndex = 9;
            this.Start_btn.Text = "發牌";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // P_decklabel
            // 
            this.P_decklabel.AutoSize = true;
            this.P_decklabel.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P_decklabel.Location = new System.Drawing.Point(761, 108);
            this.P_decklabel.Name = "P_decklabel";
            this.P_decklabel.Size = new System.Drawing.Size(114, 33);
            this.P_decklabel.TabIndex = 10;
            this.P_decklabel.Text = "閒家牌";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "用牌數:";
            // 
            // Counter_label
            // 
            this.Counter_label.AutoSize = true;
            this.Counter_label.Location = new System.Drawing.Point(468, 411);
            this.Counter_label.Name = "Counter_label";
            this.Counter_label.Size = new System.Drawing.Size(14, 15);
            this.Counter_label.TabIndex = 12;
            this.Counter_label.Text = "0";
            // 
            // B_value_label
            // 
            this.B_value_label.AutoSize = true;
            this.B_value_label.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.B_value_label.Location = new System.Drawing.Point(158, 38);
            this.B_value_label.Name = "B_value_label";
            this.B_value_label.Size = new System.Drawing.Size(103, 61);
            this.B_value_label.TabIndex = 14;
            this.B_value_label.Text = "0點";
            // 
            // P_value_label
            // 
            this.P_value_label.AutoSize = true;
            this.P_value_label.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P_value_label.Location = new System.Drawing.Point(784, 38);
            this.P_value_label.Name = "P_value_label";
            this.P_value_label.Size = new System.Drawing.Size(103, 61);
            this.P_value_label.TabIndex = 15;
            this.P_value_label.Text = "0點";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(557, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "$1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(256, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "$1000";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(558, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 25);
            this.textBox1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 46);
            this.button1.TabIndex = 19;
            this.button1.Text = "投注";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 46);
            this.button2.TabIndex = 20;
            this.button2.Text = "投降";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "本局投注金額";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(411, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 33);
            this.label5.TabIndex = 22;
            this.label5.Text = "$0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 449);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.P_value_label);
            this.Controls.Add(this.B_value_label);
            this.Controls.Add(this.Counter_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.P_decklabel);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.Shuffle_btn);
            this.Controls.Add(this.P_pass_btn);
            this.Controls.Add(this.B_pass_btn);
            this.Controls.Add(this.P_add_btn);
            this.Controls.Add(this.B_add_btn);
            this.Controls.Add(this.B_decklabel);
            this.Controls.Add(this.P_label);
            this.Controls.Add(this.B_label);
            this.Name = "Form1";
            this.Text = "1 on 1 BlackJack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label B_label;
        private System.Windows.Forms.Label P_label;
        private System.Windows.Forms.Label B_decklabel;
        private System.Windows.Forms.Button B_add_btn;
        private System.Windows.Forms.Button P_add_btn;
        private System.Windows.Forms.Button B_pass_btn;
        private System.Windows.Forms.Button P_pass_btn;
        private System.Windows.Forms.Button Shuffle_btn;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Label P_decklabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Counter_label;
        private System.Windows.Forms.Label B_value_label;
        private System.Windows.Forms.Label P_value_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

