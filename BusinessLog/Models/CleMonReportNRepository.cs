using System;
using System.Linq;
using System.Collections.Generic;
	
namespace BusinessLog.Models
{   
	public  class CleMonReportNRepository : EFRepository<CleMonReportN>, ICleMonReportNRepository
	{

	}

	public  interface ICleMonReportNRepository : IRepository<CleMonReportN>
	{

	}
}