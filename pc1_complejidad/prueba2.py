# Datos de entrada
chacras = [
    [52, 23, 72, 67],
    [21, 15, 98],
    [16, 49, 24, 72],
    [82, 55],
    [64, 46],
    [54, 21],
    [23, 24, 22],
    [53, 84, 94],
    [66, 53, 56, 79],
    [91, 95]
]

# Ordenar las chacras en función de la suma de las unidades cosechadas
chacras_ordenadas = sorted(chacras, key=sum)

# Imprimir el resultado
print("Total de unidades cosechadas en orden ascendente:")
for chacra in chacras_ordenadas:
    print(chacra)
