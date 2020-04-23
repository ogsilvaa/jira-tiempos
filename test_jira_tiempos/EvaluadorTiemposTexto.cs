using jira_tiempos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test_jira_tiempos
{
    [TestClass]
    public class EvaluadorTiemposTexto
    {
        #region Segundos
        [TestMethod]
        public void Segundos_Segundos()
        {
            var retorno=JiraTiempos.Evaluar("1s");
            Assert.AreEqual("1s", retorno);
        }
        [TestMethod]
        public void Segundos_Minutos()
        {
            var retorno = JiraTiempos.Evaluar("60s");
            Assert.AreEqual("1m", retorno);
        }
        [TestMethod]
        public void Segundos_MinutosSegundos()
        {
            var retorno = JiraTiempos.Evaluar("66s");
            Assert.AreEqual("1m 6s", retorno);
        }
        [TestMethod]
        public void Segundos_Hora()
        {
            var retorno = JiraTiempos.Evaluar("3600s");
            Assert.AreEqual("1h", retorno);
        }
        [TestMethod]
        public void Segundos_HoraMinutos()
        {
            var retorno = JiraTiempos.Evaluar("3660s");
            Assert.AreEqual("1h 1m", retorno);
        }
        [TestMethod]
        public void Segundos_HoraSegundos()
        {
            var retorno = JiraTiempos.Evaluar("3630s");
            Assert.AreEqual("1h 30s", retorno);
        }
        [TestMethod]
        public void Segundos_HoraMinutosSegundos()
        {
            var retorno = JiraTiempos.Evaluar("3690s");
            Assert.AreEqual("1h 1m 30s", retorno);
        }
        #endregion
        #region Minutos
        [TestMethod]
        public void Minutos_Minutos()
        {
            var retorno = JiraTiempos.Evaluar("1m");
            Assert.AreEqual("1m", retorno);
        }
        [TestMethod]
        public void Minutos_Horas()
        {
            var retorno = JiraTiempos.Evaluar("60m");
            Assert.AreEqual("1h", retorno);
        }
        [TestMethod]
        public void Minutos_HorasMinutos()
        {
            var retorno = JiraTiempos.Evaluar("61m");
            Assert.AreEqual("1h 1m", retorno);
        }
        #endregion
        #region Horas
        [TestMethod]
        public void Horas_Horas()
        {
            var retorno = JiraTiempos.Evaluar("1h");
            Assert.AreEqual("1h", retorno);
        }
        #endregion
    }
}
