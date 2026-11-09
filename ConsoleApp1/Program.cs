using System;

Console.WriteLine("SISTEMA DE CONTROL DE MOTORES");
Console.WriteLine();

// 1. Prueba con MotorCD
Console.WriteLine("--- CONFIGURACIÓN DE MOTOR CD ---");
MotorCD motorCD1 = new MotorCD();
Console.Write("Ingrese el identificador del motor CD: ");
motorCD1.Identificador = Console.ReadLine() ?? "Sin identificador";
Console.Write("Ingrese la temperatura del motor (°C): ");
motorCD1.Temperatura = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la corriente del motor (A): ");
motorCD1.Corriente = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la velocidad del motor (rpm): ");
motorCD1.Velocidad = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el voltaje del motor (V): ");
motorCD1.Voltaje = Convert.ToDouble(Console.ReadLine());

// 2. Prueba con MotorAC
Console.WriteLine("\n--- CONFIGURACIÓN DE MOTOR AC ---");
MotorAC motorAC1 = new MotorAC();
Console.Write("Ingrese el identificador del motor AC: ");
motorAC1.Identificador = Console.ReadLine() ?? "Sin identificador";
Console.Write("Ingrese la temperatura del motor (°C): ");
motorAC1.Temperatura = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la corriente del motor (A): ");
motorAC1.Corriente = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la velocidad del motor (rpm): ");
motorAC1.Velocidad = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese las fases de operación (ej. Monofásico / Trifásico): ");
motorAC1.FasesOperacion = Console.ReadLine() ?? "Desconocido";

// 3. Prueba con ServoMotor
Console.WriteLine("\n--- CONFIGURACIÓN DE SERVO MOTOR ---");
ServoMotor servo1 = new ServoMotor();
Console.Write("Ingrese el identificador del servomotor: ");
servo1.Identificador = Console.ReadLine() ?? "Sin identificador";
Console.Write("Ingrese la temperatura del motor (°C): ");
servo1.Temperatura = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la corriente del motor (A): ");
servo1.Corriente = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la velocidad del motor (rpm): ");
servo1.Velocidad = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la posición angular (grados): ");
servo1.PosicionAngular = Convert.ToDouble(Console.ReadLine());

// Mostrar resultados Motor CD
Console.WriteLine();
Console.WriteLine("========================================");
Console.WriteLine("DATOS DEL MOTOR CD");
Console.WriteLine($"Motor: {motorCD1.Identificador}");
Console.WriteLine($"Temperatura: {motorCD1.Temperatura} °C");
Console.WriteLine($"Corriente: {motorCD1.Corriente} A");
Console.WriteLine($"Velocidad: {motorCD1.Velocidad} rpm");
Console.WriteLine($"Voltaje: {motorCD1.Voltaje} V");
Console.WriteLine($"Estado: {motorCD1.ObtenerEstado()}");
Console.WriteLine($"Revisión de temperatura: {motorCD1.RevisarTemperatura()}");

// Mostrar resultados Motor AC
Console.WriteLine();
Console.WriteLine("DATOS DEL MOTOR AC");
Console.WriteLine($"Motor: {motorAC1.Identificador}");
Console.WriteLine($"Temperatura: {motorAC1.Temperatura} °C");
Console.WriteLine($"Corriente: {motorAC1.Corriente} A");
Console.WriteLine($"Velocidad: {motorAC1.Velocidad} rpm");
Console.WriteLine($"Fases de Operación: {motorAC1.FasesOperacion}");
Console.WriteLine($"Estado: {motorAC1.ObtenerEstado()}");
Console.WriteLine($"Revisión de temperatura: {motorAC1.RevisarTemperatura()}");

// Mostrar resultados Servo Motor
Console.WriteLine();
Console.WriteLine("DATOS DEL SERVO MOTOR");
Console.WriteLine($"Motor: {servo1.Identificador}");
Console.WriteLine($"Temperatura: {servo1.Temperatura} °C");
Console.WriteLine($"Corriente: {servo1.Corriente} A");
Console.WriteLine($"Velocidad: {servo1.Velocidad} rpm");
Console.WriteLine($"Posición Angular: {servo1.PosicionAngular} °");
Console.WriteLine($"Estado: {servo1.ObtenerEstado()}");
Console.WriteLine($"Revisión de temperatura: {servo1.RevisarTemperatura()}");
Console.WriteLine("========================================");


// CLASE BASE
class Motor
{
    // Propiedades comunes
    public string Identificador { get; set; } = "";
    public double Temperatura { get; set; }
    public double Corriente { get; set; }
    public double Velocidad { get; set; }

    // Método para determinar el estado
    public string ObtenerEstado()
    {
        if (Velocidad > 0)
            return "Motor en marcha";
        else
            return "Motor detenido";
    }

    // Método para revisar la temperatura
    public string RevisarTemperatura()
    {
        if (Temperatura > 70)
            return "ALERTA: Temperatura elevada";

        return "Temperatura normal";
    }
}

// CLASE DERIVADA 1: Motor CD
class MotorCD : Motor
{
    public double Voltaje { get; set; }
}

// CLASE DERIVada 2: Motor AC 
class MotorAC : Motor
{
    public string FasesOperacion { get; set; } = "";
}

// CLASE DERIVADA 3: Servo Motor 
class ServoMotor : Motor
{
    public double PosicionAngular { get; set; }
}