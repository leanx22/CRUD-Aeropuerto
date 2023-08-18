# AVIONES #

----------
## Sobre mí: ##
Soy Guia Leandro. La verdad que este trabajo lo sufrí bastante, sí fué un desafío ya que sentí que me faltaban conocimientos para poder lograr algunas funciones de la aplicación (sobre todo, en cuanto a controles de windowsForms) ya que no sabía donde aplicarlas o si lo que estaba haciendo estaba bien (aunque funcione). De todas formas sí siento que aprendí (sobre todo por mi cuenta), algunos controles nuevos y soluciones a crasheos constantes de visual studio por ejemplo.

## Resumen ##
La aplicación ayuda a administrar un aeropuerto. Permitiendo administrar las aeronaves, los viajes o los pasajeros de la institucion, asi como la venta de pasajes.

## Diagrama ##

![](https://i.imgur.com/hA7Vkmu.png)

## Justificacion tecnica ##
**Al menos 2 formularios:** No hay mucho que decir, utilicé varios formularios por tema de comodidad.

**Formulario MDI**: No los utilice ya que no los vimos en profundidad en la cursada.

**Ninguna entidad se debe comparar por defecto(uso de Equals y GetHashCode)**: Utilice mucho equals para poder verificar si una entidad se encontraba o no en una lista (con el metodo Contains()). Por ejemplo si dos Aeronaves se encontraban ya dadas de alta utilizaba equals, que a su vez utiliza la sobrecarga de == donde comparaba las matriculas.

**Herencia**: La utilice en formularios y en entidades con PERSONA->USUARIO/PASAJERO. Tal vez podria haber realizado herencia de la siguiente manera (PERSONA->VENDEDOR->SUPERV->ADMIN) pero simplemente me causaba muchisimos problemas que no sabia, ni se, solucionar.

**Encapsulamiento**: Lo utilice en todas las clases. Todas tienen propiedades, algunas son de lectura y escritura y otras son solo lectura. Lo mismo con los metodos, hay algunos que son privados para no exponerlos y son usados dentro de la misma clase, mientras que otros son publicos.

**Sobrecargas**: Sobrecarga de constructor hay casi en todas las entidades, sobrecarga de metodos mas de lo mismo.

**Metodos estaticos**: Hay varios metodos estaticos como el de archivos, donde los utilizo ya que no voy a instanciar un objeto solo para su uso.

**Enumerados**: Los utilice para el perfil del usuarios, para los destinos de los viajes, Tipos de equipaje,  y estados de vuelo.

**Clase abstracta** Utilizada para la clase PERSONA
