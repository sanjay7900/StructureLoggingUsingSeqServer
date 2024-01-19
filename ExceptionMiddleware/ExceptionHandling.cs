namespace StructureLoggingUsingSeqServer.ExceptionMiddleware
{
    public class ExceptionHandling
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandling> _logger;

        public ExceptionHandling(
            RequestDelegate requestDelegate,
            ILogger<ExceptionHandling> logger
            )
        {
            _next = requestDelegate;
            _logger= logger;
        } 
        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                //var  data= httpContext.Request
                await _next(httpContext);
            }
            catch ( Exception e )
            {
                _logger.LogError(e, $"Error Ocured : {e.Message}");
            }
        }


    }
}
