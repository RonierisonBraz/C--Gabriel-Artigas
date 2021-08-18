using System;
using System.Collections.Generic;
using System.Text;

namespace OutrosMembrosDeFuncao
{
    public class MyList<T>
    {
        //Campos

        const int DefaultCapacity = 4;

        T[] _items;

        int _count;

        public MyList(int capacity = DefaultCapacity)
        {
            _items = new T[capacity];
        }

        public int Count => _count;

        public int Capacity
        {
            get => _items.Length;
            set
            {
                if(value < _count) value = _count;
                
                if (value != _items.Length)
                {
                    T[] newItems = new T[value];
                    Array.Copy(_items, 0, newItems, 0, _count); //Copia um array para um novo array
                    _items = newItems;
                }
            }
        }

        public T this[int index]
        {
            get => _items[index];
            set
            {
                _items[index] = value;
                OnChanged();
            }
        }

        public void Add(T item) // adiciona itens na classe
        {
            if (_count == Capacity) Capacity = _count * 2;
            _items[_count] = item;
            _count++;
            OnChanged();
        }

        protected virtual void OnChanged() =>
            Changed?.Invoke(this, EventArgs.Empty);// vai referencia o evente changer que vai invocar o proprio objeto 

        public event EventHandler Changed;

        public override bool Equals(object other) => Equals(this, other as MyList<T>);

        static bool Equals(MyList<T> a, MyList<T> b)
        {
            if (object.ReferenceEquals(a, null)) return Object.ReferenceEquals(b, null);

            if (object.ReferenceEquals(b, null) || a._count != b._count) return false;

            for (int i = 0; i < a._count; i++)
            {
                if (!object.Equals(a._items[i], b._items[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(MyList<T> a, MyList<T> b) => Equals(a, b); 

        public static bool operator !=(MyList<T> a, MyList<T> b) => !Equals(a, b);
    }
}
