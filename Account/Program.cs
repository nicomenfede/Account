using System;

public class Account
{
    [Flags]
    public enum Access
    {
        Delete,
        Publish,
        Submit,
        Comment,
        Modify,
        Writer = Submit | Modify,
        Editor = Delete | Publish | Comment,
        Owner = Writer | Editor 
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Access.Writer.HasFlag(Access.Delete)); //Should print: "False"
    }
}