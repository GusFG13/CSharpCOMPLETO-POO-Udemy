namespace Section15.Aula219.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }


        //Console.WriteLine(a.Contains(prod));
        //retornaria falso se os overrides de GetHashCode e Equals não tivessem sido implementados
        //porque iria comparar apenas o endereço de memória dos objetos e não o valores (no caso de tipos referência)
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {

            if (!(obj is Product))
                return false;
            Product other = obj as Product;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}
