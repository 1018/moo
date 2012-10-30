namespace mooEditor
{
    partial class mooEditor
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mooEditor));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNewSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.appExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.filePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.今すぐ印刷ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.editCut = new System.Windows.Forms.ToolStripMenuItem();
            this.editCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.editPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.editFind = new System.Windows.Forms.ToolStripMenuItem();
            this.editFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.editReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.editJump = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.editAllSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.日付と時刻ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.settingEnvironment = new System.Windows.Forms.ToolStripMenuItem();
            this.スタイル設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ステータスSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.もーのお部屋ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ファイラToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.もー帳についてToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabEditor = new System.Windows.Forms.TabControl();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.tmsSetting,
            this.ステータスSToolStripMenuItem,
            this.もーのお部屋ToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(825, 26);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNew,
            this.fileOpen,
            this.fileSave,
            this.fileNewSave,
            this.fileClose,
            this.appExit,
            this.toolStripSeparator1,
            this.filePrint,
            this.今すぐ印刷ToolStripMenuItem,
            this.toolStripSeparator2});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // fileNew
            // 
            this.fileNew.Name = "fileNew";
            this.fileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.fileNew.Size = new System.Drawing.Size(237, 22);
            this.fileNew.Text = "新規作成(&N)";
            this.fileNew.Click += new System.EventHandler(this.fileNew_Click);
            // 
            // fileOpen
            // 
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileOpen.Size = new System.Drawing.Size(237, 22);
            this.fileOpen.Text = "開く(&O)";
            this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click);
            // 
            // fileSave
            // 
            this.fileSave.Name = "fileSave";
            this.fileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileSave.Size = new System.Drawing.Size(237, 22);
            this.fileSave.Text = "上書き保存(&S)";
            this.fileSave.Click += new System.EventHandler(this.fileSave_Click);
            // 
            // fileNewSave
            // 
            this.fileNewSave.Name = "fileNewSave";
            this.fileNewSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.fileNewSave.Size = new System.Drawing.Size(237, 22);
            this.fileNewSave.Text = "名前を付けて保存(&A)";
            this.fileNewSave.Click += new System.EventHandler(this.fileNewSave_Click);
            // 
            // fileClose
            // 
            this.fileClose.Name = "fileClose";
            this.fileClose.Size = new System.Drawing.Size(237, 22);
            this.fileClose.Text = "閉じる";
            this.fileClose.Click += new System.EventHandler(this.fileClose_Click);
            // 
            // appExit
            // 
            this.appExit.Name = "appExit";
            this.appExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.appExit.Size = new System.Drawing.Size(237, 22);
            this.appExit.Text = "全て閉じる(&L)";
            this.appExit.Click += new System.EventHandler(this.appExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(234, 6);
            // 
            // filePrint
            // 
            this.filePrint.Name = "filePrint";
            this.filePrint.Size = new System.Drawing.Size(237, 22);
            this.filePrint.Text = "印刷";
            this.filePrint.Click += new System.EventHandler(this.filePrint_Click);
            // 
            // 今すぐ印刷ToolStripMenuItem
            // 
            this.今すぐ印刷ToolStripMenuItem.Name = "今すぐ印刷ToolStripMenuItem";
            this.今すぐ印刷ToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.今すぐ印刷ToolStripMenuItem.Text = "今すぐ印刷";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(234, 6);
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUndo,
            this.editCut,
            this.editCopy,
            this.editPaste,
            this.toolStripSeparator4,
            this.editFind,
            this.editFindNext,
            this.editReplace,
            this.editJump,
            this.toolStripSeparator3,
            this.editAllSelect,
            this.日付と時刻ToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            // 
            // editUndo
            // 
            this.editUndo.Name = "editUndo";
            this.editUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.editUndo.Size = new System.Drawing.Size(191, 22);
            this.editUndo.Text = "元に戻す(&U)";
            this.editUndo.Click += new System.EventHandler(this.editUndo_Click);
            // 
            // editCut
            // 
            this.editCut.Name = "editCut";
            this.editCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.editCut.Size = new System.Drawing.Size(191, 22);
            this.editCut.Text = "切り取り(&T)";
            this.editCut.Click += new System.EventHandler(this.editCut_Click);
            // 
            // editCopy
            // 
            this.editCopy.Name = "editCopy";
            this.editCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.editCopy.Size = new System.Drawing.Size(191, 22);
            this.editCopy.Text = "コピー(&C)";
            this.editCopy.Click += new System.EventHandler(this.editCopy_Click);
            // 
            // editPaste
            // 
            this.editPaste.Name = "editPaste";
            this.editPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.editPaste.Size = new System.Drawing.Size(191, 22);
            this.editPaste.Text = "貼り付け(&P)";
            this.editPaste.Click += new System.EventHandler(this.editPaste_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(188, 6);
            // 
            // editFind
            // 
            this.editFind.Name = "editFind";
            this.editFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.editFind.Size = new System.Drawing.Size(191, 22);
            this.editFind.Text = "検索(&F)";
            this.editFind.Click += new System.EventHandler(this.editFind_Click);
            // 
            // editFindNext
            // 
            this.editFindNext.Name = "editFindNext";
            this.editFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.editFindNext.Size = new System.Drawing.Size(191, 22);
            this.editFindNext.Text = "次を検索(&N)";
            // 
            // editReplace
            // 
            this.editReplace.Name = "editReplace";
            this.editReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.editReplace.Size = new System.Drawing.Size(191, 22);
            this.editReplace.Text = "置き換え(&R)";
            this.editReplace.Click += new System.EventHandler(this.editReplace_Click);
            // 
            // editJump
            // 
            this.editJump.Name = "editJump";
            this.editJump.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.editJump.Size = new System.Drawing.Size(191, 22);
            this.editJump.Text = "行へ移動(&G)";
            this.editJump.Click += new System.EventHandler(this.editJump_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(188, 6);
            // 
            // editAllSelect
            // 
            this.editAllSelect.Name = "editAllSelect";
            this.editAllSelect.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.editAllSelect.Size = new System.Drawing.Size(191, 22);
            this.editAllSelect.Text = "全て選択(&A)";
            this.editAllSelect.Click += new System.EventHandler(this.editAllSelect_Click);
            // 
            // 日付と時刻ToolStripMenuItem
            // 
            this.日付と時刻ToolStripMenuItem.Name = "日付と時刻ToolStripMenuItem";
            this.日付と時刻ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.日付と時刻ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.日付と時刻ToolStripMenuItem.Text = "日付と時刻";
            // 
            // tmsSetting
            // 
            this.tmsSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingEnvironment,
            this.スタイル設定ToolStripMenuItem});
            this.tmsSetting.Name = "tmsSetting";
            this.tmsSetting.Size = new System.Drawing.Size(62, 22);
            this.tmsSetting.Text = "設定(&T)";
            // 
            // settingEnvironment
            // 
            this.settingEnvironment.Name = "settingEnvironment";
            this.settingEnvironment.Size = new System.Drawing.Size(148, 22);
            this.settingEnvironment.Text = "環境設定";
            this.settingEnvironment.Click += new System.EventHandler(this.settingEnvironment_Click);
            // 
            // スタイル設定ToolStripMenuItem
            // 
            this.スタイル設定ToolStripMenuItem.Name = "スタイル設定ToolStripMenuItem";
            this.スタイル設定ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.スタイル設定ToolStripMenuItem.Text = "スタイル設定";
            // 
            // ステータスSToolStripMenuItem
            // 
            this.ステータスSToolStripMenuItem.Name = "ステータスSToolStripMenuItem";
            this.ステータスSToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.ステータスSToolStripMenuItem.Text = "ステータス(&S)";
            // 
            // もーのお部屋ToolStripMenuItem
            // 
            this.もーのお部屋ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイラToolStripMenuItem});
            this.もーのお部屋ToolStripMenuItem.Name = "もーのお部屋ToolStripMenuItem";
            this.もーのお部屋ToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.もーのお部屋ToolStripMenuItem.Text = "もーのお部屋";
            // 
            // ファイラToolStripMenuItem
            // 
            this.ファイラToolStripMenuItem.Name = "ファイラToolStripMenuItem";
            this.ファイラToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ファイラToolStripMenuItem.Text = "ファイラ";
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ヘルプHToolStripMenuItem1,
            this.もー帳についてToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // ヘルプHToolStripMenuItem1
            // 
            this.ヘルプHToolStripMenuItem1.Name = "ヘルプHToolStripMenuItem1";
            this.ヘルプHToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.ヘルプHToolStripMenuItem1.Text = "ヘルプ(&H)";
            // 
            // もー帳についてToolStripMenuItem
            // 
            this.もー帳についてToolStripMenuItem.Name = "もー帳についてToolStripMenuItem";
            this.もー帳についてToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.もー帳についてToolStripMenuItem.Text = "もー帳について";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 500);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(825, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "もー帳";
            this.notifyIcon.Visible = true;
            // 
            // tabEditor
            // 
            this.tabEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabEditor.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabEditor.Location = new System.Drawing.Point(0, 26);
            this.tabEditor.Name = "tabEditor";
            this.tabEditor.SelectedIndex = 0;
            this.tabEditor.Size = new System.Drawing.Size(824, 478);
            this.tabEditor.TabIndex = 2;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "すべてのファイル|*.*";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // mooEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(825, 522);
            this.Controls.Add(this.tabEditor);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mooEditor";
            this.Text = "もー帳";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mooEditor_FormClosing);
            this.Load += new System.EventHandler(this.mooEditor_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmsSetting;
        private System.Windows.Forms.ToolStripMenuItem ステータスSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem もーのお部屋ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem fileNew;
        private System.Windows.Forms.ToolStripMenuItem fileOpen;
        private System.Windows.Forms.ToolStripMenuItem fileSave;
        private System.Windows.Forms.ToolStripMenuItem fileNewSave;
        private System.Windows.Forms.ToolStripMenuItem fileClose;
        private System.Windows.Forms.ToolStripMenuItem appExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem filePrint;
        private System.Windows.Forms.ToolStripMenuItem 今すぐ印刷ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editUndo;
        private System.Windows.Forms.ToolStripMenuItem editCut;
        private System.Windows.Forms.ToolStripMenuItem editCopy;
        private System.Windows.Forms.ToolStripMenuItem editPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem editFind;
        private System.Windows.Forms.ToolStripMenuItem editFindNext;
        private System.Windows.Forms.ToolStripMenuItem editReplace;
        private System.Windows.Forms.ToolStripMenuItem editJump;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem editAllSelect;
        private System.Windows.Forms.ToolStripMenuItem 日付と時刻ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ファイラToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem もー帳についてToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem settingEnvironment;
        private System.Windows.Forms.ToolStripMenuItem スタイル設定ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabEditor;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.PrintDialog printDialog;
    }
}

