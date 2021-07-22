//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.11.3.0 (NJsonSchema v10.4.4.0 (Newtonsoft.Json v9.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"

namespace xtellurian.HubSpot.Events
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.11.3.0 (NJsonSchema v10.4.4.0 (Newtonsoft.Json v9.0.0.0))")]
    public partial class EventsClient 
    {
        private string _baseUrl = "https://api.hubapi.com/";
        private System.Net.Http.HttpClient _httpClient;
        private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;
    
        public EventsClient(System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient;
            _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(CreateSerializerSettings);
        }
    
        private Newtonsoft.Json.JsonSerializerSettings CreateSerializerSettings()
        {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            UpdateJsonSerializerSettings(settings);
            return settings;
        }
    
        public string BaseUrl
        {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }
    
    
        public Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }
    
        partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);
    
    
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
        partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);
        /// <summary>Returns a collection of events matching a query.</summary>
        /// <param name="occurredAfter">The starting time as an ISO 8601 timestamp.</param>
        /// <param name="occurredBefore">The ending time as an ISO 8601 timestamp.</param>
        /// <param name="objectType">The type of object being selected. Valid values are hubspot named object types (e.g. `contact`).</param>
        /// <param name="objectId">The id of the selected object. If not present, then the `objectProperty` parameter is required.</param>
        /// <param name="eventType">Limits the response to the specified event type.  For example `&amp;eventType=e_visited_page` returns only `e_visited_page` events.  If not present all event types are returned.</param>
        /// <param name="after">An additional parameter that may be used to get the next `limit` set of results.</param>
        /// <param name="limit">The maximum number of events to return, defaults to 20.</param>
        /// <param name="sort">Selects the sort field and order. Defaults to ascending, prefix with `-` for descending order. `occurredAt` is the only field supported for sorting.</param>
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<CollectionResponseExternalUnifiedEvent> EventsV3EventsAsync(string occurredAfter, string occurredBefore, string objectType, long? objectId, string eventType, string after, string before, int? limit, System.Collections.Generic.IEnumerable<string> sort)
        {
            return EventsV3EventsAsync(occurredAfter, occurredBefore, objectType, objectId, eventType, after, before, limit, sort, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Returns a collection of events matching a query.</summary>
        /// <param name="occurredAfter">The starting time as an ISO 8601 timestamp.</param>
        /// <param name="occurredBefore">The ending time as an ISO 8601 timestamp.</param>
        /// <param name="objectType">The type of object being selected. Valid values are hubspot named object types (e.g. `contact`).</param>
        /// <param name="objectId">The id of the selected object. If not present, then the `objectProperty` parameter is required.</param>
        /// <param name="eventType">Limits the response to the specified event type.  For example `&amp;eventType=e_visited_page` returns only `e_visited_page` events.  If not present all event types are returned.</param>
        /// <param name="after">An additional parameter that may be used to get the next `limit` set of results.</param>
        /// <param name="limit">The maximum number of events to return, defaults to 20.</param>
        /// <param name="sort">Selects the sort field and order. Defaults to ascending, prefix with `-` for descending order. `occurredAt` is the only field supported for sorting.</param>
        /// <returns>successful operation</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<CollectionResponseExternalUnifiedEvent> EventsV3EventsAsync(string occurredAfter, string occurredBefore, string objectType, long? objectId, string eventType, string after, string before, int? limit, System.Collections.Generic.IEnumerable<string> sort, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/events/v3/events?");
            if (occurredAfter != null)
            {
                urlBuilder_.Append(System.Uri.EscapeDataString("occurredAfter") + "=").Append(System.Uri.EscapeDataString(ConvertToString(occurredAfter, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (occurredBefore != null)
            {
                urlBuilder_.Append(System.Uri.EscapeDataString("occurredBefore") + "=").Append(System.Uri.EscapeDataString(ConvertToString(occurredBefore, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (objectType != null)
            {
                urlBuilder_.Append(System.Uri.EscapeDataString("objectType") + "=").Append(System.Uri.EscapeDataString(ConvertToString(objectType, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (objectId != null)
            {
                urlBuilder_.Append(System.Uri.EscapeDataString("objectId") + "=").Append(System.Uri.EscapeDataString(ConvertToString(objectId, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (eventType != null)
            {
                urlBuilder_.Append(System.Uri.EscapeDataString("eventType") + "=").Append(System.Uri.EscapeDataString(ConvertToString(eventType, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (after != null)
            {
                urlBuilder_.Append(System.Uri.EscapeDataString("after") + "=").Append(System.Uri.EscapeDataString(ConvertToString(after, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (before != null)
            {
                urlBuilder_.Append(System.Uri.EscapeDataString("before") + "=").Append(System.Uri.EscapeDataString(ConvertToString(before, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (limit != null)
            {
                urlBuilder_.Append(System.Uri.EscapeDataString("limit") + "=").Append(System.Uri.EscapeDataString(ConvertToString(limit, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (sort != null)
            {
                foreach (var item_ in sort) { urlBuilder_.Append(System.Uri.EscapeDataString("sort") + "=").Append(System.Uri.EscapeDataString(ConvertToString(item_, System.Globalization.CultureInfo.InvariantCulture))).Append("&"); }
            }
            urlBuilder_.Length--;
    
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client_, request_, urlBuilder_);
    
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client_, request_, url_);
    
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }
    
                        ProcessResponse(client_, response_);
    
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<CollectionResponseExternalUnifiedEvent>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                            }
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Error>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                            }
                            throw new ApiException<Error>("An error occurred.", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }
    
        protected struct ObjectResponseResult<T>
        {
            public ObjectResponseResult(T responseObject, string responseText)
            {
                this.Object = responseObject;
                this.Text = responseText;
            }
    
            public T Object { get; }
    
            public string Text { get; }
        }
    
        public bool ReadResponseAsString { get; set; }
        
        protected virtual async System.Threading.Tasks.Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(System.Net.Http.HttpResponseMessage response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Threading.CancellationToken cancellationToken)
        {
            if (response == null || response.Content == null)
            {
                return new ObjectResponseResult<T>(default(T), string.Empty);
            }
        
            if (ReadResponseAsString)
            {
                var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    var typedBody = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                    return new ObjectResponseResult<T>(typedBody, responseText);
                }
                catch (Newtonsoft.Json.JsonException exception)
                {
                    var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
                }
            }
            else
            {
                try
                {
                    using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    using (var streamReader = new System.IO.StreamReader(responseStream))
                    using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                    {
                        var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);
                        var typedBody = serializer.Deserialize<T>(jsonTextReader);
                        return new ObjectResponseResult<T>(typedBody, string.Empty);
                    }
                }
                catch (Newtonsoft.Json.JsonException exception)
                {
                    var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
                }
            }
        }
    
        private string ConvertToString(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value == null)
            {
                return "";
            }
        
            if (value is System.Enum)
            {
                var name = System.Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                    {
                        var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute)) 
                            as System.Runtime.Serialization.EnumMemberAttribute;
                        if (attribute != null)
                        {
                            return attribute.Value != null ? attribute.Value : name;
                        }
                    }
        
                    var converted = System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                    return converted == null ? string.Empty : converted;
                }
            }
            else if (value is bool) 
            {
                return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[])
            {
                return System.Convert.ToBase64String((byte[]) value);
            }
            else if (value.GetType().IsArray)
            {
                var array = System.Linq.Enumerable.OfType<object>((System.Array) value);
                return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
            }
        
            var result = System.Convert.ToString(value, cultureInfo);
            return result == null ? "" : result;
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.4.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CollectionResponseExternalUnifiedEvent 
    {
        [Newtonsoft.Json.JsonProperty("results", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.List<ExternalUnifiedEvent> Results { get; set; } = new System.Collections.Generic.List<ExternalUnifiedEvent>();
    
        [Newtonsoft.Json.JsonProperty("paging", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Paging Paging { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.4.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Error 
    {
        /// <summary>A human readable message describing the error along with remediation steps where appropriate</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Message { get; set; }
    
        /// <summary>A unique identifier for the request. Include this value with any error reports or support tickets</summary>
        [Newtonsoft.Json.JsonProperty("correlationId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.Guid CorrelationId { get; set; }
    
        /// <summary>The error category</summary>
        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Category { get; set; }
    
        /// <summary>A specific category that contains more specific detail about the error</summary>
        [Newtonsoft.Json.JsonProperty("subCategory", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SubCategory { get; set; }
    
        /// <summary>further information about the error</summary>
        [Newtonsoft.Json.JsonProperty("errors", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<ErrorDetail> Errors { get; set; }
    
        /// <summary>Context about the error condition</summary>
        [Newtonsoft.Json.JsonProperty("context", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.List<string>> Context { get; set; }
    
        /// <summary>A map of link names to associated URIs containing documentation about the error or recommended remediation steps</summary>
        [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> Links { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.4.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ErrorDetail 
    {
        /// <summary>A human readable message describing the error along with remediation steps where appropriate</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Message { get; set; }
    
        /// <summary>The name of the field or parameter in which the error was found.</summary>
        [Newtonsoft.Json.JsonProperty("in", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string In { get; set; }
    
        /// <summary>The status code associated with the error detail</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }
    
        /// <summary>A specific category that contains more specific detail about the error</summary>
        [Newtonsoft.Json.JsonProperty("subCategory", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SubCategory { get; set; }
    
        /// <summary>Context about the error condition</summary>
        [Newtonsoft.Json.JsonProperty("context", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.List<string>> Context { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>Used to represent any event. With this format, the `objectType` and `eventType` values are stringified CRM types. Example object:
    /// &lt;br/&gt;
    /// ```
    ///  {
    ///       "objectType": "CONTACT",
    ///       "objectId": 208451632,
    ///       "eventType": "e_visited_page",
    ///       "occurredAt": 1567377501421,
    ///       "id": "leviathan-be3335d3-46f1-3985-988e-ff38e6e7b9d8",
    ///       "properties": {
    ///           "hs_url": "https://some-website.com/",
    ///           "hs_title": "Home",
    ///           "hs_referrer": "https://some-other-website.com/blog/why-we-love-big-data-and-you-should-too",
    ///           "hs_userAgent": "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2490.80 Safari/537.36",
    ///           "hs_city": "lund",
    ///           "hs_region": "m",
    ///           "hs_country": "se",
    ///           "hs_session_id" : "leviathan-be3335d3-46f1-3985-988e-ff38e6e7b9d8",
    ///           "hs_session_source" : "DIRECT"
    ///       }
    ///   }      
    /// ```</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.4.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ExternalUnifiedEvent 
    {
        /// <summary>The objectType for the object which did the event.</summary>
        [Newtonsoft.Json.JsonProperty("objectType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ObjectType { get; set; }
    
        /// <summary>The objectId of the object which did the event.</summary>
        [Newtonsoft.Json.JsonProperty("objectId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ObjectId { get; set; }
    
        /// <summary>The format of the `eventType` string is `ae{appId}_{eventTypeLabel}`, `pe{portalId}_{eventTypeLabel}`, or just `e_{eventTypeLabel}` for HubSpot events.</summary>
        [Newtonsoft.Json.JsonProperty("eventType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string EventType { get; set; }
    
        /// <summary>An ISO 8601 timestamp when the event occurred.</summary>
        [Newtonsoft.Json.JsonProperty("occurredAt", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string OccurredAt { get; set; }
    
        /// <summary>A unique identifier for the event.</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("properties", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.IDictionary<string, string> Properties { get; set; } = new System.Collections.Generic.Dictionary<string, string>();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.4.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class NextPage 
    {
        [Newtonsoft.Json.JsonProperty("after", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string After { get; set; }
    
        [Newtonsoft.Json.JsonProperty("link", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Link { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.4.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Paging 
    {
        [Newtonsoft.Json.JsonProperty("next", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public NextPage Next { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.11.3.0 (NJsonSchema v10.4.4.0 (Newtonsoft.Json v9.0.0.0))")]
    public partial class ApiException : System.Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public ApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException)
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + ((response == null) ? "(null)" : response.Substring(0, response.Length >= 512 ? 512 : response.Length)), innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.11.3.0 (NJsonSchema v10.4.4.0 (Newtonsoft.Json v9.0.0.0))")]
    public partial class ApiException<TResult> : ApiException
    {
        public TResult Result { get; private set; }

        public ApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108