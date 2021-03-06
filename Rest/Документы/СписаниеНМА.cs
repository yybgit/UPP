﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//SpisanieNMA
	[Маршрут("Документы/СписаниеНМА","")]
	public class СписаниеНМАЗапрос: V82.ДокументыСсылка.СписаниеНМА,IReturn<СписаниеНМАЗапрос>
	{
	}
	[Маршрут("Документы/СписаниеНМА/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/СписаниеНМА/ПоСсылке","{Ссылка}")]
	public class СписаниеНМАНайтиПоСсылке: V82.ДокументыСсылка.СписаниеНМА,IReturn<СписаниеНМАНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/СписаниеНМА/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/СписаниеНМА/ПоНомеру","{Номер}")]
	public class СписаниеНМАНайтиПоНомеру: V82.ДокументыСсылка.СписаниеНМА,IReturn<СписаниеНМАНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/СписаниеНМА/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/СписаниеНМА/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/СписаниеНМА/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СписаниеНМАВыбратьПоСсылке: V82.ДокументыСсылка.СписаниеНМА,IReturn<СписаниеНМАВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/СписаниеНМА/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/СписаниеНМА/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/СписаниеНМА/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class СписаниеНМАВыбратьПоНомеру: V82.ДокументыСсылка.СписаниеНМА,IReturn<СписаниеНМАВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/СписаниеНМА/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СписаниеНМАСтраницаПоСсылке: V82.ДокументыСсылка.СписаниеНМА,IReturn<СписаниеНМАСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/СписаниеНМА/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class СписаниеНМАСтраницаПоНомеру: V82.ДокументыСсылка.СписаниеНМА,IReturn<СписаниеНМАСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СписаниеНМАОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class СписаниеНМАСервис : Service
	{
		
		public object Get(СписаниеНМАЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(СписаниеНМАНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.СписаниеНМА.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new СписаниеНМАОтвет() { Ответ = "СписаниеНМА c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СписаниеНМАНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.СписаниеНМА.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new СписаниеНМАОтвет() {Ответ = "СписаниеНМА c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СписаниеНМАВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.СписаниеНМА.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(СписаниеНМАВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(СписаниеНМАСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СписаниеНМАСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(СписаниеНМАЗапрос Запрос)
		{
			return new СписаниеНМАОтвет {Ответ = "СписаниеНМА, "};
		}

		public object Post(СписаниеНМАЗапрос ЗапросСписаниеНМА)
		{
			var Ссылка = (ДокументыСсылка.СписаниеНМА)ЗапросСписаниеНМА;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}