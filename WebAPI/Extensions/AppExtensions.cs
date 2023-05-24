using WebAPI.Middelewares;

namespace WebAPI.Extensions
{
    public static class AppExtensions
    {
        public static void UserErrorHandlingMiddleware(this IApplicationBuilder app) {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
