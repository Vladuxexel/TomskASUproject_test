using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TomskAsyProject_Test
{
    class ViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Function> Functions { get; set; }

        List<int> C_vals_deg1 = new List<int>() { 1, 2, 3, 4, 5 };
        List<int> C_vals_deg2 = new List<int>() { 10, 20, 30, 40, 50 };
        List<int> C_vals_deg3 = new List<int>() { 100, 200, 300, 400, 500 };
        List<int> C_vals_deg4 = new List<int>() { 1000, 2000, 3000, 4000, 5000 };
        List<int> C_vals_deg5 = new List<int>() { 10000, 20000, 30000, 40000, 50000 };

        public ViewModel()
        {
            Functions = new ObservableCollection<Function>
            {
                new Function{Name="Линейная",Degree=1, A=1,B=1,C=1,X=1,Y=1, C_values = C_vals_deg1},
                new Function{Name="Квадратичная",Degree=2, A=2,B=2,C=10,X=2,Y=2, C_values = C_vals_deg2},
                new Function{Name="Кубическая",Degree=3, A=3,B=3,C=100,X=3,Y=3, C_values = C_vals_deg3},
                new Function{Name="4-й степени",Degree=4, A=4,B=4,C=1000,X=4,Y=4, C_values = C_vals_deg4},
                new Function{Name="5-й степени",Degree=5, A=5,B=5,C=10000,X=5,Y=5, C_values = C_vals_deg5},
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
