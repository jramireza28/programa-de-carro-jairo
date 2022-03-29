using static programa_de_carro.Class1;

Carro JairoCarrito = new Carro("BMW", 2022, "Rojo");
JairoCarrito.marcamodelo();
Console.WriteLine();
JairoCarrito.EncenderMotor();

for (int i = 0; i < 5; i++)
{
    JairoCarrito.acelerar();//acelerar
}



Console.WriteLine();
Console.WriteLine("Carro que va enfrente frena de la nada");
Console.WriteLine();



    JairoCarrito.Bocina();//bocinar


Console.WriteLine();
Console.WriteLine("Disminuyendo la velocidad");
Console.WriteLine();
for (int i = 0; i < 6; i++)
{
    JairoCarrito.disminuir();//disminucion de velocidad
}

Console.WriteLine();
Console.WriteLine("Has frenado el auto");
Console.WriteLine();

    JairoCarrito.Frenado();

Console.WriteLine();
Console.WriteLine("Me estaciono para parar el carro");
Console.WriteLine();

JairoCarrito.apagado();
