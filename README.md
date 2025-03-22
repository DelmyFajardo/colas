Sistema de Gestión de Colas - Documentación del Código
Descripción General
Este código implementa una interfaz de consola para gestionar colas de mensajes con múltiples proveedores (RabbitMQ y Amazon SQS).

Estructura del Código
Clase Principal (Program.cs)
El programa está organizado en dos métodos principales:

1 Main
  Gestiona el menú principal
  Maneja la navegación básica
  Proporciona opciones para:
      Acceder al gestor de colas
      Salir del programa
      
2 RunQueueManager
  Maneja la selección del proveedor de cola
  Implementa las operaciones de cola
  Proporciona una interfaz para interactuar con las colas

Flujo de Ejecución
Inicio

  El programa muestra el menú principal
  El usuario selecciona "Gestor de colas" o "Salir"
  Selección de Proveedor
  
  Si se elige el gestor de colas, se muestra el menú de selección de proveedor
  El usuario debe elegir entre RabbitMQ o Amazon SQS
  Operaciones de Cola
  
  Una vez seleccionado el proveedor, se muestran las operaciones disponibles
  El usuario puede realizar múltiples operaciones
  Se muestra el estado actual de la cola

Características Técnicas
  Manejo de Nulos: Uso de string? para entrada de usuario
  Control de Flujo: Bucles while para menús persistentes
  Validación: Manejo de opciones inválidas
  Interfaz de Usuario: Limpieza de pantalla y formateo de menús
  Estado: Seguimiento del número de elementos en cola

Uso del Código
Requisitos
  .NET 8.0 
  RabbitMQ instalado (para el proveedor RabbitMQ)
  Credenciales de AWS (para el proveedor Amazon SQS)
