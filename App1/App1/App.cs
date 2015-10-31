using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Xamarin.Forms;


namespace App1 {
    public class App : Application {
        public App() {
            MainPage = new MyPage();
        }
    }
    ////////////////////////////////////////////////////
    //
    //  ActivityIndicatorのサンプル
    //
    ////////////////////////////////////////////////////
    class MyPage : ContentPage {
        public MyPage() {
            // ActivityIndicator を生成する
            var ac = new ActivityIndicator {
                Color = Device.OnPlatform(Color.Black, Color.Default, Color.Default), 
                IsRunning = true, // 回転中
                VerticalOptions = LayoutOptions.CenterAndExpand // 中央に配置する
            };
            // ActivityIndicatorのみをコンテンツとして配置する
            Content = ac;
        }
    }
    /*
    ////////////////////////////////////////////////////
    //
    //  BoxViewのサンプル
    //
    ////////////////////////////////////////////////////
    class MyPage : ContentPage {
        public MyPage() {
            // BoxView を生成する
            var boxView = new BoxView {
                Color = Color.Blue,// 塗りつぶし色
                WidthRequest = 150,// 横のサイズ
                HeightRequest = 150,// 縦のサイズ
                HorizontalOptions = LayoutOptions.Center,//中央に配置する（横方向）
                VerticalOptions = LayoutOptions.CenterAndExpand // 中央に配置する（縦方向）
            };

            // BoxViewのみをコンテンツとして配置する
            Content = boxView;
        }
    }
    */
    /*
    ////////////////////////////////////////////////////
    //
    //  Buttonのサンプル
    //
    ////////////////////////////////////////////////////
    class MyPage : ContentPage {
        public MyPage() {
            // Button を生成する
            var button = new Button {
                Text = "Click Me!",
                FontSize = 30,
                HorizontalOptions = LayoutOptions.Center,//中央に配置する（横方向）
                VerticalOptions = LayoutOptions.CenterAndExpand // 中央に配置する（縦方向）
            };
            // クリック時のイベント
            button.Clicked += (s, e) => {
                // ボタンの文字を変更する
                button.Text = "Developers.IO";
            };

            // Buttonのみをコンテンツとして配置する
            Content = button;
        }
    }
    */

    /*
    ////////////////////////////////////////////////////
    //
    // DatePickerのサンプル
    //
    ////////////////////////////////////////////////////
    class MyPage : ContentPage {
        public MyPage() {
            // DatePicker を生成する
            var datePicker = new DatePicker {
                    Format = "D", // 日付表示フォーマット
                VerticalOptions = LayoutOptions.CenterAndExpand // 中央に配置する（縦方向）
            };
            // DatePickerのみをコンテンツとして配置する
            Content = datePicker;
        }
    }
    */

    /*
    ////////////////////////////////////////////////////
    //
    // Editorのサンプル
    //
    ////////////////////////////////////////////////////
    class MyPage : ContentPage {
        public MyPage() {
            // iOSだけ、上部に余白をとる
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            // Editor を生成する
            var editor = new Editor {
                VerticalOptions = LayoutOptions.FillAndExpand // 画面全体に表示する
            };
            
            // Editorのみをコンテンツとして配置する
            Content = editor;
        }
    }
    */
    /*
    ////////////////////////////////////////////////////
    //
    // Entryのサンプル
    //
    ////////////////////////////////////////////////////
    class MyPage : ContentPage {
        public MyPage() {
            // iOSだけ、上部に余白をとる
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            // StackLayoutで2種類の Entryコントロールを並べる
            Content = new StackLayout {
                Children = {
                    new Entry{
                        Keyboard = Keyboard.Email,
                        Placeholder = "メールアドレス",
                    },
                    new Entry{
                        Keyboard = Keyboard.Text,
                        Placeholder = "パスワード",
                        IsPassword = true, // 入力された文字を隠す
                    },
                }
            };

        }
    }
    */
    /*
    ////////////////////////////////////////////////////
    //
    //  Labelのサンプル
    //
    ////////////////////////////////////////////////////
    class MyPage : ContentPage {
        public MyPage() {

            // Labelを生成する
            var label = new Label {
                Text = "Developers.IO",
                FontSize =30,
                HorizontalOptions = LayoutOptions.Center,//中央に配置する（横方向）
                VerticalOptions = LayoutOptions.CenterAndExpand // 中央に配置する（縦方向）
            };
            // Labelのみをコンテンツとして配置する
            Content = label;
        }
    }
    */
    /*
    ////////////////////////////////////////////////////
    //
    //  Pickerのサンプル
    //
    ////////////////////////////////////////////////////
    class MyPage : ContentPage {
        public MyPage() {

            // iOSだけ、上部に余白をとる
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            // Pickerを生成する
            var picker = new Picker {
                Title = "選択してください",
                VerticalOptions = LayoutOptions.Start //  上詰めで配置する（縦方向）
            };
            
            //100行「item-0～item-99」のリストを作成
            var ar = Enumerable.Range(0, 100).Select(n => string.Format("item-{0}", n)).ToList();
            foreach (var a in ar) {
                picker.Items.Add(a);
            }

            // Pickerのみをコンテンツとして配置する
            Content = picker;
        }
    }
    */

    /*
    ////////////////////////////////////////////////////
    //
    //  ProgressBarのサンプル
    //
    ////////////////////////////////////////////////////
    class MyPage : ContentPage {
        public MyPage() {

        // ProgressBarを生成する
            var progressBar = new ProgressBar {
                WidthRequest=300, // 幅を300とする
                HorizontalOptions = LayoutOptions.Center,//中央に配置する（横方向）
                VerticalOptions = LayoutOptions.CenterAndExpand // 中央に配置する（縦方向）
            };

            // ProgressBarのみをコンテンツとして配置する
            Content = progressBar;

            // 0.1 秒ごとにタイマーイベントを発火させる
            Device.StartTimer(TimeSpan.FromSeconds(0.1), () => {
                // プログレスバーの値を0.1増加させる
                progressBar.Progress += 0.01;
                // プログレスバーの値が1になるまで、タイマーイベントを繰り返す
                return progressBar.Progress != 1;
            });
        }
    }
    */
    /*
    ////////////////////////////////////////////////////
    //
    //  SearchBarのサンプル
    //
    ////////////////////////////////////////////////////
    class MyPage : ContentPage {

        public MyPage() {

            // iOSだけ、上部に余白をとる
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            // SearchBarを生成する
            var searchBar = new SearchBar {
                Placeholder = "検索文字を入力してください",
                VerticalOptions = LayoutOptions.Start // 上詰めで配置する（縦方向）
            };
            // 検索文字が入力されたときのイベント処理
            searchBar.SearchButtonPressed += (a,r) => {
                // アラートダイログで入力された文字を表示する
                DisplayAlert("Search", searchBar.Text, "OK");
            };
            // SearchBarのみをコンテンツとして配置する
            Content = searchBar;

        }
    }
    */
    /*
    ////////////////////////////////////////////////////
    //
    //  Sliderのサンプル
    //
    ////////////////////////////////////////////////////
    class MyPage : ContentPage {

        public MyPage() {

            // iOSだけ、上部に余白をとる
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            //Labelを生成する
            var label = new Label {
                HorizontalOptions = LayoutOptions.Center,//中央に配置する（横方向）
            };
            // Sliderを生成する
            var slider = new Slider {
                WidthRequest = 300, // サイズ
                Minimum = 0, // 最小値
                Maximum = 100, // 最大値
                HorizontalOptions = LayoutOptions.Center,//中央に配置する（横方向）
            };
            // スライダーの値が変化したときのイベント処理
            slider.ValueChanged += (s, e) => {
                // ラベルに変化した値を表示する
                label.Text = String.Format("{0:F1}", e.NewValue);
            };

            // LabelとSliderをStacklayoutで縦に並べて配置する
            Content = new StackLayout {
                Children = { slider, label }
            };
        }
    }
    */

    /*
    ////////////////////////////////////////////////////
    //
    // Stepperのサンプル
    //
    ////////////////////////////////////////////////////
    class MyPage : ContentPage {

        public MyPage() {

            // iOSだけ、上部に余白をとる
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            //Labelを生成する
            var label = new Label {
                HorizontalOptions = LayoutOptions.Center,//中央に配置する（横方向）
            };

            // Stepperを生成する
            var stepper = new Stepper {
                Minimum = 0,
                Maximum = 10,
                Increment = 0.1,
                HorizontalOptions = LayoutOptions.Center,//中央に配置する（横方向）
            };
            
            // スライダーの値が変化したときのイベント処理
            stepper.ValueChanged += (s, e) => {
                // ラベルに変化した値を表示する
                label.Text = String.Format("{0:F1}", e.NewValue);
            };

            // LabelとStepperをStacklayoutで縦に並べて配置する
            Content = new StackLayout {
                Children = { stepper, label }
            };
        }
    }
    */
    /*
    ////////////////////////////////////////////////////
    //
    // TimePickerのサンプル
    //
    ////////////////////////////////////////////////////
    class MyPage : ContentPage {
        public MyPage() {
            // TimePicker を生成する
            var timePicker = new TimePicker {
                Format = "T", //  時刻表示フォーマット
                VerticalOptions = LayoutOptions.CenterAndExpand // 中央に配置する（縦方向）
            };
            // TimePickerのみをコンテンツとして配置する
            Content = timePicker;
        }
    }
    */
    /*
    ////////////////////////////////////////////////////
    //
    // WebViewのサンプル
    //
    ////////////////////////////////////////////////////
    class MyPage : ContentPage {
        public MyPage() {
            // WebViewを生成する
            var webView = new WebView {
                Source = new UrlWebViewSource {
                    Url = "http://dev.classmethod.jp/",
                },
                VerticalOptions = LayoutOptions.FillAndExpand // 画面全体に配置する（縦方向）
            };
            // WebViewのみをコンテンツとして配置する
            Content = webView;
        }
    }
    */
    /*
    ////////////////////////////////////////////////////
    //
    // ListViewのサンプル
    //
    ////////////////////////////////////////////////////
    class MyPage : ContentPage {
        public MyPage() {
            // iOSだけ、上部に余白をとる
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            // ListViewを生成する
            var listView = new ListView {
                //100行「item-0～item-99」のリストを作成
                ItemsSource = Enumerable.Range(0, 100).Select(n => string.Format("item-{0}", n)).ToList()
            };
            // VistViewのみをコンテンツとして配置する
            Content = listView;
        }
    }
    */
    /*
    ////////////////////////////////////////////////////
    //
    // TableViewのサンプル
    //
    ////////////////////////////////////////////////////
    class MyPage : ContentPage {
        public MyPage() {
            // iOSだけ、上部に余白をとる
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            // TableViewを生成する
            var tableView = new TableView {
                Intent = TableIntent.Form,
                Root = new TableRoot("設定"){
                    new TableSection("オプション"){
                        new TextCell{
                            Text = "Text Cell",
                            Detail = "詳細",
                        },
                        new SwitchCell{
                            Text = "Switch Cell"
                        },
                        new EntryCell{
                            Label = "Entry Cell",
                            Placeholder = "文字を入力してください"
                        }
                    }
                }
            };
            // TableViewのみをコンテンツとして配置する
            Content = tableView;
        }
    }
    */
}
