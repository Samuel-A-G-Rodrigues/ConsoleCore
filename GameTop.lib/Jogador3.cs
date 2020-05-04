using GameTop.Interface;

namespace GameTop.lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "Teste corre \n";
        }

        public string Corre()
        {
            return "Teste chuta \n";
        }

        public string Passe()
        {
            return "Teste passe \n";
        }
    }
}