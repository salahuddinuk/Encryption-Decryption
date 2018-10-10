namespace EncryptDecrypt
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
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.btn_Process = new System.Windows.Forms.Button();
            this.chb_Decrypt = new System.Windows.Forms.CheckBox();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.lbl_Input = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Value
            // 
            this.txt_Value.Location = new System.Drawing.Point(99, 54);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.Size = new System.Drawing.Size(228, 20);
            this.txt_Value.TabIndex = 0;
            // 
            // btn_Process
            // 
            this.btn_Process.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Process.Location = new System.Drawing.Point(99, 127);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(153, 51);
            this.btn_Process.TabIndex = 2;
            this.btn_Process.Text = "Process";
            this.btn_Process.UseVisualStyleBackColor = true;
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click);
            // 
            // chb_Decrypt
            // 
            this.chb_Decrypt.AutoSize = true;
            this.chb_Decrypt.Location = new System.Drawing.Point(99, 22);
            this.chb_Decrypt.Name = "chb_Decrypt";
            this.chb_Decrypt.Size = new System.Drawing.Size(63, 17);
            this.chb_Decrypt.TabIndex = 3;
            this.chb_Decrypt.Text = "Decrypt";
            this.chb_Decrypt.UseVisualStyleBackColor = true;
            // 
            // txt_Result
            // 
            this.txt_Result.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Result.Location = new System.Drawing.Point(99, 91);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ReadOnly = true;
            this.txt_Result.Size = new System.Drawing.Size(228, 20);
            this.txt_Result.TabIndex = 4;
            // 
            // lbl_Input
            // 
            this.lbl_Input.AutoSize = true;
            this.lbl_Input.Location = new System.Drawing.Point(32, 57);
            this.lbl_Input.Name = "lbl_Input";
            this.lbl_Input.Size = new System.Drawing.Size(61, 13);
            this.lbl_Input.TabIndex = 5;
            this.lbl_Input.Text = "Input String";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Result";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(32, 194);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 13);
            this.lbl_Error.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 237);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Input);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.chb_Decrypt);
            this.Controls.Add(this.btn_Process);
            this.Controls.Add(this.txt_Value);
            this.Name = "Form1";
            this.Text = "Encrypt Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Value;
        private System.Windows.Forms.Button btn_Process;
        private System.Windows.Forms.CheckBox chb_Decrypt;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Label lbl_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Error;
    }
}

