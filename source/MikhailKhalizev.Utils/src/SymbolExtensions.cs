using System;
using System.Linq.Expressions;
using System.Reflection;

namespace MikhailKhalizev.Utils
{
    // http://blog.functionalfun.net/2009/10/getting-methodinfo-of-generic-method.html
    public static class SymbolExtensions
    {
        /// <summary>
        /// Given a lambda expression that calls a method, returns the method info.
        /// </summary>
        /// <param name="expression">The expression.</param>
        public static MethodInfo GetMethodInfo(Expression<Action> expression) =>
            GetMethodInfo((LambdaExpression)expression);

        /// <summary>
        /// Given a lambda expression that calls a method, returns the method info.
        /// </summary>
        /// <param name="expression">The expression.</param>
        public static MethodInfo GetMethodInfo<T>(Expression<Action<T>> expression) =>
            GetMethodInfo((LambdaExpression)expression);

        /// <summary>
        /// Given a lambda expression that calls a method, returns the method info.
        /// </summary>
        /// <param name="expression">The expression.</param>
        public static MethodInfo GetMethodInfo<T, TResult>(Expression<Func<T, TResult>> expression) =>
            GetMethodInfo((LambdaExpression)expression);

        /// <summary>
        /// Given a lambda expression that calls a method, returns the method info.
        /// </summary>
        /// <param name="expression">The expression.</param>
        public static MethodInfo GetMethodInfo(LambdaExpression expression)
        {
            var outermostExpression = expression.Body as MethodCallExpression;
            if (outermostExpression == null)
                throw new ArgumentException("Invalid Expression. Expression should consist of a Method call only.");
            return outermostExpression.Method;
        }
    }
}