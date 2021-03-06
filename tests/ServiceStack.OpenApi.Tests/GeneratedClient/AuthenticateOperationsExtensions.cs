// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AutorestClient
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AuthenticateOperations.
    /// </summary>
    public static partial class AuthenticateOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='provider'>
            /// </param>
            /// <param name='state'>
            /// </param>
            /// <param name='oauthToken'>
            /// </param>
            /// <param name='oauthVerifier'>
            /// </param>
            /// <param name='userName'>
            /// </param>
            /// <param name='password'>
            /// </param>
            /// <param name='rememberMe'>
            /// </param>
            /// <param name='continueParameter'>
            /// </param>
            /// <param name='nonce'>
            /// </param>
            /// <param name='uri'>
            /// </param>
            /// <param name='response'>
            /// </param>
            /// <param name='qop'>
            /// </param>
            /// <param name='nc'>
            /// </param>
            /// <param name='cnonce'>
            /// </param>
            /// <param name='useTokenCookie'>
            /// </param>
            /// <param name='meta'>
            /// </param>
            public static AuthenticateResponse Get(this IAuthenticateOperations operations, string provider = default(string), string state = default(string), string oauthToken = default(string), string oauthVerifier = default(string), string userName = default(string), string password = default(string), bool? rememberMe = default(bool?), string continueParameter = default(string), string nonce = default(string), string uri = default(string), string response = default(string), string qop = default(string), string nc = default(string), string cnonce = default(string), bool? useTokenCookie = default(bool?), string meta = default(string))
            {
                return operations.GetAsync(provider, state, oauthToken, oauthVerifier, userName, password, rememberMe, continueParameter, nonce, uri, response, qop, nc, cnonce, useTokenCookie, meta).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='provider'>
            /// </param>
            /// <param name='state'>
            /// </param>
            /// <param name='oauthToken'>
            /// </param>
            /// <param name='oauthVerifier'>
            /// </param>
            /// <param name='userName'>
            /// </param>
            /// <param name='password'>
            /// </param>
            /// <param name='rememberMe'>
            /// </param>
            /// <param name='continueParameter'>
            /// </param>
            /// <param name='nonce'>
            /// </param>
            /// <param name='uri'>
            /// </param>
            /// <param name='response'>
            /// </param>
            /// <param name='qop'>
            /// </param>
            /// <param name='nc'>
            /// </param>
            /// <param name='cnonce'>
            /// </param>
            /// <param name='useTokenCookie'>
            /// </param>
            /// <param name='meta'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AuthenticateResponse> GetAsync(this IAuthenticateOperations operations, string provider = default(string), string state = default(string), string oauthToken = default(string), string oauthVerifier = default(string), string userName = default(string), string password = default(string), bool? rememberMe = default(bool?), string continueParameter = default(string), string nonce = default(string), string uri = default(string), string response = default(string), string qop = default(string), string nc = default(string), string cnonce = default(string), bool? useTokenCookie = default(bool?), string meta = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(provider, state, oauthToken, oauthVerifier, userName, password, rememberMe, continueParameter, nonce, uri, response, qop, nc, cnonce, useTokenCookie, meta, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='provider'>
            /// </param>
            /// <param name='state'>
            /// </param>
            /// <param name='oauthToken'>
            /// </param>
            /// <param name='oauthVerifier'>
            /// </param>
            /// <param name='userName'>
            /// </param>
            /// <param name='password'>
            /// </param>
            /// <param name='rememberMe'>
            /// </param>
            /// <param name='continueParameter'>
            /// </param>
            /// <param name='nonce'>
            /// </param>
            /// <param name='uri'>
            /// </param>
            /// <param name='response'>
            /// </param>
            /// <param name='qop'>
            /// </param>
            /// <param name='nc'>
            /// </param>
            /// <param name='cnonce'>
            /// </param>
            /// <param name='useTokenCookie'>
            /// </param>
            /// <param name='meta'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static AuthenticateResponse Create(this IAuthenticateOperations operations, string provider = default(string), string state = default(string), string oauthToken = default(string), string oauthVerifier = default(string), string userName = default(string), string password = default(string), bool? rememberMe = default(bool?), string continueParameter = default(string), string nonce = default(string), string uri = default(string), string response = default(string), string qop = default(string), string nc = default(string), string cnonce = default(string), bool? useTokenCookie = default(bool?), string meta = default(string), Authenticate body = default(Authenticate))
            {
                return operations.CreateAsync(provider, state, oauthToken, oauthVerifier, userName, password, rememberMe, continueParameter, nonce, uri, response, qop, nc, cnonce, useTokenCookie, meta, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='provider'>
            /// </param>
            /// <param name='state'>
            /// </param>
            /// <param name='oauthToken'>
            /// </param>
            /// <param name='oauthVerifier'>
            /// </param>
            /// <param name='userName'>
            /// </param>
            /// <param name='password'>
            /// </param>
            /// <param name='rememberMe'>
            /// </param>
            /// <param name='continueParameter'>
            /// </param>
            /// <param name='nonce'>
            /// </param>
            /// <param name='uri'>
            /// </param>
            /// <param name='response'>
            /// </param>
            /// <param name='qop'>
            /// </param>
            /// <param name='nc'>
            /// </param>
            /// <param name='cnonce'>
            /// </param>
            /// <param name='useTokenCookie'>
            /// </param>
            /// <param name='meta'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AuthenticateResponse> CreateAsync(this IAuthenticateOperations operations, string provider = default(string), string state = default(string), string oauthToken = default(string), string oauthVerifier = default(string), string userName = default(string), string password = default(string), bool? rememberMe = default(bool?), string continueParameter = default(string), string nonce = default(string), string uri = default(string), string response = default(string), string qop = default(string), string nc = default(string), string cnonce = default(string), bool? useTokenCookie = default(bool?), string meta = default(string), Authenticate body = default(Authenticate), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(provider, state, oauthToken, oauthVerifier, userName, password, rememberMe, continueParameter, nonce, uri, response, qop, nc, cnonce, useTokenCookie, meta, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='provider'>
            /// </param>
            /// <param name='state'>
            /// </param>
            /// <param name='oauthToken'>
            /// </param>
            /// <param name='oauthVerifier'>
            /// </param>
            /// <param name='userName'>
            /// </param>
            /// <param name='password'>
            /// </param>
            /// <param name='rememberMe'>
            /// </param>
            /// <param name='continueParameter'>
            /// </param>
            /// <param name='nonce'>
            /// </param>
            /// <param name='uri'>
            /// </param>
            /// <param name='response'>
            /// </param>
            /// <param name='qop'>
            /// </param>
            /// <param name='nc'>
            /// </param>
            /// <param name='cnonce'>
            /// </param>
            /// <param name='useTokenCookie'>
            /// </param>
            /// <param name='meta'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static AuthenticateResponse Post(this IAuthenticateOperations operations, string provider = default(string), string state = default(string), string oauthToken = default(string), string oauthVerifier = default(string), string userName = default(string), string password = default(string), bool? rememberMe = default(bool?), string continueParameter = default(string), string nonce = default(string), string uri = default(string), string response = default(string), string qop = default(string), string nc = default(string), string cnonce = default(string), bool? useTokenCookie = default(bool?), string meta = default(string), Authenticate body = default(Authenticate))
            {
                return operations.PostAsync(provider, state, oauthToken, oauthVerifier, userName, password, rememberMe, continueParameter, nonce, uri, response, qop, nc, cnonce, useTokenCookie, meta, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='provider'>
            /// </param>
            /// <param name='state'>
            /// </param>
            /// <param name='oauthToken'>
            /// </param>
            /// <param name='oauthVerifier'>
            /// </param>
            /// <param name='userName'>
            /// </param>
            /// <param name='password'>
            /// </param>
            /// <param name='rememberMe'>
            /// </param>
            /// <param name='continueParameter'>
            /// </param>
            /// <param name='nonce'>
            /// </param>
            /// <param name='uri'>
            /// </param>
            /// <param name='response'>
            /// </param>
            /// <param name='qop'>
            /// </param>
            /// <param name='nc'>
            /// </param>
            /// <param name='cnonce'>
            /// </param>
            /// <param name='useTokenCookie'>
            /// </param>
            /// <param name='meta'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AuthenticateResponse> PostAsync(this IAuthenticateOperations operations, string provider = default(string), string state = default(string), string oauthToken = default(string), string oauthVerifier = default(string), string userName = default(string), string password = default(string), bool? rememberMe = default(bool?), string continueParameter = default(string), string nonce = default(string), string uri = default(string), string response = default(string), string qop = default(string), string nc = default(string), string cnonce = default(string), bool? useTokenCookie = default(bool?), string meta = default(string), Authenticate body = default(Authenticate), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(provider, state, oauthToken, oauthVerifier, userName, password, rememberMe, continueParameter, nonce, uri, response, qop, nc, cnonce, useTokenCookie, meta, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='provider'>
            /// </param>
            /// <param name='state'>
            /// </param>
            /// <param name='oauthToken'>
            /// </param>
            /// <param name='oauthVerifier'>
            /// </param>
            /// <param name='userName'>
            /// </param>
            /// <param name='password'>
            /// </param>
            /// <param name='rememberMe'>
            /// </param>
            /// <param name='continueParameter'>
            /// </param>
            /// <param name='nonce'>
            /// </param>
            /// <param name='uri'>
            /// </param>
            /// <param name='response'>
            /// </param>
            /// <param name='qop'>
            /// </param>
            /// <param name='nc'>
            /// </param>
            /// <param name='cnonce'>
            /// </param>
            /// <param name='useTokenCookie'>
            /// </param>
            /// <param name='meta'>
            /// </param>
            public static AuthenticateResponse Delete(this IAuthenticateOperations operations, string provider = default(string), string state = default(string), string oauthToken = default(string), string oauthVerifier = default(string), string userName = default(string), string password = default(string), bool? rememberMe = default(bool?), string continueParameter = default(string), string nonce = default(string), string uri = default(string), string response = default(string), string qop = default(string), string nc = default(string), string cnonce = default(string), bool? useTokenCookie = default(bool?), string meta = default(string))
            {
                return operations.DeleteAsync(provider, state, oauthToken, oauthVerifier, userName, password, rememberMe, continueParameter, nonce, uri, response, qop, nc, cnonce, useTokenCookie, meta).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='provider'>
            /// </param>
            /// <param name='state'>
            /// </param>
            /// <param name='oauthToken'>
            /// </param>
            /// <param name='oauthVerifier'>
            /// </param>
            /// <param name='userName'>
            /// </param>
            /// <param name='password'>
            /// </param>
            /// <param name='rememberMe'>
            /// </param>
            /// <param name='continueParameter'>
            /// </param>
            /// <param name='nonce'>
            /// </param>
            /// <param name='uri'>
            /// </param>
            /// <param name='response'>
            /// </param>
            /// <param name='qop'>
            /// </param>
            /// <param name='nc'>
            /// </param>
            /// <param name='cnonce'>
            /// </param>
            /// <param name='useTokenCookie'>
            /// </param>
            /// <param name='meta'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AuthenticateResponse> DeleteAsync(this IAuthenticateOperations operations, string provider = default(string), string state = default(string), string oauthToken = default(string), string oauthVerifier = default(string), string userName = default(string), string password = default(string), bool? rememberMe = default(bool?), string continueParameter = default(string), string nonce = default(string), string uri = default(string), string response = default(string), string qop = default(string), string nc = default(string), string cnonce = default(string), bool? useTokenCookie = default(bool?), string meta = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(provider, state, oauthToken, oauthVerifier, userName, password, rememberMe, continueParameter, nonce, uri, response, qop, nc, cnonce, useTokenCookie, meta, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
