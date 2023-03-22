//el codigo nuevo para program utilizando DAO se inicia en la linea numero 50.
//en la clase de program y comentaras ese código
//using Semana9.Models;

//Console.WriteLine("Bienvenido a tu BD favorita.");
//Console.WriteLine("Ingresa los siguientes datos.");

//#region isertar tus datos
////para ingresar datos a la BD
//using (AlmacenContext db = new
//    AlmacenContext())
//{

//    Producto producto = new Producto();

//    Console.WriteLine("Ingresa tu nombre: ");
//    producto.Nombre = Console.ReadLine();

//    Console.WriteLine("Decribe el articulo: ");
//    producto.Descripción = Console.ReadLine();

//    Console.WriteLine("Ingresa su precio: ");
//    producto.Precio = float.Parse(Console.ReadLine());

//    Console.WriteLine("Ingresa numero de stock: ");
//    producto.Stock = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("=======================================================================");
//    Console.WriteLine("...Por favor espere mientras se cargan sus datos a la base de datos...");

//    db.Productos.Add(producto);
//    db.SaveChanges();

//    var ListProductos = db.Productos.ToList();
//    foreach (var prod in ListProductos)
//    {

//        Console.WriteLine("Sus datos ingresados son: \n");
//        Console.WriteLine("Nombre: " + prod.Nombre);
//        Console.WriteLine("Descripción: " + prod.Descripción);
//        Console.WriteLine("Precio: " + prod.Precio);
//        Console.WriteLine("Numero de Stock: " + prod.Stock);
//        Console.WriteLine("Gracias por tu paciencia. Ten un lindo dia.");
//    }
//}
//#endregion



using Semana9.Models;
using Semana9.DAO;

CrudProductos CrudProductos = new CrudProductos();
Producto Producto = new Producto();

Console.WriteLine("Bienvenido de nuevo a tu base BD favorita.");
Console.WriteLine("Ingresa un numero del menu siguiente.\n");
Console.WriteLine("pulse 1 para ingresar un producto.");
Console.WriteLine("pulse 2 para listar los datos en BD.");
Console.WriteLine("Pulsa 3 para salir.");
var Menu = Convert.ToInt32(Console.ReadLine());


switch (Menu)
{

    case 1:
        int bucle = 1;
        while (bucle == 1)
        {
            Console.WriteLine("Ingresa tu nombre: ");
            Producto.Nombre = Console.ReadLine();

            Console.WriteLine("Decribe el articulo: ");
            Producto.Descripción = Console.ReadLine();

            Console.WriteLine("Ingresa su precio: ");
            //en el dato precio uso el float.parse para covertir.
            Producto.Precio = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa numero de stock: ");
            Producto.Stock = Convert.ToInt32(Console.ReadLine());

            CrudProductos.AgregarProducto(Producto);

            Console.WriteLine("El producto se ingreso correctamente.");
            Console.WriteLine("Pulsa 1 para seguir insertando datos.\n");
            Console.WriteLine("Pulsa un numero diferente de 1 para salir.");
            bucle = Convert.ToInt32(Console.ReadLine());
        }
        break;

    //Aqui ingeniero William hago un listar asi como en la actividad de semana 8 con un foreach.
    //mostrando todos los datos
    case 2:
        int caso2 = 2;
        while (caso2 == 2)
        {

            using (AlmacenContext db = new
                AlmacenContext()) {

                Console.WriteLine("...Por favor espere mientras se cargan sus datos a la base de datos...");
                Console.WriteLine("Tus datos en la BD son: \n");
                var ListProductos = db.Productos.ToList();
                foreach (var prod in ListProductos)
                {

                    Console.WriteLine("===========================================");
                    Console.WriteLine(" 1.Nombre: " + prod.Nombre);
                    Console.WriteLine(" 2.Descripción: " + prod.Descripción); 
                    Console.WriteLine(" 3.Precio: " + prod.Precio);
                    Console.WriteLine(" 4.Numero de Stock: " + prod.Stock);
                    Console.WriteLine("===========================================");

                }
                Console.WriteLine("Gracias por tu paciencia. Ten un lindo dia.");
                break;
            }

        }
        break;
    case 3:
        Console.WriteLine("Adios");
        break;
}