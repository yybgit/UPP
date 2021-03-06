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
	public class СтатьиАналитическогоБаланса:V82.Rest.СправочникиТест.СправочникТест
	{
		public static СтатьиАналитическогоБалансаЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Справочники/СтатьиАналитическогоБаланса/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СтатьиАналитическогоБалансаЗапрос СтатьиАналитическогоБалансаЗапрос = null;
			try
			{
				СтатьиАналитическогоБалансаЗапрос = Клиент.Get(new СтатьиАналитическогоБалансаЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СтатьиАналитическогоБалансаЗапрос;
		}
		public static СтатьиАналитическогоБалансаЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Справочники/СтатьиАналитическогоБаланса/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СтатьиАналитическогоБалансаЗапрос СтатьиАналитическогоБалансаЗапрос = null;
			try
			{
				СтатьиАналитическогоБалансаЗапрос = Клиент.Get(new СтатьиАналитическогоБалансаЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СтатьиАналитическогоБалансаЗапрос;
		}
		public static СтатьиАналитическогоБалансаЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Справочники/СтатьиАналитическогоБаланса/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СтатьиАналитическогоБалансаЗапрос СтатьиАналитическогоБалансаЗапрос = null;
			try
			{
				СтатьиАналитическогоБалансаЗапрос = Клиент.Get(new СтатьиАналитическогоБалансаЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СтатьиАналитическогоБалансаЗапрос;
		}
		public static void ЗаписатьНовый(СтатьиАналитическогоБалансаЗапрос СтатьиАналитическогоБалансаЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Справочники/СтатьиАналитическогоБаланса?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СтатьиАналитическогоБалансаОтвет = Клиент.Post(СтатьиАналитическогоБалансаЗапрос);
		}
		public static void Записать(СтатьиАналитическогоБалансаЗапрос СтатьиАналитическогоБалансаЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Справочники/СтатьиАналитическогоБаланса?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СтатьиАналитическогоБалансаОтвет = Клиент.Put(СтатьиАналитическогоБалансаЗапрос);
		}
		public static void Удалить(СтатьиАналитическогоБалансаЗапрос СтатьиАналитическогоБалансаЗапрос)//
		{
			var Урл = "http://localhost:1337/Справочники/СтатьиАналитическогоБаланса?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СтатьиАналитическогоБалансаОтвет = Клиент.Delete(СтатьиАналитическогоБалансаЗапрос);
		}
	}
}