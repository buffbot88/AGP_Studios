using System;

namespace RaStudios.WinForms.Models
{
    /// <summary>
    /// Log entry model for centralized logging.
    /// </summary>
    public class LogEntry
    {
        public DateTime Timestamp { get; set; }
        public LogLevel Level { get; set; }
        public string Source { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string? Exception { get; set; }
    }

    /// <summary>
    /// Log level enumeration.
    /// </summary>
    public enum LogLevel
    {
        Debug,
        Info,
        Warning,
        Error,
        Critical
    }

    /// <summary>
    /// Request model for AI code generation.
    /// </summary>
    public class CodeGenerationRequest
    {
        public string Prompt { get; set; } = string.Empty;
        public string Language { get; set; } = "csharp";
        public int MaxTokens { get; set; } = 1000;
        public double Temperature { get; set; } = 0.7;
        public bool RequireHumanApproval { get; set; } = true;
    }

    /// <summary>
    /// Result model for AI code generation.
    /// </summary>
    public class CodeGenerationResult
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string GeneratedCode { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public bool RequiresHumanApproval { get; set; } = true;
        public bool IsApproved { get; set; } = false;
        public string? ApprovedBy { get; set; }
        public DateTime GeneratedAt { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public string? ErrorMessage { get; set; }
    }

    /// <summary>
    /// Application configuration model.
    /// </summary>
    public class AppConfiguration
    {
        public AshatOSConfiguration AshatOS { get; set; } = new AshatOSConfiguration();
        public CMSConfiguration CMS { get; set; } = new CMSConfiguration();
        public FTPConfiguration FTP { get; set; } = new FTPConfiguration();
        public BuildConfiguration Build { get; set; } = new BuildConfiguration();
        public ServerConfiguration Server { get; set; } = new ServerConfiguration();
        public AiServiceConfiguration AiService { get; set; } = new AiServiceConfiguration();
        public SecurityConfiguration Security { get; set; } = new SecurityConfiguration();
        public UpdatesConfiguration Updates { get; set; } = new UpdatesConfiguration();
    }

    /// <summary>
    /// ASHATOS server configuration.
    /// </summary>
    public class AshatOSConfiguration
    {
        public string Host { get; set; } = "localhost";
        public int Port { get; set; } = 7077;
        public string Protocol { get; set; } = "WebSocket";
        public string WebSocketUrl { get; set; } = "ws://localhost:7077/ws";
        public string ApiBaseUrl { get; set; } = "http://localhost:7077/api";
        public int TimeoutSeconds { get; set; } = 30;
        public bool UseAuthentication { get; set; } = true;
        public int RetryAttempts { get; set; } = 3;
        public int RetryDelaySeconds { get; set; } = 5;
    }

    /// <summary>
    /// CMS (Content Management System) configuration.
    /// </summary>
    public class CMSConfiguration
    {
        public string Host { get; set; } = "localhost";
        public int Port { get; set; } = 80;
        public string Protocol { get; set; } = "HTTP";
        public string ApiBaseUrl { get; set; } = "http://localhost:80/api";
        public int TimeoutSeconds { get; set; } = 30;
    }

    /// <summary>
    /// FTP server configuration.
    /// </summary>
    public class FTPConfiguration
    {
        public string Host { get; set; } = "localhost";
        public int Port { get; set; } = 21;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool UseSSL { get; set; } = true;
        public string UploadPath { get; set; } = "/uploads/dlls";
        public int TimeoutSeconds { get; set; } = 60;
        public bool PassiveMode { get; set; } = true;
    }

    /// <summary>
    /// Build configuration for .NET projects.
    /// </summary>
    public class BuildConfiguration
    {
        public string DotNetPath { get; set; } = "dotnet";
        public string BuildConfigurationType { get; set; } = "Release";
        public string OutputPath { get; set; } = "./bin/Release";
        public string TargetFramework { get; set; } = "net9.0";
        public bool EnableNuGetRestore { get; set; } = true;
    }

    /// <summary>
    /// Server connection configuration.
    /// </summary>
    public class ServerConfiguration
    {
        public string Url { get; set; } = "ws://localhost:7077/ws";
        public int Port { get; set; } = 7077;
        public string Protocol { get; set; } = "WebSocket";
        public string HandshakeType { get; set; } = "JSON";
        public int TimeoutSeconds { get; set; } = 30;
        public bool UseAuthentication { get; set; } = true;
        public bool EnableRateLimiting { get; set; } = true;
        public int MaxMessagesPerSecond { get; set; } = 10;
    }

    /// <summary>
    /// AI service configuration.
    /// </summary>
    public class AiServiceConfiguration
    {
        public string Endpoint { get; set; } = "http://localhost:8088/api/ai/generate";
        public string ApiKey { get; set; } = string.Empty;
        public int MaxRequestsPerMinute { get; set; } = 10;
        public bool RequireApproval { get; set; } = true;
        public bool EnablePolicyFilter { get; set; } = true;
        public string[] BlockedPatterns { get; set; } = Array.Empty<string>();
    }

    /// <summary>
    /// Security configuration.
    /// </summary>
    public class SecurityConfiguration
    {
        public bool RequireHumanApproval { get; set; } = true;
        public bool EnableAuditLogging { get; set; } = true;
        public bool AllowAutoExecution { get; set; } = false;
        public bool AllowSelfReplication { get; set; } = false;
    }

    /// <summary>
    /// Update configuration.
    /// </summary>
    public class UpdatesConfiguration
    {
        public string Strategy { get; set; } = "Manual";
        public bool CheckForUpdates { get; set; } = true;
        public bool AutoDownload { get; set; } = false;
        public bool RequireSignedPackages { get; set; } = true;
    }

    /// <summary>
    /// Result model for FTP upload operations.
    /// </summary>
    public class FTPUploadResult
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public string? ErrorMessage { get; set; }
        public string? RemotePath { get; set; }
        public long BytesTransferred { get; set; }
        public DateTime UploadedAt { get; set; }
        public string[] UploadedFiles { get; set; } = Array.Empty<string>();
    }

    /// <summary>
    /// Result model for build operations.
    /// </summary>
    public class BuildResult
    {
        public bool Success { get; set; }
        public string Output { get; set; } = string.Empty;
        public string ErrorOutput { get; set; } = string.Empty;
        public string[] BuiltFiles { get; set; } = Array.Empty<string>();
    }
}
