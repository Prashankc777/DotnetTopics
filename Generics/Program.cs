using System.Runtime.InteropServices;

public class Stack<T>
{
    T[] data;
    int top = -1;

    public Stack(int size)
    {
        data = new T[size];
    }
    public void Push(T value)
    {
        top++;
        data[top] = value;
    }

    public T Pop()
    {
        T value = data[top];
        top--;
        return value;
    }

    public T GetTopElement()
    {
        return data[top];
    }

    public void Print()
    {
        for (int i = 0; i < top; i++)
        {
            Console.WriteLine(data[i]);
        }

        Console.ReadLine();
    }
}

public class Program()
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>(5);
        stack.Push(5);
        stack.Push(12);
        stack.Push(13);
        Console.Write("Push Complete");
        stack.Print();
        int n = stack.Pop();
        stack.Print();

    }
}