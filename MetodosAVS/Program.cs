using System;

namespace MetodosAVS
{
    class Program
    {
        static void Main(string[] args)
        {
            MinhaClasse mClass = new MinhaClasse(3.1415);
           Console.WriteLine( mClass.RetornarValor());
            mClass.MetodoEmMinhaClasse();
            mClass.MetodoVirtual();

            Console.WriteLine();
            MinhaOutraClasse mOutraClasse = new MinhaOutraClasse("Roniérison");
            Console.WriteLine(mOutraClasse.RetornarValor());
            mOutraClasse.MetodoVirtual();
            mOutraClasse.MetodoEmMinhaOutraClasse();

            Console.WriteLine();

            // ClasseAbstrata cAbstrata = new ClasseAbstrata(); não pode ser feito isso 
            ClasseAbstrata cAbstrata = new MinhaClasse(75.18);
            Console.WriteLine(cAbstrata.RetornarValor());// posso implementar a sim a variavel abstrata.
            cAbstrata.MetodoVirtual();

            Console.WriteLine();
            ClasseAbstrata cAbstrata2 = new MinhaOutraClasse("Logan/ Wolverine");
            Console.WriteLine(cAbstrata2.RetornarValor());
            cAbstrata2.MetodoVirtual();


        }
    }

    public abstract class ClasseAbstrata
    {
        public abstract object RetornarValor();

        public virtual void MetodoVirtual()
        {
            Console.WriteLine("Método Vitual em ClasseAbstrata");
        }
    }

    public class MinhaClasse : ClasseAbstrata
    {
        double _value;

        public MinhaClasse(double value)
        {
            _value = value;
        }

        public void MetodoEmMinhaClasse() => 
            Console.WriteLine("Metodo em MinhaClasse");

        public override object RetornarValor()
        {
            return _value;
        }

        public override void MetodoVirtual()
        {
            Console.WriteLine("Método Vitual em metodo virtual");
        }
    }

    public class MinhaOutraClasse : ClasseAbstrata
    {
        string _name;

        public MinhaOutraClasse(string name)
        {
            _name = name;
        }

        public void MetodoEmMinhaOutraClasse() =>
            Console.WriteLine("Metodo em MinhaOutraClasse");

        public override object RetornarValor()
        {
            return _name;
        }

        public override void MetodoVirtual()
        {
            base.MetodoVirtual(); //faz referencia a classe base 
            Console.WriteLine("Método Vitual em MinhaOutraClasse.");
            
        }
    }
}
