using System;

namespace DP.Helpers
{
    public static class AvaliacaoHelper
    {
        public static string Avaliar(int nota)
        {
            return nota switch
            {
                0 => "○ ○ ○ ○ ○ (Muito baixo)",
                1 => "● ○ ○ ○ ○ (Baixo)",
                2 => "● ● ○ ○ ○ (Médio Baixo)",
                3 => "● ● ● ○ ○ (Médio)",
                4 => "● ● ● ● ○ (Médio Alto)",
                _ => "● ● ● ● ● (Alto)"
            };
        }
    }
}
