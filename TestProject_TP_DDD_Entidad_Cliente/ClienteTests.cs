

using Dominio_DDD_Entidad_Cliente;
using System;
using Xunit;

namespace TestProject_TP_DDD_Entidad_Cliente
{
    public class ClienteTests
    {
        [Fact]
        public void Constructor_CreaClienteCorrectamente()
        {
            // Arrange
            Guid id = Guid.NewGuid();
            string nombre = "John Doe";
            string email = "john.doe@example.com";
            string clave = "password123";
            DateTime fechaNacimiento = new DateTime(1990, 1, 1);

            // Act
            var cliente = new Cliente(id, nombre, email, clave, fechaNacimiento);

            // Assert
            Assert.Equal(id, cliente.Id);
            Assert.Equal(nombre, cliente.Nombre);
            Assert.Equal(email, cliente.Email);
            Assert.Equal(clave, cliente.Clave);
            Assert.Equal(fechaNacimiento, cliente.FechaNacimiento);
        }

        [Fact]
        public void Constructor_LanzaExcepcionCuandoEmailNoEsValido()
        {
            // Arrange
            Guid id = Guid.NewGuid();
            string nombre = "John Doe";
            string email = "correo.invalido";  // Email inválido
            string clave = "password123";
            DateTime fechaNacimiento = new DateTime(1990, 1, 1);

            // Act y Assert
            Assert.Throws<Exception>(() => new Cliente(id, nombre, email, clave, fechaNacimiento));
        }
    }
}