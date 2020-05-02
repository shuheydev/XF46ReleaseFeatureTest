using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF46ReleaseFeatureTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExperimetalFeaturesPage : ContentPage
    {
        private string _selectedFruits;
        public string SelectedFruits
        {
            get => _selectedFruits;
            set
            {
                _selectedFruits = value;
                OnPropertyChanged();
            }
        }
        public ExperimetalFeaturesPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if(rb.IsChecked)
            {
                SelectedFruits = rb.Text;
            }
        }
    }
}