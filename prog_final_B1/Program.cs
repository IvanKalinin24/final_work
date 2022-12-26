using System;
using static System.Console;

Clear();

string[] array = myArray();
string[] resArray = GetArray(array, 3);
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", resArray)}]");

string[] GetArray(string[] ar, int n) {
    string[] ar2 = new string[NewCound(ar, n)];

    for(int i = 0, j = 0; i < ar.Length; i++) {
        if(ar[i].Length <= n) {
            ar2[j] = ar[i];
            j++;
        }
    }

    return ar2;
}

int NewCound(string[] ar, int n) {
    int count = 0;

    for(int i = 0; i < ar.Length; i++) {
        if(ar[i].Length <= n) {
            count++;
        }
    }

    return count;
}

string[] myArray() {
    Write("Введите значения через пробел: ");
    return ReadLine().Split(" ");
}