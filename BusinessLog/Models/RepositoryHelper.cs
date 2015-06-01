namespace BusinessLog.Models
{
	public static class RepositoryHelper
	{
		public static IUnitOfWork GetUnitOfWork()
		{
			return new EFUnitOfWork();
		}		
		
		public static CleMonReportNRepository GetCleMonReportNRepository()
		{
			var repository = new CleMonReportNRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static CleMonReportNRepository GetCleMonReportNRepository(IUnitOfWork unitOfWork)
		{
			var repository = new CleMonReportNRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		
	}
}