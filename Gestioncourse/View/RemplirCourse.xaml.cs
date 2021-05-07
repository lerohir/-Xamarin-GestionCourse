using System;
using Gestioncourse.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Gestioncourse.Model;

namespace Gestioncourse.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RemplirCourse : ContentPage
    {
        public RemplirCourse(Course course)
        {
            InitializeComponent();
            BindingContext = new RemplirCourseViewModel(Navigation, course);
        }
    }
}