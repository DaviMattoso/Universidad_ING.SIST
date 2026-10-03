Algoritmo DescuentoPorCompra
	Definir Valor Como Real
	Escribir "ingrese el valor de la compra"
	Leer Valor
	
	Si Valor >= 100 Entonces
		Escribir "El valor es de 100 soles o mas, por eso se aplica un valor de 10%"
		
		ValorDesc <- Valor - (Valor * 0.10) // 0.10 = 10%
		
		Escribir "El valor final de la compra es de: " ValorDesc
	SiNo
		Escribir "El valor es menor que 100 soles, no aplica descuento"
	FinSi
FinAlgoritmo
