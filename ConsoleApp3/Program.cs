using System;

namespace vehiculos
{
    class Program
    {
        class Vehiculo
        {
            private string _Marca;
            public string Marca
            {
                get { return _Marca; }
                set { _Marca = value; }
            }
            private string _Modelo;
            public string Modelo
            {
                get { return _Modelo; }
                set { _Modelo = value; }
            }
            private int _Año;
            public int Año
            {
                get { return _Año; }
                set { _Año = value; }
            }

            public Vehiculo(string marca, string modelo, int año)
            {
                Marca = marca;
                Modelo = modelo;
                Año = año;
            }

            public virtual void MostrarInformacion()
            {
                Console.WriteLine($"Marca: {Marca} \nModelo: {Modelo} \nAño: {Año}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--------VEHICULOS--------");
            Vehiculo vehi = new Vehiculo("Toyota", "Aveo", 2012);
            Vehiculo vehi2 = new Vehiculo("Chevrolet", "Supra", 2022);
            vehi.MostrarInformacion();
            Console.WriteLine("-----------------");
            vehi2.MostrarInformacion();
        }
    }
}
