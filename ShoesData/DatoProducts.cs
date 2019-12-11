using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShoesData
{
    public class DatoProducts
    {
        DataProductsEntities modeldb = new DataProductsEntities();
        public bool Guardar(Products dat)
        {
            modeldb.Products.Add(dat);
            modeldb.SaveChanges();
            return true;
        }

        //public List<Products> MostrarDatos()
        //{
        //    //var query = (from e in modeldb.Products
        //    //             select e);
        //    //return query.ToList(); 


        //    //var productIdParameter = new SqlParameter("@Id", 3);
        //    //var result = modeldb.Database
        //    //    .SqlQuery<EntidadProducts>("dena_sp_BusquedaProdId @Id", productIdParameter).ToList();
        //    //return result;
        //}
    }
}
