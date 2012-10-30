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
    public partial class SettingDialog : Form
    {
        //処理対象となる TextBox のインスタンスを保持
        private TextBox _textBox;

        public SettingDialog()
        {
            InitializeComponent();
        }

        public SettingDialog(TextBox txtBox)
        {
            InitializeComponent();
            _textBox = txtBox;
        }

        #region property

        //処理対象となる TextBox のインスタンス設定するためのプロパティ
        public TextBox textBox
        {
            get { return _textBox; }
            set { _textBox = value; }
        }

        #endregion

        #region eventHandler
        /// <summary>
        /// ダイアログボックスロード
        /// </summary>
        private void SettingDialog_Load(object sender, EventArgs e)
        {
            txtPreview.ForeColor = _textBox.ForeColor;
            txtPreview.BackColor = _textBox.BackColor;
            txtPreview.Font = _textBox.Font;
            tkbTransparency.Minimum = 0;
            tkbTransparency.Maximum = 255;
        }
        
        /// <summary>
        /// [背景色]ボタンクリック
        /// </summary>
        private void btnBackColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = txtPreview.ForeColor;
            colorDialog.ShowDialog(this);
            txtPreview.BackColor = colorDialog.Color;
        }

        /// <summary>
        /// [フォント]ボタンクリック
        /// </summary>
        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog.Color = txtPreview.ForeColor;
            fontDialog.Font = txtPreview.Font;
            fontDialog.ShowDialog(this);
            txtPreview.Font = fontDialog.Font;
            txtPreview.ForeColor = fontDialog.Color;
        }

        /// <summary>
        /// [リセット]ボタンクリック
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            txtPreview.Font = Properties.Settings.Default.Font;
            txtPreview.BackColor = Properties.Settings.Default.BackGroundColor;
            txtPreview.ForeColor = Properties.Settings.Default.ForeColor;
            this.Opacity = Properties.Settings.Default.Opacity;
        }

        /// <summary>
        /// トラックバーのスライダー位置をラベルに表示
        /// </summary>
        private void tkbTransparency_Scroll(object sender, EventArgs e)
        {
            lblTransparency.Enabled = true;
            lblTransparency.Text = tkbTransparency.Value.ToString();
        }

        /// <summary>
        /// OKボタンクリック
        /// </summary> 
        private void btnOK_Click(object sender, EventArgs e)
        {
            saveSettings();
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// 適用ボタンクリック
        /// </summary>
        private void btnApply_Click(object sender, EventArgs e)
        {
            saveSettings();
        }

        /// <summary>
        /// キャンセルボタンクリック
        /// </summary>  
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        #endregion

        /// <summary>
        /// ダイアログでの設定を保存
        /// </summary>
        private void saveSettings()
        {
            _textBox.Font = txtPreview.Font;
            _textBox.BackColor = txtPreview.BackColor;
            _textBox.ForeColor = txtPreview.ForeColor;
            this.Opacity = tkbTransparency.Value;

            Properties.Settings.Default["Font"] = txtPreview.Font;
            Properties.Settings.Default["BackGroundColor"] = txtPreview.BackColor;
            Properties.Settings.Default["ForeColor"] = txtPreview.ForeColor;
            Properties.Settings.Default["Opacity"] = tkbTransparency.Value;
            Properties.Settings.Default.Save();
        }




    }
}
