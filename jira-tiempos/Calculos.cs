using System;
using System.Collections.Generic;
using System.Linq;

namespace jira_tiempos
{
    public static class Calculos
    {
        internal static List<string> PreparacionUnidades()
        {
            var unidades = new List<string> { "s", "m", "h" };
            return unidades;
        }

        internal static Dictionary<string, int> PreparacionValores(List<string> unidades)
        {
            var valores = new Dictionary<string, int>();

            unidades.ForEach(u => { valores.Add(u, 0); });
            return valores;
        }

        internal static int CalculoSegundos(Dictionary<string, int> valores)
        {
            var valorEnSegundos = valores["s"] +
                valores["m"] * Constantes.MINUTO +
                valores["h"] * Constantes.HORA;
            return valorEnSegundos;
        }

        internal static Dictionary<string, int> SegmentacionValores(string cadena, Dictionary<string, int> valores, List<string> unidades)
        {
            var tiempos = cadena.Split(' ').ToList();
            tiempos.ForEach(tiempo =>
            {
                unidades.ForEach(unidad =>
                {
                    if (tiempo.EndsWith(unidad))
                    {
                        var valor = tiempo.Substring(0, tiempo.Length - unidad.Length);
                        valores[unidad] = Convert.ToInt32(valor);
                    }
                });
            });
            return valores;
        }
    }
}
