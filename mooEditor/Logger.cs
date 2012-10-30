using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace mooEditor
{
    class Logger
    {
        #region 定数
        private string LOG_FILE_NAME = "mooEditor.log";
        #endregion

        private string _logDirPath;

        /// <summary>
        /// ログ書き込み
        /// </summary>
        public void WriteLog(string msg)
        {
            StreamWriter sw = new StreamWriter(
                getExeAppPath() + LOG_FILE_NAME, true,
                Encoding.GetEncoding(932));

            DateTime dt = System.DateTime.Now;
            if (null != msg)
            {
                sw.WriteLine(dt.ToString("F") + " " + msg);
            }
            else
            {
                sw.WriteLine(dt.ToString("F") + " " + "msg受信失敗");
            }

            sw.Close();
        }



        /// <summary>
        /// 実行ファイルのパスを取得
        /// </summary>
        /// <returns></returns>
        private static string getExeAppPath()
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetEntryAssembly();
            if (asm == null)
                return "";
            else
                return System.IO.Path.GetDirectoryName(asm.Location);
        }
    }
}
