using System;

public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        throw new Exception("Error");
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        foreach (char c in input) {
            if (c < '0' || c > '9') return null;
        }
        return Convert.ToInt32(input);
    }

    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        result = 0;
        foreach (char c in input) {
            if (c < '0' || c > '9') return false;
        }
        result = Convert.ToInt32(input);
        return true;
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        disposableObject.Dispose();
        ErrorHandling.HandleErrorByThrowingException();
    }
}
