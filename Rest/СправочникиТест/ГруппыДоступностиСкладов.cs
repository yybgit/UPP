﻿
using System;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
using ServiceStack.ServiceClient.Web;
using V82.Справочники;

namespace V82.Rest.СправочникиТест
{
	public class ГруппыДоступностиСкладов:V82.Rest.СправочникиТест.СправочникТест
	{
		public static ГруппыДоступностиСкладовЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Справочники/ГруппыДоступностиСкладов/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ГруппыДоступностиСкладовЗапрос ГруппыДоступностиСкладовЗапрос = null;
			try
			{
				ГруппыДоступностиСкладовЗапрос = Клиент.Get(new ГруппыДоступностиСкладовЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ГруппыДоступностиСкладовЗапрос;
		}
		public static ГруппыДоступностиСкладовЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Справочники/ГруппыДоступностиСкладов/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ГруппыДоступностиСкладовЗапрос ГруппыДоступностиСкладовЗапрос = null;
			try
			{
				ГруппыДоступностиСкладовЗапрос = Клиент.Get(new ГруппыДоступностиСкладовЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ГруппыДоступностиСкладовЗапрос;
		}
		public static ГруппыДоступностиСкладовЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Справочники/ГруппыДоступностиСкладов/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ГруппыДоступностиСкладовЗапрос ГруппыДоступностиСкладовЗапрос = null;
			try
			{
				ГруппыДоступностиСкладовЗапрос = Клиент.Get(new ГруппыДоступностиСкладовЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ГруппыДоступностиСкладовЗапрос;
		}
		public static void ЗаписатьНовый(ГруппыДоступностиСкладовЗапрос ГруппыДоступностиСкладовЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Справочники/ГруппыДоступностиСкладов?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ГруппыДоступностиСкладовОтвет = Клиент.Post(ГруппыДоступностиСкладовЗапрос);
		}
		public static void Записать(ГруппыДоступностиСкладовЗапрос ГруппыДоступностиСкладовЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Справочники/ГруппыДоступностиСкладов?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ГруппыДоступностиСкладовОтвет = Клиент.Put(ГруппыДоступностиСкладовЗапрос);
		}
		public static void Удалить(ГруппыДоступностиСкладовЗапрос ГруппыДоступностиСкладовЗапрос)//
		{
			var Урл = "http://localhost:1337/Справочники/ГруппыДоступностиСкладов?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ГруппыДоступностиСкладовОтвет = Клиент.Delete(ГруппыДоступностиСкладовЗапрос);
		}
	}
}