﻿
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	///<summary>
	///(Регл)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class ДоговорНаВыполнениеРаботСФизЛицом:ДокументОбъект
	{
		public bool _ЭтоНовый;
		public bool ЭтоНовый()
		{
			return _ЭтоНовый;
		}
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		[DataMember]
		[ProtoMember(3)]
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		[DataMember]
		[ProtoMember(4)]
		public bool ПометкаУдаления {get;set;}
		[DataMember]
		[ProtoMember(5)]
		public DateTime Дата {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public DateTime ПрефиксНомера {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*11*/ Номер {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public bool Проведен {get;set;}
		[DataMember]
		[ProtoMember(9)]
		public V82.СправочникиСсылка.СотрудникиОрганизаций Сотрудник {get;set;}
		[DataMember]
		[ProtoMember(10)]
		public V82.СправочникиСсылка.ФизическиеЛица ФизЛицо {get;set;}//Физическое лицо
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		[DataMember]
		[ProtoMember(12)]
		public V82.СправочникиСсылка.Валюты ВалютаДокумента {get;set;}//Валюта документа
		///<summary>
		///Сумма в валюте документа
		///</summary>
		[DataMember]
		[ProtoMember(13)]
		public decimal/*(15.2)*/ СуммаЗаРаботу {get;set;}//Сумма за работу
		[DataMember]
		[ProtoMember(14)]
		public object ВидРасчета {get;set;}//Вид расчета
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		[DataMember]
		[ProtoMember(15)]
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(16)]
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		[DataMember]
		[ProtoMember(17)]
		public object ВидДоговора {get;set;}//Вид договора
		[DataMember]
		[ProtoMember(18)]
		public V82.Перечисления/*Ссылка*/.ВидыАвторскогоДоговора ВидАвторскогоДоговора {get;set;}//Вид авторского договора
		[DataMember]
		[ProtoMember(19)]
		public DateTime ДатаНачала {get;set;}//Дата начала
		[DataMember]
		[ProtoMember(20)]
		public DateTime ДатаОкончания {get;set;}//Дата окончания
		[DataMember]
		[ProtoMember(21)]
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизации {get;set;}//Подразделение организации
		[DataMember]
		[ProtoMember(22)]
		public V82.Перечисления/*Ссылка*/.ХарактерВыплатыПоДоговору ХарактерОплаты {get;set;}//Характер оплаты
		[DataMember]
		[ProtoMember(23)]
		public V82.Перечисления/*Ссылка*/.ОтнесениеРасходовКДеятельностиЕНВД ОтнесениеРасходовКДеятельностиЕНВД {get;set;}//Отнесение расходов к деятельности ЕНВД
		[DataMember]
		[ProtoMember(24)]
		public V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете СпособОтраженияВБухучете {get;set;}//Способ отражения в бухучете
		[DataMember]
		[ProtoMember(25)]
		public V82.СправочникиСсылка.ВычетыНДФЛ КодВычета {get;set;}//Код вычета
		[DataMember]
		[ProtoMember(26)]
		public bool ЗаключенСоСтудентомРаботающимВСтудотряде {get;set;}//Заключен со студентом работающим в студотряде
		public void Записать()
		{
			//Установка блокировки элемента на горизантально масштабированный кластер.
			//Опционально введение тайм аута на запись одного и того же объекта, не чаще раза в 5-секунд. Защита от спама. упращение алгоритма блокировки.
			//Выделение сервиса для блокировки элемента и генерации кода
			//Выполнение операций контроля без обращений к sql-серверу.
			//Контроль конфликта блокировок.
			//Контроль загрузки булкинсертом гетерогенной коллекции.
			//Контроль уникальности кода для Документов.
			//Контроль уникальности номера для документов, в границах префикса.
			//Контроль владельца, он не может быть группой.
			//Контроль владельца он должен быть задан.
			//Контроль родителя он должен быть группой.
			//Контроль количества уровней, должен соотвествовать метаданным.
			//Контроль версии, объект не должен был быть записан перед чтением текущей записи, алгоритм версионника.
			//Контроль уникальности ссылки
			//Контроль зацикливания
			//Опционально контроль битых ссылок.
			//Соблюдейние транзакционности. ПередЗаписью. Открытие транзации. Валидации. ПриЗаписи. Фиксация транзакции. Информирование о записи элемента.
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					if(_ЭтоНовый)
					{
						Команда.CommandText = @"
						Insert Into _Document252(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Number
						,_Fld21426RRef
						,_Fld4198RRef
						,_Fld4199RRef
						,_Fld4200RRef
						,_Fld4201
						,_Fld4202RRef
						,_Fld4203
						,_Fld4204RRef
						,_Fld26724RRef
						,_Fld4206
						,_Fld4207
						,_Fld4208RRef
						,_Fld4209RRef
						,_Fld21428RRef
						,_Fld21427RRef
						,_Fld4210RRef
						,_Fld26725)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Номер
						,@Сотрудник
						,@ФизЛицо
						,@Организация
						,@ВалютаДокумента
						,@СуммаЗаРаботу
						,@ВидРасчета
						,@Комментарий
						,@Ответственный
						,@ВидАвторскогоДоговора
						,@ДатаНачала
						,@ДатаОкончания
						,@ПодразделениеОрганизации
						,@ХарактерОплаты
						,@ОтнесениеРасходовКДеятельностиЕНВД
						,@СпособОтраженияВБухучете
						,@КодВычета
						,@ЗаключенСоСтудентомРаботающимВСтудотряде)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Document252
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_Number	= @Номер
						,_Fld21426RRef	= @Сотрудник
						,_Fld4198RRef	= @ФизЛицо
						,_Fld4199RRef	= @Организация
						,_Fld4200RRef	= @ВалютаДокумента
						,_Fld4201	= @СуммаЗаРаботу
						,_Fld4202RRef	= @ВидРасчета
						,_Fld4203	= @Комментарий
						,_Fld4204RRef	= @Ответственный
						,_Fld26724RRef	= @ВидАвторскогоДоговора
						,_Fld4206	= @ДатаНачала
						,_Fld4207	= @ДатаОкончания
						,_Fld4208RRef	= @ПодразделениеОрганизации
						,_Fld4209RRef	= @ХарактерОплаты
						,_Fld21428RRef	= @ОтнесениеРасходовКДеятельностиЕНВД
						,_Fld21427RRef	= @СпособОтраженияВБухучете
						,_Fld4210RRef	= @КодВычета
						,_Fld26725	= @ЗаключенСоСтудентомРаботающимВСтудотряде
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Номер", Номер);
					Команда.Parameters.AddWithValue("СуммаЗаРаботу", СуммаЗаРаботу);
					Команда.Parameters.AddWithValue("ВидРасчета", Guid.Empty);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("ВидАвторскогоДоговора", ВидАвторскогоДоговора.Ключ());
					Команда.Parameters.AddWithValue("ДатаНачала", ДатаНачала);
					Команда.Parameters.AddWithValue("ДатаОкончания", ДатаОкончания);
					Команда.Parameters.AddWithValue("ХарактерОплаты", ХарактерОплаты.Ключ());
					Команда.Parameters.AddWithValue("ОтнесениеРасходовКДеятельностиЕНВД", ОтнесениеРасходовКДеятельностиЕНВД.Ключ());
					Команда.Parameters.AddWithValue("ЗаключенСоСтудентомРаботающимВСтудотряде", ЗаключенСоСтудентомРаботающимВСтудотряде);
					Команда.ExecuteNonQuery();
				}
			}
		}
		public void Удалить()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Delete _Document252
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}