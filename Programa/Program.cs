var cuenta1 = new CajaAhorro("123456",Cuenta.eTipoCuenta.CajaAhorro,10000);

var cuenta2 = new CuentaCorriente("222555",Cuenta.eTipoCuenta.CuentaCorriente,15000);

var cuenta3 = new CuentaSueldo("4455",Cuenta.eTipoCuenta.CuentaSueldo,2500);

var cliente1= new Cliente("rsmeagol");
var cliente2= new Cliente("Legolas1");

cliente1.AgregarCuentas(cuenta1);
cliente1.AgregarCuentas(cuenta2);
cliente2.AgregarCuentas(cuenta3);
cliente1.CambiarClave("Nueva Clave");


Console.WriteLine(cliente1.Usuario);
Console.WriteLine(cliente1.Clave);
cliente1.CambiarClave("Cambie la Clave");
Console.WriteLine(cliente1.cantidadCuentas);
Console.WriteLine(cliente1.Clave);
Console.WriteLine(cliente2.Usuario);
Console.WriteLine(cliente2.cantidadCuentas);
Console.WriteLine(cuenta1.Numero);
cuenta1.CobrarMantenimiento(1000);

Console.WriteLine("Mensaje de Prueba");