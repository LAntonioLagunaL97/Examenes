# Examen-5  " Area de Figuras Geómetricas " 

## **Objetivo del operario:** 

Desarrollar una palicacion que solicite al usuario elegir entre 3 figuras geométricas (Circulo, Cuadrado, Triangulo) dada la figura el usuario debe de poder introducir las medidas y con lo cual debe de entregar cómo resultado el área de la figura.

---

Requisitos: 

- ¿ Qué tipo de figura son ?
> Son figuras geómetricas basícas ( Cuadrado, Circulo, Triangulo).  

- ¿ Qué tipo de números ?
> Todos los números reales positivos, enteros positivos, punto decimal. 

- ¿ Rango de númerosa ingresar ? ¿Dígitos a poner, considernado el numero entero ? 
> 4 dígitos. 

- ¿ Los calculados deben guardarse ?
> No es necesaerio 

- ¿ Qué pasa una vez seleccionada la figura por el usuario ? 
> Se introducen los datos necesarios para poder realizar la operacion para obtener el area de dicha figura. 

- ¿ Se podran realizar operaciones si alguno de los campos no se le intruce un dígito en el caso del cuadrado y del triangulo?
> Se mostrara erro al usuario y con el ello que le pedira de favor que introdusca correctamente los valores.

- ¿ Qué sucede una vez ya relaizada la operacion ? 
> Muestra el resultado de la operación, mantiene este valor. 

- ¿ La aplicacion permite que ingresen números negativos ?
> No la aplicacion no permite que que se introduzcan numeros negativos. 

- ¿ Se mostraran los errores que se puedan presnetar al momento de estar utilizando el programa ? 
> El progrma no mostrara resultados.
 
- ¿ Se puede realizar otra opreción ensegudia que obtiene el utlimo resultado ?
> No, El usuario debera de volver a abrir la aplicaion para escoger otra operación

- ¿ Tamaño de letra ? 
> 16

---
### **Objetivo:**
Crear una aplicacióm que permita clacular el area de una figura geómetrica basíca( circulo, cuadrado y triangulo) donde podran ingresarse todo el campo de los números reales. El usuario tendra libertad de selecionar la figura de su gusto, con lo cual a continuacion tendra que intruducir dependiendo de la figura los valores para poder llevar acabo la formula para el area de dicha figura. El resultado se debe de desplegar una vez que se presionó el boton de "Resultado" en la aplicación y no debe de ser mayor a 4 dígitos.
Se debe de realizar la operación de la figura ya selecionada.
Ambos campos de los datos deben de contener información para poder realizar la operación, en caso contrario la aplicación debe de desplegar un mensaje de error pidiendo al usuario introducir ambos valores a exepción de la opción  "Circulo".
Los datos introducidos no deben tener mas de 4 dígitos. 
Los campos solo deben de aceptar números. 

---
### ** Análisis de requisitos**

 ~~ R1: Crear una aplicacióm que permita clacular el area de una figura geómetrica basíca( circulo, cuadrado y triangulo) donde podran ingresarse todo el campo de los números reales. 

- [x] Único
- [x] No es contradictorio
- [x] Se puede probar
- [x] No es ambiguo

~~ R2: El usuario tendra libertad de selecionar la figura de su gusto, con lo cual a continuacion tendra que intruducir dependiendo de la figura los valores para poder llevar acabo la formula para el area de dicha figura. 

- [x] Único
- [x] No es contradictorio
- [x] Se puede probar
- [x] No es ambiguo

~~ R3: El resultado se debe de desplegar una vez que se presionó el boton de "Resultado" en la aplicación y no debe de ser mayor a 4 dígitos.

- [x] Único
- [x] No es contradictorio
- [x] Se puede probar
- [x] No es ambiguo

~~ R4: Se debe de realizar la operación de la figura ya selecionada.

- [x] Único
- [x] No es contradictorio
- [x] Se puede probar
- [x] No es ambiguo

~~ R5: Ambos campos de los datos deben de contener información para poder realizar la operación, en caso contrario la aplicación debe de desplegar un mensaje de error pidiendo al usuario introducir ambos valores a exepción de la opción  "Area de circulo".

- [x] Único
- [x] No es contradictorio
- [x] Se puede probar
- [x] No es ambiguo

~~ R6: Los datos introducidos no deben tener mas de 4 dígitos. 

- [x] Único
- [x] No es contradictorio
- [x] Se puede probar
- [x] No es ambiguo

~~ R7: Los campos solo deben de aceptar números. 

- [x] Único
- [x] No es contradictorio
- [x] Se puede probar
- [x] No es ambiguo

---
### ** Caso prueba **

Con las condiciones antes ya mencionadas: 
  
  El dispostivo de prueba debe de ser un dispositovo con sistema operativo Android IceScream Sandwich o mayor.
  La herramienta debe de estar previamente instalada
  
  
*TestCase ID:* TC1R1
*TestScenario:* Probar que la aplicacion permita selecionar una figura geómetrica y realice la operaccion para obtener su area en el conjunto de números reales.
*TestSteps:*
1. Selecionar figura geómetrica " Cuadrado "
2. Ingresar 25 en el primer campo
3. Ingresar 25 en el segundo campo
4. Presionar el boton de Resultado
*Expected Results:*
La aplicación debe de desplegar el resultado igual a 625
*Pass/Fail:*

*TestCase ID:* TC2R1
*TestScenario:* Probar que la aplicacion permita selecionar una figura geómetrica y realice la operaccion para obtener su area en el conjunto de números reales.
*TestSteps:*
1. Selecionar figura geómetrica " Triangulo "
2. Ingresar 10 en el primer campo
3. Ingresar 25 en el segundo campo
4. Presionar el boton de Resultado
*Expected Results:*
La aplicación debe de desplegar el resultado igual a 125
*Pass/Fail:*

*TestCase ID:* TC3R1
*TestScenario:* Probar que la aplicacion permita selecionar una figura geómetrica y realice la operaccion para obtener su area en el conjunto de números reales.
*TestSteps:*
1. Selecionar figura geómetrica " Circulo  "
2. Ingresar 10 en el primer campo
3. Presionar el boton de Resultado
*Expected Results:*
La aplicación debe de desplegar el resultado igual a 314.61
*Pass/Fail:*


  2.  El resultado se debe de desplegar una vez que se presionó el boton de "Resultado" en la aplicación.

  
  3. Se debe de realizar la operación de acuerdo a la opción seleccionada.

    
  4. Ambos campos deben de contener información para poder realizar la operacióna exepción de la opción " Circulo ".

    
  5. La aplicación debe de desplegar un mensaje de error pidiendo al usuario introducir ambos valores cuando un campo no contenga      información a exepción de la opción "Circulo". 

    
  6. Los datos de entrada no deben de ser mayores a 4 dígitos.

    
  7. El tamaño de letra debe de ser de 16px para los campos de entrada y el resultado.

  
  8. Los campos en la forma solo deben de aceptar números reales positivos, enteros positivos.
  
  
  ---
  ## **Arquitectura **
  
  **Diagrama de secuencia 
  
  ![copia de diagrama en blanco](https://user-images.githubusercontent.com/42191570/48152348-3efd8880-e289-11e8-80a0-8eed8f37bbb5.png)
