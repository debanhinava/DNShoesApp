using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesData;
namespace Shoes.Business
{
    public class NegocioProducts
    {
        DatoProducts metodos = new DatoProducts();
        public bool Guardar(EntidadProducts dat)
        {
            
            Products tblPro = new Products();

            tblPro.Id = dat.Id;
            tblPro.IdType = dat.IdType;
            tblPro.IdBrand = dat.IdBrand;
            tblPro.Nombre = dat.Nombre;

            return metodos.Guardar(tblPro);
        }
        

        //public List <Products>MostrarDatos()
        //{
        //    return metodos.MostrarDatos();
        //}
    }
}
