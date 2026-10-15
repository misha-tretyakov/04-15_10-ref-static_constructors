namespace Practice;
using static System.Console;

class Practice
{
    static void Main(string[] args)
    {
        int result = MultiplicationRange(1, 5);
        WriteLine(result);


        int x = 13;
        bool test = Fibonacci(x);
        WriteLine(test);


        int[] arr = new int[] { 1, 3, 2, 0, 5 };
        SortArray(arr, true);
        for (int i = 0; i < arr.Length; i++)
        {
            Write(arr[i] + " ");
        }
        WriteLine();
        
        
        City c2 = new  City();
        c2.Input();
        c2.PrintAll();
    }
    
    //Завдання 1
    // Напишіть метод, який повертає добуток чисел у вказаному
    // діапазоні. Межі діапазону передаються як параметри.
    static int MultiplicationRange(int start, int end)
    {
        int result = 1;
        for (int i = start; i <= end; i++)
        {
            result *= i;
        }
        return result;
    }
    
    
    // Завдання 2
    // Напишіть метод, який перевіряє чи є число числом Фібоначчі.
    // Число передається як параметр.
    static bool Fibonacci(int N)
    {
        if (Math.Sqrt(5 * N * N + 4) % 1 == 0)
        {
            return true;
        }
        else if (Math.Sqrt(5 * N * N - 4) % 1 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    
    // Завдання 3
    // Напишіть метод, що сортує масив за зменшенням або
    // зростанням, залежно від вибору користувача.
    // Алгоритм сортування реалізуйте самостійно.
    // Наприклад, може бути реалізовано сортування методом
    // перестановок.
    static void SortArray(int[] arr, bool ascending)
    {
        for (int i = 0; i < arr.Length-1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if ((ascending && arr[i] > arr[j]) || (!ascending && arr[j] > arr[i]))
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
}

// Завдання 4
// Створіть клас "Місто". Необхідно зберігати у полях класу:
// назву міста, назву країни, кількість жителів у місті, телефонний код
// міста, назву районів міста. Реалізуйте методи класу для введення даних,
// виведення даних. Реалізуйте доступ до окремих полів через методи класу.
class City
{
    private string _name;
    private string _country;
    private int _population;
    private int _phoneCode;
    private string[] _districts;
    
    public City()
    {
        _name = "";
        _country = "";
        _population = 0;
        _phoneCode = 0;
        _districts = new string[0];
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Country
    {
        get { return _country; }
        set { _country = value; }
    }

    public int Population
    {
        get { return _population; }
        set { _population = value; }
    }

    public int PhoneCode
    {
        get { return _phoneCode; }
        set { _phoneCode = value; }
    }

    public string[] Districts
    {
        get { return _districts; }
        set { _districts = value; }
    }

    public void PrintAll()
    {
        WriteLine(_name);
        WriteLine(_country);
        WriteLine(_population);
        WriteLine(_phoneCode);
        for (int i = 0; i < _districts.Length - 1; i++)
        {
            Write(_districts[i] + ", ");
        }
        Write(_districts[_districts.Length - 1]);
        WriteLine();
    }

    public void Input()
    {
        Write("Enter a name: ");
        _name = ReadLine();
        Write("Enter a country: ");
        _country = ReadLine();
        Write("Enter a population: ");
        _population = int.Parse(ReadLine());
        Write("Enter a phone code: ");
        _phoneCode = int.Parse(ReadLine());
        Write("Enter a district, split using ',': ");
        _districts = ReadLine().Split(',');
    }
}

// Завдання 5
// Реалізуйте клас "Співробітник". Необхідно зберігати у полях класу:
// ПІБ, дату народження, контактний телефон, робочий email, посаду,
// опис службових обов'язків. Реалізуйте методи класу для введення даних,
// виведення даних. Реалізуйте доступ до окремих полів через методи класу.

class Employee
{
    private string _firstName;
    private string _lastName;
    private int _day;
    private int _month;
    private int _year;
    private int _phoneNumber;
    private string _email;
    private string _role;
    private string _desc;

    public Employee()
    {
        _firstName = "";
        _lastName = "";
        _day = 0;
        _month = 0;
        _year = 0;
        _phoneNumber = 0;
        _email = "";
        _role = "";
        _desc = "";
    }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }
    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }
    public int Day
    {
        get { return _day; }
        set { _day = value; }
    }
    public int Month
    {
        get { return _month; }
        set { _month = value; }
    }
    public int Year
    {
        get { return _year; }
        set { _year = value; }
    }
    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }
    public string Role
    {
        get { return _role; }
        set { _role = value; }
    }
    public string Desc
    {
        get { return _desc; }
        set { _desc = value; }
    }
    public void PrintAll()
    {
        WriteLine(_firstName);
        WriteLine(_lastName);
        WriteLine(_day + "." + _month + "." + _year);
        WriteLine(_email);
        WriteLine(_role);
        WriteLine(_desc);
    }

    public void Input()
    {
        Write("Enter a first name: ");
        _firstName = ReadLine();
        Write("Enter a last name: ");
        _lastName = ReadLine();
        Write("Enter a day: ");
        _day = int.Parse(ReadLine());
        Write("Enter a month: ");
        _month = int.Parse(ReadLine());
        Write("Enter a year: ");
        _year = int.Parse(ReadLine());
        Write("Enter a role: ");
        _role = ReadLine();
        Write("Enter a description: ");
        _desc = ReadLine();
    }
}