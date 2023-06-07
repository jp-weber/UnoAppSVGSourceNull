using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoAppSVGBug.Models
{
    [Bindable]
    public class TestModel : ObservableObject
    {
        private bool _logoExists = false;

        public bool LogoExists 
        { 
            get => _logoExists; 
            set => SetProperty(ref _logoExists, value);
        }


        private string _color = "Green";
        public string Color
        {
            get => _color;
            set => SetProperty(ref _color, value);
        }

        private string _label = string.Empty;
        public string Label
        {
            get => _label;
            set => SetProperty(ref _label, value);
        }

        private string _issuer = string.Empty;
        public string Issuer
        {
            get => _issuer;
            set => SetProperty(ref _issuer, value);
        }

        private string _accountIconName = string.Empty;

        public string AccountIconName
        {
            get => _accountIconName;
            set
            {
                if (SetProperty(ref _accountIconName, value))
                {
                    OnPropertyChanged(nameof(Model));
                }
            }
        }

        private Uri? _accountSVGIcon;

        public Uri? AccountSVGIcon
        {
            get
            {
                if (_accountSVGIcon == null)
                {
                    return null;
                }
                else
                {
                    return _accountSVGIcon;
                }
            }
            set => SetProperty(ref _accountSVGIcon, value);
        }


        private bool _isChecked = true;


        public bool IsChecked
        {
            get => _isChecked;
            set => SetProperty(ref _isChecked, value);
        }

        private bool _isEnabled = true;


        public bool IsEnabled
        {
            get => _isEnabled;
            set => SetProperty(ref _isEnabled, value);
        }


        public TestModel Model
        {
            get => this;
        }



        //public TestModel()
        //{
        //}
    }
}
