
using Pedidos;
using static System.Runtime.InteropServices.JavaScript.JSType;

Producto producto = new Producto();
producto.Id = 1;
producto.Nombre = "Laptop";
producto.Precio = 5000;
producto.Stock = 10;

producto.MostrarInformacion();
producto.DisminuirStock(1);
producto.MostrarInformacion();
producto.MostrarInformacion();
producto.DisminuirStock(15);
producto.MostrarInformacion();


Producto producto1= new Producto();
producto.Id = 2;
producto.Nombre = "Mouse";
producto.Precio = 250;
producto.Stock = 15;

producto1.MostrarInformacion();
producto1.DisminuirStock(1);
producto1.MostrarInformacion();
producto1.MostrarInformacion();
producto1.DisminuirStock(15);
producto1.MostrarInformacion();