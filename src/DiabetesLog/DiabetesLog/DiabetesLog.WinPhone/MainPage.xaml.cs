﻿using Microsoft.Phone.Controls;

namespace Cleveland.DotNet.Sig.DiabetesLog.WinPhone
{
    public partial class MainPage : global::Xamarin.Forms.Platform.WinPhone.FormsApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
            SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new Cleveland.DotNet.Sig.DiabetesLog.App());
        }
    }
}
