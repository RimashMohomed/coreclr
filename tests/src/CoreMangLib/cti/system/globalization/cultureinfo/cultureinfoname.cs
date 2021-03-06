using System;
using System.Globalization;
/// <summary>
///Name
/// </summary>
public class CultureInfoName
{
    public static int Main()
    {
        CultureInfoName CultureInfoName = new CultureInfoName();

        TestLibrary.TestFramework.BeginTestCase("CultureInfoName");
        if (CultureInfoName.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }

    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: CultureTypes.CurrentCulture");
        try
        {
            CultureInfo ci = CultureInfo.CurrentCulture;
            {
                string inFactName = ci.Name;
                string excepectedName = new CultureInfo(ci.Name).Name;
                if (excepectedName != inFactName)
                {
                    TestLibrary.TestFramework.LogError("001", "the fact Name is different from  excepectedName which  comes from LCID");
                    retVal = false;
                }
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }

   
}

