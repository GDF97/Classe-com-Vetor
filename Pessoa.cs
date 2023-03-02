class Pessoa
    {
        private string nome;
        private int idade;
        private double altura;
        private double peso;
        private string sexo;



        public Pessoa(string nome, int idade, double altura, double peso, string sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.peso = peso;
            Sexo = sexo.ToString();
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value.ToUpper() == "M" ? "MASCULINO" : "FEMININO"; }
        }
        public override string ToString()
        {
            return (String.Format("Nome:{0}\n Idade:{1} \n Altura:{2} \n Sexo:{3} \n Peso:{4}", nome, idade, altura, sexo, peso));
        }
        public double calcularPesoIdeal()
        {
            if (sexo.Equals("MASCULINO"))
            {
                return (peso * altura) - 58;
            }
            else
            {
                return (peso * altura) - 44.7;
            }
        }
    }
}