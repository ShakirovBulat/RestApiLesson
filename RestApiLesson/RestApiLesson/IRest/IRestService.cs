using RestApiLesson.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestApiLesson.IRest
{
	public interface IRestService
	{
		Task<List<TodoItem>> RefreshDataAsync();
	}
}
