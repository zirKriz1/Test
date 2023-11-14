namespace EquipoProgProyecto.Clases
{
    public class Pais
    {
        public int IdPais { get; set; }
        public string nPais { get; set; }

        public Pais(int idPais, string nPais)
        {
            IdPais = idPais;
            this.nPais = nPais;
        }

        public override string ToString()
        {
            return nPais;
        }
    }
}