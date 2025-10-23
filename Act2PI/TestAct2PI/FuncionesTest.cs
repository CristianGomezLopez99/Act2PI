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
        [DataTestMethod]

        [DataRow("")]
        [DataRow(null)]
        [DataRow("a#123")]
        [DataRow("abcdefgh")]
        public void ContrasenyaInvalida(string contrasenya)
        {
            bool resultado = Funciones.EsContrasenyaValida(contrasenya);
            Assert.IsFalse(resultado);
        }

        [DataTestMethod]
        [DataRow("abc12345#")]
        [DataRow("abcd123#")]
        [DataRow("1234567#")]
        public void ContrasenyaValida(string contrasenya)
        {
            bool resultado = Funciones.EsContrasenyaValida(contrasenya);
            Assert.IsTrue(resultado);
        }
    }
}
