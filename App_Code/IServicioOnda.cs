using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IServicioOnda
{
    [OperationContract]
    Onda ModificarFrequenciaOnda(Onda onda, float longitud);

    [OperationContract]
    Onda ModificarRecorridoOnda(Onda onda, float recorrido);

    [OperationContract]
    int ObtenerTangente(Onda onda);

    // TODO: agregue aquí sus operaciones de servicio
}

// Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
[DataContract]
public class Onda
{
	private float _frecuencia, _altura;
    [DataMember]
    public float Frecuencia
    {
        get
        {
            return _frecuencia;
        }

        set
        {
            _frecuencia = value;
        }
    }
    [DataMember]
    public float Altura
    {
        get
        {
            return _altura;
        }

        set
        {
            _altura = value;
        }
    }
    // SIN ETIQUETA DATA MEMBER
    public float valorAbsolutoRecorrido (float altura)
    {
        return Math.Abs(altura);
    } 

    public float filtrarFrecuencia(float frecuencia)
    {
        return (frecuencia < 50.0f) ? frecuencia /= 2.0f :
        (frecuencia < 5.0f) ? frecuencia *= 2.0f :
        frecuencia;
    }

    public float calcularArcoTangente()
    {
        return (float)Math.Atan(_frecuencia); //no se ha probado aun
    }

    public float calcularArcoTangente(float frecuencia)
    {
        return (float)Math.Atan(frecuencia); //no se ha probado aun
    }
}
