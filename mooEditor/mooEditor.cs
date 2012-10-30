using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace mooEditor
{
    public partial class mooEditor : Form
    {
        #region 定数
        private const string TITLE_EXTN_READONLY = "(読み取り専用)";
        private const string MSGBOX_TITLE_OPEN = "開く";
        private const string MSGBOX_TITLE_SAVE = "上書きするも～";
        private const string NEW_FILE_NAME = "new.moo";
        private const string MSGBOX_TITLE_SAVE_AS = "名前を付けて保存";
        private const string MSGBOX_TITLE_CLOSE = "閉じる";
        private const string MSG_FILE_SAVE = "を保存するかも～？";
        private const string MSGBOX_TITLE_EXIT = "も-帳の終了";
        private const string MSG_BOX_STRING = "今のファイルはすてますよ。\n\nよかかも～?";

        #endregion


        private List<PageInfo> pi = new List<PageInfo>();

        private string _editFilePath = string.Empty;

        private findDialog _findDlg = null;
        private JumpDialog _jumpDlg = null;
        private SettingDialog _settingDlg = null;
        
        private static mooEditor _instance = null;
        public static mooEditor Instance
        {
            get
            {
                if (null == _instance)
                {
                    _instance = new mooEditor();
                }
                return _instance;
            }
        }

        // 編集状態のページ
        private TextBox _activeEditor;
        public TextBox ActiveEditor
        {
            get
            {
                return _activeEditor;
            }
            set
            {
                _activeEditor = value;
            }
        }
  
        // コンストラクタ
        public mooEditor()
        {
            InitializeComponent();
            createNewTabPage("new1");
            //ActiveEditor = txtEditor;
            
        }


        #region ファイル
        /// <summary>
        /// 新規作成
        /// </summary>
        private void fileNew_Click(object sender, EventArgs e)
        {
            createNewTabPage("");
        }     
 
        /// <summary>
        /// 開く
        /// </summary>
        private void fileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog(this);
        }

        /// <summary>
        /// ファイル選択処理
        /// </summary>
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            _editFilePath = openFileDialog.FileName;
            int index = tabEditor.SelectedIndex;

            // 読み取り専用チェック
            //_readOnlyFlags[index] = openFileDialog.ReadOnlyChecked;
            pi[index].ReadOnlyFlag = openFileDialog.ReadOnlyChecked;
            if (true == pi[index].ReadOnlyFlag)
            {
                this.Text = openFileDialog.SafeFileName + TITLE_EXTN_READONLY;                
            }
            else
            {
                this.Text = openFileDialog.SafeFileName;
            }           

            try
            {
                createNewTabPage(_editFilePath, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, MSGBOX_TITLE_OPEN,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 上書き保存
        /// </summary>
        private void fileSave_Click(object sender, EventArgs e)
        {           

            if (File.Exists(_editFilePath))
            {
                try
                {
                    File.WriteAllText(_editFilePath, this.ActiveControl.Text, Encoding.Default);
                    //setDirty(false);
                    setDirty(false, tabEditor.SelectedIndex);
                    
                    showSaveDateTime();
                }
                catch (Exception ex)
                {
                    //ファイルの書き込みでエラーが発生した場合に Exception の内容を表示
                    MessageBox.Show(this, ex.Message, MSGBOX_TITLE_SAVE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string MSG_BOX_STRING = "ファイル\"" + _editFilePath + 
                    "\" のパスは正しくありません。\n\nディレクトリが存在するか確認してください。";
                MessageBox.Show(MSG_BOX_STRING, MSGBOX_TITLE_SAVE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// 名前を付けて保存
        /// </summary>
        private void fileNewSave_Click(object sender, EventArgs e)
        {
            saveFileAs();
        }

        /// <summary>
        /// ﾌﾙﾊﾟｽからファイル名のみ取得
        /// </summary>
        private string getFileNameString(string filePath, char separateChar)
        {
            try
            {
                string[] strArray = filePath.Split(separateChar);
                return strArray[strArray.Length - 1];
            }
            catch
            { return ""; }
        }

        /// <summary>
        /// ファイル保存ダイアログでOK
        /// </summary>
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            _editFilePath = saveFileDialog.FileName;

            try
            {
                // ファイルの書き込み
                File.WriteAllText(_editFilePath, this.ActiveControl.Text, Encoding.Default);
                this.Text = getFileNameString(_editFilePath, '\\');

                // ダーティーフラグのリセット
                //setDirty(false);
                setDirty(false, tabEditor.SelectedIndex);

                // ステータスバーに保存日時を表示
                showSaveDateTime();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, MSGBOX_TITLE_SAVE_AS, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 閉じる
        /// </summary>
        private void fileClose_Click(object sender, EventArgs e)
        {
            if (tabEditor.TabCount == 1)
            {
                return;
            }
            
            switch(MessageBox.Show(this, tabEditor.SelectedTab.Name + MSG_FILE_SAVE,
                MSGBOX_TITLE_CLOSE, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information))
            {
                case System.Windows.Forms.DialogResult.Yes:
                   // 保存処理
                    string fileNameString = getFileNameString(_editFilePath, '\\');

                    if ("" == fileNameString)
                    {
                        saveFileDialog.FileName = NEW_FILE_NAME;
                    }
                    else
                    {
                        saveFileDialog.FileName = fileNameString;
                    }
                    saveFileDialog.ShowDialog(this);

                    // 閉じる
                    tabEditor.TabPages.Remove(tabEditor.SelectedTab);                
                    break;

                case System.Windows.Forms.DialogResult.No:
                    tabEditor.TabPages.Remove(tabEditor.SelectedTab);                
                    break;

                case System.Windows.Forms.DialogResult.Cancel:
                    break;
            }
        }
        /// <summary>
        /// 全て閉じる
        /// </summary>
        private void appExit_Click(object sender, EventArgs e)
        {
            foreach (TabPage tp in tabEditor.TabPages)
            {
                tp.Select();
                if (!confirmDestructionText(MSGBOX_TITLE_EXIT))
                {
                    // ファイル保存処理
                    saveFileAs();
                }
            }
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// 印刷
        /// </summary>
        private void filePrint_Click(object sender, EventArgs e)
        {
            printDialog.ShowDialog(this);
        }

        

        #endregion

        #region 共通部 ファイル
        /// <summary>
        /// ダーティーフラグと [上書き(&S)] メニューアイテム有効/無効の処理
        /// </summary>
        /// <param name="flag"></param>
        private void setDirty(bool flag, int index)
        {
            //_dirtyFlags[index] = flag;
            pi[index].DirtyFlag = flag;
            
            //読み取り専用でファイルがオープンされている場合、
            //[上書き(&S)] メニューアイテムは常に無効
            //fileSave.Enabled = (_readOnlyFlags[index]) ? false : flag;
            fileSave.Enabled = (pi[index].ReadOnlyFlag) ? false : flag;
        }

        /// <summary>
        /// ページ作成 カスタマイズメソッド
        /// </summary>        
        private void createNewTabPage(string tabTitel)
        {
            createNewTabPage(tabTitel, false);
        }

        /// <summary>
        /// ページ作成 基本メソッド
        /// </summary>
        /// <param name="tabTitle"></param>
        /// <param name="flag"></param>
        private void createNewTabPage(string tabTitle, bool flag)
        {
            TabPage newTab = new TabPage(tabTitle);
            TextBox editor = new TextBox();
            Label row = new Label();

            this.SuspendLayout();

            newTab.BorderStyle = BorderStyle.Fixed3D;

            row.BackColor = Color.DimGray;
            row.ForeColor = Color.DeepSkyBlue;
            row.AutoSize = false;
            row.TextAlign = ContentAlignment.TopCenter;
            row.Size = new System.Drawing.Size(32, 448);
            row.Location = new Point(0, 0);
            row.BorderStyle = BorderStyle.None;
            
            editor.BackColor = Color.Black;
            editor.ForeColor = Color.White;
            editor.Size = new System.Drawing.Size(784, 448);
            editor.Location = new Point(32, 0);
            editor.BorderStyle = BorderStyle.None;
            editor.Multiline = true;
            editor.TextChanged += new EventHandler(editor_TextChanged);

            // 開くの場合
            if (true == flag)
            {
                newTab.Name = Path.GetFileNameWithoutExtension(_editFilePath);
                newTab.Text = this.Text;
                row.Name = "lblRow" + Path.GetFileNameWithoutExtension(_editFilePath);
                editor.Name = "txtEditor" + Path.GetFileNameWithoutExtension(_editFilePath);
                editor.Text = File.ReadAllText(tabTitle, Encoding.Default);
                // 論理行番号取得
                int cnt = editor.Lines.Length;
                for (int i = 0; i < cnt; i++)
                {
                    row.Text += (i + 1).ToString() + "\r\n";
                }
                // マウス位置を最後にもってくる
                editor.Select(editor.Text.Length, 0);

            }
            // 新規作成の場合
            else
            {
                string tabNewTitle = "new" + (tabEditor.TabCount + 1).ToString();
                newTab.Name = "tab" + tabNewTitle;
                newTab.Text = tabNewTitle;
                row.Name = "lblRow" + (tabEditor.TabCount + 1).ToString();
                row.Text = "1\r\n";
                editor.Name = "txtEditor" + (tabEditor.TabCount + 1).ToString();
#warning  ここ注意バグ温床かも
                _editFilePath = "";
            }

            // コントロール追加
            tabEditor.TabPages.Add(newTab);
            newTab.Controls.Add(row);
            newTab.Controls.Add(editor);            

            // 追加したタブをアクティブにする
            tabEditor.SelectedTab = tabEditor.TabPages[newTab.Name];
            ActiveEditor = editor;
            ActiveControl = editor;

            pi.Add(new PageInfo(newTab.Name, row.Name, editor.Name));                      

            // タブ選択でテキストボックスをアクティブにする
            tabEditor.Selected += new TabControlEventHandler(tabEditor_Selected);

            // 論理行番号を表示する            
            editor.KeyUp += new KeyEventHandler(editor_KeyUp);

            this.ResumeLayout(false);            

        }

        /// <summary>
        /// 論理行番号の表示
        /// </summary>
        void editor_KeyUp(object sender, KeyEventArgs e)
        {
            Control[] editor = null;
            Control[] row = null;
            for (int i = 0; i < pi.Count; i++)
            {
                if (pi[i].EditorName == ActiveControl.Name)
                {
                    editor = this.Controls.Find(pi[i].EditorName, true);
                    if (editor.Length > 0)
                    {
                        row = this.Controls.Find(pi[i].RowNoName, true);
                        break;
                    }
                    else
                    {
                        break;
                    }
                }                

            }

            if (row.Length > 0)
            { 
                switch (e.KeyCode)
                {
                    // 増えていくほう
                    case Keys.Enter:
                        row[0].Text += ((TextBox)editor[0]).Lines.Length.ToString() + "\r\n";
                        break;

                    // 減っていくほう
                    case Keys.Back:
                        break;

                    default:
                        break;
                }                
            }
        }

        private void setMouseControl()
        {

        }
 
        /// <summary>
        /// 他のタブを選択したときにアクティブタブの入れ替え
        /// </summary>
        void tabEditor_Selected(object sender, TabControlEventArgs e)
        { 
            for(int i = 0; i < pi.Count; i++)
            {
                if(pi[i].TabName == e.TabPage.Name)
                {
                    Control[] c = this.Controls.Find(pi[i].EditorName, true);
                    if (c.Length > 0)
                    {
                        ActiveControl = c[0];
                        ActiveEditor = (TextBox)c[0];
                    }
                    break;
                }
            }
        }
 

        /// <summary>
        /// 上書き保存できるように
        /// </summary>
        void editor_TextChanged(object sender, EventArgs e)
        {
            // 何らかの編集をした場合
            //setDirty(true);
            setDirty(true, tabEditor.SelectedIndex);
        }
        private void txtEditor_TextChanged(object sender, EventArgs e)
        {
            //setDirty(true);
            setDirty(true, tabEditor.SelectedIndex);
        }

 


        /// <summary>
        /// ステータスバーに保存日時を表示する
        /// </summary>
        private void showSaveDateTime()
        {
            const string STATUS_STRING = "に、もー帳で保存したも～";

            //ステータスバー上のラベルに表示
            toolStripStatusLabel.Text = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + STATUS_STRING;
        }

        /// <summary>
        /// 保存していない編集中のテキストがある場合に確認
        /// </summary>
        /// <param name="msgBoxTitle"></param>
        /// <returns></returns>
        private bool confirmDestructionText(string msgBoxTitle)
        {
            if(!pi[tabEditor.SelectedIndex].DirtyFlag)
            //if(!_dirtyFlags[tabEditor.SelectedIndex])
            {
                return true;
            }
            return (MessageBox.Show(MSG_BOX_STRING, msgBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }

        /// <summary>
        /// 名前を付けて保存処理
        /// </summary>
        private void saveFileAs()
        {
            string fileNameString = getFileNameString(_editFilePath, '\\');

            if ("" == fileNameString)
            {
                saveFileDialog.FileName = NEW_FILE_NAME;
            }
            else
            {
                saveFileDialog.FileName = fileNameString;
            }
            saveFileDialog.ShowDialog(this);
        }
        #endregion

        #region 編集

        /// <summary>
        /// 元に戻す
        /// </summary>
        private void editUndo_Click(object sender, EventArgs e)
        {
            if (ActiveEditor.CanUndo)
            {
                ActiveEditor.Undo();
                ActiveEditor.ClearUndo();
            }
            
        }

        /// <summary>
        /// 切り取り
        /// </summary>
        private void editCut_Click(object sender, EventArgs e)
        {
            if ("" != ActiveEditor.SelectedText)
            {
                ActiveEditor.Cut();
            }
        }

        /// <summary>
        /// コピー
        /// </summary>
        private void editCopy_Click(object sender, EventArgs e)
        {
            if ("" != ActiveEditor.SelectedText)
            {
                ActiveEditor.Copy();
            }
        }

        /// <summary>
        /// 貼り付け
        /// </summary>
        private void editPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                ActiveEditor.Paste();
            }
        }

        /// <summary>
        /// 検索
        /// </summary>
        private void editFind_Click(object sender, EventArgs e)
        {            
            //二重起動を防止
            if (null == _findDlg || _findDlg.IsDisposed)
            {
                //検索ダイアログボックス用フォームのインスタンスを生成
                _findDlg = new findDialog(dialogMode.Find, ActiveEditor);
                _findDlg.Show(this);
            }
        }

        /// <summary>
        /// 置換え
        /// </summary>
        private void editReplace_Click(object sender, EventArgs e)
        {
            //二重起動を防止
            if (null == _findDlg || _findDlg.IsDisposed)
            {
                //検索ダイアログボックス用フォームのインスタンスを生成
                _findDlg = new findDialog(dialogMode.Replace, ActiveEditor);
                _findDlg.Show(this);
            }
        }

        /// <summary>
        /// 行へ移動
        /// </summary>
        private void editJump_Click(object sender, EventArgs e)
        {
            if (_jumpDlg == null || _jumpDlg.IsDisposed)
            {
                _jumpDlg = new JumpDialog(ActiveEditor);
                _jumpDlg.ShowDialog(this);
            }

        }

        #region ﾄﾞﾗｯｸﾞ＆ﾄﾞﾛｯﾌﾟ
        #endregion

        /// <summary>
        /// 全て選択
        /// </summary>
        private void editAllSelect_Click(object sender, EventArgs e)
        {
            ActiveEditor.SelectAll();         
        }

        #endregion

        #region 設定
        /// <summary>
        /// 環境設定クリック
        /// </summary>
        private void settingEnvironment_Click(object sender, EventArgs e)
        {
            if (null == _settingDlg || _settingDlg.IsDisposed)
            {
                _settingDlg = new SettingDialog(ActiveEditor);
                _settingDlg.ShowDialog(this);
            }
        }
        
        #endregion

        /// <summary>
        /// フォームロートしたとき
        /// </summary>
        private void mooEditor_Load(object sender, EventArgs e)
        {
            loadSetting();
        }

        /// <summary>
        /// 状態の取り出し
        /// </summary>
        private void loadSetting()
        {
            //ユーザーにより値が設定されないうちはアプリケーション情報をロードしない
            if (Properties.Settings.Default.Initialized)
            {
                this.Height = Properties.Settings.Default.Height;
                this.Width = Properties.Settings.Default.Width;
                this.Top = Properties.Settings.Default.Top;
                this.Left = Properties.Settings.Default.Left;
                //txtEditor.Font = Properties.Settings.Default.Font;
                //txtEditor.BackColor = Properties.Settings.Default.BackGroundColor;
                //txtEditor.ForeColor = Properties.Settings.Default.ForeColor;
                //txtRowNo.Font = Properties.Settings.Default.Font;
            }
        }

        /// <summary>
        /// アプリケーション情報の読み出しと保存
        /// </summary> 
        private void mooEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (confirmDestructionText(MSGBOX_TITLE_EXIT))
            {
                saveSetting();
                this.Dispose();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 状態の保存
        /// </summary>
        private void saveSetting()
        {
            Properties.Settings.Default["Height"] = this.Height;
            Properties.Settings.Default["Width"] = this.Width;
            Properties.Settings.Default["Top"] = this.Top;
            Properties.Settings.Default["Left"] = this.Top;
            Properties.Settings.Default["Font"] = ActiveEditor.Font;
            Properties.Settings.Default["BackGroundColor"] = ActiveEditor.BackColor;
            Properties.Settings.Default["Initialized"] = true;
            Properties.Settings.Default.Save();
        }
        /// <summary>
        /// 全てのコントロールを取得する
        /// </summary>
        /// <param name="top">探したい最上位コントロール</param>
        /// <returns></returns>
        private Control[] getAllControls(Control top)
        {
            ArrayList buf = new ArrayList();
            foreach (Control c in top.Controls)
            {
                buf.Add(c);
                buf.AddRange(getAllControls(c));
            }
            return (Control[])buf.ToArray(typeof(Control));
        } 

 

        


    }
}
// EOF
