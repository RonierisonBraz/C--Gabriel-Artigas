using System;

namespace MetodosEstaticoseDeInstancia
{
    class Program
    {
        static void Main(string[] args)
        {
            Entity.SetNextSerilNo(1000);

            Entity e1 = new Entity();
            Entity e2 = new Entity();

            Console.WriteLine(e1.GetSerialNo());
            Console.WriteLine(e2.GetSerialNo());
            Console.WriteLine(Entity.GetNextSerialNo());

        }
    }

    class Entity
    {
        static int s_nextSerialNo;

        int _serialNo;

        public Entity()
        {
            _serialNo = s_nextSerialNo++;
        }

        public int GetSerialNo()
        {
            return _serialNo;
        }

        
       public static int GetNextSerialNo()
        {
            return s_nextSerialNo;
        }

        public static void SetNextSerilNo(int Value)
        {
            s_nextSerialNo = Value;
        }
    }
}
