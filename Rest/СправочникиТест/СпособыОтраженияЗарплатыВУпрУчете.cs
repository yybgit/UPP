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
	public class СпособыОтраженияЗарплатыВУпрУчете:V82.Rest.СправочникиТест.СправочникТест
	{
		public static СпособыОтраженияЗарплатыВУпрУчетеЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Справочники/СпособыОтраженияЗарплатыВУпрУчете/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СпособыОтраженияЗарплатыВУпрУчетеЗапрос СпособыОтраженияЗарплатыВУпрУчетеЗапрос = null;
			try
			{
				СпособыОтраженияЗарплатыВУпрУчетеЗапрос = Клиент.Get(new СпособыОтраженияЗарплатыВУпрУчетеЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СпособыОтраженияЗарплатыВУпрУчетеЗапрос;
		}
		public static СпособыОтраженияЗарплатыВУпрУчетеЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Справочники/СпособыОтраженияЗарплатыВУпрУчете/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СпособыОтраженияЗарплатыВУпрУчетеЗапрос СпособыОтраженияЗарплатыВУпрУчетеЗапрос = null;
			try
			{
				СпособыОтраженияЗарплатыВУпрУчетеЗапрос = Клиент.Get(new СпособыОтраженияЗарплатыВУпрУчетеЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СпособыОтраженияЗарплатыВУпрУчетеЗапрос;
		}
		public static void ЗаписатьНовый(СпособыОтраженияЗарплатыВУпрУчетеЗапрос СпособыОтраженияЗарплатыВУпрУчетеЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Справочники/СпособыОтраженияЗарплатыВУпрУчете?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СпособыОтраженияЗарплатыВУпрУчетеОтвет = Клиент.Post(СпособыОтраженияЗарплатыВУпрУчетеЗапрос);
		}
		public static void Записать(СпособыОтраженияЗарплатыВУпрУчетеЗапрос СпособыОтраженияЗарплатыВУпрУчетеЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Справочники/СпособыОтраженияЗарплатыВУпрУчете?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СпособыОтраженияЗарплатыВУпрУчетеОтвет = Клиент.Put(СпособыОтраженияЗарплатыВУпрУчетеЗапрос);
		}
		public static void Удалить(СпособыОтраженияЗарплатыВУпрУчетеЗапрос СпособыОтраженияЗарплатыВУпрУчетеЗапрос)//
		{
			var Урл = "http://localhost:1337/Справочники/СпособыОтраженияЗарплатыВУпрУчете?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СпособыОтраженияЗарплатыВУпрУчетеОтвет = Клиент.Delete(СпособыОтраженияЗарплатыВУпрУчетеЗапрос);
		}
	}
}