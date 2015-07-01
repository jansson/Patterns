public class ExampleHandler : Handler<object>
{
	
	public ExampleHandler(IHandler<object> next) : base(next) { }
	
	public async Task HandleAsync(object context) {
		// A handler may chose to invoke the next handler in the chain or not.
		
		if (context is string) {
			Console.WriteLine("The context is {0}", context)
		}
		else
		{
			return await Next(context);
		}
	}
	
}