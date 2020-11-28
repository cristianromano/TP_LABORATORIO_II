using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using ClaseAbstracta;
using ClasesInstanciables;

namespace TestsUnitarios
{
    [TestClass]
    public class Testing
    {
        /// <summary>
        /// verifico si la excepcion de alumno repetido funciona.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void AlumnoRepetido()
        {
            Universidad u1 = new Universidad();

            Alumno a1 = new Alumno(10, "Cristian", "Romano", "38525610", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno a2 = new Alumno(10, "Cristian", "Romano", "38525610", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            u1 += a1;
            u1 += a2;
        }

        /// <summary>
        /// verifico que el constructor funcione correctamente
        /// </summary>
        [TestMethod]
        public void ValidoConstructor()
        {
            Alumno a2 = new Alumno(2, "Juana", "Martinez", "155899", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.Deudor);

            Assert.IsNotNull(a2);
        }

        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void DniInvalidoException()
        {
          Alumno a2 = new Alumno(2, "Juana", "Martinez", "ABC", Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.Deudor);           
        }

    }
}
