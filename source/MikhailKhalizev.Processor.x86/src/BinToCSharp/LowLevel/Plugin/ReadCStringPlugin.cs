using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using MikhailKhalizev.Processor.x86.Core.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Utils;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Plugin
{
    public class ReadCStringPlugin : PluginBase
    {
        public Interval<Address> StringArea { get; set; }
        private HashSet<StringDefinition> _allStringDefinitions;

        private bool _anyChange;
        private readonly HashSet<string> _myNames = new HashSet<string>();
        private readonly Dictionary<string /* Value */, string /* PropertyName */> _myStrings = new Dictionary<string, string>();
        private readonly Dictionary<StringDefinition, (string ProperyName, string StringPropertyName)> _myStringDefinitions =
            new Dictionary<StringDefinition, (string ProperyName, string StringPropertyName)>();


        /// <inheritdoc />
        public ReadCStringPlugin(Engine engine)
            : base(engine)
        {
            Engine.InstructionDecoded += EngineOnInstructionDecoded;
            Engine.OnSave += OnSave;

            InitializeIfNeed();
        }

        private void InitializeIfNeed()
        {
            if (_allStringDefinitions != null)
                return;
            _allStringDefinitions = new HashSet<StringDefinition>();
            
            Type myType = null;
            
            foreach (var propertyInfo in Engine.DefinitionCollection.GetAllStringDefinition())
            {
                var sd = (StringDefinition) propertyInfo.GetValue(null);
                _allStringDefinitions.Add(sd);

                if (myType == null && propertyInfo.DeclaringType.Name == Engine.Configuration.StringDefinitionsClassName)
                    myType = propertyInfo.DeclaringType;
            }

            if (myType != null)
            {
                var stringDefinitions = new List<(string PropertyName, StringDefinition Value)>();

                foreach (var propertyInfo in myType.GetProperties(BindingFlags.Public | BindingFlags.Static))
                {
                    _myNames.Add(propertyInfo.Name);
                    if (typeof(string).IsAssignableFrom(propertyInfo.PropertyType))
                    {
                        var value = (string) propertyInfo.GetValue(null);
                        _myStrings[value] = propertyInfo.Name;
                    }
                    else if (typeof(StringDefinition).IsAssignableFrom(propertyInfo.PropertyType))
                    {
                        var value = (StringDefinition) propertyInfo.GetValue(null);
                        stringDefinitions.Add((propertyInfo.Name, value));
                    }
                }

                foreach (var (propertyName, sd) in stringDefinitions)
                {
                    var stringPropertyName = GetOrAddStringPropertyName(propertyName, sd);
                    _myStringDefinitions[sd] = (propertyName, stringPropertyName);
                }
            }
        }

        private void EngineOnInstructionDecoded(object sender, CSharpInstruction cmd)
        {
            for (var i = 0; i < cmd.Operands.Count; i++)
            {
                if (cmd.Operands[i].type != ud_type.UD_OP_IMM || !StringArea.Contains(cmd.Operands[i].lval.uqword))
                    continue;

                InitializeIfNeed();

                var address = (Address)cmd.Operands[i].lval.uqword;
                var str = Engine.Memory.ReadCString(address);
                var sd = new StringDefinition(address, str);
                if (_allStringDefinitions.Contains(sd))
                    continue;

                _anyChange = true;
                _allStringDefinitions.Add(sd);
                var name = GetPropertyName(str);
                var propertyName = GetUniqueName(name);
                _myStringDefinitions[sd] = (propertyName, GetOrAddStringPropertyName(name, sd));

                Engine.DefinitionCollection.AddDefinitionsClass(
                    new MyType(Engine.Configuration.StringDefinitionsClassName, propertyName, sd));

                //cmd.Comments.Add($"\"{escapedStr}\"");
            }
        }

        private void OnSave(object sender, EventArgs e)
        {
            if (!_anyChange)
                return;
            
            NonBlockingConsole.WriteLine($"Save {Engine.Configuration.StringDefinitionsClassName}");

            var list = new List<string>
            {
                "using MikhailKhalizev.Processor.x86;",
                "using MikhailKhalizev.Processor.x86.BinToCSharp;",
                "",
                $"namespace {Engine.Configuration.Namespace}",
                "{",
                $"    public partial class {Engine.Configuration.StringDefinitionsClassName} : IDefinitionGroup",
                "    {",
                "        #region Strings",
                ""
            };

            foreach (var pair in _myStrings.OrderBy(x => x.Value))
                list.Add($"        public static string {pair.Value} {{ get; }} = \"{EscapeString(pair.Key)}\";");
            
            list.Add("");
            list.Add("        #endregion");
            list.Add("");
            list.Add("        #region StringDefinition");
            list.Add("");
            
            foreach (var pair in _myStringDefinitions.OrderBy(x => x.Key.Address))
            {
                var str = "        " +
                    $"public static StringDefinition {pair.Value.ProperyName} {{ get; }} = " +
                    $"new StringDefinition({pair.Key.Address}, {pair.Value.StringPropertyName});";

                list.Add(str);
            }

            list.Add("");
            list.Add("        #endregion");
            list.Add("    }");
            list.Add("}");

            File.WriteAllLines(
                Path.Combine(Engine.Configuration.CodeOutput, Engine.Configuration.StringDefinitionsClassName + ".cs"),
                list);
        }
        

        private string GetOrAddStringPropertyName(string propertyName, StringDefinition sd)
        {
            if (_myStrings.TryGetValue(sd.String, out var stringPropertyName))
                return stringPropertyName;
            
            stringPropertyName = GetUniqueName(propertyName + "String");
            _myStrings[sd.String] = stringPropertyName;

            return stringPropertyName;
        }
        
        public static string GetPropertyName(string name)
        {
            if (name == "")
                return "Empty";

            name = name
                .Replace("!=", " Not Equal ")
                .Replace("==", " Equal ")
                .Replace("<=", " Less Or Equal ")
                .Replace(">=", " Greater Or Equal ")
                .Replace("->", " ")
                .Replace(">", " Greater ")
                .Replace("<", " Less ");

            var parts = new List<string>();
            var index = 0;
            while (index < name.Length)
            {
                var len = name.Skip(index).TakeWhile(IsName).Count();

                var part = name.Substring(index, len);
                if (0 < part.Length)
                    parts.Add(part);

                index += len;
                if (name.Length <= index)
                    break;

                index += name.Skip(index).TakeWhile(x => !IsName(x)).Count();
            }

            var result = string.Concat(parts.Select(x => char.ToUpperInvariant(x[0]) + x.Substring(1).ToLowerInvariant()));
            if (128 < result.Length)
                result = result.Substring(0, 128); // Limit string size.

            if (result == "")
                result = "Control";
            else if (char.IsDigit(result[0]))
                result = "_" + result;
            return result;
        }

        private static bool IsName(char c) => char.IsLetterOrDigit(c);
        
        private string GetUniqueName(string value)
        {
            var num = 2;
            var name = value;
            while (!_myNames.Add(name))
                name = value + num++;
            return name;
        }
        
        private static string EscapeString(string nativeStr)
        {
            return nativeStr
                .Replace("\\", "\\\\")
                .Replace("\"", "\\\"")
                .Replace("\t", "\\t")
                .Replace("\n", "\\n")
                .Replace("\r", "\\r");
        }


        private class MyType : Type
        {
            public MyType(string typeName, string propertyName, StringDefinition sd)
            {
                Name = typeName;
                _propertyInfos = new[] { new MyPropertyInfo(this, propertyName, sd) };
            }

            /// <inheritdoc />
            public override object[] GetCustomAttributes(bool inherit)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override object[] GetCustomAttributes(Type attributeType, bool inherit)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override bool IsDefined(Type attributeType, bool inherit)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override Module Module { get; }

            /// <inheritdoc />
            public override string Namespace { get; }

            /// <inheritdoc />
            public override string Name { get; }

            /// <inheritdoc />
            protected override TypeAttributes GetAttributeFlagsImpl()
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            protected override ConstructorInfo GetConstructorImpl(
                BindingFlags bindingAttr,
                Binder binder,
                CallingConventions callConvention,
                Type[] types,
                ParameterModifier[] modifiers)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override Type GetElementType()
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override EventInfo[] GetEvents(BindingFlags bindingAttr)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override FieldInfo GetField(string name, BindingFlags bindingAttr)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override FieldInfo[] GetFields(BindingFlags bindingAttr)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            protected override System.Reflection.MethodInfo GetMethodImpl(
                string name,
                BindingFlags bindingAttr,
                Binder binder,
                CallingConventions callConvention,
                Type[] types,
                ParameterModifier[] modifiers)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override System.Reflection.MethodInfo[] GetMethods(BindingFlags bindingAttr)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) => _propertyInfos;
            private PropertyInfo[] _propertyInfos;

            /// <inheritdoc />
            public override object InvokeMember(
                string name,
                BindingFlags invokeAttr,
                Binder binder,
                object target,
                object[] args,
                ParameterModifier[] modifiers,
                CultureInfo culture,
                string[] namedParameters)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override Type UnderlyingSystemType { get; }

            /// <inheritdoc />
            protected override bool IsArrayImpl()
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            protected override bool IsByRefImpl()
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            protected override bool IsCOMObjectImpl()
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            protected override bool IsPointerImpl()
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            protected override bool IsPrimitiveImpl()
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override Assembly Assembly { get; }

            /// <inheritdoc />
            public override string AssemblyQualifiedName { get; }

            /// <inheritdoc />
            public override Type BaseType { get; }

            /// <inheritdoc />
            public override string FullName { get; }

            /// <inheritdoc />
            public override Guid GUID { get; }

            /// <inheritdoc />
            protected override PropertyInfo GetPropertyImpl(
                string name,
                BindingFlags bindingAttr,
                Binder binder,
                Type returnType,
                Type[] types,
                ParameterModifier[] modifiers)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            protected override bool HasElementTypeImpl()
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override Type GetNestedType(string name, BindingFlags bindingAttr)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override Type[] GetNestedTypes(BindingFlags bindingAttr)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override Type GetInterface(string name, bool ignoreCase)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override Type[] GetInterfaces()
            {
                throw new NotImplementedException();
            }
        }

        private class MyPropertyInfo : PropertyInfo
        {
            public MyPropertyInfo(Type declaringType, string name, StringDefinition value)
            {
                DeclaringType = declaringType;
                Name = name;
                Value = value;
            }

            /// <inheritdoc />
            public override object[] GetCustomAttributes(bool inherit)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override object[] GetCustomAttributes(Type attributeType, bool inherit)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override bool IsDefined(Type attributeType, bool inherit)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override Type DeclaringType { get; }

            /// <inheritdoc />
            public override string Name { get; }

            public StringDefinition Value { get; }

            /// <inheritdoc />
            public override Type ReflectedType { get; }

            /// <inheritdoc />
            public override System.Reflection.MethodInfo[] GetAccessors(bool nonPublic)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override System.Reflection.MethodInfo GetGetMethod(bool nonPublic)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override ParameterInfo[] GetIndexParameters()
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override System.Reflection.MethodInfo GetSetMethod(bool nonPublic)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) => Value;

            /// <inheritdoc />
            public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
            {
                throw new NotImplementedException();
            }

            /// <inheritdoc />
            public override PropertyAttributes Attributes { get; }

            /// <inheritdoc />
            public override bool CanRead { get; }

            /// <inheritdoc />
            public override bool CanWrite { get; }

            /// <inheritdoc />
            public override Type PropertyType { get; } = typeof(StringDefinition);
        }
    }
}