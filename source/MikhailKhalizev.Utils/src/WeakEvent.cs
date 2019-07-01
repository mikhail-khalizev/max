using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace MikhailKhalizev.Utils
{
    /* http://habrahabr.ru/post/89529/ */

    /// <summary>
    /// Представляет слабое событие, которое укаывает на методы, но позволяет сборщику мусора
    /// удалять объекты, методы экземпляра класса которого подписаны на получение данного события.
    /// </summary>
    /// <typeparam name="T">Тип метода обработки события.</typeparam>
    /// <remarks>
    /// See FastSmartWeakEvent in http://www.codeproject.com/KB/cs/WeakEvents.aspx. MIT licence.
    /// </remarks>
    public sealed class WeakEvent<T>
        where T : class
    {
        /// <summary>
        /// Содержит список подписчиков на события.
        /// </summary>
        private readonly List<EventEntry> _eventEntries = new List<EventEntry>();

        /// <summary>
        /// Инициализирует класс <see cref="WeakEvent{T}"/>.
        /// </summary>
        static WeakEvent()
        {
            if (!typeof(T).IsSubclassOf(typeof(Delegate)))
                throw new ArgumentException("T must be a delegate type.");

            var invoke = typeof(T).GetMethod("Invoke");
            if (invoke == null || invoke.GetParameters().Length != 2)
                throw new ArgumentException("T must be a delegate type taking 2 parameters.");

            var senderParameter = invoke.GetParameters()[0];
            if (senderParameter.ParameterType != typeof(object))
                throw new ArgumentException("The first delegate parameter must be of type 'object'.");

            var argsParameter = invoke.GetParameters()[1];
            if (argsParameter.ParameterType != typeof(EventArgs) &&
                    !argsParameter.ParameterType.IsSubclassOf(typeof(EventArgs)))
                throw new ArgumentException("The second delegate parameter must be derived from type 'EventArgs'.");

            if (invoke.ReturnType != typeof(void))
                throw new ArgumentException("The delegate return type must be void.");
        }

        /// <summary>
        /// Подписывает метод на получение события.
        /// </summary>
        /// <param name="eh">Метод, который будет вызываться при наступлении события.</param>
        /// <remarks>Потокобезопасный.</remarks>
        public void Add(T eh)
        {
            if (eh == null)
                return;

            var d = (Delegate)(object)eh;
            var target = d.Target != null ? new WeakReference(d.Target) : null;
            var entry = new EventEntry(WeakEventForwarderProvider.GetForwarder(d.Method), d.Method, target);

            lock (_eventEntries)
            {
                if (_eventEntries.Count == _eventEntries.Capacity)
                    RemoveDeadEntries();

                _eventEntries.Add(entry);
            }
        }

        /// <summary>
        /// Удаляет из подписки методы экземпляра класса, сам экземпляра класса которого был удалён сборщиком мусора.
        /// </summary>
        /// <remarks>Потокобезопасный.</remarks>
        private void RemoveDeadEntries()
        {
            lock (_eventEntries)
                _eventEntries.RemoveAll(ee => ee.TargetReference != null && !ee.TargetReference.IsAlive);
        }

        /// <summary>
        /// Отписываем метод от получения события.
        /// </summary>
        /// <param name="eh">Метод, который вызывался при наступлении события.</param>
        /// <remarks>Потокобезопасный.</remarks>
        public void Remove(T eh)
        {
            if (eh == null)
                return;

            var d = (Delegate)(object)eh;

            lock (_eventEntries)
                for (var i = _eventEntries.Count - 1; i >= 0; i--)
                {
                    var entry = _eventEntries[i];
                    if (entry.TargetReference != null)
                    {
                        var target = entry.TargetReference.Target;
                        if (target == null)
                        {
                            _eventEntries.RemoveAt(i);
                        }
                        else if (target == d.Target && entry.TargetMethod == d.Method)
                        {
                            _eventEntries.RemoveAt(i);
                            break;
                        }
                    }
                    else
                    {
                        if (d.Target == null && entry.TargetMethod == d.Method)
                        {
                            _eventEntries.RemoveAt(i);
                            break;
                        }
                    }
                }
        }

        /// <summary>
        /// Вызывает наступления события.
        /// </summary>
        /// <param name="sender">Источник возникновения события.</param>
        /// <param name="e">Данные о событии.</param>
        /// <remarks>Потокобезопасный.</remarks>
        public void Raise(object sender, EventArgs e)
        {
            List<EventEntry> events;
            lock (_eventEntries)
                events = _eventEntries.ToList();

            var needsCleanup = false;
            foreach (var ee in events)
                needsCleanup |= ee.Forwarder(ee.TargetReference, sender, e);

            if (needsCleanup)
                RemoveDeadEntries();
        }

        /// <summary>
        /// Возвращает true, если у данного события есть подписчики; иначе - false.
        /// </summary>
        /// <returns>true, если у данного события есть подписчики; иначе - false.</returns>
        /// <remarks>Потокобезопасный.</remarks>
        public bool SafeAny()
        {
            lock (_eventEntries)
                return _eventEntries.SkipNull().Any();
        }

        #region Nested type: EventEntry

        /// <summary>
        /// Представляет данные об одном подписчике на событие.
        /// </summary>
        private struct EventEntry
        {
            /// <summary>
            /// Методов уведомления подписчика о наступлении события.
            /// </summary>
            public readonly WeakEventForwarderProvider.ForwarderDelegate Forwarder;

            /// <summary>
            /// Информация о целевом методе, вызов которого должен происходить при наступлении события.
            /// </summary>
            public readonly MethodInfo TargetMethod;

            /// <summary>
            /// Слабая ссылка на экзепляр класса, метод которого подписан на событие.
            /// Если на событие подписан статический метод, содержит null.
            /// </summary>
            public readonly WeakReference TargetReference;

            /// <summary>
            /// Инициализирует новый экземпляр класса <see cref="EventEntry"/>.
            /// </summary>
            /// <param name="forwarder"></param>
            /// <param name="targetMethod">Информация о целевом методе, вызов которого должен происходить при наступлении события.</param>
            /// <param name="targetReference">
            /// Слабая ссылка на экзепляр класса, метод которого подписан на событие.
            /// Если на событие подписан статический метод, null.
            /// </param>
            public EventEntry(
                WeakEventForwarderProvider.ForwarderDelegate forwarder,
                MethodInfo targetMethod,
                WeakReference targetReference)
            {
                Forwarder = forwarder;
                TargetMethod = targetMethod;
                TargetReference = targetReference;
            }
        }

        #endregion
    }

    /// <summary>
    /// Предоставляет механизм создания методов уведомления подписчиков о наступлении события.
    /// </summary>
    internal static class WeakEventForwarderProvider
    {
        /// <summary>
        /// Типы аргуметов делегата <see cref="ForwarderDelegate"/>.
        /// </summary>
        private static readonly Type[] ForwarderParameters =
        {
            typeof(WeakReference),
            typeof(object),
            typeof(EventArgs)
        };

        /// <summary>
        /// Кэш методов уведомления подписчиков о событии.
        /// </summary>
        private static readonly Dictionary<MethodInfo, ForwarderDelegate> Forwarders =
            new Dictionary<MethodInfo, ForwarderDelegate>();

        /// <summary>
        /// Информация о методе получения значения стойства Target класса WeakReference.
        /// </summary>
        private static readonly MethodInfo GetTarget = typeof(WeakReference).GetMethod("get_Target");

        /// <summary>
        /// Возвращает метод уведомления подписчика о возникновении события.
        /// </summary>
        /// <param name="method">Целевой метод, предоставляемый подписчиком события.</param>
        /// <returns>Метод уведомления подписчика о возникновении события.</returns>
        internal static ForwarderDelegate GetForwarder(MethodInfo method)
        {
            lock (Forwarders)
            {
                ForwarderDelegate d;
                if (Forwarders.TryGetValue(method, out d))
                    return d;
            }

            if (method.DeclaringType?.GetCustomAttributes(typeof(CompilerGeneratedAttribute), false).Length != 0)
                throw new ArgumentException("Cannot create weak event to anonymous method with closure.");

            if (GetTarget == null)
                throw new InvalidOperationException();

            var dm = new DynamicMethod("WeakEvent", typeof(bool), ForwarderParameters, method.DeclaringType);
            var il = dm.GetILGenerator();

            if (!method.IsStatic)
            {
                il.Emit(OpCodes.Ldarg_0);
                il.EmitCall(OpCodes.Callvirt, GetTarget, null);
                il.Emit(OpCodes.Dup);

                var label = il.DefineLabel();
                il.Emit(OpCodes.Brtrue, label);
                il.Emit(OpCodes.Pop);
                il.Emit(OpCodes.Ldc_I4_1);
                il.Emit(OpCodes.Ret);
                il.MarkLabel(label);
            }
            il.Emit(OpCodes.Ldarg_1);
            il.Emit(OpCodes.Ldarg_2);
            il.EmitCall(OpCodes.Call, method, null);
            il.Emit(OpCodes.Ldc_I4_0);
            il.Emit(OpCodes.Ret);

            var fd = (ForwarderDelegate)dm.CreateDelegate(typeof(ForwarderDelegate));

            lock (Forwarders)
                Forwarders[method] = fd;

            return fd;
        }

        #region Nested type: ForwarderDelegate

        /// <summary>
        /// Представляет метод уведомления подписчика о возникновении события.
        /// </summary>
        /// <param name="wr">
        /// Слабая ссылка на экзепляр класса, метод которого подписан на событие.
        /// Если на событие подписан статический метод, null.
        /// </param>
        /// <param name="sender">Источник возникновения события.</param>
        /// <param name="e">Данные о событии.</param>
        /// <returns>true, если экземпляр класса, содержащий целевой метод, был удалён сборщиком мусора; иначе false.</returns>
        internal delegate bool ForwarderDelegate(
            WeakReference wr,
            object sender,
            EventArgs e);

        #endregion
    }
}
