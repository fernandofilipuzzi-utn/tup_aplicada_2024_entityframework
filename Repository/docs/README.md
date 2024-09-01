
### _Comandos_
---

### Referencias

[Patrón repository](https://learn.microsoft.com/es-es/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application)
[Modelo de datos más complejos](https://learn.microsoft.com/es-es/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/creating-a-more-complex-data-model-for-an-asp-net-mvc-application)

### Paquete NuGET
```
Install-Package EntityFramework
```

## migrar 
en tools/administrador de paquetes NuGet/Consola del Administrador de paquetes
enable-migrations -contexttypename LogisticaContext



**Habilita la migración**

 Generará una carpeta Migrations en el proyecto, con una clase Configuration que configura las migraciones.
 
 ```
 Enable-Migrations
 ```

 **Crea la migración**

 Crear una clase con los cambios a realizr en la carpeta migración y correrá cuando se ejecute update-database
 
 ```
 Add-Migration Nombre de clase
 ```

 **Actualizar la base de datos**

 Aplica la migración a la base de datos usando el siguiente comando:
 
 ```
 Update-Database
 ```

 ```
 Drop-Database -Context LogisticaContext
 ```