using Act2PI;
namespace TestAct2PI
{
    [TestClass]
    public class FuncionesTests
    {
        [DataTestMethod]
        [DataRow(-1, -1)]
        [DataRow(0, 1)] 
        [DataRow(6, 720)]
        public void CalcularFactorial_Pruebas(int numero, long esperado)
        {

            long resultado = Funciones.CalcularFactorial(numero);

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void ContrasenyaVacia()
        {
            string contrasenya = "";
            bool resultado = Funciones.EsContrasenyaValida(contrasenya);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void ContrasenyaNull()
        {
            string contrasenya = null;
            bool resultado = Funciones.EsContrasenyaValida(contrasenya);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void ContrasenyaCorta()
        {
            string contrasenya = "a#123";
            bool resultado = Funciones.EsContrasenyaValida(contrasenya);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void ContrasenyaSinHashtag()
        {
            string contrasenya = "abcdefgh";
            bool resultado = Funciones.EsContrasenyaValida(contrasenya);
            Assert.IsFalse(resultado);
        }
    }
}
