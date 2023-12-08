// По заданному вещественному x, вычислить корень кубический из x по следующей итерационной формуле: yi+1= 0.5 ( yi + 3 x / ( 2 yi2 + x / yi )).

int Zapros(string message) {
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void CubeRoot(int k) { // метод вычисления кубического корня
    double y = k;
    double y1 = 0;

        do {
            y1 = y;
            y = 0.5 * (y + 3 * k / ( 2 * y * y + k / y));
        }
        while (Math.Abs(y - y1) > 1 / 100000);
        Console.WriteLine(y);
}

int x = Zapros("Введите x");
CubeRoot(x); 
