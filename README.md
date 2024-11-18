# Sistema de Chat Básico con RabbitMQ y MassTransit

Este proyecto es un ejemplo sencillo que demuestra cómo utilizar RabbitMQ y MassTransit para crear un sistema de chat básico en .NET Core. Incluye:

- **ProducerApi**: Una API ASP.NET Core que permite enviar mensajes de chat.
- **ConsumerApi**: Una aplicación de consola que recibe y muestra los mensajes en tiempo real.

## Prerrequisitos

- **.NET 8 SDK** o superior instalado. Puedes descargarlo desde [aquí](https://dotnet.microsoft.com/download).
- **Docker** instalado para ejecutar RabbitMQ. Descárgalo desde [aquí](https://www.docker.com/products/docker-desktop).
- Una herramienta para probar APIs, como **Postman** o **cURL**.

## Configuración

### 1. Levantar RabbitMQ con Docker

Ejecuta el siguiente comando en tu terminal para iniciar RabbitMQ con la consola de administración:

```bash
docker run -d --hostname my-rabbit --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3-management
```

### 2. Levantar cada proyecto

Una vez que tengas el código de los proyectos `ProducerApi` y `ConsumerApp`, sigue estos pasos para levantarlos localmente.

#### Restaurar paquetes NuGet en producerApi y ejecutar proyecto

```bash
cd ./producerApi
dotnet restore
dotnet run
```

#### Restaurar paquetes NuGet en consumerApi y ejecutar proyecto

```bash
cd ./consumerApi
dotnet restore
dotnet run
```
