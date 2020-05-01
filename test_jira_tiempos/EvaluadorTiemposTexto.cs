using jira_tiempos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test_jira_tiempos
{
    [TestClass]
    public class EvaluadorTiemposTexto
    {
        [TestMethod]
        public void Segundos()
        {
            #region Segundos
            var retorno = JiraTiempos.Evaluar($"{1}s");
            Assert.AreEqual("1s", retorno);
            #endregion
            #region Minutos
            retorno = JiraTiempos.Evaluar($"{1 * 60}s");
            Assert.AreEqual("1m", retorno);

            retorno = JiraTiempos.Evaluar($"{1 * 60 + 30}s");
            Assert.AreEqual("1m 30s", retorno);
            #endregion
            #region Horas
            retorno = JiraTiempos.Evaluar($"{1 * 60 * 60}s");
            Assert.AreEqual("1h", retorno);

            retorno = JiraTiempos.Evaluar($"{1 * 60 * 60 + 30 * 60}s");
            Assert.AreEqual("1h 30m", retorno);

            retorno = JiraTiempos.Evaluar($"{1 * 60 * 60 + 30 * 60 + 30}s");
            Assert.AreEqual("1h 30m 30s", retorno);
            #endregion
            #region Dias
            retorno = JiraTiempos.Evaluar($"{1 * 60 * 60 * 8}s");
            Assert.AreEqual("1d", retorno);

            retorno = JiraTiempos.Evaluar($"{1 * 60 * 60 * 8 + 7 * 60 * 60}s");
            Assert.AreEqual("1d 7h", retorno);

            retorno = JiraTiempos.Evaluar($"{1 * 60 * 60 * 8 + 7 * 60 * 60 + 30 * 60}s");
            Assert.AreEqual("1d 7h 30m", retorno);

            retorno = JiraTiempos.Evaluar($"{1 * 60 * 60 * 8 + 7 * 60 * 60 + 30 * 60 + 30}s");
            Assert.AreEqual("1d 7h 30m 30s", retorno);
            #endregion
            #region Semanas
            retorno = JiraTiempos.Evaluar($"{2 * 60 * 60 * 8 * 5  }s");
            Assert.AreEqual("2w", retorno);

            retorno = JiraTiempos.Evaluar($"{1 * 60 * 60 * 8 * 5 + 4 * 60 * 60 * 8  }s");
            Assert.AreEqual("1w 4d", retorno);

            retorno = JiraTiempos.Evaluar($"{1 * 60 * 60 * 8 * 5 + 4 * 60 * 60 * 8 + 7 * 60 * 60 }s");
            Assert.AreEqual("1w 4d 7h", retorno);

            retorno = JiraTiempos.Evaluar($"{1 * 60 * 60 * 8 * 5 + 4 * 60 * 60 * 8 + 7 * 60 * 60 + 30 * 60}s");
            Assert.AreEqual("1w 4d 7h 30m", retorno);

            retorno = JiraTiempos.Evaluar($"{1 * 60 * 60 * 8 * 5 + 4 * 60 * 60 * 8 + 7 * 60 * 60 + 30 * 60 + 30}s");
            Assert.AreEqual("1w 4d 7h 30m 30s", retorno);
            #endregion
            #region Mes
            retorno = JiraTiempos.Evaluar($"{3 * 60 * 60 * 8 * 5 * 4}s");
            Assert.AreEqual("3M", retorno);

            retorno = JiraTiempos.Evaluar($"{3 * 60 * 60 * 8 * 5 * 4 + 2 * 60 * 60 * 8 * 5  }s");
            Assert.AreEqual("3M 2w", retorno);

            retorno = JiraTiempos.Evaluar($"{3 * 60 * 60 * 8 * 5 * 4 + 1 * 60 * 60 * 8 * 5 + 4 * 60 * 60 * 8  }s");
            Assert.AreEqual("3M 1w 4d", retorno);

            retorno = JiraTiempos.Evaluar($"{3 * 60 * 60 * 8 * 5 * 4 + 1 * 60 * 60 * 8 * 5 + 4 * 60 * 60 * 8 + 7 * 60 * 60 }s");
            Assert.AreEqual("3M 1w 4d 7h", retorno);

            retorno = JiraTiempos.Evaluar($"{3 * 60 * 60 * 8 * 5 * 4 + 1 * 60 * 60 * 8 * 5 + 4 * 60 * 60 * 8 + 7 * 60 * 60 + 30 * 60}s");
            Assert.AreEqual("3M 1w 4d 7h 30m", retorno);

            retorno = JiraTiempos.Evaluar($"{3 * 60 * 60 * 8 * 5 * 4 + 1 * 60 * 60 * 8 * 5 + 4 * 60 * 60 * 8 + 7 * 60 * 60 + 30 * 60 + 30}s");
            Assert.AreEqual("3M 1w 4d 7h 30m 30s", retorno);
            #endregion
        }
        [TestMethod]
        public void Minutos()
        {
            #region Minutos
            var retorno = JiraTiempos.Evaluar($"{1 }m");
            Assert.AreEqual("1m", retorno);
            #endregion
            #region Horas
            retorno = JiraTiempos.Evaluar($"{1 * 60 }m");
            Assert.AreEqual("1h", retorno);

            retorno = JiraTiempos.Evaluar($"{1 * 60 + 30}m");
            Assert.AreEqual("1h 30m", retorno);
            #endregion
            #region Dias
            retorno = JiraTiempos.Evaluar($"{1 * 60 * 8}m");
            Assert.AreEqual("1d", retorno);

            retorno = JiraTiempos.Evaluar($"{1 * 60 * 8 + 7 * 60}m");
            Assert.AreEqual("1d 7h", retorno);

            retorno = JiraTiempos.Evaluar($"{1 * 60 * 8 + 7 * 60 + 30 }m");
            Assert.AreEqual("1d 7h 30m", retorno);
            #endregion
            #region Semanas
            retorno = JiraTiempos.Evaluar($"{2 * 60 * 8 * 5  }m");
            Assert.AreEqual("2w", retorno);

            retorno = JiraTiempos.Evaluar($"{1 * 60 * 8 * 5 + 4 * 60 * 8  }m");
            Assert.AreEqual("1w 4d", retorno);

            retorno = JiraTiempos.Evaluar($"{1 * 60 * 8 * 5 + 4 * 60 * 8 + 7 * 60 }m");
            Assert.AreEqual("1w 4d 7h", retorno);

            retorno = JiraTiempos.Evaluar($"{1 * 60 * 8 * 5 + 4 * 60 * 8 + 7 * 60 + 30 }m");
            Assert.AreEqual("1w 4d 7h 30m", retorno);
            #endregion
            #region Mes
            retorno = JiraTiempos.Evaluar($"{3 * 60  * 8 * 5 * 4}m");
            Assert.AreEqual("3M", retorno);

            retorno = JiraTiempos.Evaluar($"{3  * 60 * 8 * 5 * 4 + 2 * 60  * 8 * 5  }m");
            Assert.AreEqual("3M 2w", retorno);

            retorno = JiraTiempos.Evaluar($"{3 * 60 * 8 * 5 * 4 + 1 * 60 * 8 * 5 + 4 * 60  * 8  }m");
            Assert.AreEqual("3M 1w 4d", retorno);

            retorno = JiraTiempos.Evaluar($"{3 * 60  * 8 * 5 * 4 + 1 * 60  * 8 * 5 + 4 * 60  * 8 + 7 * 60 }m");
            Assert.AreEqual("3M 1w 4d 7h", retorno);

            retorno = JiraTiempos.Evaluar($"{3 * 60  * 8 * 5 * 4 + 1 * 60 * 8 * 5 + 4 * 60  * 8 + 7  * 60 + 30 }m");
            Assert.AreEqual("3M 1w 4d 7h 30m", retorno);
            #endregion
        }
        [TestMethod]
        public void Horas()
        {
            #region Horas
            var retorno = JiraTiempos.Evaluar($"{1  }h");
            Assert.AreEqual("1h", retorno);
            #endregion
            #region Dias
            retorno = JiraTiempos.Evaluar($"{1 * 8}h");
            Assert.AreEqual("1d", retorno);

            retorno = JiraTiempos.Evaluar($"{1 * 8 + 7 }h");
            Assert.AreEqual("1d 7h", retorno);
            #endregion
            #region Semanas
            retorno = JiraTiempos.Evaluar($"{2 * 8 * 5  }h");
            Assert.AreEqual("2w", retorno);

            retorno = JiraTiempos.Evaluar($"{1 * 8 * 5 + 4 * 8  }h");
            Assert.AreEqual("1w 4d", retorno);

            retorno = JiraTiempos.Evaluar($"{1 * 8 * 5 + 4 * 8 + 7}h");
            Assert.AreEqual("1w 4d 7h", retorno);
            #endregion
            #region Mes
            retorno = JiraTiempos.Evaluar($"{3  * 8 * 5 * 4}h");
            Assert.AreEqual("3M", retorno);

            retorno = JiraTiempos.Evaluar($"{3  * 8 * 5 * 4 + 2 * 8 * 5  }h");
            Assert.AreEqual("3M 2w", retorno);

            retorno = JiraTiempos.Evaluar($"{3 * 8 * 5 * 4 + 1  * 8 * 5 + 4  * 8  }h");
            Assert.AreEqual("3M 1w 4d", retorno);

            retorno = JiraTiempos.Evaluar($"{3  * 8 * 5 * 4 + 1  * 8 * 5 + 4 * 8 + 7 }h");
            Assert.AreEqual("3M 1w 4d 7h", retorno);
            #endregion

        }
        [TestMethod]
        public void Dias()
        {
            #region Dias
            var retorno = JiraTiempos.Evaluar($"{1 }d");
            Assert.AreEqual("1d", retorno);
            #endregion
            #region Semanas
            retorno = JiraTiempos.Evaluar($"{2 * 5  }d");
            Assert.AreEqual("2w", retorno);

            retorno = JiraTiempos.Evaluar($"{1 * 5 + 4   }d");
            Assert.AreEqual("1w 4d", retorno);
            #endregion
            #region Mes
            retorno = JiraTiempos.Evaluar($"{3  * 5 * 4}d");
            Assert.AreEqual("3M", retorno);

            retorno = JiraTiempos.Evaluar($"{3  * 5 * 4 + 2 * 5  }d");
            Assert.AreEqual("3M 2w", retorno);

            retorno = JiraTiempos.Evaluar($"{3  * 5 * 4 + 1  * 5 + 4   }d");
            Assert.AreEqual("3M 1w 4d", retorno);
            #endregion
        }
        [TestMethod]
        public void Semanas()
        {
            #region Semanas
            var retorno = JiraTiempos.Evaluar($"{2}w");
            Assert.AreEqual("2w", retorno);
            #endregion
            #region Mes
            retorno = JiraTiempos.Evaluar($"{3  * 4}w");
            Assert.AreEqual("3M", retorno);

            retorno = JiraTiempos.Evaluar($"{3 * 4 + 2   }w");
            Assert.AreEqual("3M 2w", retorno);
            #endregion
        }
        [TestMethod]
        public void Meses()
        {
            #region Meses
            var retorno = JiraTiempos.Evaluar($"{2}M");
            Assert.AreEqual("2M", retorno);
            #endregion
        }
    }
}
