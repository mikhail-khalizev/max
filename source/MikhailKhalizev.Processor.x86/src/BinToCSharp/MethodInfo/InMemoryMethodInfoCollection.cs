using System;
using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Processor.x86.Utils;
using SharpDisasm;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo
{
    public class InMemoryMethodInfoCollection : IMethodInfoCollection
    {
        private readonly List<MethodInfoDto> _methods = new List<MethodInfoDto>();

        /// <inheritdoc />
        public void Add(MethodInfoDto method)
        {
            var exists = _methods.Any(
                x =>
                    x.Id == method.Id ||
                    (x.Address == method.Address && x.Mode == method.Mode && x.RawBytes.SequenceEqual(method.RawBytes)));

            if (exists)
                throw new InvalidOperationException("Duplicated item");

            _methods.Add(method);
        }

        /// <inheritdoc />
        public MethodInfoDto GetForMethod(ArchitectureMode mode, byte[] rawBytes, Address address)
        {
            return _methods.FirstOrDefault(x => x.Address == address && x.Mode == mode && x.RawBytes.SequenceEqual(rawBytes));
        }

        /// <inheritdoc />
        public void AddExtraRaw(MethodInfoDto methodInfo, Address extraBeginAddress, byte[] extraBytes)
        {
            var extraInterval = Interval.From(extraBeginAddress, extraBeginAddress + extraBytes.Length);
            var methodInterval = Interval.From(methodInfo.Address, methodInfo.Address + methodInfo.RawBytes.Length);

            var exists = Enumerable.Empty<Interval<Address, Address.Comparer>>().Append(methodInterval);
            if (methodInfo.ExtraRaw != null)
                exists = exists.Concat(methodInfo.ExtraRaw.Select(x => Interval.From(x.Key, x.Key + x.Value.Length / 2)));

            foreach (var interval in extraInterval.Subtract(exists).SelectMany(x => x.Split(methodInterval)))
            {
                if (methodInfo.ExtraRaw == null)
                    methodInfo.ExtraRaw = new Dictionary<Address, string>();

                var raw = new ArraySegment<byte>(extraBytes).Slice(interval.Begin - extraBeginAddress, interval.End - interval.Begin);
                var rawString = HexHelper.ToHexWithoutPrefix(raw);

                methodInfo.ExtraRaw[interval.Begin] = rawString;
            }
        }
    }
}