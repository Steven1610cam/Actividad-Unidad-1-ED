from dataclasses import dataclass


#1.	Declaración

@dataclass
class EstudianteRecord:

    nombre: str
    edad: int
    promedio: float


#2.	Inicialización

alumno1 = EstudianteRecord("Daniel Arroyo", 21, 4.3)
alumno2 = EstudianteRecord("Mario Padilla", 22, 3.9)
alumno3 = EstudianteRecord("Camila Aguas", 21, 4.8)


#3.	Recorrido

listaEstudiantes = [alumno1, alumno2,alumno3]

print("----Records/DataClass----")

for i, est in enumerate(listaEstudiantes, start=1):
    print(f"Estudiante {i}:")
    print(f"  Nombre: {est.nombre}")
    print(f"  Edad: {est.edad}")
    print(f"  Promedio: {est.promedio}")
    print("-" * 30)


#4.	Modificación

print("----Modificar Promedio----")

for est in listaEstudiantes:
    if est.nombre == "Mario Padilla":
        est.promedio = 4.0
        print(f"El nuevo promedio de {est.nombre} es: {est.promedio}")
