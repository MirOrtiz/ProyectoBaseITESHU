# Proyecto Base ITESHU
## ¿Como usar este repositorio?

1. Haga un fork de este proyecto
2. En base a su base de datos SQL Server, cree las entidades que mapean las tablas en el proyecto COMMON/Entidades, recuerde que para que este proyecto funcione cada tabla debera tener un campo "Id" que debe ser autonumerico e identidad, así como tener un campo de "FechaHora" datetime
3. Cree los validadores para cada entidad dentro de COMMON/Validadores
4. En el proyecto DAL, en el archivo FactoriRepository escriba la cadena de conexión en la variable destinada para ellos
5. En el mismo FactoryRepository cree los metodos que generan cada repositorio
6. En el proyecto de WebAPI dentro de la carpeta API, genere los controladores necesarios
7. Pruebe su API de manera local verificando su funcionamiento
8. Publique su API
9. Verifique el funcionamiento del API ya publicado mediante POSTMAN
10. En el proyecto BIZ, cree un manager por cada entidad y agrege los metodos que requiera
11. En el archivo FabricManager cree metodo que permitan regresar los manager construidos
12. En las respectivas interfaces de usuario, haga uso de FabricManager para llamar los managers necesarios
13. En el proyecto web server ya esta instalado el Nuget de Radzen