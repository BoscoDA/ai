namespace VendingMachine
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
            this.gbox_select = new System.Windows.Forms.GroupBox();
            this.rbtn_granola = new System.Windows.Forms.RadioButton();
            this.rbtn_gum = new System.Windows.Forms.RadioButton();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_quarter = new System.Windows.Forms.Button();
            this.tb_money = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_state = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_retrieve = new System.Windows.Forms.Button();
            this.tb_output_log = new System.Windows.Forms.TextBox();
            this.tb_change = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_take_change = new System.Windows.Forms.Button();
            this.gbox_select.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_select
            // 
            this.gbox_select.Controls.Add(this.rbtn_granola);
            this.gbox_select.Controls.Add(this.rbtn_gum);
            this.gbox_select.Location = new System.Drawing.Point(535, 85);
            this.gbox_select.Name = "gbox_select";
            this.gbox_select.Size = new System.Drawing.Size(113, 110);
            this.gbox_select.TabIndex = 0;
            this.gbox_select.TabStop = false;
            this.gbox_select.Text = "Selection";
            // 
            // rbtn_granola
            // 
            this.rbtn_granola.AutoSize = true;
            this.rbtn_granola.Location = new System.Drawing.Point(14, 65);
            this.rbtn_granola.Name = "rbtn_granola";
            this.rbtn_granola.Size = new System.Drawing.Size(62, 17);
            this.rbtn_granola.TabIndex = 1;
            this.rbtn_granola.TabStop = true;
            this.rbtn_granola.Text = "Granola";
            this.rbtn_granola.UseVisualStyleBackColor = true;
            // 
            // rbtn_gum
            // 
            this.rbtn_gum.AutoSize = true;
            this.rbtn_gum.Location = new System.Drawing.Point(14, 28);
            this.rbtn_gum.Name = "rbtn_gum";
            this.rbtn_gum.Size = new System.Drawing.Size(47, 17);
            this.rbtn_gum.TabIndex = 0;
            this.rbtn_gum.TabStop = true;
            this.rbtn_gum.Text = "Gum";
            this.rbtn_gum.UseVisualStyleBackColor = true;
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(543, 207);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(90, 33);
            this.btn_select.TabIndex = 1;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_quarter
            // 
            this.btn_quarter.Location = new System.Drawing.Point(543, 246);
            this.btn_quarter.Name = "btn_quarter";
            this.btn_quarter.Size = new System.Drawing.Size(90, 33);
            this.btn_quarter.TabIndex = 2;
            this.btn_quarter.Text = "Insert Quarter";
            this.btn_quarter.UseVisualStyleBackColor = true;
            this.btn_quarter.Click += new System.EventHandler(this.btn_quarter_Click);
            // 
            // tb_money
            // 
            this.tb_money.Location = new System.Drawing.Point(544, 59);
            this.tb_money.Name = "tb_money";
            this.tb_money.ReadOnly = true;
            this.tb_money.Size = new System.Drawing.Size(89, 20);
            this.tb_money.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(308, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 385);
            this.panel1.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Fuchsia;
            this.panel10.Controls.Add(this.label8);
            this.panel10.Location = new System.Drawing.Point(123, 217);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(79, 54);
            this.panel10.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(3, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Granola";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Olive;
            this.panel9.Controls.Add(this.label5);
            this.panel9.Location = new System.Drawing.Point(17, 217);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(79, 54);
            this.panel9.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(17, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Gum";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Lime;
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(123, 142);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(79, 54);
            this.panel8.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Granola";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Yellow;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(17, 142);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(79, 54);
            this.panel7.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gum";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.IndianRed;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(123, 69);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(79, 54);
            this.panel6.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Granola";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(17, 69);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(79, 54);
            this.panel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gum";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.tb_state);
            this.panel4.Location = new System.Drawing.Point(0, 277);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(216, 47);
            this.panel4.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(25, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "State";
            // 
            // tb_state
            // 
            this.tb_state.Location = new System.Drawing.Point(89, 13);
            this.tb_state.Name = "tb_state";
            this.tb_state.ReadOnly = true;
            this.tb_state.Size = new System.Drawing.Size(103, 20);
            this.tb_state.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 47);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "VEND-O-MATIC";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tb_output);
            this.panel2.Location = new System.Drawing.Point(308, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 64);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Output";
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(87, 23);
            this.tb_output.Name = "tb_output";
            this.tb_output.ReadOnly = true;
            this.tb_output.Size = new System.Drawing.Size(103, 20);
            this.tb_output.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(543, 285);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(90, 33);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_retrieve
            // 
            this.btn_retrieve.Location = new System.Drawing.Point(544, 387);
            this.btn_retrieve.Name = "btn_retrieve";
            this.btn_retrieve.Size = new System.Drawing.Size(81, 24);
            this.btn_retrieve.TabIndex = 7;
            this.btn_retrieve.Text = "Take Item";
            this.btn_retrieve.UseVisualStyleBackColor = true;
            this.btn_retrieve.Click += new System.EventHandler(this.btn_retrieve_Click);
            // 
            // tb_output_log
            // 
            this.tb_output_log.Location = new System.Drawing.Point(12, 71);
            this.tb_output_log.Multiline = true;
            this.tb_output_log.Name = "tb_output_log";
            this.tb_output_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_output_log.Size = new System.Drawing.Size(143, 255);
            this.tb_output_log.TabIndex = 8;
            // 
            // tb_change
            // 
            this.tb_change.Location = new System.Drawing.Point(535, 348);
            this.tb_change.Name = "tb_change";
            this.tb_change.Size = new System.Drawing.Size(113, 20);
            this.tb_change.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(532, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Change Return";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(12, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Output Log";
            // 
            // tb_take_change
            // 
            this.tb_take_change.Location = new System.Drawing.Point(654, 348);
            this.tb_take_change.Name = "tb_take_change";
            this.tb_take_change.Size = new System.Drawing.Size(89, 22);
            this.tb_take_change.TabIndex = 12;
            this.tb_take_change.Text = "Take Change";
            this.tb_take_change.UseVisualStyleBackColor = true;
            this.tb_take_change.Click += new System.EventHandler(this.tb_take_change_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_take_change);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_change);
            this.Controls.Add(this.tb_output_log);
            this.Controls.Add(this.btn_retrieve);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_money);
            this.Controls.Add(this.btn_quarter);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.gbox_select);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbox_select.ResumeLayout(false);
            this.gbox_select.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_select;
        private System.Windows.Forms.RadioButton rbtn_granola;
        private System.Windows.Forms.RadioButton rbtn_gum;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_quarter;
        private System.Windows.Forms.TextBox tb_money;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_state;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_retrieve;
        private System.Windows.Forms.TextBox tb_output_log;
        private System.Windows.Forms.TextBox tb_change;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button tb_take_change;
    }
}

