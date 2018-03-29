using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tardiness
{
    /// <summary>
    /// Interaction logic for Data.xaml
    /// </summary>
    public partial class Data : UserControl
    {
        public Data()
        {
            InitializeComponent();
        }

        public void Update(int[] values)
        {
            point1.Margin = new Thickness(5, calcHeight(values[0]), 0, 0);
            point2.Margin = new Thickness(15, calcHeight(values[1]), 0, 0);
            point3.Margin = new Thickness(25, calcHeight(values[2]), 0, 0);

            point4.Margin = new Thickness(35, calcHeight(values[3]), 0, 0);
            point5.Margin = new Thickness(45, calcHeight(values[4]), 0, 0);
            point6.Margin = new Thickness(55, calcHeight(values[5]), 0, 0);

            point7.Margin = new Thickness(65, calcHeight(values[6]), 0, 0);
            point8.Margin = new Thickness(75, calcHeight(values[7]), 0, 0);
        }

        private int calcHeight(int v)
        {
            return Math.Min(Math.Max((45 + (v / 2)), 0), 100);
        }
    }
}
