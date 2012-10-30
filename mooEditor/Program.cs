using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace mooEditor
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Mutexクラスの作成
            //"MyName"の部分を適当な文字列に変えてください
            System.Threading.Mutex mutex = new System.Threading.Mutex(false, "mooEditor");
            //ミューテックスの所有権を要求する
            if (mutex.WaitOne(0, false) == false)
            {
                //すでに起動していると判断して終了                
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mooEditor());

            //ミューテックスを解放する
            mutex.ReleaseMutex();

        }
    }
}
