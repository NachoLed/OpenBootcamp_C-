/// <summary>
/// Ejercicio 1
/// Crea una estructura de datos para un cliente con estos campos:
///     Nombre completo
///     Teléfono
///     Dirección
///     Email
///     Si es nuevo cliente
/// Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)
/// </summary>

public struct Cliente
    {
        public Cliente( string nombre, string telefono, string direccion, string email, bool esCliente)
        {
            Name = nombre;
            Phone = telefono;
            Adress = direccion;
            Mail = email;
            IsClient = esCliente;
        }

        public string Name { get; }

        public string Phone { get; }

        public string Adress { get; }

        public string Mail { get; }

        public bool IsClient { get; }

        public override string ToString() => $"Cliente: {Name}\n Telefono: {Phone}\n Direccion: {Adress}\n Email: {Mail}\n Cliente Nuevo: {IsClient}";
       
    }


