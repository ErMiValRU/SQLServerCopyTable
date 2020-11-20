﻿namespace GenerateScripts
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
            this.lblConnString = new System.Windows.Forms.Label();
            this.txtConnString = new System.Windows.Forms.TextBox();
            this.lbxTableList = new System.Windows.Forms.ListBox();
            this.btnLoadTable = new System.Windows.Forms.Button();
            this.lbTableCount = new System.Windows.Forms.Label();
            this.txtTableCount = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConnString
            // 
            this.lblConnString.AutoSize = true;
            this.lblConnString.Location = new System.Drawing.Point(12, 76);
            this.lblConnString.Name = "lblConnString";
            this.lblConnString.Size = new System.Drawing.Size(107, 12);
            this.lblConnString.TabIndex = 5;
            this.lblConnString.Text = "Connection String";
            // 
            // txtConnString
            // 
            this.txtConnString.Location = new System.Drawing.Point(125, 73);
            this.txtConnString.Name = "txtConnString";
            this.txtConnString.Size = new System.Drawing.Size(515, 21);
            this.txtConnString.TabIndex = 6;
            // 
            // lbxTableList
            // 
            this.lbxTableList.FormattingEnabled = true;
            this.lbxTableList.ItemHeight = 12;
            this.lbxTableList.Location = new System.Drawing.Point(14, 121);
            this.lbxTableList.Name = "lbxTableList";
            this.lbxTableList.Size = new System.Drawing.Size(264, 352);
            this.lbxTableList.TabIndex = 9;
            // 
            // btnLoadTable
            // 
            this.btnLoadTable.Location = new System.Drawing.Point(659, 71);
            this.btnLoadTable.Name = "btnLoadTable";
            this.btnLoadTable.Size = new System.Drawing.Size(75, 23);
            this.btnLoadTable.TabIndex = 10;
            this.btnLoadTable.Text = "加载表";
            this.btnLoadTable.UseVisualStyleBackColor = true;
            this.btnLoadTable.Click += new System.EventHandler(this.btnLoadTable_Click);
            // 
            // lbTableCount
            // 
            this.lbTableCount.AutoSize = true;
            this.lbTableCount.Location = new System.Drawing.Point(300, 121);
            this.lbTableCount.Name = "lbTableCount";
            this.lbTableCount.Size = new System.Drawing.Size(53, 12);
            this.lbTableCount.TabIndex = 11;
            this.lbTableCount.Text = "分表个数";
            // 
            // txtTableCount
            // 
            this.txtTableCount.Location = new System.Drawing.Point(376, 118);
            this.txtTableCount.Name = "txtTableCount";
            this.txtTableCount.Size = new System.Drawing.Size(100, 21);
            this.txtTableCount.TabIndex = 12;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(302, 204);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 13;
            this.btnRun.Text = "开始分表";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(410, 204);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTable.TabIndex = 14;
            this.btnDeleteTable.Text = "删除分表";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.BtnDeleteTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 523);
            this.Controls.Add(this.btnDeleteTable);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtTableCount);
            this.Controls.Add(this.lbTableCount);
            this.Controls.Add(this.btnLoadTable);
            this.Controls.Add(this.lbxTableList);
            this.Controls.Add(this.txtConnString);
            this.Controls.Add(this.lblConnString);
            this.Name = "Form1";
            this.Text = "闪电分表利器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConnString;
        private System.Windows.Forms.TextBox txtConnString;
        private System.Windows.Forms.ListBox lbxTableList;
        private System.Windows.Forms.Button btnLoadTable;
        private System.Windows.Forms.Label lbTableCount;
        private System.Windows.Forms.TextBox txtTableCount;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnDeleteTable;
    }
}

