using Exam3_App;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Exam3_App
{  
    public sealed partial class MainPage : Page
    {
        API api;
        
        public ObservableCollection<Student> students = new ObservableCollection<Student>();
        public MainPage()
        {
            this.students.Add(new Student() { firstName = "FirstName" });
            this.students.Add(new Student() { lastName = "LastName" });
            this.students.Add(new Student() { phoneNumber = "Phone" });
            this.students.Add(new Student() { email = "Email" });
            this.InitializeComponent();
            

        }

    }
  
}
