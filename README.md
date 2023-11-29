# WinUI Linear Gauge Getting started

This repository contains sample to getting started with the [SfLinearGauge](https://help.syncfusion.com/winui/linear-gauge/getting-started) control. The WinUI Linear Gauge control is a multipurpose data visualization control that displays numerical values on a linear scale horizontally or vertically.

## Syncfusion controls

This project used the following Syncfusion control(s):
* [Syncfusion WinUI Linear Gauge](https://www.syncfusion.com/winui-controls/linear-gauge)

## Requirements to run the sample

* [Visual Studio](https://visualstudio.microsoft.com/downloads/)
* [Windows App SDK 1.1 extension](https://docs.microsoft.com/en-us/windows/apps/windows-app-sdk/stable-channel#version-11)
* .NET 6.0

Refer to the following link for more details - [System Requirements](https://help.syncfusion.com/winui/system-requirements)

## How to run the sample

1. Clone the sample and open it in Visual Studio.

   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*

2. Register your license key in the App.cs file as demonstrated in the following code.

        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

Refer to this [link](https://help.syncfusion.com/winui/licensing/overview) for more details.

3. Clean and build the application.

4. Run the application.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
