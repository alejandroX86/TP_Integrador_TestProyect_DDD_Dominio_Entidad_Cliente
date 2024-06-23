Proyecto Hotel: Prueba Unitaria Dominio Entidad Cliente

Este proyecto forma parte del Trabajo Práctico de Laboratorio de Software y se enfoca en la implementación y pruebas unitarias del dominio Cliente en el contexto de una arquitectura DDD (Domain-Driven Design) para un sistema de reservas de hotel. A continuación se detalla el funcionamiento de las pruebas unitarias desarrolladas para asegurar la correcta creación y validación de la entidad Cliente.

Descripción del Proyecto

El proyecto consiste en la implementación de la entidad Cliente con sus respectivas propiedades y métodos de validación, así como la realización de pruebas unitarias para verificar el correcto funcionamiento de dicha entidad.

Entidad Cliente

La entidad Cliente posee las siguientes propiedades:

Id: Identificador único del cliente.
Nombre: Nombre del cliente.
Email: Correo electrónico del cliente.
Clave: Contraseña del cliente.
FechaNacimiento: Fecha de nacimiento del cliente.
El constructor de la clase Cliente incluye una validación para asegurar que el correo electrónico proporcionado es válido.

Métodos
IsValidEmail: Método privado utilizado para validar la estructura del correo electrónico.
Pruebas Unitarias
Las pruebas unitarias son esenciales para verificar que cada componente del sistema funcione correctamente de manera aislada. En este proyecto, se utilizaron pruebas unitarias para asegurar la correcta creación y validación de la entidad Cliente.

Descripción de las Pruebas
Prueba: Constructor_CreaClienteCorrectamente
Objetivo: Verificar que el constructor de la clase Cliente inicialice correctamente todas las propiedades cuando se proporcionan datos válidos.
Escenario: Se crea un cliente con un id, nombre, email, clave y fechaNacimiento válidos.
Validación: Se verifica que cada propiedad del cliente se haya inicializado correctamente con los valores proporcionados.
Prueba: Constructor_LanzaExcepcionCuandoEmailNoEsValido
Objetivo: Verificar que el constructor de la clase Cliente lance una excepción cuando se proporciona un correo electrónico no válido.
Escenario: Se intenta crear un cliente con un correo electrónico inválido.
Validación: Se comprueba que se lance una excepción al intentar crear el cliente con un correo electrónico no válido.
Cómo Ejecutar las Pruebas
Para ejecutar las pruebas unitarias, sigue estos pasos:

Clona el Repositorio

Clona el repositorio y abre el proyecto en tu IDE preferido.
Instala las Dependencias

Asegúrate de tener todas las dependencias necesarias instaladas en tu entorno de desarrollo.
Ejecuta las Pruebas

Navega a la carpeta de pruebas en tu proyecto y ejecuta los tests utilizando el comando de tu framework de pruebas. Por ejemplo, si estás usando XUnit, puedes usar el comando:
bash
Copiar código
dotnet test
Revisa los Resultados

Revisa los resultados de las pruebas para asegurarte de que todas pasen correctamente. Si alguna prueba falla, revisa el código para identificar y corregir el problema.
Importancia de las Pruebas Unitarias
Las pruebas unitarias son cruciales para el desarrollo de software de calidad debido a los siguientes motivos:

Detección Temprana de Errores

Ayudan a detectar errores en etapas tempranas del desarrollo, lo que facilita su corrección antes de que se conviertan en problemas mayores.
Evitación de Regresiones

Aseguran que los cambios en el código no introduzcan nuevos errores, permitiendo que el sistema evolucione sin comprometer la estabilidad.
Documentación del Comportamiento

Documentan el comportamiento esperado de los componentes del sistema, lo que es útil para los desarrolladores actuales y futuros.
Facilitación del Mantenimiento

Facilitan el mantenimiento y la evolución del sistema, ya que las pruebas aseguran que el código siga funcionando correctamente después de las modificaciones.
