using System;
using System.Collections.Generic;
using System.Text;

namespace jira_tiempos
{
    class Constantes
    {
        public class Factores
        {
            public const int SEGUNDO = 1;
            public const int MINUTO = 60;
            public const int HORA = MINUTO * 60;
            public const int DIA = HORA * 8;
            public const int SEMANA = DIA * 5;
            public const int MES = SEMANA * 4;
            public const int AÑO = MES * 12;
        }

        public class Abreviaturas
        {
            public const string Segundo = "s";
            public const string Minuto = "m";
            public const string Hora = "h";
            public const string Dia = "d";
            public const string Semana = "w";
            public const string Mes = "M";
            public const string Año = "a";
        }
    }
}
