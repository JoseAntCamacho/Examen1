# Examen Orientación a Objetos.

## 1. Modifica la siguiente clase para que cualquiera pueda crear una instancia de ella y si lo desea pueda recibir una notificación mediante un evento cuando cambie el nombre. Este evento notificará el valor anterior y el actual del nombre.

```
public abstract class Foo 
{
   public string Name {get;set;}
}
```

Para poder crear una instancia de esta clase debemos implementarla en otra clase no abstract, a la cuál hemos llamado Bar. La clase Bar hereda de Foo y de IEventos y tiene como atributo privado un string (_Name) y como público el heredado de la clase Foo (Name) al cuál le sobre-escribimos el método set para que lance una notificación. También tiene otro atributo event del tipo ChangeNameEventHandler, que es un delegado creado en el mismo namespace cuyos parámetros son un objeto y un elemento de la clase ChangeNameEventArgs. Por último, implementa el método OnChangeName para concretar las acciones que queremos realizar cuando cambiamos el nombre.

La clase ChangeNameEventArgs nos ayudará a almacenar los nombres antiguo y nuevo para poder mostrarlos en el evento. Esta clase hereda de EventArgs.

Para poder cumplir con las reglas SOLID debemos trabajar con interfaces, por lo que creamos la interfaz IEventos que contendrá un event ChangeNameEventHandler y un método OnChangeName(ChangeNameEventArgs e). Estos han de ser comunes a todas las clases para que al cambiar el atributo Name de éstas podamos realizar el evento.

## 2. Implementa el código necesario para crear una clase figura de la que heredan las siguientes clases: Rectángulo, Círculo y Flecha. Todas estas clases tienen una propiedad color que puede ser Rojo,Verde y Azul.

Necesitaremos crear una enumeración que se llamará Colores que contendrá los colores de la lista del enunciado. Una vez realizado, declararemos la clase Shape que es la clase base del resto de clases, es decir, las clases Rectángulo, Círculo y Flecha, heredarán de ésta. Tendrá como atributo único Colores, con sus respectivos métodos get y set. 

Por último, creamos las clases Rectable, Circle y Arrow que heredan de Shape y que no contienen nada ya que el atributo Colores lo heredan directamente de Shape.

## 3. Una vez creadas esas clases crea una lista de esas clases del tipo IShape que tiene un método Draw y que escriben por consola el color y lo que son Rectangulo, Circulo o Flecha. La lista tiene que ser del siguiente tipo. 

```
var shapes = new List<IShape>(){
    new Rectable(Color.red),
    new Circle(Color.blue),
    new Rectable(Color.green),
    new Arrow(Color.blue)
}
ForEach(var item in shapes){
   item.Draw(...pasar como parámetro el medio donde imprimir);
  //El medio donde imprimir es la consola con el método WriteLine.
}

```
Una vez

## ¿Qué técnica de la orientación a objetos crees que estás utilizando?





