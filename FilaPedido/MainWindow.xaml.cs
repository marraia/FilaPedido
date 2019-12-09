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

namespace FilaPedido
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            var pedidos = new[]{
                  new {Pedido = "VVFFF", Item = "Batata", Quantidade = 2},
                  new {Pedido = "VVTTF", Item = "Batata", Quantidade = 1},
                  new {Pedido = "VVTTF", Item = "Batata", Quantidade = 1},
                  new {Pedido = "VVTTF", Item = "Batata", Quantidade = 1},
                  new {Pedido = "VVTTF", Item = "Batata", Quantidade = 1},
                  new {Pedido = "VVTTF", Item = "Batata", Quantidade = 1},
                  new {Pedido = "VVTTF", Item = "Batata", Quantidade = 1},
                  new {Pedido = "VVTTF", Item = "Batata", Quantidade = 1},
                  new {Pedido = "VVTTF", Item = "Batata", Quantidade = 1},
                  new {Pedido = "VVTTF", Item = "Batata", Quantidade = 1},
                  new {Pedido = "VVTTF", Item = "Batata", Quantidade = 1},
                  new {Pedido = "VVTTF", Item = "Batata", Quantidade = 1},
                  new {Pedido = "VVTTF", Item = "Batata", Quantidade = 1},
                  new {Pedido = "VVTTF", Item = "Batata", Quantidade = 1},
                  new {Pedido = "VVTTF", Item = "Batata", Quantidade = 1},
                  new {Pedido = "VVTTF", Item = "Batata", Quantidade = 1},
                  new {Pedido = "VVTTF", Item = "Batata", Quantidade = 1},
                  new {Pedido = "VVTTF", Item = "Batata", Quantidade = 1},
                  new {Pedido = "VVTTF", Item = "Batata", Quantidade = 1},
                  new {Pedido = "VVHHF", Item = "Batata", Quantidade = 3}
              };

            var itens = new[]{ "Batata", "Contra Filé"
                  
                  
              };



            dbView.ItemsSource = pedidos;
            listItem.ItemsSource = itens;
            
        }

        private void DbView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Senha win2 = new Senha();
            win2.Show();
        }
    }
}
