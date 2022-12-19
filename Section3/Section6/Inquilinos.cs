namespace Section6
{
    internal class Inquilinos
    {
        //Classe para exercício aula 71
        public string Nome { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Nome + ", " + Email; 
        }
    }
}
