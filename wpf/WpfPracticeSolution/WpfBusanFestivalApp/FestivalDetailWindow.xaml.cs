using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfBusanFestivalApp.Models;

namespace WpfBusanFestivalApp
{
    /// <summary>
    /// FestivalDetailWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class FestivalDetailWindow : MetroWindow
    {
        public FestivalItem? DetailItem { get; }

        public FestivalDetailWindow()
        {
            InitializeComponent();
        }

        public FestivalDetailWindow(FestivalItem? detailItem)
        {
            InitializeComponent();

            DetailItem = detailItem;

            // CS 비하인드코드에 존재하는 데이터를 xaml에서 할당받는 속성
            DataContext = DetailItem;

            // 구글맵은 왼쪽패널이 지도를 가림
            //string url = $"https://map.google.com/?q={detailItem.Lat},{detailItem.Lng}";
            string url = $"https://www.openstreetmap.org/?mlat={detailItem.Lat}&mlon={detailItem.Lng}&zoom=13";
            MapBrowser.Address = url;
        }

    }
}
