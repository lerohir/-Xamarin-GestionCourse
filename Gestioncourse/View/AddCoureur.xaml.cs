using Gestioncourse.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gestioncourse.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddCoureur : ContentPage
    {
        public AddCoureur()
        {
            InitializeComponent();

            BindingContext = new AddCoureurViewModel(Navigation);
        }
    }
}