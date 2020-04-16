using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebApplication2;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
	public List<ObjConsuta> GetData()
	{
		return Consulta.ConsultarDatos();
	}

	//public CompositeType GetDataUsingDataContract(CompositeType composite)
	//{
	//	if (composite == null)
	//	{
	//		throw new ArgumentNullException("composite");
	//	}
	//	if (composite.BoolValue)
	//	{
	//		composite.StringValue += "Suffix";
	//	}
	//	return composite;
	//}
}
