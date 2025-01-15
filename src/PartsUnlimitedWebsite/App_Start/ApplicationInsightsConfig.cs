//using Microsoft.ApplicationInsights.Channel;
//using Microsoft.ApplicationInsights.Extensibility;
//using System.Configuration;
//using System.Web;

//namespace PartsUnlimited
//{
//    public static class ApplicationInsightsConfig
//    {
//        public static void Configure()
//        {
//            TelemetryConfiguration.Active.ConnectionString = ConfigurationManager.AppSettings["APPLICATIONINSIGHTS_CONNECTION_STRING"];
//            TelemetryConfiguration.Active.TelemetryInitializers.Add(new UserTelemetryInitializer());
//        }
//    }

//    public class UserTelemetryInitializer : ITelemetryInitializer
//    {
//        private const string UserIdKey = "TelemetryUserId";

//        public void Initialize(ITelemetry telemetry)
//        {
//            var httpContext = HttpContext.Current;
//            if (httpContext != null)
//            {
//                var userId = httpContext.Items[UserIdKey] as string;

//                if (string.IsNullOrEmpty(userId))
//                {
//                    var user = httpContext.User;
//                    if (user != null)
//                    {
//                        var identity = user.Identity;
//                        if (identity != null && identity.IsAuthenticated)
//                        {
//                            userId = identity.Name.Replace("\\", "\\\\").Replace(",", "_").Replace(";", "_").Replace("=", "_").Replace("|", "_").Replace(" ", "_");
//                            httpContext.Items[UserIdKey] = userId;
//                        }
//                    }
//                }

//                if (!string.IsNullOrEmpty(userId))
//                {
//                    telemetry.Context.User.AuthenticatedUserId = userId;
//                }
//            }
//        }
//    }
//}
