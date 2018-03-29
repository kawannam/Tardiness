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
using System.IO;

namespace Tardiness
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numberOfCycles = 100;
        int[][][] chrom;
        int[] truth;
        public MainWindow()
        {
            InitializeComponent();
            readResults();
            Truth.Update(truth);
            updateUiElements(30);
        }

        public void updateUiElements(int i)
        {
            Data1.Update(chrom[i][0]);
            Data2.Update(chrom[i][1]);
            Data2.Update(chrom[i][2]);
            Data2.Update(chrom[i][3]);
            Data2.Update(chrom[i][4]);
            Data2.Update(chrom[i][5]);
            Data2.Update(chrom[i][6]);
            Data2.Update(chrom[i][7]);
            Data2.Update(chrom[i][8]);
        }

        public void readResults()
        {
            chrom = new int[numberOfCycles][][];
            truth = new int[9];

            Console.WriteLine(Environment.CurrentDirectory + "/../../gep.csv");
            using (var reader = new StreamReader( Environment.CurrentDirectory + "/../../gep.csv"))
            {
                int i = 0;
                if (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    for (int v = 0; v < values.Length; v++ )
                    {
                        truth[v] = (int)float.Parse(values[v]);
                    }
                }
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    int l = 0;
                    chrom[i] = new int[9][];
                    for (int j = 0; j < 9; j++) {
                        chrom[i][j] = new int[8];
                        for (int k = 0; k <  8; k++)
                        {
                            chrom[i][j][k] = (int)float.Parse(values[l]);
                            l++;
                            if (l > 71)
                            {
                                Console.WriteLine(l);
                            }
                        }
                    }
                    i++;
                }
            }


        }
    }
}
