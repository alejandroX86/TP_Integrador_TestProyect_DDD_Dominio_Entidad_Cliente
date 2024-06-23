namespace Dominio_DDD_Entidad_Cliente
{

    public class Cliente
    {
        public Guid Id { get; private set; }
        public string Nombre { get; private set; }
        public string Email { get; private set; }
        public string Clave { get; private set; }
        public DateTime FechaNacimiento { get; private set; }

        public Cliente(Guid id, string nombre, string email, string clave, DateTime fechaNacimiento)
        {
            // Validar que el email sea válido
            if (!IsValidEmail(email))
                throw new Exception("El email ingresado no es válido.");

            Id = id;
            Nombre = nombre;
            Email = email;
            Clave = clave;
            FechaNacimiento = fechaNacimiento;
        }

      

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}