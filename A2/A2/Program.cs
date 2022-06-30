// See https://aka.ms/new-console-template for more information
// 1. If a string is not going to change throughout the program, then use String class object.
//    If a string can change then use a StringBuilder.
// 2. Array Class
// 3. Array.Sort
// 4. length
// 5. Yes, if we create an object array.
// 6. Clone() returns a new array object containing all the elements in the original array.
//    CopyTo() copies elements into another existing array.
using System;
using System.Text.RegularExpressions;
//For testing question after Q1, you need comment out Q1, since this is a infinite while loop.
// Q1

int[] ints = new int[] {1,2,3,4,5,6,7,8,9,10};
int[] arr = new int[ints.Length];
for (int i = 0; i < ints.Length; i++)
{
    arr[i] = ints[i];
}

// Q2
List<int> list = new List<int>();
while (1 == 1)
{
    Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
    string input = Console.ReadLine();
    if (input == "+")
    {
        Console.WriteLine("Add item name:");
        string add = Console.ReadLine();
        list.Add(Int16.Parse(add));
        Console.WriteLine(String.Join(" ", list));
    }
    if (input == "-")
    {
        Console.WriteLine("Remove item name:");
        string rem = Console.ReadLine();
        list.Remove(Int16.Parse(rem));
        Console.WriteLine(String.Join(" ", list));
    }
    if (input == "--")
    {
        list = new List<int>();
        Console.WriteLine(String.Join(" ", list));
    }

}

// Q3
Console.WriteLine("Enter start number:");
int startNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter end number:");
int endNum = Convert.ToInt32(Console.ReadLine());

FindPrimesInRange(startNum, endNum);

static int[] FindPrimesInRange(int startNum, int endNum)
{
    int[] res = new int[20];
    for (int num = startNum; num <= endNum; num++)
    {
        int ctr = 0;

        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                ctr++;
                break;
            }
        }

        if (ctr == 0 && num != 1)
            Console.Write(num+" ");
            res.Append(num);

    }
    Console.Write("\n");
    return res;
}

// Q4
int[] arr2 = { 3, 2, 4, -1 };
int N = arr2.Length;
int K = 2;

RightRotate(arr2, N, K);
static void RightRotate(int[] a, int n, int k)
    {

        k = k % n;

        for (int i = 0; i < n; i++)
        {
            if (i < k)
            {
                Console.Write(a[n + i - k] + " ");
            }
            else
            {
                Console.Write(a[i - k] + " ");
            }
        }
        Console.WriteLine();
    }


// Q5
int[] arr1 = {2,1,1,2,3,3,3,3,1};
int N1 = arr1.Length;
int tmp = 0;
int maxTimes = 1;
for (int i = 1; i < N1; i++)
{
    if (arr1[i-1] == arr1[i])
    {
        maxTimes++;
        tmp = arr1[i];
    }
    else
    {
        maxTimes = Math.Max(maxTimes--,0);
    }
}
int[] res5 = Enumerable.Repeat(tmp, maxTimes).ToArray();
Console.WriteLine(String.Join(",", res5));


// Q7
int mn = 0;
int fre = 0;
IDictionary<int, int> map = new Dictionary<int, int>();
for (int i = 0; i < N; i++)
{
    if (map.ContainsKey(arr1[i]))
        map[arr1[i]] += 1;
    else
        map[arr1[i]] = 1;
    if (map[arr1[i]] > fre)
    {
        mn = arr1[i];
    }
}
Console.Write(mn + " with most occurrencesb: "+ fre );
// 1
Console.WriteLine("Enter the input string: ");
string s = Console.ReadLine();
char[] charArray = s.ToCharArray();
Array.Reverse(charArray);
Console.WriteLine(new string(charArray));

// 3
string _inputstr, _reversestr = string.Empty;
Console.Write("Enter a string : ");
_inputstr = Console.ReadLine();
    if (_inputstr != null)
    {
        for (int i = _inputstr.Length - 1; i >= 0; i--)
        {
            _reversestr += _inputstr[i].ToString();
        }
        if (_reversestr == _inputstr)
        {
            Console.WriteLine("String is Palindrome Input = {0} and Output= {1}", _inputstr, _reversestr);
        }
    }
    Console.ReadLine();

// 4
// For example: https://www.apple.com/iphone
Console.WriteLine("Input URL: ");
string url = Console.ReadLine();

Regex r = new Regex(@"^(?<proto>\w+)://(?<server>[^/]+)/(?<resource>\w+)",RegexOptions.None, TimeSpan.FromMilliseconds(150));
Match m = r.Match(url);
if (m.Success)
   Console.WriteLine(m.Result("${proto} ${server} ${resource}"));