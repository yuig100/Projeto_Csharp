/*
1.	Crie um novo projeto Windows Forms.
2.	Desenhe uma janela com um botão e um rótulo.
3.	Ao clicar no botão, altere o texto do rótulo.
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
            label1.Text = "Texto alterado pelo botão!";
        }
    }
}