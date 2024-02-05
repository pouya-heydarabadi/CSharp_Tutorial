namespace CSharp._01.Variable;

public class SampleVar
{
    public void Main()
    {
        #region string

        // Definition String Variable
        string str1 = new string("string1");
        string str2 = new("string2");
        string str3 = "string3";

        // default value in string
        string stringDefaultValue = string.Empty;
        string stringDefaultValueWithDefault = default; // Is <<Null>>  Value For This
        #endregion

        #region Char
        // Definitionn Char Variable
        char char1 = 'a';
        char char2 = 'b';
        char char3 = default;  // Value Is '\0'
        #endregion

        #region int

        // Definition Int Variable
        int int1 = 1;
        int int2 = 2;

        int intMin = int.MinValue; // -2147483648
        int intMax = int.MaxValue; // 2147483647

        // default Value in Int 
        int intDefaultValue = default; // default is <<0>>
        #endregion

        #region Decimal

        // Definition Decimal Variable
        // M -->(decimal) Meaning Implicit Cast 

        decimal dec1 = 1.2M;
        decimal dec2 = 1.21323124M;
        decimal dec3 = -13123.12312312M;

        decimal decimanMin = decimal.MinValue; // Value is -79228162514264337593543950335M
        decimal decimalMax = decimal.MaxValue; // Value Is 79228162514264337593543950335M

        // Default Value For decimal
        decimal defaultValueForDecimal = default; // Default Value Is 0
        #endregion

        #region Float
        // Definition Float Variable
        // F -->(Float) Meaning Implicit Cast 
        float flt1 = 23.44F;
        float flt2 = 234213.1231241F;
        float flt3 = -223123123.2132141241F;

        float floatMin = float.MinValue; // Value Is -3.40282347E+38
        float floatMax = float.MaxValue; // Value Is  3.40282347E+38

        // Default Value For Float
        float defaultValueForFloat = default; // Default Value Is 0
        #endregion

        #region Long
        // Definition Long Variable
        // L -->(long) Meaning Implicit Cast 
        long lng1 = 232132312312L;
        long lng2 = -324234324324324324;

        long minLong = long.MinValue; // Value Is 9223372036854775807
        long maxLong = long.MaxValue; // Value Is -9223372036854775807
        #endregion

        #region Short

        // Definition Short Variable
        short shrt1 = 123;
        short shrt2 = -123;

        short minShort = short.MinValue; // Value Is -32768
        short maxShort = short.MaxValue; // Value Is 32768

        // Default Value For Short 
        short defaultValueForShort = default; // Value Is 0
        #endregion

        #region UShort

        // Definition UShort Variable
        ushort ushrt1 = 12334;

        ushort ushrtMin = ushort.MinValue; // Min Is 0
        ushort ushrtMax = ushort.MaxValue; // Max Is 65535

        // Default Value For Ushort
        ushort defaultValueForUShort = default; // Value Is 0
        #endregion

    }
}
