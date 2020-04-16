using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApplication2
{
    public static class Consulta
    {
        public static List<ObjConsuta> ConsultarDatos()
        {
            DiegoLopezEntities objConexion = new DiegoLopezEntities();
            var consulta = (from municipio in objConexion.Municipios
                            join departamento in objConexion.Departamentos on municipio.IdDepartamento equals departamento.IdDepartamento
                            select new ObjConsuta
                            {
                                IdDepto = departamento.IdDepartamento,
                                NombreDepto = departamento.DescripcionDepartamento,
                                IdMunicipio = municipio.IdMunicipio,
                                NombreMunicipio = municipio.DescripcionMunicipio
                            }).ToList();
            return consulta;
        }
    }

    [DataContract]
    public class ObjConsuta
    {
        [DataMember]
        public int IdDepto { get; set; }
        [DataMember]
        public string NombreDepto { get; set; }
        [DataMember]
        public int IdMunicipio { get; set; }
        [DataMember]
        public string NombreMunicipio { get; set; }    
    }
}