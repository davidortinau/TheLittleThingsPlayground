using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Demos.ViewModels
{
    class DemoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DemoViewModel()
        {
            _colors = new List<string>();
            foreach (var field in typeof(Xamarin.Forms.Color).GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                if (field != null && !String.IsNullOrEmpty(field.Name))
                    _colors.Add(field.Name);
            }

        }

        List<string> _colors;
        public List<string> Colors { get { return _colors; } }

        public List<ColorViewModel> ColorViewModels
        {
            get
            {
                return _colors.Select(x => new ColorViewModel { Name = x }).ToList<ColorViewModel>();
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
