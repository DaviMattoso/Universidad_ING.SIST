Algoritmo DatosCorrectos
	Definir Usuario, Contraseña, ingUsuario, IngContraseña Como Caracter
	Usuario = davi
	Contraseña = "1234"
	
	Escribir "ingrese el Usuario"
	Leer ingUsuario
	Escribir "Ingrese la contraseña"
	Leer ingContraseña
	
	Si Usuario = ingUsuario Y Contraseña = ingContraseña Entonces
		Escribir "Bien venido al sistema"
	SiNo
		Escribir "Usuario o contraseña incorrectos"
	FinSi
	
FinAlgoritmo
