/*
1.	Crie um novo projeto Windows Forms.
2.	Desenhe uma janela com um bot�o e um r�tulo.
3.	Ao clicar no bot�o, altere o texto do r�tulo.
*/

namespace IntroducaoaoWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Texto alterado pelo bot�o!";
        }
    }
}