Algoritmo PromedioPonderado
	Definir nota1, nota2, nota3, peso1, peso2, peso3, promediop Como Real
	
	
	Escribir "Ingrese la primera nota"
	Leer nota1
	
	Escribir "Ingrese la segunda nota"
	Leer nota2
	
	Escribir "Ingrese la tercera nota"
	Leer nota3
	
	Escribir "ingrese el peso de la primera nota"
	Leer peso1
	
	Escribir "ingrese el peso de la segunda nota"
	Leer peso2
	
	Escribir "ingrese el peso de la tercera nota"
	Leer peso3
	
	promediop <- ((nota1*peso1) + (nota2*peso2) + (nota3*peso3)) / (peso1 + peso2 + peso3) //formula
	
	Escribir "El promedio ponderado es de: " promediop
	
FinAlgoritmo
