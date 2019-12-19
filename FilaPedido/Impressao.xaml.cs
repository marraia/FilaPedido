using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace FilaPedido
{
    /// <summary>
    /// Interaction logic for Impressao.xaml
    /// </summary>
    public partial class Impressao : Window
    {
        public Impressao()
        {
            InitializeComponent();
            Imprimir("Montenegro1", 1000);
            Imprimir("Montenegro2", 1000);
        }


        private delegate void UpdateLabelDelegate(DependencyProperty dp, object value);

        public void UpdateLabelContent(Label label, string newContent)
        {
            Dispatcher.Invoke(new UpdateLabelDelegate(label.SetValue), DispatcherPriority.Background, ContentProperty, newContent);
        }


        public void Imprimir(string nomeImpressora, int quantidade)
        {
            var ordem = $"{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}{DateTime.Now.Millisecond}";
            //var ordem = Math.Round((decimal)new Random().Next() * 2019);
            var listaItem = new List<ItemPedido>();

            for (int i = 0; i <= quantidade; i++)
            {
                listaItem.Add(new ItemPedido() { Descricao = "BATATA" });
            }

            var pedido = new Pedido()
            {
                Ordem = ordem.ToString(),
                NomeImpressora = nomeImpressora,
                Itens = listaItem
            };

            Exibir(pedido);
        }

        public void Exibir(Pedido pedido)
        {
            Label controlOrdem = FindChild<Label>(this.Teste, $"lblImpressao{pedido.NomeImpressora}");
            Label controlContador = FindChild<Label>(this.Teste, $"lblImpressao{pedido.NomeImpressora}Contador");
            controlOrdem.Content = pedido.Ordem;
            controlContador.Content = pedido.Itens.Count();
            var contador = pedido.Itens.Count();
            controlOrdem.Refresh();
            controlContador.Refresh();

            foreach (var item in pedido.Itens)
            {
                contador--;
                UpdateLabelContent(controlContador, contador.ToString());
            }

            controlOrdem.Content = "--";
            controlContador.Content = "--";
        }

        private void BtnFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public static T FindChild<T>(DependencyObject parent, string childName) where T : DependencyObject
        {
            // Confirm parent and childName are valid. 
            if (parent == null) return null;
            T foundChild = null;
            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                // If the child is not of the request child type child
                T childType = child as T;
                if (childType == null)
                {
                    // recursively drill down the tree
                    foundChild = FindChild<T>(child, childName);
                    // If the child is found, break so we do not overwrite the found child. 
                    if (foundChild != null) break;
                }
                else if (!string.IsNullOrEmpty(childName))
                {
                    var frameworkElement = child as FrameworkElement;
                    // If the child's name is set for search
                    if (frameworkElement != null && frameworkElement.Name == childName)
                    {
                        // if the child's name is of the request name
                        foundChild = (T)child;
                        break;
                    }
                }
                else
                {
                    // child element found.
                    foundChild = (T)child;
                    break;
                }
            }
            return foundChild;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }

    public class Pedido
    {
        public string Ordem { get; set; }
        public string NomeImpressora { get; set; }
        public List<ItemPedido> Itens { get; set; }

    }

    public class ItemPedido
    {
        public string Descricao { get; set; }
    }

    public static class ExtensionMethods
    {
        private static Action EmptyDelegate = delegate () { };

        public static void Refresh(this UIElement uiElement)
        {
            uiElement.Dispatcher.Invoke(DispatcherPriority.Render, EmptyDelegate);
        }
    }
}
