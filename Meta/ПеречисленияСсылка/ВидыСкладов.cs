﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Общ)
	///</summary>
	[DataContract]
	public enum ВидыСкладов
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ) Оптовый склад
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"70b37882-34f4-422a-a187-01a13ce539dd\", \"Представление\":\"Оптовый\"}")]
		Оптовый = 0,
	///<summary>
	///(Общ) Розничный
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"7fdc7b68-8b01-4730-8c86-5047e2fb2120\", \"Представление\":\"Розничный\"}")]
		Розничный = 1,
	///<summary>
	///(Общ) Неавтоматизированная торговая точка
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"6fee5b3d-a2c0-4bb3-b69b-c761710f6117\", \"Представление\":\"НТТ\"}")]
		НТТ = 2,
	}
	public static partial class ВидыСкладов_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ) Оптовый склад
		///</summary>
		public static readonly Guid Оптовый = new Guid("a10187a1-e53c-dd39-422a-34f470b37882");
		///<summary>
		///(Общ) Розничный
		///</summary>
		public static readonly Guid Розничный = new Guid("4750868c-fbe2-2021-4730-8b017fdc7b68");
		///<summary>
		///(Общ) Неавтоматизированная торговая точка
		///</summary>
		public static readonly Guid НТТ = new Guid("61c79bb6-0f71-1761-4bb3-a2c06fee5b3d");
		public static ВидыСкладов Получить(this ВидыСкладов Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыСкладов Получить(this ВидыСкладов Значение, Guid Ссылка)
		{
			if(Ссылка == Оптовый)
			{
				return ВидыСкладов.Оптовый;
			}
			else if(Ссылка == Розничный)
			{
				return ВидыСкладов.Розничный;
			}
			else if(Ссылка == НТТ)
			{
				return ВидыСкладов.НТТ;
			}
			return ВидыСкладов.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыСкладов Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыСкладов Значение)
		{
			switch (Значение)
			{
				case ВидыСкладов.Оптовый: return Оптовый;
				case ВидыСкладов.Розничный: return Розничный;
				case ВидыСкладов.НТТ: return НТТ;
			}
			return Guid.Empty;
		}
	}
}