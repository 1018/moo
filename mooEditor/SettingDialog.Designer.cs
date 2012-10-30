namespace mooEditor
{
    partial class SettingDialog
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
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.tbcSetting = new System.Windows.Forms.TabControl();
            this.tabColorFont = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.tabEtc = new System.Windows.Forms.TabPage();
            this.gbxTransparency = new System.Windows.Forms.GroupBox();
            this.lblTransparency = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tkbTransparency = new System.Windows.Forms.TrackBar();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbcSetting.SuspendLayout();
            this.tabColorFont.SuspendLayout();
            this.tabEtc.SuspendLayout();
            this.gbxTransparency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTransparency)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcSetting
            // 
            this.tbcSetting.Controls.Add(this.tabColorFont);
            this.tbcSetting.Controls.Add(this.tabEtc);
            this.tbcSetting.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbcSetting.Location = new System.Drawing.Point(8, 16);
            this.tbcSetting.Name = "tbcSetting";
            this.tbcSetting.SelectedIndex = 0;
            this.tbcSetting.Size = new System.Drawing.Size(392, 240);
            this.tbcSetting.TabIndex = 0;
            // 
            // tabColorFont
            // 
            this.tabColorFont.Controls.Add(this.btnReset);
            this.tabColorFont.Controls.Add(this.btnFont);
            this.tabColorFont.Controls.Add(this.btnBackColor);
            this.tabColorFont.Controls.Add(this.txtPreview);
            this.tabColorFont.Controls.Add(this.lblPreview);
            this.tabColorFont.Location = new System.Drawing.Point(4, 27);
            this.tabColorFont.Name = "tabColorFont";
            this.tabColorFont.Padding = new System.Windows.Forms.Padding(3);
            this.tabColorFont.Size = new System.Drawing.Size(384, 209);
            this.tabColorFont.TabIndex = 0;
            this.tabColorFont.Text = "色とフォント";
            this.tabColorFont.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(256, 128);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "リセット(&R)...";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(256, 88);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(95, 23);
            this.btnFont.TabIndex = 3;
            this.btnFont.Text = "フォント(&F)...";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(256, 48);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(95, 23);
            this.btnBackColor.TabIndex = 2;
            this.btnBackColor.Text = "背景色(&B)...";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // txtPreview
            // 
            this.txtPreview.BackColor = System.Drawing.Color.Black;
            this.txtPreview.ForeColor = System.Drawing.Color.White;
            this.txtPreview.Location = new System.Drawing.Point(16, 40);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.Size = new System.Drawing.Size(232, 128);
            this.txtPreview.TabIndex = 1;
            this.txtPreview.Text = "12345";
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(16, 16);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(85, 18);
            this.lblPreview.TabIndex = 0;
            this.lblPreview.Text = "プレビュー(&P)";
            // 
            // tabEtc
            // 
            this.tabEtc.Controls.Add(this.gbxTransparency);
            this.tabEtc.Location = new System.Drawing.Point(4, 27);
            this.tabEtc.Name = "tabEtc";
            this.tabEtc.Padding = new System.Windows.Forms.Padding(3);
            this.tabEtc.Size = new System.Drawing.Size(384, 209);
            this.tabEtc.TabIndex = 1;
            this.tabEtc.Text = "全般";
            this.tabEtc.UseVisualStyleBackColor = true;
            // 
            // gbxTransparency
            // 
            this.gbxTransparency.Controls.Add(this.lblTransparency);
            this.gbxTransparency.Controls.Add(this.label2);
            this.gbxTransparency.Controls.Add(this.label1);
            this.gbxTransparency.Controls.Add(this.tkbTransparency);
            this.gbxTransparency.Location = new System.Drawing.Point(8, 8);
            this.gbxTransparency.Name = "gbxTransparency";
            this.gbxTransparency.Size = new System.Drawing.Size(320, 96);
            this.gbxTransparency.TabIndex = 0;
            this.gbxTransparency.TabStop = false;
            this.gbxTransparency.Text = "透明度";
            // 
            // lblTransparency
            // 
            this.lblTransparency.AutoSize = true;
            this.lblTransparency.Enabled = false;
            this.lblTransparency.Location = new System.Drawing.Point(144, 72);
            this.lblTransparency.Name = "lblTransparency";
            this.lblTransparency.Size = new System.Drawing.Size(0, 18);
            this.lblTransparency.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "255";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // tkbTransparency
            // 
            this.tkbTransparency.Location = new System.Drawing.Point(16, 24);
            this.tkbTransparency.Name = "tkbTransparency";
            this.tkbTransparency.Size = new System.Drawing.Size(272, 45);
            this.tkbTransparency.TabIndex = 0;
            this.tkbTransparency.Scroll += new System.EventHandler(this.tkbTransparency_Scroll);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOK.Location = new System.Drawing.Point(144, 264);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnApply.Location = new System.Drawing.Point(232, 264);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(80, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "適用";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCancel.Location = new System.Drawing.Point(320, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SettingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(416, 306);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbcSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "もー帳の設定";
            this.Load += new System.EventHandler(this.SettingDialog_Load);
            this.tbcSetting.ResumeLayout(false);
            this.tabColorFont.ResumeLayout(false);
            this.tabColorFont.PerformLayout();
            this.tabEtc.ResumeLayout(false);
            this.gbxTransparency.ResumeLayout(false);
            this.gbxTransparency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTransparency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TabControl tbcSetting;
        private System.Windows.Forms.TabPage tabColorFont;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabPage tabEtc;
        private System.Windows.Forms.GroupBox gbxTransparency;
        private System.Windows.Forms.Label lblTransparency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tkbTransparency;
    }
}