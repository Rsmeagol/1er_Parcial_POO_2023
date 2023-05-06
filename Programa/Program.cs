var cuenta1 = new CajaAhorro(Cuenta.eTipoCuenta.CajaAhorro,1510,"123456");

var cuenta2 = new CuentaCorriente(Cuenta.eTipoCuenta.CuentaCorriente,1500,"222555");

var cuenta3 = new CuentaSueldo(Cuenta.eTipoCuenta.CuentaSueldo,2500,"4455");


var cliente1= new Cliente("rsmeagol");
var cliente2= new Cliente("Legolas1");

cliente1.AgregarCuentas(cuenta1);
cliente1.AgregarCuentas(cuenta2);
cliente2.AgregarCuentas(cuenta3);



cliente1.BuscarCuenta("123456");
Console.WriteLine(cliente1.cuenta);

cuenta1.AplicarDebito(2000);
Console.WriteLine(cuenta1.Descubierto);
cuenta2.AplicarDebito(2000);
Console.WriteLine(cuenta2.Descubierto);

cliente1.Descubierto = cliente1.DescubiertoxCliente();
Console.WriteLine(cliente1.Descubierto);

cliente1.LimiteCredito = 900;

