public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int i = 0;
        try
        {
            while (i < 10)
            {
                // Simulate some work
                Thread.Sleep(100);
                i++;
                if (i == 5) { throw new Exception("Something went wrong!"); }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            // Add more sophisticated error handling here, e.g., logging, retrying, etc.
        }
    }
}