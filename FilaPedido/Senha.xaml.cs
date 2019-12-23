using Microsoft.AspNet.SignalR.Client;
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

namespace FilaPedido
{
    /// <summary>
    /// Interaction logic for Senha.xaml
    /// </summary>
    public partial class Senha : Window
    {
        IHubProxy chat;
        public SynchronizationContext Context { get; set; }
        public string senha = "";
        public Senha()
        {
            InitializeComponent();
            this.lblSenha.Content = senha;
            BindCbo();
            makeConnection();
        }

        async private void makeConnection()
        {
            try
            {
                var hubConnection = new HubConnection("http://localhost:60978");
                chat = hubConnection.CreateHubProxy("ChatHub");
                Context = SynchronizationContext.Current;
                chat.On<string, string>("broadcastMessage",
                    (name, message) =>
                        Context.Post(delegate
                        {
                            var item = this.cboItem.SelectedItem as NomeId;
                            if (name.Equals(item.Nome))
                                EscreverSenha(message);
                        }, null)
                        );
                await hubConnection.Start();
                //await chat.Invoke("Notify", chatName.Text, hubConnection.ConnectionId);
            }
            catch (Exception ex)
            {
            }
        }

        private void EscreverSenha(string senha)
        {
            this.lblSenha.Content = senha;
        }

        private void BindCbo()
        {
            var pedidos = new List<NomeId>();
            pedidos.Add(new NomeId() { Id = 1, Nome = "BATATA" });
            pedidos.Add(new NomeId() { Id = 2, Nome = "CONTRA FILÉ" });


            cboItem.ItemsSource = pedidos;
        }
    }
}
