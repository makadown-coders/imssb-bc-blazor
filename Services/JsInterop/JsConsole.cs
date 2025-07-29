using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace ImssbBcBlazor.Services.JsInterop
{
    public class JsConsole
    {
        private readonly IJSRuntime _jsRuntime;

        public JsConsole(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task LogAsync(string message)
            => await _jsRuntime.InvokeVoidAsync("console.log", message);

        public async Task WarnAsync(string message)
            => await _jsRuntime.InvokeVoidAsync("console.warn", message);

        public async Task ErrorAsync(string message)
            => await _jsRuntime.InvokeVoidAsync("console.error", message);

        public async Task TableAsync(object obj)
            => await _jsRuntime.InvokeVoidAsync("console.table", obj);
    }
}