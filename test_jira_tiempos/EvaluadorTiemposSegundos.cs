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
            #region Segundos
            var retorno = JiraTiempos.Evaluar(1);
            Assert.AreEqual("1s", retorno);
            #endregion
            #region Minutos
            retorno = JiraTiempos.Evaluar(1 * 60);
            Assert.AreEqual("1m", retorno);

            retorno = JiraTiempos.Evaluar(1 * 60 + 30);
            Assert.AreEqual("1m 30s", retorno);
            #endregion
            #region Horas
            retorno = JiraTiempos.Evaluar(1 * 60 * 60);
            Assert.AreEqual("1h", retorno);

            retorno = JiraTiempos.Evaluar(1 * 60 * 60 + 30 * 60);
            Assert.AreEqual("1h 30m", retorno);

            retorno = JiraTiempos.Evaluar(1 * 60 * 60 + 30 * 60 + 30);
            Assert.AreEqual("1h 30m 30s", retorno);
            #endregion
            #region Dias
            retorno = JiraTiempos.Evaluar(1 * 60 * 60 * 8);
            Assert.AreEqual("1d", retorno);

            retorno = JiraTiempos.Evaluar(1 * 60 * 60 * 8 + 7 * 60 * 60);
            Assert.AreEqual("1d 7h", retorno);

            retorno = JiraTiempos.Evaluar(1 * 60 * 60 * 8 + 7 * 60 * 60 + 30 * 60);
            Assert.AreEqual("1d 7h 30m", retorno);

            retorno = JiraTiempos.Evaluar(1 * 60 * 60 * 8 + 7 * 60 * 60 + 30 * 60 + 30);
            Assert.AreEqual("1d 7h 30m 30s", retorno);
            #endregion
            #region Semanas
            retorno = JiraTiempos.Evaluar(2 * 60 * 60 * 8 * 5  );
            Assert.AreEqual("2w", retorno);

            retorno = JiraTiempos.Evaluar(1 * 60 * 60 * 8 * 5 + 4 * 60 * 60 * 8  );
            Assert.AreEqual("1w 4d", retorno);

            retorno = JiraTiempos.Evaluar(1 * 60 * 60 * 8 * 5 + 4 * 60 * 60 * 8 + 7 * 60 * 60 );
            Assert.AreEqual("1w 4d 7h", retorno);

            retorno = JiraTiempos.Evaluar(1 * 60 * 60 * 8 * 5 + 4 * 60 * 60 * 8 + 7 * 60 * 60 + 30 * 60);
            Assert.AreEqual("1w 4d 7h 30m", retorno);

            retorno = JiraTiempos.Evaluar(1 * 60 * 60 * 8 * 5 + 4 * 60 * 60 * 8 + 7 * 60 * 60 + 30 * 60 + 30);
            Assert.AreEqual("1w 4d 7h 30m 30s", retorno);
            #endregion
            #region Mes
            retorno = JiraTiempos.Evaluar(3 * 60 * 60 * 8 * 5 * 4);
            Assert.AreEqual("3M", retorno);

            retorno = JiraTiempos.Evaluar(3 * 60 * 60 * 8 * 5 * 4 + 2 * 60 * 60 * 8 * 5  );
            Assert.AreEqual("3M 2w", retorno);

            retorno = JiraTiempos.Evaluar(3 * 60 * 60 * 8 * 5 * 4 + 1 * 60 * 60 * 8 * 5 + 4 * 60 * 60 * 8  );
            Assert.AreEqual("3M 1w 4d", retorno);

            retorno = JiraTiempos.Evaluar(3 * 60 * 60 * 8 * 5 * 4 + 1 * 60 * 60 * 8 * 5 + 4 * 60 * 60 * 8 + 7 * 60 * 60 );
            Assert.AreEqual("3M 1w 4d 7h", retorno);

            retorno = JiraTiempos.Evaluar(3 * 60 * 60 * 8 * 5 * 4 + 1 * 60 * 60 * 8 * 5 + 4 * 60 * 60 * 8 + 7 * 60 * 60 + 30 * 60);
            Assert.AreEqual("3M 1w 4d 7h 30m", retorno);

            retorno = JiraTiempos.Evaluar(3 * 60 * 60 * 8 * 5 * 4 + 1 * 60 * 60 * 8 * 5 + 4 * 60 * 60 * 8 + 7 * 60 * 60 + 30 * 60 + 30);
            Assert.AreEqual("3M 1w 4d 7h 30m 30s", retorno);
            #endregion
            #region Años
            retorno = JiraTiempos.Evaluar(2 * 60 * 60 * 8 * 5 * 4 * 12);
            Assert.AreEqual("2a", retorno);

            retorno = JiraTiempos.Evaluar(2 * 60 * 60 * 8 * 5 * 4 * 12 + 3 * 60 * 60 * 8 * 5 * 4);
            Assert.AreEqual("2a 3M", retorno);

            retorno = JiraTiempos.Evaluar(2 * 60 * 60 * 8 * 5 * 4 * 12 + 3 * 60 * 60 * 8 * 5 * 4 + 2 * 60 * 60 * 8 * 5  );
            Assert.AreEqual("2a 3M 2w", retorno);

            retorno = JiraTiempos.Evaluar(2 * 60 * 60 * 8 * 5 * 4 * 12 + 3 * 60 * 60 * 8 * 5 * 4 + 1 * 60 * 60 * 8 * 5 + 4 * 60 * 60 * 8  );
            Assert.AreEqual("2a 3M 1w 4d", retorno);

            retorno = JiraTiempos.Evaluar(2 * 60 * 60 * 8 * 5 * 4 * 12 + 3 * 60 * 60 * 8 * 5 * 4 + 1 * 60 * 60 * 8 * 5 + 4 * 60 * 60 * 8 + 7 * 60 * 60 );
            Assert.AreEqual("2a 3M 1w 4d 7h", retorno);

            retorno = JiraTiempos.Evaluar(2 * 60 * 60 * 8 * 5 * 4 * 12 + 3 * 60 * 60 * 8 * 5 * 4 + 1 * 60 * 60 * 8 * 5 + 4 * 60 * 60 * 8 + 7 * 60 * 60 + 30 * 60);
            Assert.AreEqual("2a 3M 1w 4d 7h 30m", retorno);

            retorno = JiraTiempos.Evaluar(2 * 60 * 60 * 8 * 5 * 4 * 12 + 3 * 60 * 60 * 8 * 5 * 4 + 1 * 60 * 60 * 8 * 5 + 4 * 60 * 60 * 8 + 7 * 60 * 60 + 30 * 60 + 30);
            Assert.AreEqual("2a 3M 1w 4d 7h 30m 30s", retorno);
            #endregion
        }
    }
}
