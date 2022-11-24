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

namespace verificaGIT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lstElenco.Items.Clear();
            List<Libro> listaDeiLibri = new List<Libro>();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Libro libro = new Libro(txtAut.Text.ToString(), txtNomeLibro.Text.ToString(), int.Parse(txtAnnoPub.Text), txtEd.Text.ToString(), int.Parse(txtPagine.Text));
            lstElenco.Items.Add(libro);
            
        }

        private void btnBiblioteca_Click(object sender, RoutedEventArgs e)
        {
            Biblioteca biblioteca = new Biblioteca(txtNomeBib.Text.ToString(), txtIndi.Text.ToString(), txtAp.Text.ToString(), txtChius.Text.ToString());
        }

        private void btnReTi_Click(object sender, RoutedEventArgs e)
        {
            Libro libro = new Libro(txtAut.Text.ToString(), txtNomeLibro.Text.ToString(), int.Parse(txtAnnoPub.Text), txtEd.Text.ToString(), int.Parse(txtPagine.Text));
            string tempo =libro.toString(libro);
            lblTempo.Content = tempo;
        }

        private void btnToString_Click(object sender, RoutedEventArgs e)
        {
            Libro libro = new Libro(txtAut.Text.ToString(), txtNomeLibro.Text.ToString(), int.Parse(txtAnnoPub.Text), txtEd.Text.ToString(), int.Parse(txtPagine.Text));
            string info = libro.toString(libro);
            lblInfo.Content = info;
        }
    }
}
