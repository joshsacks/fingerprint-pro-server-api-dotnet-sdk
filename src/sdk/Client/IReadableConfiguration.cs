/* 
 * Fingerprint Pro Server API
 *
 * Fingerprint Pro Server API allows you to get information about visitors and about individual events in a server environment. This API can be used for data exports, decision-making, and data analysis scenarios.
 *
 * OpenAPI spec version: 3
 * Contact: support@fingerprint.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

namespace sdk.Client;

/// <summary>
///     Represents a readable-only configuration contract.
/// </summary>
public interface IReadableConfiguration
{
    /// <summary>
    ///     Gets the access token.
    /// </summary>
    /// <value>Access token.</value>
    string AccessToken { get; }

    /// <summary>
    ///     Gets the API key.
    /// </summary>
    /// <value>API key.</value>
    IDictionary<string, string> ApiKey { get; }

    /// <summary>
    ///     Gets the API key prefix.
    /// </summary>
    /// <value>API key prefix.</value>
    IDictionary<string, string> ApiKeyPrefix { get; }

    /// <summary>
    ///     Gets the base path.
    /// </summary>
    /// <value>Base path.</value>
    string BasePath { get; }

    /// <summary>
    ///     Gets the date time format.
    /// </summary>
    /// <value>Date time foramt.</value>
    string DateTimeFormat { get; }

    /// <summary>
    ///     Gets the default header.
    /// </summary>
    /// <value>Default header.</value>
    IDictionary<string, string> DefaultHeader { get; }

    /// <summary>
    ///     Gets the temp folder path.
    /// </summary>
    /// <value>Temp folder path.</value>
    string TempFolderPath { get; }

    /// <summary>
    ///     Gets the HTTP connection timeout (in milliseconds)
    /// </summary>
    /// <value>HTTP connection timeout.</value>
    int Timeout { get; }

    /// <summary>
    ///     Gets the user agent.
    /// </summary>
    /// <value>User agent.</value>
    string UserAgent { get; }

    /// <summary>
    ///     Gets the username.
    /// </summary>
    /// <value>Username.</value>
    string Username { get; }

    /// <summary>
    ///     Gets the password.
    /// </summary>
    /// <value>Password.</value>
    string Password { get; }

    /// <summary>
    ///     Gets the API key with prefix.
    /// </summary>
    /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
    /// <returns>API key with prefix.</returns>
    string GetApiKeyWithPrefix(string apiKeyIdentifier);
}