using System.Collections.Generic;
using System.ComponentModel;

namespace TomskAsyProject_Test
{
    class Function : INotifyPropertyChanged
    {
        public double a, b, x, y;
        public int c, degree;

        public string Name { get; set; }

        public List<int> C_values { get; set; }

        public double A
        {
            get { return a; }
            set
            {
                a = value;
                OnPropertyChanged("Result");
            }
        }

        public double B
        {
            get { return b; }
            set
            {
                b = value;
                OnPropertyChanged("Result");
            }
        }

        public int C
        {
            get { return c; }
            set
            {
                c = value;
                OnPropertyChanged("Result");
            }
        }

        public double X
        {
            get { return x; }
            set
            {
                x = value;
                OnPropertyChanged("Result");
            }
        }

        public double Y
        {
            get { return y; }
            set
            {
                y = value;
                OnPropertyChanged("Result");
            }
        }

        public int Degree
        {
            get { return degree; }
            set
            {
                degree = value;
                OnPropertyChanged("Result");
            }
        }

        public double Result
        {
            get
            {
                return Model.Function(Degree, A, X, B, Y, C);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
