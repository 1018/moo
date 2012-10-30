namespace mooEditor
{
    partial class findDialog
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
            this.lblFind = new System.Windows.Forms.Label();
            this.lblReplace = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.cbxCaseSensitivityOn = new System.Windows.Forms.CheckBox();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnReplaceNext = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxFindDirection = new System.Windows.Forms.GroupBox();
            this.rdbTopPosition = new System.Windows.Forms.RadioButton();
            this.rdbCurrentPosition = new System.Windows.Forms.RadioButton();
            this.pnlReplace = new System.Windows.Forms.Panel();
            this.gbxFindDirection.SuspendLayout();
            this.pnlReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFind.Location = new System.Drawing.Point(8, 16);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(111, 18);
            this.lblFind.TabIndex = 0;
            this.lblFind.Text = "検索する文字列(&N)";
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblReplace.Location = new System.Drawing.Point(8, 16);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(109, 18);
            this.lblReplace.TabIndex = 2;
            this.lblReplace.Text = "置換後の文字列(&P)";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(120, 16);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(253, 25);
            this.txtFind.TabIndex = 1;
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(120, 16);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(253, 25);
            this.txtReplace.TabIndex = 3;
            // 
            // cbxCaseSensitivityOn
            // 
            this.cbxCaseSensitivityOn.AutoSize = true;
            this.cbxCaseSensitivityOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxCaseSensitivityOn.Location = new System.Drawing.Point(16, 136);
            this.cbxCaseSensitivityOn.Name = "cbxCaseSensitivityOn";
            this.cbxCaseSensitivityOn.Size = new System.Drawing.Size(159, 22);
            this.cbxCaseSensitivityOn.TabIndex = 4;
            this.cbxCaseSensitivityOn.Text = "大文字小文字を区別する";
            this.cbxCaseSensitivityOn.UseVisualStyleBackColor = true;
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(392, 16);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(110, 23);
            this.btnFindNext.TabIndex = 5;
            this.btnFindNext.Text = "次を検索(&F)";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // btnReplaceNext
            // 
            this.btnReplaceNext.Location = new System.Drawing.Point(392, 16);
            this.btnReplaceNext.Name = "btnReplaceNext";
            this.btnReplaceNext.Size = new System.Drawing.Size(110, 23);
            this.btnReplaceNext.TabIndex = 6;
            this.btnReplaceNext.Text = "置換して次に(&R)";
            this.btnReplaceNext.UseVisualStyleBackColor = true;
            this.btnReplaceNext.Click += new System.EventHandler(this.btnReplaceNext_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(392, 48);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(110, 23);
            this.btnReplaceAll.TabIndex = 7;
            this.btnReplaceAll.Text = "すべて置換(&A)";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(392, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbxFindDirection
            // 
            this.gbxFindDirection.Controls.Add(this.rdbTopPosition);
            this.gbxFindDirection.Controls.Add(this.rdbCurrentPosition);
            this.gbxFindDirection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbxFindDirection.Location = new System.Drawing.Point(136, 56);
            this.gbxFindDirection.Name = "gbxFindDirection";
            this.gbxFindDirection.Size = new System.Drawing.Size(264, 56);
            this.gbxFindDirection.TabIndex = 9;
            this.gbxFindDirection.TabStop = false;
            this.gbxFindDirection.Text = "検索する方向";
            // 
            // rdbTopPosition
            // 
            this.rdbTopPosition.AutoSize = true;
            this.rdbTopPosition.Location = new System.Drawing.Point(152, 16);
            this.rdbTopPosition.Name = "rdbTopPosition";
            this.rdbTopPosition.Size = new System.Drawing.Size(92, 22);
            this.rdbTopPosition.TabIndex = 1;
            this.rdbTopPosition.TabStop = true;
            this.rdbTopPosition.Text = "先頭から(&T)";
            this.rdbTopPosition.UseVisualStyleBackColor = true;
            // 
            // rdbCurrentPosition
            // 
            this.rdbCurrentPosition.AutoSize = true;
            this.rdbCurrentPosition.Location = new System.Drawing.Point(16, 16);
            this.rdbCurrentPosition.Name = "rdbCurrentPosition";
            this.rdbCurrentPosition.Size = new System.Drawing.Size(105, 22);
            this.rdbCurrentPosition.TabIndex = 0;
            this.rdbCurrentPosition.TabStop = true;
            this.rdbCurrentPosition.Text = "現在行から(&D)";
            this.rdbCurrentPosition.UseVisualStyleBackColor = true;
            // 
            // pnlReplace
            // 
            this.pnlReplace.Controls.Add(this.btnReplaceNext);
            this.pnlReplace.Controls.Add(this.btnReplaceAll);
            this.pnlReplace.Controls.Add(this.lblReplace);
            this.pnlReplace.Controls.Add(this.txtReplace);
            this.pnlReplace.Location = new System.Drawing.Point(0, 48);
            this.pnlReplace.Name = "pnlReplace";
            this.pnlReplace.Size = new System.Drawing.Size(520, 80);
            this.pnlReplace.TabIndex = 10;
            // 
            // findDialog
            // 
            this.AcceptButton = this.btnFindNext;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(519, 181);
            this.Controls.Add(this.pnlReplace);
            this.Controls.Add(this.gbxFindDirection);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.cbxCaseSensitivityOn);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.lblFind);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "findDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.gbxFindDirection.ResumeLayout(false);
            this.gbxFindDirection.PerformLayout();
            this.pnlReplace.ResumeLayout(false);
            this.pnlReplace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.CheckBox cbxCaseSensitivityOn;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnReplaceNext;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxFindDirection;
        private System.Windows.Forms.RadioButton rdbTopPosition;
        private System.Windows.Forms.RadioButton rdbCurrentPosition;
        private System.Windows.Forms.Panel pnlReplace;
    }
}