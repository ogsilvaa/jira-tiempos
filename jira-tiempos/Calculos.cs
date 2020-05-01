using System;
using System.Collections.Generic;
using System.Linq;

namespace jira_tiempos
{
    public static class Calculos
    {
        internal static IDictionary<EUnidad, int> Factor()
        {
            var _factor = new Dictionary<EUnidad, int> {
                            {EUnidad.Segundo,Constantes.Factores.SEGUNDO },
                            {EUnidad.Minuto,Constantes.Factores.MINUTO },
                            {EUnidad.Hora,Constantes.Factores.HORA },
                            {EUnidad.Dia,Constantes.Factores.DIA },
                            {EUnidad.Semana,Constantes.Factores.SEMANA },
                            {EUnidad.Mes,Constantes.Factores.MES },
                            {EUnidad.Año,Constantes.Factores.AÑO }
                        };

            return _factor;
        }
        internal static IDictionary<EUnidad, string> PreparacionUnidades()
        {
            var unidades = new Dictionary<EUnidad, string>
            {
                {EUnidad.Segundo,Constantes.Abreviaturas.Segundo },
                {EUnidad.Minuto,Constantes.Abreviaturas.Minuto },
                {EUnidad.Hora,Constantes.Abreviaturas.Hora },
                {EUnidad.Dia,Constantes.Abreviaturas.Dia },
                {EUnidad.Semana,Constantes.Abreviaturas.Semana },
                {EUnidad.Mes,Constantes.Abreviaturas.Mes },
                {EUnidad.Año,Constantes.Abreviaturas.Año }
            };
            return unidades;
        }

        internal static IDictionary<EUnidad, int> PreparacionValores(IDictionary<EUnidad, string> unidades)
        {
            return PreparacionValores<int>(unidades);
        }
        internal static IDictionary<EUnidad, T> PreparacionValores<T>(IDictionary<EUnidad, string> unidades)
        {
            var valores = new Dictionary<EUnidad, T>();

            unidades.Keys.ToList().ForEach(k => { valores.Add(k, default); });
            return valores;
        }

        internal static int CalculoSegundos(IDictionary<EUnidad, int> valores)
        {
            var factores = Factor();
            var valorEnSegundos = 0;
            valores.Keys.ToList().ForEach(k =>
            {
                valorEnSegundos += valores[k] * factores[k];
            });

            return valorEnSegundos;
        }

        internal static IDictionary<EUnidad, int> SegmentacionValores(string cadena, IDictionary<EUnidad, int> valores, IDictionary<EUnidad, string> unidades)
        {
            var tiempos = cadena.Split(' ').ToList();
            tiempos.ForEach(tiempo =>
            {
                unidades.Keys.ToList().ForEach(k =>
                {
                    if (tiempo.EndsWith(unidades[k]))
                    {
                        var valor = tiempo.Substring(0, tiempo.Length - unidades[k].Length);
                        valores[k] += Convert.ToInt32(valor);
                    }
                });
            });
            return valores;
        }
    }
}
