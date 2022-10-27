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
using System.Windows.Shapes;

namespace CloneTermooo
{
    /// <summary>
    /// Lógica interna para Regras.xaml
    /// </summary>
    public partial class Regras : Window
    {
        public Regras()
        {
            InitializeComponent();
        }

        private void fecharRegras(object sender, RoutedEventArgs e)
        {
            Termo termo = new Termo();
            termo.Show();
            Close();
        }
    }
}
