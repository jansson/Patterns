public interface IHandler<TContext> where TContext : class
{
	Task HandleAsync(TContext context)
}

public abstract class Handler<TContext> : IHandler<TContext>
{
	protected IHandler<TContext> Next { get; private set; }
	
	protected Handler(IHandler next) {
		Next = next;
	}
}