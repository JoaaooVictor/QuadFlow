namespace QuadFlow.SharedKernel.Abstractions
{
	public class Result
	{
		public bool Sucess { get; set; }
		public string Message { get; set; }

		public Result(bool sucess, string message) 
		{
			Sucess = sucess;
			Message = message;
		}

		public static Result Success(string message)
		{
			return new Result(true, message);
		}
			
		public static Result Fail(string message)
		{
			return new Result(false, message);
		}
	}

	public class Result<T> : Result
	{
		public T? Value { get; set; }
		public Result(bool sucess, string message, T? value) : base(sucess, message)
		{
			Value = value;
		}

		public static Result<T> Success(string message, T? value)
		{
			return new Result<T>(true, message, value);
		}

		public static new Result<T> Fail(string message)
		{
			return new Result<T>(false, message, default);
		}

	}
}
