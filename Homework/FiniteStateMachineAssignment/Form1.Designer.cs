namespace FiniteStateMachineAssignment
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
            this.btn_gum = new System.Windows.Forms.Button();
            this.btn_granola = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_state = new System.Windows.Forms.TextBox();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_input_money = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_quarter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_gum
            // 
            this.btn_gum.Location = new System.Drawing.Point(272, 167);
            this.btn_gum.Name = "btn_gum";
            this.btn_gum.Size = new System.Drawing.Size(105, 34);
            this.btn_gum.TabIndex = 1;
            this.btn_gum.Text = "Gum";
            this.btn_gum.UseVisualStyleBackColor = true;
            this.btn_gum.Click += new System.EventHandler(this.btn_gum_Click);
            // 
            // btn_granola
            // 
            this.btn_granola.Location = new System.Drawing.Point(407, 165);
            this.btn_granola.Name = "btn_granola";
            this.btn_granola.Size = new System.Drawing.Size(103, 35);
            this.btn_granola.TabIndex = 2;
            this.btn_granola.Text = "Granola";
            this.btn_granola.UseVisualStyleBackColor = true;
            this.btn_granola.Click += new System.EventHandler(this.btn_granola_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(528, 166);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(103, 34);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(329, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "State";
            // 
            // tb_state
            // 
            this.tb_state.Location = new System.Drawing.Point(393, 42);
            this.tb_state.Name = "tb_state";
            this.tb_state.ReadOnly = true;
            this.tb_state.Size = new System.Drawing.Size(100, 20);
            this.tb_state.TabIndex = 5;
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(34, 317);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.ReadOnly = true;
            this.tb_output.Size = new System.Drawing.Size(738, 121);
            this.tb_output.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(42, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(30, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output";
            // 
            // tb_input_money
            // 
            this.tb_input_money.Location = new System.Drawing.Point(151, 133);
            this.tb_input_money.Name = "tb_input_money";
            this.tb_input_money.ReadOnly = true;
            this.tb_input_money.Size = new System.Drawing.Size(83, 20);
            this.tb_input_money.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Money Inserted";
            // 
            // btn_quarter
            // 
            this.btn_quarter.Location = new System.Drawing.Point(129, 167);
            this.btn_quarter.Name = "btn_quarter";
            this.btn_quarter.Size = new System.Drawing.Size(105, 33);
            this.btn_quarter.TabIndex = 0;
            this.btn_quarter.Text = "Insert Quarter";
            this.btn_quarter.UseVisualStyleBackColor = true;
            this.btn_quarter.Click += new System.EventHandler(this.btn_quarter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_input_money);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_quarter);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.tb_state);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_granola);
            this.Controls.Add(this.btn_gum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_gum;
        private System.Windows.Forms.Button btn_granola;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_state;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_input_money;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_quarter;
    }
}

