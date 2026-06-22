namespace HanumanInstitute.LibMpv.Core;

public class MpvConfiguration
{
    public string RootPath { get; set; } = AppDomain.CurrentDomain.BaseDirectory;
    public string DllName { get; set; } = "libmpv";
    
    public static Dictionary<string, int> LibraryVersionMap = new()
    {
        {"libmpv", 2}
    };
}
