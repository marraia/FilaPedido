using System;
using System.Collections.Generic;
using System.Data;
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
using System.Xml;

namespace FilaPedido
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            var t = ObterNovo();
            Bind(t);
        }

        private void Bind(List<Item> pedidos)
        {
            dgItem.ItemsSource = pedidos;
            this.Contar();
        }

        private List<Item> ObterNovo()
        {
            var pedidos = new List<Item>();


            pedidos.Add(new Item() { Pedido = "092114", Descricao = "BATATA", Quantidade = 5, Tipo = "NOVO" });
            pedidos.Add(new Item() { Pedido = "092115", Descricao = "BATATA", Quantidade = 5, Tipo = "NOVO" });
            pedidos.Add(new Item() { Pedido = "092116", Descricao = "BATATA", Quantidade = 5, Tipo = "NOVO" });
            pedidos.Add(new Item() { Pedido = "092113", Descricao = "BATATA", Quantidade = 5, Tipo = "EM PREPARAÇÃO" });

            return pedidos;
        }

        private void DgItem_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            var item = e.Row.Item as Item;
            if (item != null)
            {
                e.Row.FontSize = 18;
                e.Row.FontWeight = FontWeights.Bold;

                if (item.Tipo == "NOVO")
                    e.Row.Foreground = new SolidColorBrush(Colors.Green);
                else
                    e.Row.Foreground = new SolidColorBrush(Colors.Orange);
            }
        }

        private void Contar()
        {
            this.lblEntrada.FontSize = 60;
            this.lblEntrada.Content = 19;
            this.lblEntrada.FontWeight = FontWeights.Bold;
            this.lblEntrada.Foreground = new SolidColorBrush(Colors.Green);
            this.lblEntrada.HorizontalContentAlignment = HorizontalAlignment.Center;

            this.lblPreparacao.FontSize = 60;
            this.lblPreparacao.Content = 1;
            this.lblPreparacao.FontWeight = FontWeights.Bold;
            this.lblPreparacao.Foreground = new SolidColorBrush(Colors.Orange);
            this.lblPreparacao.HorizontalContentAlignment = HorizontalAlignment.Center;

            this.lblSaida.FontSize = 60;
            this.lblSaida.Content = 100;
            this.lblSaida.FontWeight = FontWeights.Bold;
            this.lblSaida.Foreground = new SolidColorBrush(Colors.Blue);
            this.lblSaida.HorizontalContentAlignment = HorizontalAlignment.Center;
        }

        private void DgItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var grid = sender as DataGrid;
            var cellValue = grid.SelectedValue as Item;
        }
    }

    public class Item
    {
        public string Pedido { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public string Tipo { get; set; }
    }
}
