using System;

namespace ShaellLang;

public class ShaellConversionException : StackTracedException
{
    private string _from;
    private string _to;
    private string _message;
    public ShaellConversionException(string from, string to) : base("")
    {
        _to = to;
        _from = from;
        _message = null;
    }
    
    public ShaellConversionException(string from, string to, string message) : base(message)
    {
        _to = to;
        _from = from;
        _message = message;
    }

    public override string ToString()
    {
        string rv = $"Cannot convert from {_from} to {_to}";
        if (_message != null)
        {
            rv += $":\n{_message}";
        }

        rv += "\nTrace:\n" + base.ToString();
        return rv;
    }
}