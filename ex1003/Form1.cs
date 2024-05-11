using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form frmdialog = new Form(); // 創建一個新的表單物件並賦值給frmdialog變數
            frmdialog.Text = "新建表單 -- 對話方塊樣式"; // 設置表單的標題文字

            Button btnCancle = new Button(); // 創建一個新的按鈕物件
            btnCancle.Font = new Font("微軟正黑體", 12); // 設置按鈕的字體
            btnCancle.AutoSize = true; // 設置按鈕自動調整大小以適應文本內容
            btnCancle.Text = "取消"; // 設置按鈕的文字內容
            btnCancle.Location = new Point(70, 80); // 設置按鈕的位置

            frmdialog.FormBorderStyle = FormBorderStyle.FixedDialog; // 設置表單的邊框樣式
            frmdialog.Opacity = 0.85; // 設置表單的不透明度
            frmdialog.AutoSize = true; // 設置表單自動調整大小模式
            frmdialog.AutoSizeMode = AutoSizeMode.GrowOnly;
            frmdialog.MaximizeBox = false; // 設置表單的最大化按鈕是否可用
            frmdialog.MinimizeBox = false; // 設置表單的最小化按鈕是否可用
            frmdialog.CancelButton = btnCancle; // 設置表單的取消按鈕為btnCancle
            frmdialog.StartPosition = FormStartPosition.CenterScreen; // 設置表單的起始位置為屏幕中央

            frmdialog.Controls.Add(btnCancle); // 將按鈕添加到表單的控件集合中
            frmdialog.ShowDialog(); // 顯示對話框表單
        }

    }
}
