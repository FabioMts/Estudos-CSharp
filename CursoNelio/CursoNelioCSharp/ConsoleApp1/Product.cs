using System.Globalization;
namespace PRODUCT
{
    class Produto
    {
        public string _nome { get; set; }
        public double Preco { get; private set; }
        public int Quantidade { get; set; }


        public Produto()
        {
            Quantidade = 10;
        }




       public Produto(string nome, double preco, int quantidade) : this(nome, preco){

            Quantidade = quantidade;

        }


        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 0;
        }

        public string Nome
        {
            get { return _nome; }
            set {
                if (value!= null && value.Length>1) {
                    _nome = value;
                }  
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }


        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }


        public override string ToString()
        {
            return _nome
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }


    }
}
