#include <iostream>

using std::cout;
using std::endl;
using std::cin;
using std::numeric_limits;

void Exerc1();
void Exerc2();
void Exerc3();
void Exerc4();
void Exerc5();
void Exerc6();
void Exerc7();
void Exerc8();
void Exerc9();
float max(float *array, int sizeArray);
float min(float *array, int sizeArray);
void Exerc10();

int main() {
	Exerc8();
	system("pause");
	return 0;
}

void Exerc1() {
	std::cout << "AUT0218 - Programacao Visual Aplicada" << std::endl;
}

void Exerc2() {
	float km;
	std::cout << "Informe km/h: ";
	std::cin >> km;
	std::cout << "Em metros/segundo: " << km / 3.6 << std::endl;
}

void Exerc3() {
	float base, altura;
	std::cout << "Informe a base: ";
	std::cin >> base;
	std::cout << "Informe a altura: ";
	std::cin >> altura;
	std::cout << "Area: " << base * altura / 2 << std::endl;
}

void Exerc4() {
	int numeros[5], i = 0;
	float acumulador = 0;
	for (i = 0; i <= std::size(numeros) - 1; i++) {
		std::cout << "Informe um numero: ";
		std::cin >> numeros[i];
		acumulador += numeros[i];
	}
	std::cout << "Media: " << acumulador / i << std::endl;
}

void Exerc5() {
	for (int i = 1; i <= 50; i++) std::cout << i << std::endl;
	for (int i = 50; i >= 1; i--) std::cout << i << std::endl;
}

void Exerc6() {
	int x;
	std::cout << "Informe um numero: ";
	std::cin >> x;
	while (x <= 100) {
		std::cout << x << std::endl;
		x *= 3;
	}
	std::cout << x << std::endl;
}

void Exerc7() {
	for (int i = 1; i <= 10; i++) std::cout << 9 * i << std::endl;
}

void Exerc8() {
	int x, acumulador;
	cout << "Informe um numero: ";
	cin >> x;

	for (int i = 1; i <= x; i++) {
		acumulador = i;
		for (int j = 1; j <= i; j++) {
			cout << acumulador << " ";
			acumulador += i;
		}
		cout << endl;
	}
}

void Exerc9() {
	float array[10] = { 1, 2, -3, 4, 99, 6, 7, 8, 9, 10 };
	int sizeArray = sizeof(array) / sizeof(*array) - 1;

	for (int i = 0; i <= sizeArray; i++) {
		cout << "Informe um valor: ";
		cin >> array[i];
	}

	cout << "Maior valor: " << max(array, sizeArray) << endl;
	cout << "Menor valor: " << min(array, sizeArray) << endl;
}

float max(float *array, int sizeArray) {
	float maxValue = numeric_limits<float>::min();
	for (int i = 0; i <= sizeArray; i++) maxValue = (array[i] > maxValue) ? array[i] : maxValue;
	return maxValue;
}

float min(float *array, int sizeArray) {
	float minValue = numeric_limits<float>::max();
	for (int i = 0; i <= sizeArray; i++) minValue = (array[i] < minValue) ? array[i] : minValue;
	return minValue;
}

void Exerc10() {
	float array[10], acumulador = 0;
	int i, sizeArray = sizeof(array) / sizeof(*array) - 1;

	for (i = 0; i <= sizeArray; i++) {
		cout << "Informe um valor: ";
		cin >> array[i];
		acumulador += array[i];
	}
	cout << "Media: " << acumulador / (i - 1) << endl;
}
