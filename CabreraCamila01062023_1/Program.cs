// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Persona Cami = new Persona("Camila", "Ecuatoriana","Femenino",new DateTime(2003,12,11));
Console.WriteLine(Cami.imprimir());
Console.WriteLine(Cami.mayorEdad());

class Persona : PersonaInterfaz
{
    public string nombre;
    public string nacionalidad;
    public int edad;
    public string genero;
    public DateTime fechaNac;
    public DateTime fechActual;

    public Persona(string nombre_, string nacionalidad_,string genero_,DateTime fechaNac_)
    {
        nombre = nombre_;
        nacionalidad = nacionalidad_;
        genero = genero_;
        fechActual = DateTime.Now;
        fechaNac = fechaNac_;
        edad = calcularedad();
    }

    public string imprimir()
    {
        return "Nombre: " + nombre + "\n" + "Edad: " + edad + "\n" + "Nacionalidad: " + nacionalidad+ "\n" + "Genero: " + genero;
    }
    public string mayorEdad()
    {
        if(edad > 17)
        {
            return "Mayor de edad";
        }
        else
        {
            return "Menor de edad";
        }
            
    }
    public int calcularedad()
    {

        int edad = fechActual.Year - fechaNac.Year;

        if (fechActual.Month < fechaNac.Month || (fechActual.Month == fechaNac.Month && fechActual.Day < fechaNac.Day))
        {
            edad--;
        }

        return edad;
    }

    
}

interface PersonaInterfaz
{
    public string imprimir();
    public string mayorEdad();
    public int calcularedad();

}

