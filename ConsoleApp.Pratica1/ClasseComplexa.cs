namespace ConsoleApp.Pratica1
{
    public class ClasseComplexa : IImprimirValores
    {
        private int PropInt { get; set; }
        protected bool PropBool { get; set; }
        public decimal MeuDecimal { get; set; }

        protected DateTime dataAtual;
        float floatField;

        public Direcoes Direcao { get; set; }
        public string PropInterface { get; set; }

        /// <summary>
        /// observe que foi setado um valor explícito para cada item do enum
        /// </summary>
        public enum Direcoes
        {
            Cima = 1,
            Baixo = 10,
            LadoEsquerdo = 20,
            LadoDireiro = 67
        }
    }
}