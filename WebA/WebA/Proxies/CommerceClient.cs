using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace WebA.Proxies
{
    public class CommerceClient : IDisposable
    {

        public string InvokeHttpClientPut(string serviceCallUrl, string content, IDictionary<string, string> headers = null)
        {
            var task = Task.Run(() => InvokeHttpClientPutAsync(serviceCallUrl, new StringContent(content), headers));
            task.Wait();
            return task.Result;
        }
        public string InvokeHttpClientPost(string serviceCallUrl, string content, IDictionary<string, string> headers = null)
        {
            var task = Task.Run(() => InvokeHttpClientPostAsync(serviceCallUrl, new StringContent(content), headers));
            task.Wait();
            return task.Result;
        }

        public string InvokeHttpClientGet(string serviceCallUrl, string content, IDictionary<string, string> headers = null)
        {
            var task = Task.Run(() => InvokeHttpClientGetAsync(serviceCallUrl, new StringContent(content), headers));
            task.Wait();
            return task.Result;
        }

        public string InvokeHttpClientDelete(string serviceCallUrl, string content, IDictionary<string, string> headers = null)
        {
            var task = Task.Run(() => InvokeHttpClientDeleteAsync(serviceCallUrl, new StringContent(content), headers));
            task.Wait();
            return task.Result;
        }

        public async Task<string> InvokeHttpClientDeleteAsync(string serviceCallUrl, StringContent content, IDictionary<string, string> headers = null)
        {
            try
            {
                var client = new HttpClient
                {
                    BaseAddress = new Uri("https://localhost:44332/")
                };
                try
                {
                    if (headers != null)
                    {
                        var requestHeader = client.DefaultRequestHeaders;
                        foreach (var item in headers)
                        {
                            if (requestHeader.TryGetValues(item.Key, out IEnumerable<string> values))
                            {
                                requestHeader.Remove(item.Key);
                            }
                            requestHeader.Add(item.Key, item.Value);
                        }
                    }
                    content.Headers.Remove("Content-Type");
                    content.Headers.Add("Content-Type", "application/json");
                    var response = await client.DeleteAsync(serviceCallUrl);
                    if (response.IsSuccessStatusCode)
                        return await response.Content.ReadAsStringAsync();
                    return string.Empty;
                }
                finally
                {
                    client?.Dispose();
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }


        public async Task<string> InvokeHttpClientGetAsync(string serviceCallUrl, StringContent content, IDictionary<string, string> headers = null)
        {
            try
            {
                var client = new HttpClient
                {
                    BaseAddress = new Uri("https://localhost:44332/")
                };
                try
                {
                    if (headers != null)
                    {
                        var requestHeader = client.DefaultRequestHeaders;
                        foreach (var item in headers)
                        {
                            if (requestHeader.TryGetValues(item.Key, out IEnumerable<string> values))
                            {
                                requestHeader.Remove(item.Key);
                            }
                            requestHeader.Add(item.Key, item.Value);
                        }
                    }
                    content.Headers.Remove("Content-Type");
                    content.Headers.Add("Content-Type", "application/json");
                    var response = await client.GetAsync(serviceCallUrl);
                    if (response.IsSuccessStatusCode)
                        return await response.Content.ReadAsStringAsync();
                    return string.Empty;
                }
                finally
                {
                    client?.Dispose();
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        public async Task<string> InvokeHttpClientPostAsync(string serviceCallUrl, StringContent content, IDictionary<string, string> headers = null)
        {
            try
            {
                var client = new HttpClient
                {
                    BaseAddress = new Uri("https://localhost:44332/")
                };
                try
                {
                    if (headers != null)
                    {
                        var requestHeader = client.DefaultRequestHeaders;
                        foreach (var item in headers)
                        {
                            if (requestHeader.TryGetValues(item.Key, out IEnumerable<string> values))
                            {
                                requestHeader.Remove(item.Key);
                            }
                            requestHeader.Add(item.Key, item.Value);
                        }
                    }
                    content.Headers.Remove("Content-Type");
                    content.Headers.Add("Content-Type", "application/json");
                    var response = await client.PostAsync(serviceCallUrl, content);
                    if (response.IsSuccessStatusCode)
                        return await response.Content.ReadAsStringAsync();
                    return string.Empty;
                }
                finally
                {
                    client?.Dispose();
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }


        public async Task<string> InvokeHttpClientPutAsync(string serviceCallUrl, StringContent content, IDictionary<string, string> headers = null)
        {
            try
            {
                var client = new HttpClient
                {
                    BaseAddress = new Uri("https://localhost:44332/")
                };
                try
                {
                    if (headers != null)
                    {
                        var requestHeader = client.DefaultRequestHeaders;
                        foreach (var item in headers)
                        {
                            if (requestHeader.TryGetValues(item.Key, out IEnumerable<string> values))
                            {
                                requestHeader.Remove(item.Key);
                            }
                            requestHeader.Add(item.Key, item.Value);
                        }
                    }
                    content.Headers.Remove("Content-Type");
                    content.Headers.Add("Content-Type", "application/json");
                    var response = await client.PutAsync(serviceCallUrl, content);
                    if (response.IsSuccessStatusCode)
                        return await response.Content.ReadAsStringAsync();
                    return string.Empty;
                }
                finally
                {
                    client?.Dispose();
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}