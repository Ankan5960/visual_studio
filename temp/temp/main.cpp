#include<stdio.h>
#include<math.h>

bool IsPrimeNumber(int num)
{
    if (num == 0 || num == 1)
        return true;

    for (int i = 2; i <= num / 2; i++) {
        if (num % i == 0) {
            return false;
        }
    }
    return true;
}

int countDigit(int number)
{
    int count = 0;
    while (number) {
        count++;
        number /= 10;
    }
    return count;
}

bool IsCircularPrimeNumber(int number, int n) {
    int temp;
    int flag = 0;
    for (int i = 0; i < n; i++) {
        temp = number % 10;
        number = (number / 10) + temp * (pow(10, (n - 1)));
        if (IsPrimeNumber(number))
            flag = 1;
        else
            return false;
    }

    if (flag == 1) {
        return true;
    }


}

int main()
{
    int number = 19937;
    int n = countDigit(number);

    if (IsCircularPrimeNumber(number, n))
        printf("Circular Prime number");
    else
        printf("Non-Circular Prime number");

    int temp;
    for (int i = 0; i < n; i++) {
        temp = number % 10;
        number = (number / 10) + temp * (pow(10, (n - 1)));
        printf("\n%d", number);
    }
}