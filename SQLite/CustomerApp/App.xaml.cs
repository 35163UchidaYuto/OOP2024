﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CustomerApp {
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application {
        static string datebaseName = "Customer00.db";
        static string folderPass = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string datebasePass = System.IO.Path.Combine(folderPass, datebaseName);
    }
}
