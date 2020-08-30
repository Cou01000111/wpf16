using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp16
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 一覧設定ファイルパス存在チェック
        /// </summary>
        /// <returns>設定が有効ならtrue</returns>
        private bool IsExistsSaveConfigPath()
        {
            if(string.IsNullOrWhiteSpace(Properties.Settings.Default.SaveConfigPath) ||
                System.IO.File.Exists(Properties.Settings.Default.SavaConfigPath) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

}
