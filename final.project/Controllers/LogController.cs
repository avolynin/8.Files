using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final.project
{
	/// <summary>Класс, содержащий функционал для лога.</summary>
	public class LogController
	{
		#region Data

		private string _path = @"Log\Logs.txt";

		#endregion

		#region .ctor
		public LogController()
		{
			var dirInfo = new DirectoryInfo($"Log");
			if(!dirInfo.Exists) dirInfo.Create();
		}
		#endregion

		#region Events

		/// <summary>Вызывается при добавлении сообщения в лог.</summary>
		public event EventHandler<string> AddMessageLog;

		#endregion

		#region Handlers

		/// <summary>Обработчик события добавления в лог.</summary>
		private void OnAddMessageLog(string text)
		{
			AddMessageLog?.Invoke(null, text);
		}

		#endregion

		#region Methods

		/// <summary>Формирует дата-лог и вызывает обработчик события.</summary>
		public void AddMessage(string text)
		{
			var msg = $"[{DateTime.Now}] - {text} \n";
			OnAddMessageLog(msg);
			SaveLogInFile(msg);
		}

		/// <summary>Сохранение лога в файл.</summary>
		public void SaveLogInFile(string text)
		{
			using FileStream fs = new FileStream(_path, FileMode.Append);
			byte[] array = Encoding.Default.GetBytes(text);
			fs.Write(array);
		}

		#endregion
	}
}
