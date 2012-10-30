using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mooEditor
{
    //[検索]用、[置換]用の列挙型(フラグ用)
    public enum dialogMode
    {
        Find,
        Replace
    }

    public partial class findDialog : Form
    {
        private const string MSGBOX_STRING = "ドキュメントの最後まで検索しました。\nもう一度先頭から検索しますか?";
        private TextBox _textBox;

        // [検索]用のダイアログボックスを表示するか、
        // [置換]用のダイアログボックスを表示するかのフラグ
        private dialogMode _mode;

        private int _findStartIndex = 0;
        private int _findCount = 0;
        private string _dialogTitle = "";

        #region コンストラクタ
        public findDialog()
        {
            InitializeComponent();
        }

        public findDialog(TextBox txtBox)
        {
            InitializeComponent();
            _textBox = txtBox;
        }

        public findDialog(dialogMode mode)
        {
            InitializeComponent();
            Mode = mode;
        }

        public findDialog(dialogMode mode, TextBox txtBox)
        {
            InitializeComponent();
            _textBox = txtBox;
            Mode = mode;
        }
        #endregion

        /// <summary>
        /// キャンセルボタンクリック
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// [次を検索]ボタンクリック
        /// </summary>
        private void btnFindNext_Click(object sender, EventArgs e)
        {
            btnReplaceNext.Enabled = execFind();
        }

        /// <summary>
        /// [置換して次に]ボタンクリック
        /// </summary>
        private void btnReplaceNext_Click(object sender, EventArgs e)
        {
            if (_textBox.SelectionLength > 0)
            {
                _textBox.SelectedText = txtReplace.Text;
            }
            btnReplaceNext.Enabled = execFind();

        }

#warning これ意味不明！！        
        //検索開始位置ラジオボタンの処理
        private void findPosition_Radio_CheckedChanged(object sender, EventArgs e)
        {
            //対応するラジオボタンの常に反対の値を設定
            rdbTopPosition.Checked = (rdbCurrentPosition.Checked != true);
        }

        #region Method
        /// <summary>
        /// 検索処理
        /// </summary>
        /// <returns></returns>
        private bool execFind()
        {
            // コントロール内の文字列
            string editString = _textBox.Text;

            // 検索を行う文字列
            string findString = txtFind.Text;

            // 検索を行う文字列の長さ
            int findStringLength = findString.Length;

            // 検索開始位置が先頭 = 0を設定
            int findPoint = (rdbTopPosition.Checked) ? 0 : _textBox.SelectionStart;

            // 2回目以降の検索位置の指定
            _findStartIndex = (_findStartIndex == 0) ? findPoint : _findStartIndex;

            // 検索処理
            findPoint = editString.IndexOf(findString, _findStartIndex, (cbxCaseSensitivityOn.Checked) ?
                StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase);

            // 検索する文字列が見つからなかった場合
            if(-1 == findPoint)
            {
                string nothingWord = "\"" + findString + "\"はみつからないも～";
                if(0 != _findCount)
                {
                    if(MessageBox.Show(this, MSGBOX_STRING, _dialogTitle, 
                        MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        resetFindPosition();
                    }
                    else
                    {
                        this.Close();
                        this.Dispose();
                    }
                }                
                else
                {
                    if(rdbCurrentPosition.Checked)
                    {
                        string msbString = "現在位置から" + MSGBOX_STRING;
                        if(MessageBox.Show(this, msbString, _dialogTitle,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            resetFindPosition();
                        }
                        else
                        {
                            this.Close();
                            this.Dispose();
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, nothingWord,_dialogTitle,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
    
                }
                return false;
            }
            else
            {
                // 見つかった文字を選択
                _textBox.Select(findPoint, findStringLength);

                //TextBox が選択された文字列を表示するようキャレットを移動
                _textBox.ScrollToCaret(); 

                //[次を検索] ボタンをクリックされた際の検索開始位置を設定
                _findStartIndex = findPoint + findStringLength;

                //検索がヒットした回数をカウント
                _findCount++;

                //テキストボックスにフォーカスをあてる
                _textBox.Focus();
                return true;
            }
        }

        /// <summary>
        /// 検索位置をリセット
        /// </summary>
        private void resetFindPosition()
        {
            _findStartIndex = 0;
            _findCount = 0;
            _textBox.SelectionStart = 0;
            _textBox.Select(0, 0);
            _textBox.Focus();
        }

        #endregion

        #region property
        //処理対象となる TextBox のインスタンス設定するためのプロパティ
        public TextBox textBox
        {
            get { return _textBox; }
            set { _textBox = value; }
        }

        //[検索]用のダイアログボックスを表示するか、
        //[置換用のダイアログボックス]を表示するかのプロパティ
        public dialogMode Mode
        {
            get { return _mode; }
            set
            {
                const string DIALOGTITLE_FIND = "検索";
                const string DIALOGTITLE_REPLACE = "置換";
                _mode = value;
                if (_mode == dialogMode.Find)
                {
                    _dialogTitle = DIALOGTITLE_FIND;                    
                    pnlReplace.Visible = false;
                }
                else
                {
                    _dialogTitle = DIALOGTITLE_REPLACE;                    
                    pnlReplace.Visible = true;
                }
                this.Text = _dialogTitle;
            }
        }

        #endregion

    }
}
