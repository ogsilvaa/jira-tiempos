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
            int _segundos, _minutos, _horas;

            _horas = segundos / Constantes.HORA;
            _minutos = (segundos - (_horas * Constantes.HORA)) / Constantes.MINUTO;
            _segundos = segundos - (_horas * Constantes.HORA) - (_minutos * Constantes.MINUTO);

            return Texto(_segundos, _minutos, _horas);
        }
        public static string Texto(int segundos, int minutos, int horas)
        {
            string _segundos, _minutos, _horas;
            _segundos = Parte(segundos, "s");
            _minutos = Parte(minutos, "m");
            _horas = Parte(horas, "h");
            return $"{_horas}{_minutos}{_segundos}".Trim();
        }
        public static string Parte(int cantidad, string unidad)
        {
            return cantidad > 0 ? $"{cantidad}{unidad} " : "";
        }
    }
}
