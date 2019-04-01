Tutorial: Desarrollando un Servicio SOAP sobre WCF para Dummies

Una breve intro

Debido a que el target son personas interesadas en conocer WCF, no necesariamente profesionales de TI o developers, intentaré explicar paso a paso y de forma simple como crear su primer servicio con WCF o al menos espero lograrlo.

¿Qué lograremos?, para saber si debo continuar

A pesar que haremos algo básico, creo que les será muy útil, ya sea que solo quieran saber “¿Cómo se hace?” o quieran profundizar y usarlo como plantilla, pues he tratado de utilizar “algunas” buenas prácticas en cuanto a código y nomenclaturas, no verán nombres como “Protecto1” o “MiClase”.

Luego de la implementación obtendremos lo siguiente:
1. Base de datos, para almacenar la información del docente.
2. Servicio WCF, para conectarse a la base de datos y retornar la información requerida.
3. Unit Test, para probar el correcto funcionamiento de los servicios creados.

¿Qué problema resolveremos?, el objetivo práctico

El alcance de lo que desarrollaremos es crear la funcionalidad básica de un servicio web.
Como cualquier servicio web, usaremos una entidad u objeto de negocio y crearemos un CRUD o en español Crear, Leer, Actualizar y Borrar.
Para este caso usaremos “Docente” extraída de un proceso de matrículas.
Para lograrlo necesitamos, entre leer, asistentes y su facilidad para codear, un aproximado de 30-45 minutos 

¿Qué es WCF?, empezamos por lo aburrido

Windows Communication Foundation o simplemente WCF está diseñado para ofrecer un enfoque manejable a la informática distribuida, interoperabilidad ancha y asistencia directa para la orientación sobre el servicio. WCF permite describir, publicar, implementar y consumir servicios, no solo con la interoperabilidad de los Web Services entre plataformas servidor y cliente, sino también utilizando diferentes plataformas de transporte de forma transparente al resto de la arquitectura.

¿Muy complicado? Entonces solo diré que WCF simplifica el desarrollo de aplicaciones conectadas a través de un modelo de programación orientado a servicios. 

¿Qué necesito?, tranquilo todo es gratis

Usaremos las siguientes herramientas de Microsoft en sus versiones gratuitas:
- SQL Server 2017, descarga: https://www.microsoft.com/es-es/sql-server/sql-server-editions-express
- Visual Studio 2017, descarga: https://visualstudio.microsoft.com/es/vs/community/

Desarrollo, ahora si empieza lo divertido, para algunos

1. Crear la base de datos.

- Sí, es necesario abrir el programa: SQL Server Management Studio.


- Creamos la base de datos: BD_AsistenteMatricula.





- Creamos la tabla: TB_Docente, campos: NU_IdDocente, TX_Nombres, TX_Apellidos, TX_Dni, TX_Estado.





- Insertamos un registro, no necesariamente los mismos datos.





   Y ya tenemos la base de datos lista.
   ¿Fácil verdad?, clic por acá, clic derecho por allá, tranquilo lo que viene te hará sentir un Tony Stark.

2. Crear el Servicio WCF.

- Lo obvio, es necesario abrir el programa: Visual Studio.



- Creamos el proyecto: WCF_DocenteService.





- Eliminamos el código que nos crea por defecto, no sirve.



- Agregamos un Servicio WCF: DocenteService.svc.





- Creamos la siguiente estructura de Carpetas y Clases:
Dominio - Docente.cs
Errores - Repetido.cs
Persistencia – DocenteDAO.cs



- Ahora si a codear, empecemos por la clase del objeto de negocio: Docente.cs.
- Luego la clase que conecta a la base de datos: DocenteDAO.cs.
- Continuamos con la clase que usaremos para el manejo de errores: RepetidoException.cs.
- Ahora el servicio, empecemos por la clase o interfaz que define el contrato y operaciones del servicio: IDocenteService.cs.
- Finalmente implementamos el servicio y sus operaciones: DocenteService.svc.cs.
- Compilamos el proyecto para que nuestro servicio se ejecute en nuestro servidor de aplicaciones IIS.







- Visualizamos el servicio en el explorador de internet.





- Realizamos pruebas desde el cliente WCF: Depurar – Iniciar depuración o F5.



Método: CrearDocente





Método: ObtenerDocente



Método: ModificarDocente





Método: ListarDocentes



Método: EliminarDocente





   Y bien, hemos terminado nuestro servicio WCF.
¿Fácil o difícil?, tranquilo lo que viene es sencillo, no es común implementar un proyecto de pruebas unitarias, pero es muy recomendable, sobre todo si queremos automatizar nuestras pruebas y agilizar la puesta en marcha.

3. Crear el Unit Test.

- Ya estamos en Visual Studio, agreguemos un nuevo proyecto a la solución: WCF_DocenteServiceTest.






- Cambiamos el nombre de la clase creada por defecto: De “UnitTest1.cs” a “UnitTestDocente.cs”.



- Agregamos una referencia de servicio: DocenteWS.





- Nuevamente a codear, empecemos por la prueba de creación: TestCrearDocente.
- Finalmente, la prueba de creación con excepción o error: TestCrearDocenteRepetido.
- Finalmente, ejecutamos las pruebas de ambos test.



- Si nos muestra un check verde quiere decir que está funcionando correctamente.



Conclusiones, hemos terminado

- De la implementación, siento, he confirmado y creo que ustedes también que es muy sencillo crear servicios con WCF que conectan a una base de datos y con pruebas unitarias para asegurar el correcto funcionamiento, invirtiendo poco tiempo. 
- De las herramientas, como ya es conocido Microsoft ofrece aplicaciones fáciles de usar y gratis, aunque las mejores versiones son de pago.
- De la creación de este tutorial, espero haber cubierto sus expectativas y haber contribuido al conocimiento de WCF de la forma descrita al inicio, nada formal, poco técnico, sólo simple, si no lo logré ¡sorry! pero no siempre sale como uno quiere.
