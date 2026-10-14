import 'dart:io';
import 'dart:math';

class Challenge1 {
  void run() {
    print("Ingrese un número:");
    int num = int.parse(stdin.readLineSync()!);
    if (num > 0) {
      print("Positivo");
    } else if (num < 0) {
      print("Negativo");
    } else {
      print("Es cero");
    }
  }
}

class Challenge2 {
  void run() {
    print("Ingrese primer número:");
    double num1 = double.parse(stdin.readLineSync()!);
    print("Ingrese segundo número:");
    double num2 = double.parse(stdin.readLineSync()!);
    print(
      "Suma: ${num1 + num2}\nResta: ${num1 - num2}\nMultiplicación: ${num1 * num2}\nDivisión: ${num1 / num2}",
    );
  }
}

class Challenge3 {
  void run() {
    print("Ingrese un número:");
    int numero = int.parse(stdin.readLineSync()!);
    print("El cuadrado de $numero es: ${numero * numero}");
  }
}

class Challenge4 {
  void run() {
    print("Ingrese el radio del círculo:");
    double radio = double.parse(stdin.readLineSync()!);
    double area = pi * radio * radio;
    print("El área del círculo con radio $radio es: $area");
  }
}

class Challenge5 {
  void run() {
    print("Ingrese un número entre 1 y 7:");
    int dia = int.parse(stdin.readLineSync()!);
    switch (dia) {
      case 1:
        print("Lunes");
        break;
      case 2:
        print("Martes");
        break;
      case 3:
        print("Miércoles");
        break;
      case 4:
        print("Jueves");
        break;
      case 5:
        print("Viernes");
        break;
      case 6:
        print("Sábado");
        break;
      case 7:
        print("Domingo");
        break;
      default:
        print("Número no válido");
        break;
    }
  }
}

class Challenge6 {
  void run() {
    print("Ingrese su salario mensual:");
    double salario = double.parse(stdin.readLineSync()!);
    double impuesto = salario > 4000 ? salario * 0.1 : 0;
    print("El impuesto a pagar es: $impuesto");
  }
}

class Challenge7 {
  void run() {
    print("Ingrese el primer número:");
    int num1 = int.parse(stdin.readLineSync()!);
    print("Ingrese el segundo número:");
    int num2 = int.parse(stdin.readLineSync()!);
    print("El residuo de la división es: ${num1 % num2}");
  }
}

class Challenge8 {
  void run() {
    int suma = 0;
    for (int i = 1; i <= 50; i++) {
      if (i % 2 == 0) {
        suma += i;
      }
    }
    print("La suma de los números pares entre 1 y 50 es: $suma");
  }
}

class Challenge9 {
  void run() {
    print("Ingrese el numerador de la primera fracción:");
    int num1 = int.parse(stdin.readLineSync()!);
    print("Ingrese el denominador de la primera fracción:");
    int den1 = int.parse(stdin.readLineSync()!);

    print("Ingrese el numerador de la segunda fracción:");
    int num2 = int.parse(stdin.readLineSync()!);
    print("Ingrese el denominador de la segunda fracción:");
    int den2 = int.parse(stdin.readLineSync()!);

    int numRes = (num1 * den2) - (num2 * den1);
    int denRes = den1 * den2;

    if (numRes == 0) {
      print("La diferencia es: 0");
    } else {
      print("La diferencia es: $numRes/$denRes");
    }
  }
}

class Challenge10 {
  void run() {
    print("Ingrese una palabra:");
    String palabra = stdin.readLineSync()!;
    print("La longitud de la palabra es: ${palabra.length}");
  }
}

class Challenge11 {
  void run() {
    print("Ingrese el primer número:");
    double n1 = double.parse(stdin.readLineSync()!);
    print("Ingrese el segundo número:");
    double n2 = double.parse(stdin.readLineSync()!);
    print("Ingrese el tercer número:");
    double n3 = double.parse(stdin.readLineSync()!);
    print("Ingrese el cuarto número:");
    double n4 = double.parse(stdin.readLineSync()!);

    double promedio = (n1 + n2 + n3 + n4) / 4;
    print("El promedio es: $promedio");
  }
}

class Challenge12 {
  void run() {
    List<double> numeros = [];
    for (int i = 1; i <= 5; i++) {
      print("Ingrese el número $i:");
      numeros.add(double.parse(stdin.readLineSync()!));
    }
    double menor = numeros.reduce((a, b) => a < b ? a : b);
    print("El número más pequeño es: $menor");
  }
}

class Challenge13 {
  void run() {
    print("Ingrese una palabra:");
    String palabra = stdin.readLineSync()!.toLowerCase();
    int contador = 0;
    for (int i = 0; i < palabra.length; i++) {
      String char = palabra[i];
      if ('aeiou'.contains(char)) {
        contador++;
      }
    }
    print("Número de vocales: $contador");
  }
}

class Challenge14 {
  void run() {
    print("Ingrese un número:");
    int n = int.parse(stdin.readLineSync()!);
    int factorial = 1;
    for (int i = 1; i <= n; i++) {
      factorial *= i;
    }
    print("El factorial de $n es: $factorial");
  }
}

class Challenge15 {
  void run() {
    print("Ingrese un número:");
    int num = int.parse(stdin.readLineSync()!);
    if (num >= 10 && num <= 20) {
      print("Está en el rango.");
    } else {
      print("Fuera del rango.");
    }
  }
}
