﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class РегламентныеПроцедуры
	{
		////////////////////////////////////////////////////////////////////////////////
		// РАБОТА С РЕГЛАМЕНТНЫМ ЗАДАНИЕМ В ДИАЛОГЕ ФОРМЫ
		// Управляет выводом представления расписания
		//
		// Параметры
		//  Форма - форма, на которой находятся реквизиты связанные с расписанием.
		//          Форма обязательно должна содержать:
		//          - реквизит ПредставлениеРасписания - Тип: Строка
		//          - экспортную переменную Расписание
		//

		public void НастроитьПредставлениеРасписания(/*Форма*/)
		{
			if(true/*Форма.Расписание = Неопределено*/)
			{
				//Форма.ПредставлениеРасписания = "<Ввести расписание>";
			}
		}
		// НастроитьПредставлениеРасписания()
		// Выполняет редактирование расписания регламентного задания
		//
		// Параметры
		//  Форма - форма, на которой находятся реквизиты связанные с расписанием.
		//          Форма обязательно должна содержать:
		//          - экспортную переменную Расписание
		//

		public void РедактироватьРасписаниеРегламентногоЗадания(/*Форма*/)
		{
			//СтароеРасписание = Форма.Расписание;
			//РасписаниеНеопределено = (Форма.Расписание = Неопределено);
			if(true/*РасписаниеНеопределено*/)
			{
				//Форма.Расписание = Новый РасписаниеРегламентногоЗадания;
			}
			//Диалог = Новый ДиалогРасписанияРегламентногоЗадания(Форма.Расписание);
			if(true/*Диалог.ОткрытьМодально()*/)
			{
				//Форма.Расписание = Диалог.Расписание;
				//Форма.Модифицированность = Истина;
				//НастроитьПредставлениеРасписания(Форма);
			}
		}
		// РедактироватьРасписаниеРегламентногоЗадания()
		// Очищает расписание при снятии флага ФормироватьДокументыАвтоматически
		//
		// Параметры
		//  Форма - форма, на которой находятся реквизиты связанные с расписанием.
		//          Форма обязательно должна содержать:
		//          - реквизит ФормироватьДокументыАвтоматически
		//          - экспортную переменную Расписание
		//

		public object ПриИзмененииФлагаФормироватьДокументыАвтоматически(/*Форма*/)
		{
			//НужноУдалитьРегламентноеЗадание = Ложь;
			if(true/*НЕ Форма.ФормироватьДокументыАвтоматически*/)
			{
				if(true/*Форма.Расписание <> Неопределено*/)
				{
					/*// Уточним, не надо ли удалить регламентное задание
*/
					/*//таймаут
*/
					/*КодВозвратаДиалога.Нет,
			"Удаление расписания"
			);*/
					if(true/*Ответ = КодВозвратаДиалога.Да*/)
					{
						//НужноУдалитьРегламентноеЗадание = Истина;
						//Форма.Расписание = Неопределено;
						//НастроитьПредставлениеРасписания(Форма);
					}
				}
			}
			return null;
		}
		// ПриИзмененииФлагаФормироватьДокументыАвтоматически()
		// Получает расписание регламентного задания
		//
		// Параметры
		//  РегламентноеЗадание - ссылка на регламентное задание
		//

		public object ПолучитьРасписаниеРегламентногоЗадания(/*РегламентноеЗадание*/)
		{
			if(true/*ПустаяСтрока(РегламентноеЗадание)*/)
			{
				/*// Расписание по-умолчанию
*/
			}
			//СвойстваРегламентногоЗадания = Новый Структура("Расписание");
			if(true/*ПолныеПрава.ПрочитатьРегламентноеЗадание(Новый УникальныйИдентификатор(РегламентноеЗадание), СвойстваРегламентногоЗадания,"Ошибка при чтении расписания")*/)
			{
				/*// Расписание передается внутри ХранилищеЗначения, чтобы его можно было передать с сервера
*/
			}
			/*// Расписание по-умолчанию
*/
			return null;
		}
		// ПолучитьРасписаниеРегламентногоЗадания()
		// Удаляет соответствующее регламентное задание при записи справочника с настройками
		//
		// Параметры
		//  ЭтотОбъект - справочник настроек,
		//  ЗаголовокСообщения - строка, содержащая заголовок для сообщений об ошибках,
		//  Отказ - булево, в случае ошибки устанавливается в Истина
		//

		public void УдалитьРегламентноеЗаданиеПриЗаписиНастройки(/*ЭтотОбъект,ЗаголовокСообщения,Отказ*/)
		{
			/*// Обрабатываем удаление регламентного задания
*/
			if(true/*НЕ ЭтотОбъект.ФормироватьДокументыАвтоматически*/)
			{
				if(true/*НЕ ПустаяСтрока(ЭтотОбъект.РегламентноеЗадание)*/)
				{
					//СообщениеОбОшибке 	= "Ошибка при удалении регламентного задания";
					if(true/*ПолныеПрава.УдалитьРегламентноеЗадание(
				Новый УникальныйИдентификатор(ЭтотОбъект.РегламентноеЗадание), 
				СообщениеОбОшибке, 
				ЗаголовокСообщения)*/)
					{
						//ЭтотОбъект.РегламентноеЗадание = "";
					}
				}
			}
		}
		// УдалитьРегламентноеЗаданиеПриЗаписиНастройки()
		// Изменяет расписание соответствующего регламентного задания при записи справочника с настройками
		//
		// Параметры
		//  ЭтотОбъект - справочник настроек,
		//  Расписание - расписание, которое необходимо установить,
		//  ЗаголовокСообщения - строка, содержащая заголовок для сообщений об ошибках,
		//  Отказ - булево, в случае ошибки устанавливается в Истина
		//

		public void ИзменитьРегламентноеЗаданиеПриЗаписиНастройки(/*ЭтотОбъект,Расписание,ЗаголовокСообщения,Отказ*/)
		{
			/*// Обрабатываем расписание регл. задания
*/
			if(true/*Расписание = Неопределено*/)
			{
				//ОбщегоНазначения.СообщитьОбОшибке("Не задано расписание.", Отказ, ЗаголовокСообщения);
			}
			//СвойстваРегламентногоЗадания = Новый Структура();
			//СвойстваРегламентногоЗадания.Вставить("Расписание", Новый ХранилищеЗначения(Расписание));
			if(true/*НЕ ПолныеПрава.ИзменитьРегламентноеЗадание(
		Новый УникальныйИдентификатор(ЭтотОбъект.РегламентноеЗадание), 
		СвойстваРегламентногоЗадания, 
		"Ошибка при записи расписания", 
		ЗаголовокСообщения)*/)
			{
				//Отказ = Истина;
			}
		}
		// ИзменитьРегламентноеЗаданиеПриЗаписиНастройки()

		public void ВывестиПризнакОтраженияВУчетеУчетВФормуСписка(/*ОформленияСтрок, ИмяТипа, УпрУчет=Истина, РеглУчет=Истина*/)
		{
			//МассивЭлементов = новый Массив;
			//Соответствие = новый Соответствие;
			//Запрос = новый Запрос;
			/*Запрос.Текст = "ВЫБРАТЬ РАЗРЕШЕННЫЕ
	|Ссылка,
	|ВЫБОР КОГДА ВидОтраженияВУчете = ЗНАЧЕНИЕ(Перечисление.ВидыОтраженияВУчете.ОтражатьВУправленческомУчете)
	|ТОГДА ИСТИНА
	|ИНАЧЕ ЛОЖЬ
	|КОНЕЦ КАК ОтражатьВУправленческомУчете,
	|ВЫБОР КОГДА ВидОтраженияВУчете = ЗНАЧЕНИЕ(Перечисление.ВидыОтраженияВУчете.ОтражатьВРегламентированномУчете)
	|ТОГДА ИСТИНА
	|ИНАЧЕ ЛОЖЬ
	|КОНЕЦ КАК ОтражатьВРегламентированномУчете	
	|ИЗ Справочник." + ИмяТипа + "
	|ГДЕ Ссылка в (&МассивЭлементов)";*/
			//Запрос.УстановитьПараметр("МассивЭлементов",МассивЭлементов);
			//Выборка = Запрос.Выполнить().Выбрать();
			while(true/*Выборка.Следующий()*/)
			{
				if(true/*УпрУчет*/)
				{
					//Соответствие.Получить(Выборка.Ссылка).Ячейки.ОтражатьВУправленческомУчете.УстановитьФлажок(Выборка.ОтражатьВУправленческомУчете);
				}
				if(true/*РеглУчет*/)
				{
					//Соответствие.Получить(Выборка.Ссылка).Ячейки.ОтражатьВРегламентированномУчете.УстановитьФлажок(Выборка.ОтражатьВРегламентированномУчете);
				}
			}
			//;;
		}
		////////////////////////////////////////////////////////////////////////////////
		// РАБОТА С РЕГЛАМЕНТНЫМ ЗАДАНИЕМ МОДУЛЬ СПРАВОЧНИКА НАСТРОЕК
		// Устанавливает параметры регламентного задания
		// соответствующие реквизитам элемента
		//
		// Параметры
		//	ЭтотОбъект - элемент справочника настроек,
		//  Отказ - значение параметра будет установлено в Истина, если при выполнении операций
		//          с регламентным заданием произошла ошибка и оно может не соответствовать
		//          реквизитам элемента

		public void НастроитьРегламентноеЗадание(/*ЭтотОбъект, Отказ*/)
		{
			//Заголовок 			= ЭтотОбъект.ЗаголовокПриЗаписи();
			//СообщениеОбОшибке 	= "Ошибка при записи регламентного задания";
			//УИД = ЭтотОбъект.Ссылка.УникальныйИдентификатор();
			//СвойстваРегламентногоЗадания = Новый Структура();
			//СвойстваРегламентногоЗадания.Вставить("Использование");
			//СвойстваРегламентногоЗадания.Вставить("Параметры");
			//СвойстваРегламентногоЗадания.Вставить("Наименование");
			//СвойстваРегламентногоЗадания.Вставить("Ключ");
			if(true/*НЕ ПолныеПрава.ПрочитатьРегламентноеЗадание(
		Новый УникальныйИдентификатор(ЭтотОбъект.РегламентноеЗадание),
		СвойстваРегламентногоЗадания,
		СообщениеОбОшибке,
		Заголовок)*/)
			{
				/*// Идентификатор РегламентноеЗадание не должен быть пустым
*/
				/*// а само регл. задание должно существовать.
*/
				/*// Это обеспечивается в обработчике события ПередЗаписью().
*/
				//Отказ = Истина;
			}
			/*// Проверим, что свойства - правильные, 
*/
			/*// записывать задание будем только в случае, если их нужно менять
*/
			if(true/*СвойстваРегламентногоЗадания.Параметры.Количество() = 1 
		И СвойстваРегламентногоЗадания.Параметры[0]  = ЭтотОбъект.Ссылка
		И СвойстваРегламентногоЗадания.Наименование  = ЭтотОбъект.Наименование
		И СвойстваРегламентногоЗадания.Ключ 		 = "" + УИД
		И СвойстваРегламентногоЗадания.Использование = Истина*/)
			{
				/*// Все нормально
*/
			}
			/*// Будем записывать новые настройки
*/
			//ПараметрыРегламентногоЗадания = Новый Массив();
			//ПараметрыРегламентногоЗадания.Добавить(ЭтотОбъект.Ссылка);
			//СвойстваРегламентногоЗадания.Использование = Истина;
			//СвойстваРегламентногоЗадания.Параметры     = ПараметрыРегламентногоЗадания;
			//СвойстваРегламентногоЗадания.Наименование  = ЭтотОбъект.Наименование;
			/*// Одновременно может выполняться только одно регл. задание для минимизации конфликтов
*/
			/*// Для этого устанавливаем ключ
*/
			//СвойстваРегламентногоЗадания.Ключ 		   = "" + УИД;
			if(true/*НЕ ПолныеПрава.ИзменитьРегламентноеЗадание(
		Новый УникальныйИдентификатор(ЭтотОбъект.РегламентноеЗадание), 
		СвойстваРегламентногоЗадания, 
		СообщениеОбОшибке,
		Заголовок)*/)
			{
				//Отказ = Истина;
			}
		}
		// НастроитьРегламентноеЗадание()
		// Обеспечивает, что регламентное задание, связанное с элементом справочника,
		// не используется
		//
		// Параметры
		//	ЭтотОбъект - элемент справочника настроек

		public void ОтключитьИспользованиеРегламентногоЗадания(/*ЭтотОбъект*/)
		{
			if(true/*ПустаяСтрока(ЭтотОбъект.РегламентноеЗадание)*/)
			{
				/*// Не создавалось регламентное задания, связанное с элементом справочника.
*/
			}
			/*// Регл. задание по этому элементу справочника создавалось.
*/
			/*// Проверим, возможно оно еще используется.
*/
			/*// В этом случае его надо выключить.
*/
			//СвойстваРегламентногоЗадания = Новый Структура();
			//СвойстваРегламентногоЗадания.Вставить("Использование");
			if(true/*НЕ ПолныеПрава.ПрочитатьРегламентноеЗадание(
		Новый УникальныйИдентификатор(ЭтотОбъект.РегламентноеЗадание), 
		СвойстваРегламентногоЗадания)*/)
			{
				/*// Регл. задания уже нет
*/
			}
			if(true/*СвойстваРегламентногоЗадания.Использование <> Истина*/)
			{
				/*// Регл. задание отключено
*/
			}
			/*// Использование регл. задания надо отключить
*/
			//СвойстваРегламентногоЗадания.Использование = Ложь;
			/*ПолныеПрава.ИзменитьРегламентноеЗадание(
		Новый УникальныйИдентификатор(ЭтотОбъект.РегламентноеЗадание), 
		СвойстваРегламентногоЗадания);*/
		}
		// ОтключитьИспользованиеРегламентногоЗадания()
		// Удаляет регламентное задание, связанное с элементом справочника
		//
		// Параметры
		//	ЭтотОбъект - элемент справочника настроек,
		//  Отказ - значение параметра будет установлено в Истина, если при удалении задания произошла ошибка

		public void УдалитьРегламентноеЗаданиеСвязанноеСНастройкой(/*ЭтотОбъект, Отказ*/)
		{
			if(true/*ПустаяСтрока(ЭтотОбъект.РегламентноеЗадание)*/)
			{
				/*// Не создавалось регламентное задания, связанное с элементом справочника.
*/
			}
			/*// Регл. задание по этому элементу справочника создавалось.
*/
			/*// Его надо удалить.
*/
			/*// Без удаления регл. задания удалить элемент справочника нельзя.
*/
			//Заголовок 			= "Удаление настройки """ + ЭтотОбъект.Наименование + """";
			//СообщениеОбОшибке 	= "Ошибка при удалении регламентного задания";
			if(true/*НЕ ПолныеПрава.УдалитьРегламентноеЗадание(
		Новый УникальныйИдентификатор(ЭтотОбъект.РегламентноеЗадание), 
		СообщениеОбОшибке, 
		Заголовок)*/)
			{
				//Отказ = Истина;
			}
		}
		// УдалитьРегламентноеЗадание()
		////////////////////////////////////////////////////////////////////////////////
		// ОБРАБОТЧИКИ СОБЫТИЙ В МОДУЛЯХ СПРАВОЧНИКОВ РЕГЛАМЕНТНЫХ НАСТРОЕК
		// Обработчик события ПередЗаписью
		// Выполняются проверки - можно записать элемент или нет.
		// При необходимости создается регламентное задание

		public void ПередЗаписьюНастроекРегламентныхПроцедур(/*Источник, Отказ*/)
		{
			if(true/*Источник.ЭтоГруппа ИЛИ Источник.ОбменДанными.Загрузка*/)
			{
			}
			if(true/*Источник.ПометкаУдаления*/)
			{
				//Источник.ФормироватьДокументыАвтоматически = Ложь;
			}
			/*// Запрещена запись элемента с пустым наименованием. Проверяем отдельно, 
*/
			/*// т.к. наименование - это основное представление, в т.ч. в сообщениях об ошибке.
*/
			/*// Текст сообщения - по аналогии с незаполненной датой документа.
*/
			if(true/*ПустаяСтрока(Источник.Наименование)*/)
			{
				//Заголовок = "Запись настройки ";
				/*// без наименования, т.к. оно пустое
*/
				//ОбщегоНазначения.СообщитьОбОшибке("Не задано наименование",	Отказ, Заголовок);
			}
			/*// Проверим заполнение реквизитов
*/
			//Заголовок = Источник.ЗаголовокПриЗаписи();
			//Отказ = Отказ ИЛИ НЕ Источник.РеквизитыЗаполнены(Заголовок);
			/*// Проверим корректность регламентного задания
*/
			/*// Важно: с одним элементом справочника могут быть связаны несколько регл. заданий.
*/
			/*// Но только с одним из них поддерживается манипулирование через справочник.
*/
			/*// Ссылка на это регл. задание хранится в справочнике.
*/
			/*// Если настройка поддерживает использования регл.задания, то оно должно существовать
*/
			/*// и ссылка на него должна быть указана в реквизите РегламентноеЗадание.
*/
			if(true/*Источник.ФормироватьДокументыАвтоматически*/)
			{
				//Отказ = Отказ ИЛИ НЕ ПолныеПрава.ОбеспечитьРегламентноеЗадание(Источник.ИмяРегламентногоЗадания(), Источник.РегламентноеЗадание, "Ошибка при создании регламентного задания", Заголовок);
			}
		}
		// ПередЗаписьюНастроекРегламентныхПроцедур()
		// Обработчик события ПриЗаписи
		// Проверим, что параметры регламентного задания соответствуют настройкам регламента

		public void ПриЗаписиНастроекРегламентныхПроцедур(/*Источник, Отказ*/)
		{
			if(true/*Источник.ЭтоГруппа ИЛИ Источник.ОбменДанными.Загрузка ИЛИ Источник.ПометкаУдаления*/)
			{
			}
			/*// Проверим, что параметры регламентного задания соответствуют настройкам регламента
*/
			if(true/*Источник.ФормироватьДокументыАвтоматически*/)
			{
				//НастроитьРегламентноеЗадание(Источник, Отказ);
			}
		}
		// ПриЗаписиНастроекРегламентныхПроцедур()
		// Обработчик события ПередУдалением
		// При удалении элемента справочника удалим и связанное с ним регламентное задание

		public void ПередУдалениемНастроекРегламентныхПроцедур(/*Источник, Отказ*/)
		{
			if(true/*Источник.ЭтоГруппа ИЛИ Источник.ОбменДанными.Загрузка*/)
			{
			}
			//УдалитьРегламентноеЗаданиеСвязанноеСНастройкой(Источник, Отказ);
		}
		// ПередУдалениемНастроекРегламентныхПроцедур()
		// Обработчик события ПриКопировании
		// Новый элемент должен использовать свое регламентное задание

		public void ПриКопированииНастроекРегламентныхПроцедур(/*Источник, ОбъектКопирования*/)
		{
			if(true/*Источник.ЭтоГруппа*/)
			{
			}
			/*// Новый элемент должен использовать свое регламентное задание
*/
			//Источник.РегламентноеЗадание = "";
		}
		// ПриКопированииНастроекРегламентныхПроцедур()
	}
}
