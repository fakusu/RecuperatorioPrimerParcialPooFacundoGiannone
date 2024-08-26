using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.dll;




public class Esfera

{
    public readonly int Radio;
    private double Diametro;


    public calcularArea(int radio)
    {
        Volumen = 4 * (Math.pow(radio, 2))
    }
    public Esfera(int radio)
    {
        if (Radio <= 0)
        {
            throw new ArgumentException("El radio debe ser mayor que 0");
        }
        if (_diametro <= 0)
        {
            throw new ArgumentException("El diametro debe ser mayor que 0");
        }
        this.Radio = radio;
       Diametro= CalcularDiametro(radio);

    }
    public double CalcularDiametro(int radio) 
    {
        return radio * 2;
    }
    public string InformarRadio()
    {
        return Console.Writeline($"El Radio es {Radio} ");x`
    }
    public string InformarDiametro()
    {
        return Console.Writeline($"El diametro es {CalcularDiametro}")
    }

    public double InformarArea(int radio) 
    {
        return 4 * Math.PI * (Math.Pow(radio, 2);
    }
    public double informarVolumen(int Radio)
    {
        return 4/3 * Math.PI * Math.Pow(Radio, 3);
    }


    public void MostrarDatos()
    {
        Console.Writeline("Caracteristicas de la Esfera");
        Console.WriteLine($"-Area: {InformarArea}"):
            Console.Writelne($"-Volumen: {informarVolumen}")
    }

   
}
   
