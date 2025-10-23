using Act2PI;
namespace TestAct2PI
{
    [TestClass]
    public class FuncionesTest
    {
        [TestMethod]
        public void Es_Negativo()
        {
            long result = Funciones.CalcularFactorial(-1);
            Assert.AreEqual(-1, result);
        }
        [TestMethod]
        public void Es_Cero()
        {
            long result = Funciones.CalcularFactorial(0);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Es_Positivo()
        {
            long result = Funciones.CalcularFactorial(6);
            Assert.AreEqual(720, result);
        }
    }
}
