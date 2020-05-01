using System.Collections.Generic;
using System.Linq;

namespace jira_tiempos
{
    public static class JiraTiempos
    {
        public static string Evaluar(string cadena)
        {
            var unidades = Calculos.PreparacionUnidades();
            var valores = Calculos.PreparacionValores(unidades);
            valores = Calculos.SegmentacionValores(cadena, valores, unidades);
            var valorEnSegundos = Calculos.CalculoSegundos(valores);
            var valorEnTexto = Evaluar(valorEnSegundos);
            return valorEnTexto;
        }
        public static string Evaluar(int segundos)
        {
            var unidades = Calculos.PreparacionUnidades();
            var valores = Calculos.PreparacionValores(unidades);
            var factores = Calculos.Factor();

            var keys = unidades.Keys.ToList();
            keys.Reverse();

            keys.ForEach(k =>
            {
                valores[k] = segundos / factores[k];
                segundos -= valores[k] * factores[k];
            });

            return Texto(valores);
        }
        private static string Texto(IDictionary<EUnidad, int> tiempos)
        {
            var unidades = Calculos.PreparacionUnidades();
            var valores = Calculos.PreparacionValores<string>(unidades);
            var keys = tiempos.Keys.ToList();
            var retorno = string.Empty;
            keys.Reverse();

            keys.ForEach(k =>
            {
                valores[k] = Parte(tiempos[k], unidades[k]);
            });

            keys.ForEach(k =>
            {
                retorno += valores[k];
            });
            return retorno.Trim();
        }
        public static string Parte(int cantidad, string unidad)
        {
            return cantidad > 0 ? $"{cantidad}{unidad} " : "";
        }
    }
}
