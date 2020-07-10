using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return "Maradona estas pateando \n";
        }

        public string Corre()
        {
            return "Maradona estas corriendo \n";
        }

        public string Passe()
        {
            return "Maradona estas pasando \n";
        }
    }
}