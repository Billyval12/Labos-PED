namespace FormPrincipal
{
    public class Coleccion
    {
        public int IDcoleccion { get; set; }
        public string Nombre { get; set; }
        public int IDgenero { get; set; }
        public int IDtipo { get; set; }
        public int numeroPiso { get; set; }

        public Coleccion()
        {
            this.IDcoleccion = 0;
            this.Nombre = "";
            this.IDgenero = 0;
            this.IDtipo = 0;
            this.numeroPiso = 0;
        }

        public Coleccion(int idCol, string nom, int idG, int idT, int numP)
        {
            IDcoleccion = idCol;
            Nombre = nom;
            IDgenero = idG;
            IDtipo = idT;
            numeroPiso = numP;
        }
    }
}