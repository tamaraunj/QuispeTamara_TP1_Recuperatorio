# Shadow Run: Parkour Mission

## 🎮 Descripción del juego

**Parkour Mission** es un videojuego 3D de plataformas desarrollado en Unity. El jugador debe superar un recorrido lleno de plataformas y obstáculos, utilizar habilidades especiales, transportar un objeto y alcanzar la meta.

## 📖 Historia

Un agente que debe completar una misión de entrenamiento a través de un recorrido lleno de plataformas, obstáculos y zonas peligrosas.

Para llegar al destino, tendrás que demostrar tu habilidad para saltar entre plataformas, recuperar un objeto importante y entregarlo en la zona indicada. Durante el recorrido, podrás activar un Power-Up que aumentará temporalmente tu velocidad y utilizar checkpoints para retomar el camino si caes al vacío.

Tu objetivo es superar cada desafío y completar la misión. Cada salto cuenta, y cada checkpoint te acerca un poco más a la victoria.

## 👤 Datos del alumno

- **Nombre y apellido:** [Tamara Melisa Quispe]
- **Materia:** [Programación de Videojuegos 1]
- **Trabajo práctico:** [Recuperatorio TP1]

## 🛠️ Información técnica

- **Motor de desarrollo:** Unity
- **Versión de Unity:** [6000.3.26f1]
- **Lenguaje de programación:** C#
- **Tipo de juego:** Plataformas 3D / Parkour

## 🎮 Controles

| Tecla | Acción |
|---|---|
| W | Avanzar |
| A | Moverse hacia la izquierda |
| S | Retroceder |
| D | Moverse hacia la derecha |
| Espacio | Saltar |
| E | Recoger un objeto |
| Q | Soltar un objeto |
| P | Activar el Power-Up de velocidad |

## ⚙️ Mecánicas implementadas

### Movimiento y salto

El jugador puede desplazarse por el escenario y saltar entre plataformas para superar los obstáculos.

### Interacción con objetos

El jugador puede recoger, transportar y soltar objetos utilizando las teclas correspondientes.

### Power-Up de velocidad

El jugador puede activar un Power-Up que duplica temporalmente su velocidad. La duración y el tiempo de recarga se gestionan mediante una Coroutine.

### Entrega del objeto y victoria

El nivel incluye una zona de entrega configurada con un Collider en modo Trigger. La victoria se produce cuando el objeto requerido entra correctamente en la zona. El juego informa el resultado mediante un mensaje en la consola y un cambio de color de la zona.

### Checkpoint

El escenario cuenta con un punto de control ubicado en una plataforma intermedia. Cuando el jugador lo alcanza, se guarda su posición para utilizarla como punto de reaparición.

### Sistema de Respawn

El sistema de respawn permite recuperar la posición del jugador cuando cae al vacío.

Su funcionamiento es el siguiente:

1. Al comenzar el nivel, se guarda la posición inicial del jugador.
2. Cuando el jugador entra en el Trigger del checkpoint, se registra su posición.
3. Una zona de caída ubicada debajo del escenario detecta al jugador mediante un Collider configurado como Trigger.
4. Si el jugador alcanzó un checkpoint, reaparece en la posición guardada.
5. Si todavía no alcanzó ningún checkpoint, vuelve a su posición inicial.
6. Al reaparecer, se reinician las velocidades lineal y angular del Rigidbody para evitar que continúe cayendo o girando.

Este sistema permite continuar el recorrido desde el último punto de control alcanzado sin tener que comenzar el nivel desde cero.

### Cámara

La cámara sigue al jugador 

## 🖼️ Captura de pantalla del nivel


![Captura de pantalla de Shadow Run: Parkour Mission](Proyecto/nivel.png)

## ▶️ Cómo ejecutar el proyecto

1. Descargar o clonar el repositorio.
2. Abrir Unity Hub.
3. Seleccionar **Add project from disk** y elegir la carpeta del proyecto.
4. Abrir el proyecto con la versión de Unity correspondiente.
5. Abrir la escena principal.
6. Presionar **Play** para comenzar.

## 📌 Estado del proyecto

Proyecto académico desarrollado en Unity para practicar programación de videojuegos 3D, físicas, colisiones, interacción con objetos, corrutinas y sistemas de checkpoint y respawn.