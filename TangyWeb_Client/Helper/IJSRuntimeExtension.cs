using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace TangyWeb_Client.Helper
{
    public static class IJSRuntimeExtension
    {
        public static async ValueTask ToastrSuccess(this IJSRuntime jsruntime, string message)
        {
            await jsruntime.InvokeVoidAsync("ShowToastr", "success", message);
        }
        public static async ValueTask ToastrError(this IJSRuntime jsruntime, string message)
        {
            await jsruntime.InvokeVoidAsync("ShowToastr", "error", message);
        }
    }
}
