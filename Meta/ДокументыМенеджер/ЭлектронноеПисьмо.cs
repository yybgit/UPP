﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.ДокументыСсылка;
using V82.Документы;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Документы//Менеджер
{
	public partial class ЭлектронноеПисьмо:ДокументМенеджер
	{
		
		public static ДокументыСсылка.ЭлектронноеПисьмо НайтиПоСсылке(Guid _Ссылка)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld12718RRef [ВидТекстаПисьма]
					,_Fld12719RRef [ГруппаУчетнойЗаписи]
					,_Fld12720 [ДатаОтправления]
					,_Fld12721 [ДатаТранспорта]
					,_Fld22325RRef [ЗаявкаКандидата]
					,_Fld12722 [ЕстьВложения]
					,_Fld12749 [ЗаголовокПисьма]
					,_Fld12723 [ИдентификаторПисьма]
					,_Fld12724 [ИмяКомпьютераРедактированияХТМЛТекста]
					,_Fld12725 [ИмяФайлаРедактированияХТМЛТекста]
					,_Fld12750 [КодировкаПисьма]
					,_Fld12726 [Комментарий]
					,_Fld12727 [Кому]
					,_Fld12728 [КомуПредставление]
					,_Fld12729 [Копии]
					,_Fld12730 [КопииПредставление]
					,_Fld12731 [НеРассмотрено]
					,_Fld12732_TYPE [ОснованиеПисьма_Тип],_Fld12732_RRRef [ОснованиеПисьма],_Fld12732_RTRef [ОснованиеПисьма_Вид]
					,_Fld12733 [Ответ]
					,_Fld12734RRef [Ответственный]
					,_Fld12735 [ОтправительАдресЭлектроннойПочты]
					,_Fld12736 [ОтправительИмя]
					,_Fld12737 [ОтправительПредставление]
					,_Fld12751RRef [Оформление]
					,_Fld12738 [Переадресация]
					,_Fld12739 [ПочтовоеСообщение]
					,_Fld12752 [ПредметКонтакта]
					,_Fld12740 [РассмотретьПосле]
					,_Fld12741 [СкрытыеКопии]
					,_Fld12748_TYPE [ОтправительОбъект_Тип],_Fld12748_RRRef [ОтправительОбъект],_Fld12748_RTRef [ОтправительОбъект_Вид]
					,_Fld12742RRef [СостояниеПотомкаПисьма]
					,_Fld12743RRef [СтатусПисьма]
					,_Fld12744 [ТекстПисьма]
					,_Fld12745 [Тема]
					,_Fld12746RRef [УчетнаяЗапись]
					From _Document497(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЭлектронноеПисьмо();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидТекстаПисьма = V82.Перечисления/*Ссылка*/.ВидыТекстовЭлектронныхПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ДатаОтправления = Читалка.GetDateTime(5);
							Ссылка.ДатаТранспорта = Читалка.GetDateTime(6);
							Ссылка.ЕстьВложения = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ЗаголовокПисьма = Читалка.GetString(9);
							Ссылка.ИдентификаторПисьма = Читалка.GetString(10);
							Ссылка.ИмяКомпьютераРедактированияХТМЛТекста = Читалка.GetString(11);
							Ссылка.ИмяФайлаРедактированияХТМЛТекста = Читалка.GetString(12);
							Ссылка.КодировкаПисьма = Читалка.GetString(13);
							Ссылка.Комментарий = Читалка.GetString(14);
							Ссылка.Кому = Читалка.GetString(15);
							Ссылка.КомуПредставление = Читалка.GetString(16);
							Ссылка.Копии = Читалка.GetString(17);
							Ссылка.КопииПредставление = Читалка.GetString(18);
							Ссылка.НеРассмотрено = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.Ответ = ((byte[])Читалка.GetValue(23))[0]==1;
							Ссылка.ОтправительАдресЭлектроннойПочты = Читалка.GetString(25);
							Ссылка.ОтправительИмя = Читалка.GetString(26);
							Ссылка.ОтправительПредставление = Читалка.GetString(27);
							Ссылка.Переадресация = ((byte[])Читалка.GetValue(29))[0]==1;
							Ссылка.ПредметКонтакта = Читалка.GetString(31);
							Ссылка.РассмотретьПосле = Читалка.GetDateTime(32);
							Ссылка.СкрытыеКопии = Читалка.GetString(33);
							Ссылка.СостояниеПотомкаПисьма = V82.Перечисления/*Ссылка*/.СостоянияПотомковЭлектронныхПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(37));
							Ссылка.СтатусПисьма = V82.Перечисления/*Ссылка*/.СтатусыПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(38));
							Ссылка.ТекстПисьма = Читалка.GetString(39);
							Ссылка.Тема = Читалка.GetString(40);
							return Ссылка;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}
		
		public static ДокументыСсылка.ЭлектронноеПисьмо НайтиПоНомеру(string Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld12718RRef [ВидТекстаПисьма]
					,_Fld12719RRef [ГруппаУчетнойЗаписи]
					,_Fld12720 [ДатаОтправления]
					,_Fld12721 [ДатаТранспорта]
					,_Fld22325RRef [ЗаявкаКандидата]
					,_Fld12722 [ЕстьВложения]
					,_Fld12749 [ЗаголовокПисьма]
					,_Fld12723 [ИдентификаторПисьма]
					,_Fld12724 [ИмяКомпьютераРедактированияХТМЛТекста]
					,_Fld12725 [ИмяФайлаРедактированияХТМЛТекста]
					,_Fld12750 [КодировкаПисьма]
					,_Fld12726 [Комментарий]
					,_Fld12727 [Кому]
					,_Fld12728 [КомуПредставление]
					,_Fld12729 [Копии]
					,_Fld12730 [КопииПредставление]
					,_Fld12731 [НеРассмотрено]
					,_Fld12732_TYPE [ОснованиеПисьма_Тип],_Fld12732_RRRef [ОснованиеПисьма],_Fld12732_RTRef [ОснованиеПисьма_Вид]
					,_Fld12733 [Ответ]
					,_Fld12734RRef [Ответственный]
					,_Fld12735 [ОтправительАдресЭлектроннойПочты]
					,_Fld12736 [ОтправительИмя]
					,_Fld12737 [ОтправительПредставление]
					,_Fld12751RRef [Оформление]
					,_Fld12738 [Переадресация]
					,_Fld12739 [ПочтовоеСообщение]
					,_Fld12752 [ПредметКонтакта]
					,_Fld12740 [РассмотретьПосле]
					,_Fld12741 [СкрытыеКопии]
					,_Fld12748_TYPE [ОтправительОбъект_Тип],_Fld12748_RRRef [ОтправительОбъект],_Fld12748_RTRef [ОтправительОбъект_Вид]
					,_Fld12742RRef [СостояниеПотомкаПисьма]
					,_Fld12743RRef [СтатусПисьма]
					,_Fld12744 [ТекстПисьма]
					,_Fld12745 [Тема]
					,_Fld12746RRef [УчетнаяЗапись]
					From _Document497(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЭлектронноеПисьмо();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидТекстаПисьма = V82.Перечисления/*Ссылка*/.ВидыТекстовЭлектронныхПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ДатаОтправления = Читалка.GetDateTime(5);
							Ссылка.ДатаТранспорта = Читалка.GetDateTime(6);
							Ссылка.ЕстьВложения = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ЗаголовокПисьма = Читалка.GetString(9);
							Ссылка.ИдентификаторПисьма = Читалка.GetString(10);
							Ссылка.ИмяКомпьютераРедактированияХТМЛТекста = Читалка.GetString(11);
							Ссылка.ИмяФайлаРедактированияХТМЛТекста = Читалка.GetString(12);
							Ссылка.КодировкаПисьма = Читалка.GetString(13);
							Ссылка.Комментарий = Читалка.GetString(14);
							Ссылка.Кому = Читалка.GetString(15);
							Ссылка.КомуПредставление = Читалка.GetString(16);
							Ссылка.Копии = Читалка.GetString(17);
							Ссылка.КопииПредставление = Читалка.GetString(18);
							Ссылка.НеРассмотрено = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.Ответ = ((byte[])Читалка.GetValue(23))[0]==1;
							Ссылка.ОтправительАдресЭлектроннойПочты = Читалка.GetString(25);
							Ссылка.ОтправительИмя = Читалка.GetString(26);
							Ссылка.ОтправительПредставление = Читалка.GetString(27);
							Ссылка.Переадресация = ((byte[])Читалка.GetValue(29))[0]==1;
							Ссылка.ПредметКонтакта = Читалка.GetString(31);
							Ссылка.РассмотретьПосле = Читалка.GetDateTime(32);
							Ссылка.СкрытыеКопии = Читалка.GetString(33);
							Ссылка.СостояниеПотомкаПисьма = V82.Перечисления/*Ссылка*/.СостоянияПотомковЭлектронныхПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(37));
							Ссылка.СтатусПисьма = V82.Перечисления/*Ссылка*/.СтатусыПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(38));
							Ссылка.ТекстПисьма = Читалка.GetString(39);
							Ссылка.Тема = Читалка.GetString(40);
							return Ссылка;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}
		
		public static ДокументыВыборка.ЭлектронноеПисьмо Выбрать()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld12718RRef [ВидТекстаПисьма]
					,_Fld12719RRef [ГруппаУчетнойЗаписи]
					,_Fld12720 [ДатаОтправления]
					,_Fld12721 [ДатаТранспорта]
					,_Fld22325RRef [ЗаявкаКандидата]
					,_Fld12722 [ЕстьВложения]
					,_Fld12749 [ЗаголовокПисьма]
					,_Fld12723 [ИдентификаторПисьма]
					,_Fld12724 [ИмяКомпьютераРедактированияХТМЛТекста]
					,_Fld12725 [ИмяФайлаРедактированияХТМЛТекста]
					,_Fld12750 [КодировкаПисьма]
					,_Fld12726 [Комментарий]
					,_Fld12727 [Кому]
					,_Fld12728 [КомуПредставление]
					,_Fld12729 [Копии]
					,_Fld12730 [КопииПредставление]
					,_Fld12731 [НеРассмотрено]
					,_Fld12732_TYPE [ОснованиеПисьма_Тип],_Fld12732_RRRef [ОснованиеПисьма],_Fld12732_RTRef [ОснованиеПисьма_Вид]
					,_Fld12733 [Ответ]
					,_Fld12734RRef [Ответственный]
					,_Fld12735 [ОтправительАдресЭлектроннойПочты]
					,_Fld12736 [ОтправительИмя]
					,_Fld12737 [ОтправительПредставление]
					,_Fld12751RRef [Оформление]
					,_Fld12738 [Переадресация]
					,_Fld12739 [ПочтовоеСообщение]
					,_Fld12752 [ПредметКонтакта]
					,_Fld12740 [РассмотретьПосле]
					,_Fld12741 [СкрытыеКопии]
					,_Fld12748_TYPE [ОтправительОбъект_Тип],_Fld12748_RRRef [ОтправительОбъект],_Fld12748_RTRef [ОтправительОбъект_Вид]
					,_Fld12742RRef [СостояниеПотомкаПисьма]
					,_Fld12743RRef [СтатусПисьма]
					,_Fld12744 [ТекстПисьма]
					,_Fld12745 [Тема]
					,_Fld12746RRef [УчетнаяЗапись]
					From _Document497(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ЭлектронноеПисьмо();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЭлектронноеПисьмо();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидТекстаПисьма = V82.Перечисления/*Ссылка*/.ВидыТекстовЭлектронныхПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ДатаОтправления = Читалка.GetDateTime(5);
							Ссылка.ДатаТранспорта = Читалка.GetDateTime(6);
							Ссылка.ЕстьВложения = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ЗаголовокПисьма = Читалка.GetString(9);
							Ссылка.ИдентификаторПисьма = Читалка.GetString(10);
							Ссылка.ИмяКомпьютераРедактированияХТМЛТекста = Читалка.GetString(11);
							Ссылка.ИмяФайлаРедактированияХТМЛТекста = Читалка.GetString(12);
							Ссылка.КодировкаПисьма = Читалка.GetString(13);
							Ссылка.Комментарий = Читалка.GetString(14);
							Ссылка.Кому = Читалка.GetString(15);
							Ссылка.КомуПредставление = Читалка.GetString(16);
							Ссылка.Копии = Читалка.GetString(17);
							Ссылка.КопииПредставление = Читалка.GetString(18);
							Ссылка.НеРассмотрено = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.Ответ = ((byte[])Читалка.GetValue(23))[0]==1;
							Ссылка.ОтправительАдресЭлектроннойПочты = Читалка.GetString(25);
							Ссылка.ОтправительИмя = Читалка.GetString(26);
							Ссылка.ОтправительПредставление = Читалка.GetString(27);
							Ссылка.Переадресация = ((byte[])Читалка.GetValue(29))[0]==1;
							Ссылка.ПредметКонтакта = Читалка.GetString(31);
							Ссылка.РассмотретьПосле = Читалка.GetDateTime(32);
							Ссылка.СкрытыеКопии = Читалка.GetString(33);
							Ссылка.СостояниеПотомкаПисьма = V82.Перечисления/*Ссылка*/.СостоянияПотомковЭлектронныхПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(37));
							Ссылка.СтатусПисьма = V82.Перечисления/*Ссылка*/.СтатусыПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(38));
							Ссылка.ТекстПисьма = Читалка.GetString(39);
							Ссылка.Тема = Читалка.GetString(40);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ЭлектронноеПисьмо ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld12718RRef [ВидТекстаПисьма]
					,_Fld12719RRef [ГруппаУчетнойЗаписи]
					,_Fld12720 [ДатаОтправления]
					,_Fld12721 [ДатаТранспорта]
					,_Fld22325RRef [ЗаявкаКандидата]
					,_Fld12722 [ЕстьВложения]
					,_Fld12749 [ЗаголовокПисьма]
					,_Fld12723 [ИдентификаторПисьма]
					,_Fld12724 [ИмяКомпьютераРедактированияХТМЛТекста]
					,_Fld12725 [ИмяФайлаРедактированияХТМЛТекста]
					,_Fld12750 [КодировкаПисьма]
					,_Fld12726 [Комментарий]
					,_Fld12727 [Кому]
					,_Fld12728 [КомуПредставление]
					,_Fld12729 [Копии]
					,_Fld12730 [КопииПредставление]
					,_Fld12731 [НеРассмотрено]
					,_Fld12732_TYPE [ОснованиеПисьма_Тип],_Fld12732_RRRef [ОснованиеПисьма],_Fld12732_RTRef [ОснованиеПисьма_Вид]
					,_Fld12733 [Ответ]
					,_Fld12734RRef [Ответственный]
					,_Fld12735 [ОтправительАдресЭлектроннойПочты]
					,_Fld12736 [ОтправительИмя]
					,_Fld12737 [ОтправительПредставление]
					,_Fld12751RRef [Оформление]
					,_Fld12738 [Переадресация]
					,_Fld12739 [ПочтовоеСообщение]
					,_Fld12752 [ПредметКонтакта]
					,_Fld12740 [РассмотретьПосле]
					,_Fld12741 [СкрытыеКопии]
					,_Fld12748_TYPE [ОтправительОбъект_Тип],_Fld12748_RRRef [ОтправительОбъект],_Fld12748_RTRef [ОтправительОбъект_Вид]
					,_Fld12742RRef [СостояниеПотомкаПисьма]
					,_Fld12743RRef [СтатусПисьма]
					,_Fld12744 [ТекстПисьма]
					,_Fld12745 [Тема]
					,_Fld12746RRef [УчетнаяЗапись]
					From _Document497(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ЭлектронноеПисьмо();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЭлектронноеПисьмо();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидТекстаПисьма = V82.Перечисления/*Ссылка*/.ВидыТекстовЭлектронныхПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ДатаОтправления = Читалка.GetDateTime(5);
							Ссылка.ДатаТранспорта = Читалка.GetDateTime(6);
							Ссылка.ЕстьВложения = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ЗаголовокПисьма = Читалка.GetString(9);
							Ссылка.ИдентификаторПисьма = Читалка.GetString(10);
							Ссылка.ИмяКомпьютераРедактированияХТМЛТекста = Читалка.GetString(11);
							Ссылка.ИмяФайлаРедактированияХТМЛТекста = Читалка.GetString(12);
							Ссылка.КодировкаПисьма = Читалка.GetString(13);
							Ссылка.Комментарий = Читалка.GetString(14);
							Ссылка.Кому = Читалка.GetString(15);
							Ссылка.КомуПредставление = Читалка.GetString(16);
							Ссылка.Копии = Читалка.GetString(17);
							Ссылка.КопииПредставление = Читалка.GetString(18);
							Ссылка.НеРассмотрено = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.Ответ = ((byte[])Читалка.GetValue(23))[0]==1;
							Ссылка.ОтправительАдресЭлектроннойПочты = Читалка.GetString(25);
							Ссылка.ОтправительИмя = Читалка.GetString(26);
							Ссылка.ОтправительПредставление = Читалка.GetString(27);
							Ссылка.Переадресация = ((byte[])Читалка.GetValue(29))[0]==1;
							Ссылка.ПредметКонтакта = Читалка.GetString(31);
							Ссылка.РассмотретьПосле = Читалка.GetDateTime(32);
							Ссылка.СкрытыеКопии = Читалка.GetString(33);
							Ссылка.СостояниеПотомкаПисьма = V82.Перечисления/*Ссылка*/.СостоянияПотомковЭлектронныхПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(37));
							Ссылка.СтатусПисьма = V82.Перечисления/*Ссылка*/.СтатусыПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(38));
							Ссылка.ТекстПисьма = Читалка.GetString(39);
							Ссылка.Тема = Читалка.GetString(40);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ЭлектронноеПисьмо ВыбратьПоНомеру(int Первые,string Мин,string Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld12718RRef [ВидТекстаПисьма]
					,_Fld12719RRef [ГруппаУчетнойЗаписи]
					,_Fld12720 [ДатаОтправления]
					,_Fld12721 [ДатаТранспорта]
					,_Fld22325RRef [ЗаявкаКандидата]
					,_Fld12722 [ЕстьВложения]
					,_Fld12749 [ЗаголовокПисьма]
					,_Fld12723 [ИдентификаторПисьма]
					,_Fld12724 [ИмяКомпьютераРедактированияХТМЛТекста]
					,_Fld12725 [ИмяФайлаРедактированияХТМЛТекста]
					,_Fld12750 [КодировкаПисьма]
					,_Fld12726 [Комментарий]
					,_Fld12727 [Кому]
					,_Fld12728 [КомуПредставление]
					,_Fld12729 [Копии]
					,_Fld12730 [КопииПредставление]
					,_Fld12731 [НеРассмотрено]
					,_Fld12732_TYPE [ОснованиеПисьма_Тип],_Fld12732_RRRef [ОснованиеПисьма],_Fld12732_RTRef [ОснованиеПисьма_Вид]
					,_Fld12733 [Ответ]
					,_Fld12734RRef [Ответственный]
					,_Fld12735 [ОтправительАдресЭлектроннойПочты]
					,_Fld12736 [ОтправительИмя]
					,_Fld12737 [ОтправительПредставление]
					,_Fld12751RRef [Оформление]
					,_Fld12738 [Переадресация]
					,_Fld12739 [ПочтовоеСообщение]
					,_Fld12752 [ПредметКонтакта]
					,_Fld12740 [РассмотретьПосле]
					,_Fld12741 [СкрытыеКопии]
					,_Fld12748_TYPE [ОтправительОбъект_Тип],_Fld12748_RRRef [ОтправительОбъект],_Fld12748_RTRef [ОтправительОбъект_Вид]
					,_Fld12742RRef [СостояниеПотомкаПисьма]
					,_Fld12743RRef [СтатусПисьма]
					,_Fld12744 [ТекстПисьма]
					,_Fld12745 [Тема]
					,_Fld12746RRef [УчетнаяЗапись]
					From _Document497(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ЭлектронноеПисьмо();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЭлектронноеПисьмо();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидТекстаПисьма = V82.Перечисления/*Ссылка*/.ВидыТекстовЭлектронныхПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ДатаОтправления = Читалка.GetDateTime(5);
							Ссылка.ДатаТранспорта = Читалка.GetDateTime(6);
							Ссылка.ЕстьВложения = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ЗаголовокПисьма = Читалка.GetString(9);
							Ссылка.ИдентификаторПисьма = Читалка.GetString(10);
							Ссылка.ИмяКомпьютераРедактированияХТМЛТекста = Читалка.GetString(11);
							Ссылка.ИмяФайлаРедактированияХТМЛТекста = Читалка.GetString(12);
							Ссылка.КодировкаПисьма = Читалка.GetString(13);
							Ссылка.Комментарий = Читалка.GetString(14);
							Ссылка.Кому = Читалка.GetString(15);
							Ссылка.КомуПредставление = Читалка.GetString(16);
							Ссылка.Копии = Читалка.GetString(17);
							Ссылка.КопииПредставление = Читалка.GetString(18);
							Ссылка.НеРассмотрено = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.Ответ = ((byte[])Читалка.GetValue(23))[0]==1;
							Ссылка.ОтправительАдресЭлектроннойПочты = Читалка.GetString(25);
							Ссылка.ОтправительИмя = Читалка.GetString(26);
							Ссылка.ОтправительПредставление = Читалка.GetString(27);
							Ссылка.Переадресация = ((byte[])Читалка.GetValue(29))[0]==1;
							Ссылка.ПредметКонтакта = Читалка.GetString(31);
							Ссылка.РассмотретьПосле = Читалка.GetDateTime(32);
							Ссылка.СкрытыеКопии = Читалка.GetString(33);
							Ссылка.СостояниеПотомкаПисьма = V82.Перечисления/*Ссылка*/.СостоянияПотомковЭлектронныхПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(37));
							Ссылка.СтатусПисьма = V82.Перечисления/*Ссылка*/.СтатусыПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(38));
							Ссылка.ТекстПисьма = Читалка.GetString(39);
							Ссылка.Тема = Читалка.GetString(40);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ЭлектронноеПисьмо СтраницаПоСсылке(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld12718RRef [ВидТекстаПисьма]
					,_Fld12719RRef [ГруппаУчетнойЗаписи]
					,_Fld12720 [ДатаОтправления]
					,_Fld12721 [ДатаТранспорта]
					,_Fld22325RRef [ЗаявкаКандидата]
					,_Fld12722 [ЕстьВложения]
					,_Fld12749 [ЗаголовокПисьма]
					,_Fld12723 [ИдентификаторПисьма]
					,_Fld12724 [ИмяКомпьютераРедактированияХТМЛТекста]
					,_Fld12725 [ИмяФайлаРедактированияХТМЛТекста]
					,_Fld12750 [КодировкаПисьма]
					,_Fld12726 [Комментарий]
					,_Fld12727 [Кому]
					,_Fld12728 [КомуПредставление]
					,_Fld12729 [Копии]
					,_Fld12730 [КопииПредставление]
					,_Fld12731 [НеРассмотрено]
					,_Fld12732_TYPE [ОснованиеПисьма_Тип],_Fld12732_RRRef [ОснованиеПисьма],_Fld12732_RTRef [ОснованиеПисьма_Вид]
					,_Fld12733 [Ответ]
					,_Fld12734RRef [Ответственный]
					,_Fld12735 [ОтправительАдресЭлектроннойПочты]
					,_Fld12736 [ОтправительИмя]
					,_Fld12737 [ОтправительПредставление]
					,_Fld12751RRef [Оформление]
					,_Fld12738 [Переадресация]
					,_Fld12739 [ПочтовоеСообщение]
					,_Fld12752 [ПредметКонтакта]
					,_Fld12740 [РассмотретьПосле]
					,_Fld12741 [СкрытыеКопии]
					,_Fld12748_TYPE [ОтправительОбъект_Тип],_Fld12748_RRRef [ОтправительОбъект],_Fld12748_RTRef [ОтправительОбъект_Вид]
					,_Fld12742RRef [СостояниеПотомкаПисьма]
					,_Fld12743RRef [СтатусПисьма]
					,_Fld12744 [ТекстПисьма]
					,_Fld12745 [Тема]
					,_Fld12746RRef [УчетнаяЗапись]
					From _Document497(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ЭлектронноеПисьмо();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЭлектронноеПисьмо();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидТекстаПисьма = V82.Перечисления/*Ссылка*/.ВидыТекстовЭлектронныхПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ДатаОтправления = Читалка.GetDateTime(5);
							Ссылка.ДатаТранспорта = Читалка.GetDateTime(6);
							Ссылка.ЕстьВложения = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ЗаголовокПисьма = Читалка.GetString(9);
							Ссылка.ИдентификаторПисьма = Читалка.GetString(10);
							Ссылка.ИмяКомпьютераРедактированияХТМЛТекста = Читалка.GetString(11);
							Ссылка.ИмяФайлаРедактированияХТМЛТекста = Читалка.GetString(12);
							Ссылка.КодировкаПисьма = Читалка.GetString(13);
							Ссылка.Комментарий = Читалка.GetString(14);
							Ссылка.Кому = Читалка.GetString(15);
							Ссылка.КомуПредставление = Читалка.GetString(16);
							Ссылка.Копии = Читалка.GetString(17);
							Ссылка.КопииПредставление = Читалка.GetString(18);
							Ссылка.НеРассмотрено = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.Ответ = ((byte[])Читалка.GetValue(23))[0]==1;
							Ссылка.ОтправительАдресЭлектроннойПочты = Читалка.GetString(25);
							Ссылка.ОтправительИмя = Читалка.GetString(26);
							Ссылка.ОтправительПредставление = Читалка.GetString(27);
							Ссылка.Переадресация = ((byte[])Читалка.GetValue(29))[0]==1;
							Ссылка.ПредметКонтакта = Читалка.GetString(31);
							Ссылка.РассмотретьПосле = Читалка.GetDateTime(32);
							Ссылка.СкрытыеКопии = Читалка.GetString(33);
							Ссылка.СостояниеПотомкаПисьма = V82.Перечисления/*Ссылка*/.СостоянияПотомковЭлектронныхПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(37));
							Ссылка.СтатусПисьма = V82.Перечисления/*Ссылка*/.СтатусыПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(38));
							Ссылка.ТекстПисьма = Читалка.GetString(39);
							Ссылка.Тема = Читалка.GetString(40);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ЭлектронноеПисьмо СтраницаПоНомеру(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld12718RRef [ВидТекстаПисьма]
					,_Fld12719RRef [ГруппаУчетнойЗаписи]
					,_Fld12720 [ДатаОтправления]
					,_Fld12721 [ДатаТранспорта]
					,_Fld22325RRef [ЗаявкаКандидата]
					,_Fld12722 [ЕстьВложения]
					,_Fld12749 [ЗаголовокПисьма]
					,_Fld12723 [ИдентификаторПисьма]
					,_Fld12724 [ИмяКомпьютераРедактированияХТМЛТекста]
					,_Fld12725 [ИмяФайлаРедактированияХТМЛТекста]
					,_Fld12750 [КодировкаПисьма]
					,_Fld12726 [Комментарий]
					,_Fld12727 [Кому]
					,_Fld12728 [КомуПредставление]
					,_Fld12729 [Копии]
					,_Fld12730 [КопииПредставление]
					,_Fld12731 [НеРассмотрено]
					,_Fld12732_TYPE [ОснованиеПисьма_Тип],_Fld12732_RRRef [ОснованиеПисьма],_Fld12732_RTRef [ОснованиеПисьма_Вид]
					,_Fld12733 [Ответ]
					,_Fld12734RRef [Ответственный]
					,_Fld12735 [ОтправительАдресЭлектроннойПочты]
					,_Fld12736 [ОтправительИмя]
					,_Fld12737 [ОтправительПредставление]
					,_Fld12751RRef [Оформление]
					,_Fld12738 [Переадресация]
					,_Fld12739 [ПочтовоеСообщение]
					,_Fld12752 [ПредметКонтакта]
					,_Fld12740 [РассмотретьПосле]
					,_Fld12741 [СкрытыеКопии]
					,_Fld12748_TYPE [ОтправительОбъект_Тип],_Fld12748_RRRef [ОтправительОбъект],_Fld12748_RTRef [ОтправительОбъект_Вид]
					,_Fld12742RRef [СостояниеПотомкаПисьма]
					,_Fld12743RRef [СтатусПисьма]
					,_Fld12744 [ТекстПисьма]
					,_Fld12745 [Тема]
					,_Fld12746RRef [УчетнаяЗапись]
					From _Document497(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ЭлектронноеПисьмо();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЭлектронноеПисьмо();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидТекстаПисьма = V82.Перечисления/*Ссылка*/.ВидыТекстовЭлектронныхПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ДатаОтправления = Читалка.GetDateTime(5);
							Ссылка.ДатаТранспорта = Читалка.GetDateTime(6);
							Ссылка.ЕстьВложения = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ЗаголовокПисьма = Читалка.GetString(9);
							Ссылка.ИдентификаторПисьма = Читалка.GetString(10);
							Ссылка.ИмяКомпьютераРедактированияХТМЛТекста = Читалка.GetString(11);
							Ссылка.ИмяФайлаРедактированияХТМЛТекста = Читалка.GetString(12);
							Ссылка.КодировкаПисьма = Читалка.GetString(13);
							Ссылка.Комментарий = Читалка.GetString(14);
							Ссылка.Кому = Читалка.GetString(15);
							Ссылка.КомуПредставление = Читалка.GetString(16);
							Ссылка.Копии = Читалка.GetString(17);
							Ссылка.КопииПредставление = Читалка.GetString(18);
							Ссылка.НеРассмотрено = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.Ответ = ((byte[])Читалка.GetValue(23))[0]==1;
							Ссылка.ОтправительАдресЭлектроннойПочты = Читалка.GetString(25);
							Ссылка.ОтправительИмя = Читалка.GetString(26);
							Ссылка.ОтправительПредставление = Читалка.GetString(27);
							Ссылка.Переадресация = ((byte[])Читалка.GetValue(29))[0]==1;
							Ссылка.ПредметКонтакта = Читалка.GetString(31);
							Ссылка.РассмотретьПосле = Читалка.GetDateTime(32);
							Ссылка.СкрытыеКопии = Читалка.GetString(33);
							Ссылка.СостояниеПотомкаПисьма = V82.Перечисления/*Ссылка*/.СостоянияПотомковЭлектронныхПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(37));
							Ссылка.СтатусПисьма = V82.Перечисления/*Ссылка*/.СтатусыПисем.ПустаяСсылка.Получить((byte[])Читалка.GetValue(38));
							Ссылка.ТекстПисьма = Читалка.GetString(39);
							Ссылка.Тема = Читалка.GetString(40);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.ЭлектронноеПисьмо СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.ЭлектронноеПисьмо();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЗаголовокПисьма = "";
			Объект.ИдентификаторПисьма = "";
			Объект.ИмяКомпьютераРедактированияХТМЛТекста = "";
			Объект.ИмяФайлаРедактированияХТМЛТекста = "";
			Объект.КодировкаПисьма = "";
			Объект.Комментарий = "";
			Объект.Кому = "";
			Объект.КомуПредставление = "";
			Объект.Копии = "";
			Объект.КопииПредставление = "";
			Объект.ОтправительАдресЭлектроннойПочты = "";
			Объект.ОтправительИмя = "";
			Объект.ОтправительПредставление = "";
			Объект.ПредметКонтакта = "";
			Объект.СкрытыеКопии = "";
			Объект.ТекстПисьма = "";
			Объект.Тема = "";
			Объект.ВидТекстаПисьма = V82.Перечисления/*Ссылка*/.ВидыТекстовЭлектронныхПисем.ПустаяСсылка;
			Объект.СостояниеПотомкаПисьма = V82.Перечисления/*Ссылка*/.СостоянияПотомковЭлектронныхПисем.ПустаяСсылка;
			Объект.СтатусПисьма = V82.Перечисления/*Ссылка*/.СтатусыПисем.ПустаяСсылка;
			return Объект;
		}
	}
}