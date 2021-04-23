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
    public partial class ListeCourses : ContentPage
    {
        public ListeCourses()
        {
            InitializeComponent();
            BindingContext = new ListeCoursesViewModel(Navigation);
        }

        private void lstCourses_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListeCoursesViewModel)BindingContext).AfficherView_RemplirCourse();
        }
    }
}