using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using JetBrains.Annotations;

namespace MikhailKhalizev.Utils
{
	/// <summary>
	///   Содержит вспомогательные методы для работы с типами.
	/// </summary>
	public class TypeHelper
	{
		/// <summary>
		///   Возвращает объект System.Type с указанным полным именем, учитывая при поиске регистр.
		/// </summary>
		/// <param name="typeFullName"> Полное имя искомого типа. </param>
		/// <returns> Тип с указанным именем. </returns>
		[NotNull]
		public static Type GetType(string typeFullName)
		{
			return GetType(typeFullName, true);
		}

		/// <summary>
		///   Возвращает объект System.Type с указанным полным именем, учитывая при поиске регистр.
		/// </summary>
		/// <param name="typeFullName"> Полное имя искомого типа. </param>
		/// <param name="throwOnError">
		///   Значение true, чтобы в случае невозможности найти тип создавалось исключение;
		///   значение false, чтобы возвращалось значение null. Кроме того, при указании значения false
		///   подавляются некоторые другие условия возникновения исключений, но не все из них.
		/// </param>
		/// <returns> Тип с указанным именем. </returns>
		public static Type GetType(string typeFullName, bool throwOnError)
		{
			var type = Type.GetType(typeFullName);
			if (type != null)
				return type;

			var count = 1;
			for (var i = 0; i < count; i++)
			{
				type = AppDomain.CurrentDomain.GetAssemblies().Select(a =>
				{
					try
					{
						return a.GetType(typeFullName);
					}
					catch (ReflectionTypeLoadException)
					{
						count = 2;
						return null;
					}
				}).SkipNull().FirstOrDefault();

				if (type != null)
					return type;
			}

			return Type.GetType(typeFullName, throwOnError);
		}

		/// <summary>
		///   Возвращает объект System.Type с указанным именем, учитывая при поиске регистр.
		/// </summary>
		/// <param name="name"> Имя искомого типа. </param>
		/// <returns> Тип с указанным именем. </returns>
		[CanBeNull]
		public static Type FindTypeByName(string name)
		{
			return FindTypeByName(name, typeof(object));
		}

		/// <summary>
		///   Возвращает объект System.Type с указанным именем, учитывая при поиске регистр.
		/// </summary>
		/// <param name="name"> Имя искомого типа. </param>
		/// <param name="baseType"> Базовый тип искомого типа. </param>
		/// <returns> Тип с указанным именем. </returns>
		[CanBeNull]
		public static Type FindTypeByName(string name, Type baseType)
		{
			var type = GetType(name, false);
			if (type != null && baseType.IsAssignableFrom(type))
				return type;

			var count = 1;
			for (var i = 0; i < count; i++)
			{
				type = AppDomain.CurrentDomain.GetAssemblies().Select(a =>
				{
					try
					{
						var types = a.GetTypes().Where(x => x.Name == name && baseType.IsAssignableFrom(x));
						return types.SingleOrDefault();
					}
					catch (ReflectionTypeLoadException)
					{
						count = 2;
						return null;
					}
				}).SkipNull().SingleOrDefault();

				if (type != null)
					return type;
			}

			return null;
		}

		/// <summary>
		///   Возвращает значение свойства заданного объекта.
		/// </summary>
		/// <param name="obj"> Исходный объект. </param>
		/// <param name="objType"> Интерфейс объекта. </param>
		/// <param name="targetPropertyName"> Наименование целевого свойства. </param>
		/// <param name="throwOnError">
		///   True, требуется генерировать исключение, если свойство не будет обнаружено в исходном объекте;
		///   False, если исключение надо погасить.
		/// </param>
		/// <returns> Значение свойства заданного объекта. </returns>
		[CanBeNull]
		public static object GetProperyValue(object obj, Type objType, string targetPropertyName, bool throwOnError)
		{
			PropertyInfo targetPropertyInfo;
			object targetPropertyObj;

			GetPropertyType(obj, objType, targetPropertyName, out targetPropertyInfo, out targetPropertyObj, throwOnError);

			return targetPropertyInfo == null ? null : targetPropertyInfo.GetValue(targetPropertyObj);
		}

		/// <summary>
		///   Возвращает тип целевого свойства заданного объекта и дополнительную информацию для доступа к нему.
		/// </summary>
		/// <param name="obj"> Исходный объект. </param>
		/// <param name="objType"> Интерфейс исходного объекта. </param>
		/// <param name="targetPropertyName"> Наименование целевого свойства. </param>
		/// <param name="targetPropertyInfo"> Метаданные целевого свойства. </param>
		/// <param name="targetPropertyObj"> Объект, содержащий целевое свойство. </param>
		/// <param name="throwOnError">
		///   True, требуется генерировать исключение, если свойство не будет обнаружено в исходном объекте;
		///   False, если исключение надо погасить.
		/// </param>
		/// <returns> Тип целевого свойства. </returns>
		public static Type GetPropertyType(
		  object obj, Type objType, string targetPropertyName,
		  out PropertyInfo targetPropertyInfo, out object targetPropertyObj,
		  bool throwOnError)
		{
			targetPropertyInfo = null;
			targetPropertyObj = null;

			foreach (var c in targetPropertyName.Split('.'))
			{
				targetPropertyInfo =
				  new[] { objType }.Concat(objType.GetInterfaces())
					.Select(x => x.GetProperty(c))
					.SkipNull()
					.FirstOrDefault();

				if (targetPropertyInfo == null)
				{
					if (throwOnError)
						throw new ArgumentException(targetPropertyName);

					return null;
				}

				objType = targetPropertyInfo.PropertyType;
				targetPropertyObj = obj;
				obj = targetPropertyInfo.GetValue(obj);

				objType = AccurateTypes.Aggregate(objType, (current, method) => method(obj, current));
			}

			return objType;
		}


		/// <summary>
		/// Представляет метод, производящий уточнение типа объекта на основании базового типа.
		/// </summary>
		public delegate Type AccurateType(object obj, Type type);

		/// <summary>
		/// Добавляет метод типа <see cref="AccurateType"/> в список методов производящих уточнение типа объекта, использующихся в работах методов данного класса.
		/// </summary>
		public static void AddAccurateTypeMethod(AccurateType method)
		{
			AccurateTypes.Add(method);
		}

		/// <summary>
		/// Содержит список методов производящих уточнение типа объекта.
		/// </summary>
		private static readonly List<AccurateType> AccurateTypes = new List<AccurateType>();
	}
}