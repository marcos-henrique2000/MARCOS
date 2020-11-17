using System.Data;

namespace Marcos.entities
{
    class RegFoguete
    {
        public int idReg { get; set; }
        public string DataVoo { get; set; }
        public string Custo { get; set; }
        public string Distancia { get; set; }
        public string Captura { get; set; }
        public string NivelDor { get; set; }

        public RegFoguete() { }

        public RegFoguete(int id,  string dataVoo, string custo, string distancia, string captura, string nivelDor)
        {
            idReg = id;
            DataVoo = dataVoo;
            Custo = custo;
            Distancia = distancia;
            Captura = captura;
            NivelDor = nivelDor;
        }

        public RegFoguete(string dataVoo, string custo, string distancia, string captura, string nivelDor)
        {
            DataVoo = dataVoo;
            Custo = custo;
            Distancia = distancia;
            Captura = captura;
            NivelDor = nivelDor;
        }

        public RegFoguete(string dataVoo, string captura, string nivelDor)
        {
            DataVoo = dataVoo;
            Captura = captura;
            NivelDor = nivelDor;
        }
    }
}
