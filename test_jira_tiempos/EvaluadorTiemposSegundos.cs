using Microsoft.VisualStudio.TestTools.UnitTesting;
using jira_tiempos;
namespace test_jira_tiempos
{
    [TestClass]
    public class EvaluadorTiemposSegundos
    {
        [TestMethod]
        public void Segundos()
        {
            var resultado = JiraTiempos.Evaluar(1);
            Assert.AreEqual(resultado, "1s");
        }
        [TestMethod]
        public void MinutosExactos()
        {
            var resultado = JiraTiempos.Evaluar(60);
            Assert.AreEqual("1m", resultado);
        }
        [TestMethod]
        public void MinutosInexactos()
        {
            var resultado = JiraTiempos.Evaluar(115);
            Assert.AreEqual("1m 55s", resultado);
        }
        [TestMethod]
        public void HorasExactas()
        {
            var resultado = JiraTiempos.Evaluar(60*60);
            Assert.AreEqual("1h", resultado);
        }
        [TestMethod]
        public void HorasMinutoExactas()
        {
            var resultado = JiraTiempos.Evaluar(60*60+30*60);
            Assert.AreEqual("1h 30m", resultado);
        }
        [TestMethod]
        public void HorasSegundo()
        {
            var resultado = JiraTiempos.Evaluar(60*60+30);
            Assert.AreEqual("1h 30s", resultado);
        }

        [TestMethod]
        public void HorasMinutoSegundo()
        {
            var resultado = JiraTiempos.Evaluar(60 * 60 + 30*60+30);
            Assert.AreEqual("1h 30m 30s", resultado);
        }
    }
}
