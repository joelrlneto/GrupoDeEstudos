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
using ColecoesLINQ.Dominio;

namespace ColecoesLINQ.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Produto> produtos;

        public MainWindow()
        {
            InitializeComponent();

            produtos = Repositorio.GerarDados().ToList();

            listProdutos.ItemsSource = produtos;
            gridProdutos.ItemsSource = produtos;
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            //LINQ - Language Integrated Query
            //Lambda Expressions: (entrada) => (filtro)

            string texto = txtBusca.Text;
            //var sublista = produtos.Where(p => p.Descricao.Contains(texto));
            //var primeiro = produtos.First(p => p.Preco > 2);
            //var ultimo = produtos.Last();
            //var primeiro = produtos.Where(p => p.Descricao.Contains(texto)).First();
            //var primeiro = produtos.FirstOrDefault(p => p.Preco > 20);

            //if(primeiro != null)
            //    MessageBox.Show(primeiro.ToString());
            //else
            //    MessageBox.Show("Produto não localizado");

            //var sublista = produtos.OrderBy(p => p.Descricao);
            //var maiscaro = produtos.Max(p => p.Preco);
            //var maiscaro = produtos.Max();
            //int qtd = produtos.Count();
            //var soma = produtos.Sum(p => p.Preco * p.Estoque);

            var sublista = from p in produtos
                           where p.Descricao.Contains(texto)
                           orderby p.Preco
                           select p;

            //MessageBox.Show(soma.ToString("c"));

            listProdutos.ItemsSource = sublista;
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            var selecionado = listProdutos.SelectedItem as Produto;
            
            produtos.Remove(selecionado);

            listProdutos.ItemsSource = null;
            listProdutos.ItemsSource = produtos;

            listNovo.ItemsSource = produtos;

            gridProdutos.ItemsSource = produtos;
        }

        private void listProdutos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selecionado = listProdutos.SelectedItem as Produto;
            
            panelDetalhes.DataContext = selecionado;            
        }
    }
}
