namespace Problema_3_Restaurantes
{
    public interface ItemOrder
    {
        public bool VerifyAviability();

        public double CalculatePrice();

        public void Prepare();

        public void Package();
    }
}
