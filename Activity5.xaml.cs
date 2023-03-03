using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace PDC03_Activity02
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Activity5 : ContentPage
	{

		ObservableCollection<employee> employees = new ObservableCollection<employee>();
		public ObservableCollection<employee> Employees { get { return employees; } }

        public Activity5 ()
		{
			InitializeComponent ();
			{
				lst.ItemsSource = employees;

				employees.Add(new employee { DisplayName="Karylle Lopez", Position="President", profileImage="img1.jpg" });
                employees.Add(new employee { DisplayName="Im Nayeon", Position="Vice President", profileImage="img2.jpg" });
                employees.Add(new employee { DisplayName="Sana Minatozaki", Position="Secretary", profileImage="img3.jpg" });
            }
		}
	}
}