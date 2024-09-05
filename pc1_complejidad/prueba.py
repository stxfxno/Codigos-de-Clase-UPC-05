
def tot_palabras_por_linea(txt):
    def contar_palabras(lineas):
        if not lineas:
            return []

        linea = lineas[0]
        num_palabras = len(linea.split())
        # Procesamos la siguiente línea de forma recursiva
        return [num_palabras] + contar_palabras(lineas[1:])
    
    lineas = txt.splitlines()  #separamos el texto en lineas 
    return contar_palabras(lineas)

# Ejemplo de uso
txt = """Lorem ipsum dolor sit amet, consectetur adipiscing elit.
Nam arcu arcu, euismod mollis rhoncus quis, egestas at leo.
Maecenas luctus neque nulla, vel imperdiet lacus ultrices vel."""

# Obtener el resultado
resultado = tot_palabras_por_linea(txt)
for r in resultado:
    print(r)
