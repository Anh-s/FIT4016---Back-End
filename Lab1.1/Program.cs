//Bài 1:
Console.Write("1. Nhập tên của bạn: ");
string name = Console.ReadLine();//return type is string

Console.Write("Nhập tuổi của bạn: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine($"Name: {name}, age: {age}");

//Bài 2:
Console.Write("\n 2. Nhập chiều dài: ");
double chieuDai = double.Parse(Console.ReadLine());

Console.Write("Nhập chiều rộng: ");
double chieuRong = double.Parse(Console.ReadLine());

double dienTich = chieuDai * chieuRong;
Console.WriteLine($"Diện tích hình chữ nhật là: {dienTich}");

//Bài 3:
Console.Write("\n 3. Nhập nhiệt độ (độ C): ");
double doC = double.Parse(Console.ReadLine());

double doF = (doC * 9 / 5) + 32;
Console.WriteLine($"Nhiệt độ tương ứng (độ F): {doF}");

//Bài 4:
Console.Write("\n 4. Nhập một số nguyên: ");
int so = int.Parse(Console.ReadLine());

string ketQua = (so % 2 == 0) ? "là số chẵn" : "không phải là số chẵn";
Console.WriteLine($"Số {so} {ketQua}.");

//Bài 5:
Console.Write("\n 5. Nhập số thứ nhất: ");
int so1 = int.Parse(Console.ReadLine());

Console.Write("Nhập số thứ hai: ");
int so2 = int.Parse(Console.ReadLine());

int tong = so1 + so2;
int tich = so1 * so2;

Console.WriteLine($"Tổng: {tong}, Tích: {tich}");

//Bài 6:
Console.Write("\n 6. Nhập một số nguyên: ");
int songuyen = int.Parse(Console.ReadLine());
if (songuyen > 0)
    Console.WriteLine($"{songuyen} là số dương.");
else if (songuyen < 0)
    Console.WriteLine($"{songuyen} là số âm.");
else
    Console.WriteLine($"{songuyen} là số không.");

//Bài 7:
Console.Write("\n 7. Nhập một năm: ");
int nam = int.Parse(Console.ReadLine());

bool laNamNhuan = (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0);
if (laNamNhuan)
    Console.WriteLine($"{nam} là năm nhuận.");
else
    Console.WriteLine($"{nam} không phải là năm nhuận.");

//Bài 8:
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"\n 8.Bảng cửu chương {i}:");
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

//Bài 9:
Console.Write("\n 9.Nhập số nguyên dương n: ");
int n = int.Parse(Console.ReadLine());

int giaiThua = 1;
for (int i = 1; i <= n; i++)
{
    giaiThua *= i;
}

Console.WriteLine($"Giai thừa của {n} là: {giaiThua}");

//Bài 10:
Console.Write("\n 10.Nhập một số nguyên: ");
int number = int.Parse(Console.ReadLine());

bool laNguyenTo = so > 1;
for (int i = 2; i <= Math.Sqrt(so); i++)
{
    if (number % i == 0)
    {
        laNguyenTo = false;
        break;
    }
}

if (laNguyenTo)
    Console.WriteLine($"{number} là số nguyên tố.");
else
    Console.WriteLine($"{number} không phải là số nguyên tố.");
