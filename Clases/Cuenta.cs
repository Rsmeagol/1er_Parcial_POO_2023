public abstract class Cuenta{
    public Cuenta( eTipoCuenta tipocuenta, double saldo){
        this.TipoCuenta= tipocuenta;
        this.Saldo = saldo;
        
    }
    public Cuenta( eTipoCuenta tipocuenta, double saldo,string numeroCuenta):this(tipocuenta,saldo){
        this.Numero= numeroCuenta;
    }
    public string Numero{get;}
    public enum eTipoCuenta{
        CajaAhorro,
        CuentaCorriente,
        CuentaSueldo
    }
    public eTipoCuenta TipoCuenta{get;}
    public double Saldo{get;}

    public double AplicarCredito(Single credito){
        return this.Saldo + credito;
    }
    public double AplicarDebito(Single debito){
        double saldodebitado = this.Saldo;
        

        if(this.Saldo <= debito){
            saldodebitado -= debito;
            Console.WriteLine($"Verificar Descubierto: {saldodebitado}");
            this.Descubierto = saldodebitado;
            return saldodebitado;
        }
        else
        {
        saldodebitado -= debito;
        return saldodebitado;
        }
    }
    public double Descubierto{get;set;}

    public abstract double CobrarMantenimiento();

}
public class CajaAhorro:Cuenta{
    public CajaAhorro(eTipoCuenta tipocuenta, double saldo,string numeroCuenta):base(tipocuenta,saldo,numeroCuenta){
        
    }
    public override double CobrarMantenimiento(){
        double saldoMantenimientoCobrado = this.Saldo;
        Single mantenimiento = 1500;

        saldoMantenimientoCobrado = AplicarDebito(mantenimiento);

        Console.WriteLine($"Se a realizado el cobro del mantenimiento: ${mantenimiento}");

        return saldoMantenimientoCobrado;
    }
    
}
public class CuentaCorriente:Cuenta{
    public CuentaCorriente(eTipoCuenta tipocuenta, double saldo,string numeroCuenta):base(tipocuenta,saldo,numeroCuenta){
        
    }
    public override double CobrarMantenimiento(){
        double saldoMantenimientoCobrado = this.Saldo;
        Single mantenimiento = 1500;

        saldoMantenimientoCobrado = AplicarDebito(mantenimiento);

        Console.WriteLine($"Se a realizado el cobro del mantenimiento: ${mantenimiento}");

        return saldoMantenimientoCobrado;
    }
    
}
public class CuentaSueldo:Cuenta{
    public CuentaSueldo(eTipoCuenta tipocuenta, double saldo,string numeroCuenta):base(tipocuenta,saldo,numeroCuenta){
        
    }
    public override double CobrarMantenimiento(){
            return this.Saldo;
    }
    
    
}

public class Cliente{
    private List<Cuenta> Cuentas;

    public Cliente(string usuario){
        Usuario=usuario;
    }
    public string Nombre{get;set;}
    public string Apellido{get;set;}
    public string Usuario{get;}
    public string Clave{get; private set;}
    public double LimiteCredito{get;set;}

    public double Descubierto{get;set;}

    private Cuenta cuentaabuscar;
    public Cuenta BuscarCuenta(string nrocuenta){
        cuentaabuscar = null;
        foreach(var cuent in Cuentas){
            if (cuent.Numero == nrocuenta){
                cuentaabuscar = cuent;
            }
            }
            return cuentaabuscar;
    }
    public Cuenta cuenta{get{
            return cuentaabuscar;
    }}

    public int cantidadCuentas{
        get{
            var cuentasTotal = 0;
                foreach(var cuenta in Cuentas)
                {
                    cuentasTotal++;
                }
            return cuentasTotal;
        }
    }
    public double DescubiertoxCliente(){
        double descubiertoTotal = 0;
        foreach(var cuen in Cuentas){
            descubiertoTotal+= cuen.Descubierto;
        }
        return descubiertoTotal;
    }

    public void CambiarClave(string ClaveNueva){
        this.Clave=ClaveNueva;
    }

    public void AgregarCuentas(Cuenta cuenta){
        if (Cuentas is null)
        Cuentas = new List<Cuenta>();
        Cuentas.Add(cuenta);
    }

}
public class Movimiento
{
    public DateTime Fecha{get;set;}
    public int Monto{get;set;}
    public enum eTipoMovimiento{
        Debito,
        Credito
    }

}