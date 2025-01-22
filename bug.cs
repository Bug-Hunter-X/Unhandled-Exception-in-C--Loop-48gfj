public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int i = 0;
        while (i < 10)
        {
            // Simulate some work
            Thread.Sleep(100);
            i++;
            if (i == 5) { throw new Exception("Something went wrong!"); }
        }
    }
}