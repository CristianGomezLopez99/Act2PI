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
    }
}
