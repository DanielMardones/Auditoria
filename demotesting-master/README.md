# demotesting
Código para testear con el framework NUnit en VS 2017

Verifiquen que git está instalado

git version, si no está instalar.

Pueden clonar el repositorio localmente con git clone https://github.com/labfran/demotesting.git

o pueden descargarlo directamente.

Procedimiento:

1. Abrir solución

2. Agregar proyecto Unit Test Project:

NombreProyecto.UnitTests

3. Cambiar nombre de la clase UnitTest1

NombredelaClaseTests

4. Cambiar el nombre del método TestMethod1()

NombreMétodo_Scenario_ExpectedBehavior()


5. Identificar los escenarios posibles


6. Cada Método tiene tres partes (Convención triple A)

//Arrange

*Inicializamos nuestros objetos, preparamos el objeto que queremos testear se crea una instacia de la clase que vamos a probar

*Debemos agregar la referencia al proyecto principal

//Act

*Donce actua el objeto, donde llamamos al método para testearlo

//Assert

*Se verifica que el resultado es correcto


7. Instalar paquetes de NUnit, desde Package Manager Console

PM> install-package NUnit -Version 3.8.1

PM> install-package NUnit3TestAdapter -Version 3.8.0

8. Así en ves de [TestClass] usamos [TestFixture]  debemos agregar using NUnit.Framework;

Y en ves de [TestMethod] usamos [Test] 

9. Luego correguimos Assert. y ahora queda Assert.That(result, Is.True); o

Assert.That(result == True);

*removemos: using Microsoft.VisualStudio.TestTools.UnitTesting;

*agregamos using NUnit.Framework;

10. Cuando hay un solo escenario usamos Add_WhenCalled_ReturnTheSumOfArguments()

SubirSueldo_WhenCalled_ReturnNewSalaryOfArguments()
