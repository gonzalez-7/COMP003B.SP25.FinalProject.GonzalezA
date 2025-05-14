using System.Diagnostics;

namespace COMP003B.SP25.FinalProject.GonzalezA.Middleware
{
	public class RequestTimingMiddleware
	{
		private readonly RequestDelegate _next;

		public RequestTimingMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public async Task InvokeAsync(HttpContext context)
		{
			var stopwatch = Stopwatch.StartNew();

			await _next(context);

			stopwatch.Stop();

			var logMessage = $"[Request Timing] {context.Request.Method} {context.Request.Path} took {stopwatch.ElapsedMilliseconds} ms";
			Console.WriteLine(logMessage);
		}
	}
}