namespace BuracoNasLetras
{
    public partial class BuracoNasLetras : Form
    {
        string[,] letras = { {"A", "1" }, {"a", "1" }, { "B", "2"}, {"b", "1" }, {"D", "1" }, { "e", "1"}, {"g", "1" }, { "O", "1"}, { "o", "1"},
            { "P", "1" }, { "p", "1"}, { "Q", "1" }, { "q", "1" }, { "R", "1" }, { "6", "1"}, { "8", "2" }, { "9", "1" }, { "0", "1" } };

        public BuracoNasLetras()
        {
            InitializeComponent();
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            lblTamanhoTextoContador.Text = txtTexto.Text.Count().ToString();
            lblTotalPalavrasContador.Text = RemoveEspacos(txtTexto.Text.Split(" ").ToList()).ToString();
            lblTotalBuracosContador.Text = ContaBuracos(txtTexto.Text).ToString();
        }

        private int RemoveEspacos(List<string> palavras)
        {
            for (int i = 0; i < palavras.Count; i++)
            {
                if (palavras[i] == "")
                {
                    palavras.RemoveAt(i);
                    i = 0;
                }
            }

            return palavras.Count;
        }

        private int ContaBuracos(string texto)
        {
            int buracos = 0;

            var letrasSeparadas = texto.ToCharArray();

            for (int i = 0; i < texto.Length; i++)
            {
                for (int j = 0; j < letras.GetLength(0); j++)
                {
                    if (letrasSeparadas[i].ToString() == letras[j, 0])
                        buracos += int.Parse(letras[j, 1]);
                }
            }

            return buracos;
        }
    }
}