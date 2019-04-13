﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using static 倒计时.App;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace 倒计时
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class All : Page
    {
        public CustomDataViewModel ViewModel = new CustomDataViewModel();
        private string str1, str2, str3;
        public double MyNavCMTW = MainPage.Current.MyNav.CompactModeThresholdWidth;
        public static All Current;

        public All()
        {
            this.InitializeComponent();
            Current = this;
            
            Today.Text= DateTime.Now.ToShortDateString().ToString();
            TopText.Text = "今年你已经走过了" + DateTime.Now.DayOfYear.ToString() + "天啦！";
            MyProgressBar.Value = 100 * (DateTime.Now.DayOfYear / MyProgressBar.Width);
            //Date1.Text = Calculator(StartName1.Text);
            //Date2.Text = Calculator(StartName2.Text);
            //Date3.Text = Calculator(StartName3.Text);
            //Date4.Text = Calculator(StartName4.Text);
        }

        private string Calculator(string s1)
        {
            string str1 = s1;
            string str2 = DateTime.Now.ToShortDateString().ToString();
            string s2;
            DateTime d1 = Convert.ToDateTime(str1);
            DateTime d2 = Convert.ToDateTime(str2);
            DateTime d3 = Convert.ToDateTime(string.Format("{0}/{1}/{2}", d1.Year, d1.Month, d1.Day));
            DateTime d4 = Convert.ToDateTime(string.Format("{0}/{1}/{2}", d2.Year, d2.Month, d2.Day));
            int days = (d4 - d3).Days;
            if (days < 0)
            {
                days = -days;
                s2 = "还有" + days.ToString() + "天";
            }
            else
                s2 = "已过" + days.ToString() + "天";
            return s2;
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Add));
        }

        private void MyGirdView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void MyGirdView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var selectedItems = MyListView.Items.Cast<ListViewItem>()
            //    .Where(p => p.IsSelected)
            //    .Select(t => t.Content.ToString())
            //    .ToArray();
            var wid = MyGirdView.Width;
            TopText.Text = wid.ToString();
        }

        private void MyListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(Add));
        }
    }
}
