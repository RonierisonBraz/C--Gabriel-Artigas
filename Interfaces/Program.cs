using System;

namespace Interfaces
{
    class Program 
    {
        static void Main(string[] args)
        {
            EditBox editBox = new EditBox();
            IControl control = editBox; //referencionda o editBox no objeto control.
            IDataBound dataBound = editBox;
            
            editBox.Paint();
            editBox.Bind("Ronierison");

            control.Paint();
            dataBound.Bind("Objeto dataBound");

            var oClass = new OutraClase();
            oClass.Paint();           
        }

        interface IControl
        {
            void Paint();

        }

        interface ITextBox : IControl
        {
            void SetText(string text);
        }

        interface IListBox : IControl
        {
            void SetItems(String[] items);
        }

        interface IComboBox : ITextBox, IListBox { }

        interface IDataBound
        {
            void Bind(string b);
        }

        public class EditBox : IControl, IDataBound
        {
            public void Paint()
            {
                Console.WriteLine("executando método Paint() da classe EditBox");
            }

            public void Bind(string b)
            {
                Console.WriteLine("executando método Baind()");
                Console.WriteLine(b); 
            }

        }
        class OutraClase : IControl
        {
            public void Paint()
            {
                Console.WriteLine("executando método Paint() da classe OutraClasse");
            }
        }
    }

    
}
