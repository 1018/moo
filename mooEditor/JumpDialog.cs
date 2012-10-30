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
    public partial class JumpDialog : Form
    {
        private const string MSG_INVALI_LINE = "行番号が範囲外だも～。";
        private TextBox _textBox;

        public JumpDialog()
        {
            InitializeComponent();
        }

        public JumpDialog(TextBox txtBox)
        {
            InitializeComponent();
            _textBox = txtBox;
        }

        // ダイアログボックスのロード
        private void JumpDialog_Load(object sender, EventArgs e)
        {
            txtRowNo.Text = getCurrentLineNumber().ToString();
            txtRowNo.SelectAll();
            txtRowNo.Focus();
        }

        // キャンセルボタンクリック
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        // OKボタンクリック
        private void btnOK_Click(object sender, EventArgs e)
        {
            string[] lineArray = _textBox.Text.Split('\n');
            int jumpPoint = int.Parse(txtRowNo.Text) - 1;
            int lineCount = lineArray.Length;
            int lastLength = 0;
            if (lineCount < jumpPoint)
            {
                MessageBox.Show(MSG_INVALI_LINE, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; jumpPoint >= i; i++)
            {
                lastLength = lineArray[i].Length;
                sb.Append(lineArray[i]);
            }
            _textBox.SelectionStart = sb.ToString().Length - (lastLength - jumpPoint);
            _textBox.Focus();
            this.Close();
            this.Dispose();
        }

        //処理対象となる TextBox のインスタンス設定するためのプロパティ
        public TextBox textBox
        {
            get
            {
                return _textBox;
            }
            set
            {
                _textBox = value;
            }
        }

        private int getCurrentLineNumber()
        {
            int currentPoint = _textBox.SelectionStart;
            string editString = _textBox.Text.Substring(0, currentPoint);
            return editString.Split('\n').Length;
        }

    }
}
