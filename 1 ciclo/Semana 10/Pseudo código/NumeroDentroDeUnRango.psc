Algoritmo NumeroDentroDeUnRango //[10, 50]
	Definir Num Como Real
	
	Escribir "Ingrese un numero"
	Leer Num
	
	Si Num >= 10 Y  Num <= 50 Entonces //devuelve true solo si AMBAS expreciones son verdaderas
		Escribir Num " esta dentro del rango de 10 y 50"
	SiNo
		Escribir Num " esta fuera del rango"
	FinSi
	
	// podriamos hacer que el programa dijera si esta antes del 10 o despues del 50, pero utilizando condicionales anilladas
FinAlgoritmo
