﻿namespace FinalProject_C3
{
    partial class Join
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
            this.PNL_JOIN = new System.Windows.Forms.Panel();
            this.TB_EMAIL = new System.Windows.Forms.TextBox();
            this.TB_PHONE = new System.Windows.Forms.TextBox();
            this.TB_NAME = new System.Windows.Forms.TextBox();
            this.TB_PW2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_CLOSE = new System.Windows.Forms.Button();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.TB_PW = new System.Windows.Forms.TextBox();
            this.BT_JOIN = new System.Windows.Forms.Button();
            this.PNL_JOIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_JOIN
            // 
            this.PNL_JOIN.BackgroundImage = global::FinalProject_C3.Properties.Resources.회원가입화면2;
            this.PNL_JOIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PNL_JOIN.Controls.Add(this.TB_EMAIL);
            this.PNL_JOIN.Controls.Add(this.TB_PHONE);
            this.PNL_JOIN.Controls.Add(this.TB_NAME);
            this.PNL_JOIN.Controls.Add(this.TB_PW2);
            this.PNL_JOIN.Controls.Add(this.label1);
            this.PNL_JOIN.Controls.Add(this.BT_CLOSE);
            this.PNL_JOIN.Controls.Add(this.TB_ID);
            this.PNL_JOIN.Controls.Add(this.TB_PW);
            this.PNL_JOIN.Controls.Add(this.BT_JOIN);
            this.PNL_JOIN.Location = new System.Drawing.Point(0, -1);
            this.PNL_JOIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PNL_JOIN.Name = "PNL_JOIN";
            this.PNL_JOIN.Size = new System.Drawing.Size(418, 553);
            this.PNL_JOIN.TabIndex = 5;
            // 
            // TB_EMAIL
            // 
            this.TB_EMAIL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_EMAIL.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TB_EMAIL.Location = new System.Drawing.Point(117, 415);
            this.TB_EMAIL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_EMAIL.MaximumSize = new System.Drawing.Size(175, 30);
            this.TB_EMAIL.MinimumSize = new System.Drawing.Size(175, 30);
            this.TB_EMAIL.Name = "TB_EMAIL";
            this.TB_EMAIL.Size = new System.Drawing.Size(175, 26);
            this.TB_EMAIL.TabIndex = 11;
            this.TB_EMAIL.Text = "이메일";
            // 
            // TB_PHONE
            // 
            this.TB_PHONE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_PHONE.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TB_PHONE.Location = new System.Drawing.Point(117, 348);
            this.TB_PHONE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_PHONE.MaximumSize = new System.Drawing.Size(175, 30);
            this.TB_PHONE.MinimumSize = new System.Drawing.Size(175, 30);
            this.TB_PHONE.Name = "TB_PHONE";
            this.TB_PHONE.Size = new System.Drawing.Size(175, 26);
            this.TB_PHONE.TabIndex = 10;
            this.TB_PHONE.Text = "전화번호";
            // 
            // TB_NAME
            // 
            this.TB_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_NAME.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TB_NAME.Location = new System.Drawing.Point(117, 278);
            this.TB_NAME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_NAME.MaximumSize = new System.Drawing.Size(175, 30);
            this.TB_NAME.MinimumSize = new System.Drawing.Size(175, 30);
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.Size = new System.Drawing.Size(175, 26);
            this.TB_NAME.TabIndex = 9;
            this.TB_NAME.Text = "이름";
            // 
            // TB_PW2
            // 
            this.TB_PW2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_PW2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TB_PW2.Location = new System.Drawing.Point(117, 215);
            this.TB_PW2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_PW2.MaximumSize = new System.Drawing.Size(175, 30);
            this.TB_PW2.MinimumSize = new System.Drawing.Size(175, 30);
            this.TB_PW2.Name = "TB_PW2";
            this.TB_PW2.Size = new System.Drawing.Size(175, 26);
            this.TB_PW2.TabIndex = 8;
            this.TB_PW2.Text = "재확인";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sign Up";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BT_CLOSE
            // 
            this.BT_CLOSE.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BT_CLOSE.FlatAppearance.BorderSize = 0;
            this.BT_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_CLOSE.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_CLOSE.ForeColor = System.Drawing.Color.White;
            this.BT_CLOSE.Location = new System.Drawing.Point(380, 6);
            this.BT_CLOSE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_CLOSE.Name = "BT_CLOSE";
            this.BT_CLOSE.Size = new System.Drawing.Size(24, 26);
            this.BT_CLOSE.TabIndex = 4;
            this.BT_CLOSE.Text = "X";
            this.BT_CLOSE.UseVisualStyleBackColor = false;
            this.BT_CLOSE.Click += new System.EventHandler(this.BT_CLOSE_Click);
            // 
            // TB_ID
            // 
            this.TB_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_ID.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TB_ID.Location = new System.Drawing.Point(117, 123);
            this.TB_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_ID.MaximumSize = new System.Drawing.Size(175, 30);
            this.TB_ID.MinimumSize = new System.Drawing.Size(175, 30);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(175, 26);
            this.TB_ID.TabIndex = 2;
            this.TB_ID.Text = "아이디";
            // 
            // TB_PW
            // 
            this.TB_PW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_PW.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TB_PW.Location = new System.Drawing.Point(117, 187);
            this.TB_PW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_PW.MaximumSize = new System.Drawing.Size(175, 30);
            this.TB_PW.MinimumSize = new System.Drawing.Size(175, 30);
            this.TB_PW.Name = "TB_PW";
            this.TB_PW.Size = new System.Drawing.Size(175, 26);
            this.TB_PW.TabIndex = 3;
            this.TB_PW.Text = "패스워드";
            // 
            // BT_JOIN
            // 
            this.BT_JOIN.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_JOIN.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BT_JOIN.Location = new System.Drawing.Point(130, 466);
            this.BT_JOIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_JOIN.Name = "BT_JOIN";
            this.BT_JOIN.Size = new System.Drawing.Size(140, 43);
            this.BT_JOIN.TabIndex = 0;
            this.BT_JOIN.Text = "확인";
            this.BT_JOIN.UseVisualStyleBackColor = true;
            this.BT_JOIN.Click += new System.EventHandler(this.BT_JOIN_Click);
            // 
            // Join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(416, 550);
            this.Controls.Add(this.PNL_JOIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Join";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.PNL_JOIN.ResumeLayout(false);
            this.PNL_JOIN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_JOIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_CLOSE;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.TextBox TB_PW;
        private System.Windows.Forms.Button BT_JOIN;
        private System.Windows.Forms.TextBox TB_EMAIL;
        private System.Windows.Forms.TextBox TB_PHONE;
        private System.Windows.Forms.TextBox TB_NAME;
        private System.Windows.Forms.TextBox TB_PW2;
    }
}