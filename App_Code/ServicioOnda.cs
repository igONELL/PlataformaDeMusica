using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.

// Implementación, que es donde vamos a escribir lo que hacen los métodos publicados en internet
public class ServicioOnda : IServicioOnda
{
    Onda IServicioOnda.ModificarFrequenciaOnda(Onda onda, float longitud) // longitud = x
    {
        return onda;
    }

    Onda IServicioOnda.ModificarRecorridoOnda(Onda onda, float recorrido) // recorrido = y
    {
        return onda;
    }

    IServicioOnda.ObtenerTangente(Onda onda)
    {
        return onda.calcularArcoTangente();
    }
    
    

}
