using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// testeo que me devuelva una excepcion en caso de pasarle un parametro al constructor de tipo vacio o nullo
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ProductosException))]
        public void FaltanDatosProducto()
        {
            string prod = null;
            
                if(string.IsNullOrEmpty(prod))
                {
                    Producto producto = new Producto(prod, 40, 70, "HFCW53");

                    throw new ProductosException();
                }                                                       

        }

        /// <summary>
        /// testeo que no me devuelva nulo al crear un producto nuevo
        /// </summary>
        [TestMethod]
        public void testeoConstructor()
        {
            Producto producto = new Producto("Alfajor", 47, 10, "GF45G");

            Assert.IsNotNull(producto);
        }


    }
}
