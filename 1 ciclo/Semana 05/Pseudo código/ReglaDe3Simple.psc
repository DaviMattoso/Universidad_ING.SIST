Algoritmo ReglaDe3Simple
	Definir Cantidaddeproducto1, Preciototalproducto1, Cantidaddeproducto2, Preciototalproducto2, Precioporunidad Como Real
	Escribir "Ingrese la cantidad total de los productos 1"
	Leer Cantidaddeproducto1
	Escribir "Ingrese el precio total de los productos 1"
	Leer Preciototalproducto1
	Escribir "Ingrese lo total de productos que va llevar"
	Leer Cantidaddeproducto2
	
	Preciototalproducto2 <- (Cantidaddeproducto2 * Preciototalproducto1) / Cantidaddeproducto1
	Precioporunidad <- Cantidaddeproducto1 / Preciototalproducto1
	
	Escribir "El precio toral de los poductos 2 es de " Preciototalproducto2
	Escribir "El precio por unidad del producto es de " Precioporunidad
FinAlgoritmo
