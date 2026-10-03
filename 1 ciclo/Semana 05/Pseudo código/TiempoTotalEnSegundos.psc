Algoritmo TiempoTotalEnSegundos
	Definir H, M, S, TotalSegundos como real
	Escribir "Ingrese la cantidad de horas"
	Leer H
	Escribir "Ingrese la cantidad de minutos"
	Leer M
	Escribir "Ingrese la cantidad de segundos"
	Leer S
	
	TotalSegundos <- (H * 3600) + (M * 60) + S
	
	Escribir "El total de segundos es de " TotalSegundos
FinAlgoritmo
