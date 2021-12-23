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

namespace DZ5ksk
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
  public class room
    {
        public double meters;
        public double height;
        public int windows;


    public room()
    {
        meters = 0;
        height = 0;
        windows = 0;

    }

    public void Addroom(double a, double b, int c)
    {
        meters = a;
        height = b;
        windows = c;
    }


}
public partial class MainWindow : Window
    {
        int N = 0;
        room[] inforoom = new room[40];
        public MainWindow()
        {
            InitializeComponent();
            bsquare.IsEnabled = false;
            bvolume.IsEnabled = false;
            Badd.IsEnabled= false;
            for (int i = 0; i < 40; i++)
            {
           inforoom[i] = new room();
            }
 

        }

        private void bsquare_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                int vvod = Convert.ToInt32(tn.Text);
                int vvod2 = Convert.ToInt32(tn.Text);
                double S = 0;
                
                S = 2*inforoom[vvod - 1].meters * inforoom[vvod - 1].meters+4*inforoom[vvod2-1].height* inforoom[vvod - 1].meters;
                tinfo.Content = "S= "+String.Format("{0}", S);
            }
            catch (Exception )
            {
                    tinfo.Content = "Проверьте правильность введённых данных";
            }

        }

        private void bvolume_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {   int vvod = Convert.ToInt32(tn.Text);
                double V = 0;
                V = inforoom[vvod - 1].meters * inforoom[vvod - 1].meters * inforoom[vvod - 1].height;
                tinfo.Content = "V= " + String.Format("{0}", V);
            }
            catch (Exception ) {

                    tinfo.Content = "Проверьте правильность введённых данных";
                
            }
        }

        private void binfo_Click(object sender, RoutedEventArgs e)
        {
            tend.Text = "";
            for (int i = 0; i < N; i++)
            {
                tend.Text +=i+1+"комната, "+ inforoom[i].meters + "метраж, " + inforoom[i].height + "высота, " + inforoom[i].windows + "окона." + "\n";
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                inforoom[N].Addroom(Convert.ToDouble(tnewroomS.Text), Convert.ToDouble(tnewroomV.Text), Convert.ToInt32(tnewroomW.Text));
                N++;
                tadd.Content = "";
            }
            catch (Exception)
            {
                tadd.Content = "Проверьте правильность введённых данных";
            }
        }

        private void tn_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tn.Text == "")
            {
                bsquare.IsEnabled = false;
                bvolume.IsEnabled = false;
            }
            else
            {
            bsquare.IsEnabled = true;
            bvolume.IsEnabled = true;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < N; i++)
            {
                
                inforoom[i].meters = 0;
                inforoom[i].windows = 0;
                inforoom[i].height = 0;
            }
            N = 0;
            tend.Text = "";
        }

        private void tnewroomS_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tnewroomS.Text == "" || tnewroomV.Text == "" || tnewroomW.Text == "")
            {
                Badd.IsEnabled = false;
            }
            else
            {
                Badd.IsEnabled = true;
            }
        }

        private void tnewroomV_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tnewroomS.Text == "" || tnewroomV.Text == "" || tnewroomW.Text == "")
            {
                Badd.IsEnabled = false;
            }
            else
            {
                Badd.IsEnabled = true;
            }
        }

        private void tnewroomW_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tnewroomS.Text == "" || tnewroomV.Text == "" || tnewroomW.Text == "")
            {
                Badd.IsEnabled = false;
            }
            else
            {
                Badd.IsEnabled = true;
            }
        }
    }
}
