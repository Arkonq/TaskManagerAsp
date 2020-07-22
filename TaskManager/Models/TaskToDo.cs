using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
	public class TaskToDo
	{
		//4. Добавление новой задачи(название, описание, дедлайн)
		public int Id { get; set; }
		public string Name { get; set; }
		public string Desc { get; set; }
		public DateTime DeadLine { get; set; }
	}
}
