# 🏧 Simulador de Cajero Automático

Este es un proyecto de consola en C# que simula el funcionamiento básico de un cajero automático. El objetivo es practicar estructuras de control como condicionales, `switch`, funciones y manejo de arreglos.

## 🎯 Objetivo

Desarrollar la lógica fundamental para un cajero automático mediante:
- Condicionales (`if`, `else`)
- Estructura `switch`
- Funciones
- Arreglos dinámicos (`Array.Resize`)
- Entrada y salida de datos por consola

## 🧠 Funcionalidades

El programa ofrece un menú interactivo con las siguientes opciones:

1. **Consultar Saldo**  
   Muestra el saldo actual disponible, calculado como la diferencia entre depósitos y retiros.

2. **Depositar**  
   Permite ingresar una cantidad para depositar. Cada depósito se guarda en un historial.

3. **Retirar**  
   Permite retirar una cantidad siempre y cuando haya saldo suficiente.

4. **Ver Historial de Transacciones**  
   Muestra todos los depósitos y retiros realizados, además del saldo disponible.

5. **Salir**  
   Finaliza el programa con una confirmación.

## 🛠️ Tecnologías

- Lenguaje: **C#**
- Tipo de aplicación: **Consola**
- .NET Framework/Core compatible

## 🚀 Ejecución

Para ejecutar este programa, necesitas tener instalado .NET SDK. Puedes correrlo con:

```bash
dotnet run
