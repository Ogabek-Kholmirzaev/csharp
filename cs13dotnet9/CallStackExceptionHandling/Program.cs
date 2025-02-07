using CallStackExceptionHandlingLib;
using static System.Console;

WriteLine("In Main");
Alpha();

void Alpha()
{
    WriteLine("In Alpha");
    Beta();
}

void Beta()
{
    WriteLine("In Beta");

    try
    {
        Processor.Gamma();
    }
    catch (IOException ex)
    {
        LogException(ex);

        // Throw the caught exception as if it happened here
        // this will lose the original call stack.
        //throw ex;

        // Rethrow the caught exception and retain its original call stack.
        //throw;

        // Throw a new exception with the caught exception nested within it.
        throw new InvalidOperationException(
            message: "Calculation had invalid values. See inner exception for why.",
            innerException: ex);
    }
}

void LogException(Exception ex)
{
    WriteLine($"{DateTime.Now}\tMessage: {ex.Message}");
}
