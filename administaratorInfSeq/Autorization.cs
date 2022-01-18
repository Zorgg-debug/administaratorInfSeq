
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.Handler;

namespace administaratorInfSeq
{
    /// <summary>
    /// для взаимодействия с grafana через браузер, без авторизации с использованием токена
    /// </summary>
    class Autorization : ResourceRequestHandler
    {
        string _token;
        public Autorization(string token)
        {
            _token = token;
        }

        protected override CefReturnValue OnBeforeResourceLoad(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IRequestCallback callback)
        {
            if (!string.IsNullOrEmpty(_token))
            {
                var headers = request.Headers;
                headers["Authorization"] = $"Bearer {_token}";
                request.Headers = headers;
                return CefReturnValue.Continue;
            }
            else return base.OnBeforeResourceLoad(chromiumWebBrowser, browser, frame, request, callback);
        }
    }
    public class BearerAuthRequestHandler:RequestHandler
    {
        string _token;
        public BearerAuthRequestHandler(string token)
        {
            _token = token;
        }
        protected override IResourceRequestHandler GetResourceRequestHandler(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling)
        {
            if (!string.IsNullOrEmpty(_token)) return new Autorization(_token);
            else return base.GetResourceRequestHandler(chromiumWebBrowser, browser, frame, request, isNavigation, isDownload, requestInitiator, ref disableDefaultHandling);
        }
    }
}
