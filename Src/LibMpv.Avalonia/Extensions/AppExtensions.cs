#if ANDROID
using Avalonia;
using Android.Content;
using HanumanInstitute.LibMpv.Core;

namespace HanumanInstitute.LibMpv.Avalonia.Extensions;

public static class AppExtensions
{
    public static AppBuilder UseMpvAndroid(this AppBuilder builder, Context? context, string dllName = "")
    {
        if (context == null)
            return builder;

        MpvApi.RootPath = context.ApplicationInfo.NativeLibraryDir;
        
        if(!string.IsNullOrWhiteSpace(dllName))
            MpvApi.DllName = dllName;
        
        return builder;
    }
}
#endif

