﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//RegionalnyeSegmentyPoMSFO
	[Маршрут("Справочники/РегиональныеСегментыПоМСФО","")]
	public class РегиональныеСегментыПоМСФОЗапрос: V82.СправочникиСсылка.РегиональныеСегментыПоМСФО,IReturn<РегиональныеСегментыПоМСФОЗапрос>
	{
	}
	[Маршрут("Справочники/РегиональныеСегментыПоМСФО/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/РегиональныеСегментыПоМСФО/ПоСсылке","{Ссылка}")]
	public class РегиональныеСегментыПоМСФОНайтиПоСсылке: V82.СправочникиСсылка.РегиональныеСегментыПоМСФО,IReturn<РегиональныеСегментыПоМСФОНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/РегиональныеСегментыПоМСФО/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/РегиональныеСегментыПоМСФО/ПоКоду","{Код}")]
	public class РегиональныеСегментыПоМСФОНайтиПоКоду: V82.СправочникиСсылка.РегиональныеСегментыПоМСФО,IReturn<РегиональныеСегментыПоМСФОНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/РегиональныеСегментыПоМСФО/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/РегиональныеСегментыПоМСФО/ПоНаименованию","{Наименование}")]
	public class РегиональныеСегментыПоМСФОНайтиПоНаименованию: V82.СправочникиСсылка.РегиональныеСегментыПоМСФО,IReturn<РегиональныеСегментыПоМСФОНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/РегиональныеСегментыПоМСФО/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/РегиональныеСегментыПоМСФО/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/РегиональныеСегментыПоМСФО/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class РегиональныеСегментыПоМСФОВыбратьПоСсылке: V82.СправочникиСсылка.РегиональныеСегментыПоМСФО,IReturn<РегиональныеСегментыПоМСФОВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/РегиональныеСегментыПоМСФО/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/РегиональныеСегментыПоМСФО/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/РегиональныеСегментыПоМСФО/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class РегиональныеСегментыПоМСФОВыбратьПоКоду: V82.СправочникиСсылка.РегиональныеСегментыПоМСФО,IReturn<РегиональныеСегментыПоМСФОВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/РегиональныеСегментыПоМСФО/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/РегиональныеСегментыПоМСФО/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/РегиональныеСегментыПоМСФО/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class РегиональныеСегментыПоМСФОВыбратьПоНаименованию: V82.СправочникиСсылка.РегиональныеСегментыПоМСФО,IReturn<РегиональныеСегментыПоМСФОВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/РегиональныеСегментыПоМСФО/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class РегиональныеСегментыПоМСФОСтраницаПоСсылке: V82.СправочникиСсылка.РегиональныеСегментыПоМСФО,IReturn<РегиональныеСегментыПоМСФОСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/РегиональныеСегментыПоМСФО/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class РегиональныеСегментыПоМСФОСтраницаПоКоду: V82.СправочникиСсылка.РегиональныеСегментыПоМСФО,IReturn<РегиональныеСегментыПоМСФОСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/РегиональныеСегментыПоМСФО/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class РегиональныеСегментыПоМСФОСтраницаПоНаименованию: V82.СправочникиСсылка.РегиональныеСегментыПоМСФО,IReturn<РегиональныеСегментыПоМСФОСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class РегиональныеСегментыПоМСФООтвет
	{
		public string Ответ {get;set;}
	}

	public partial class РегиональныеСегментыПоМСФОСервис : Service
	{
		
		public object Get(РегиональныеСегментыПоМСФОЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(РегиональныеСегментыПоМСФОНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.РегиональныеСегментыПоМСФО.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new РегиональныеСегментыПоМСФООтвет() { Ответ = "РегиональныеСегментыПоМСФО c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(РегиональныеСегментыПоМСФОНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.РегиональныеСегментыПоМСФО.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new РегиональныеСегментыПоМСФООтвет() {Ответ = "РегиональныеСегментыПоМСФО c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(РегиональныеСегментыПоМСФОНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(РегиональныеСегментыПоМСФОВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.РегиональныеСегментыПоМСФО.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(РегиональныеСегментыПоМСФОВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(РегиональныеСегментыПоМСФОВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(РегиональныеСегментыПоМСФОСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(РегиональныеСегментыПоМСФОСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(РегиональныеСегментыПоМСФОСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(РегиональныеСегментыПоМСФОЗапрос Запрос)
		{
			return new РегиональныеСегментыПоМСФООтвет {Ответ = "РегиональныеСегментыПоМСФО, "};
		}

		public object Post(РегиональныеСегментыПоМСФОЗапрос ЗапросРегиональныеСегментыПоМСФО)
		{
			var Ссылка = (СправочникиСсылка.РегиональныеСегментыПоМСФО)ЗапросРегиональныеСегментыПоМСФО;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}