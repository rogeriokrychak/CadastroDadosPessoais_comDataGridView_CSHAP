using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDadosPessoais_comDataGridView
{
    public partial class Form1 : Form
    {
        //cria uma variável global
        string opcao;//esta variável recebe a opção do sexo selecionado.


        //Instanciar uma classe dentro de uma Lista
        public List<Dados> dados { get; set; }
        public Form1()
        {
            InitializeComponent();
            //pega meu lista de dados e cria um objeto
            dados = new List<Dados>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dados.Add(new Dados { Nome = campoNome.Text, 
            Sobrenome = campoSobrenome.Text,
            Endereço = campoEndereco.Text,
            Cidade = campoCidade.Text,
            CEP = campoCep.Text,
            UF = comboEstados.SelectedItem.ToString(),
            data = campoData.Value.ToShortDateString(),
            sexo = opcao,
            telefone = campoTelefone.Text,
            email = campoEmail.Text});

            //precisa limpar o datasource, colocando null, para colocar novos dados
            GridNome.DataSource = null;
            GridNome.DataSource = dados;

            //precisa colocar este comando para apagar os campos após inserir os dados correntes para inserir
            //novos dados
            campoNome.Text = " ";
            campoSobrenome.Text = " ";
            campoEndereco.Text = " ";
            campoCidade.Text = " ";
            campoCep.Text = " ";
            comboEstados.SelectedItem = " ";
            opcao = " ";
            campoTelefone.Text = " ";
            campoEmail.Text = " ";
        }

        //criar uma classe, definir propriedades
        public class Dados
        {
            public string Nome { get; set; }
            public string Sobrenome { get; set; }
            public string Endereço { get; set; }
            public string Cidade { get; set; }
            public string CEP { get; set; }
            public string UF { get; set; }
            public string data { get; set; }
            public string sexo { get; set; }
            public string telefone { get; set; }
            public string email { get; set; }

        }

        private void radioMasculino_CheckedChanged(object sender, EventArgs e)
        {
            opcao = "Masculino";
        }

        private void radioFeminino_CheckedChanged(object sender, EventArgs e)
        {
            opcao = "Feminino";
        }

        private void radioOutros_CheckedChanged(object sender, EventArgs e)
        {
            opcao = "Outros";
        }
    }
}
