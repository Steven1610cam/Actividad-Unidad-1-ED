# 1. Declaración

class EstudianteClase:

    def __init__(self, nombre, edad, promedio):
        self.nombre = nombre
        self.edad = edad
        self.promedio = promedio

    def mostrarInfo(self):
        print(f"Nombre: {self.nombre}, Edad: {self.edad}, Promedio: {self.promedio}")

    def setPromedio(self, nuevo_promedio):
        self.promedio = nuevo_promedio


# 2. Inicialización

alumno1 = EstudianteClase("Daniel Arroyo", 21, 4.3)
alumno2 = EstudianteClase("Mario Padilla", 22, 3.9)
alumno3 = EstudianteClase("Camila Aguas", 21, 4.8)

listaEstudiantes = [alumno1, alumno2, alumno3]


# 3. Recorrido

print("----Información de Estudiantes----")

for est in listaEstudiantes:
    est.mostrarInfo()


# 4. Modificación

print("\n----Modificación de Promedio----")

alumno2.setPromedio(4.5)  # Cambio de promedio para Mario otra vez xd
alumno2.mostrarInfo()





