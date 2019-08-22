using System;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo
{
    public class MemoryFromMethodInfo : IMemory
    {
        public MethodInfoDto MethodInfo { get; }

        public MemoryFromMethodInfo(MethodInfoDto methodInfo)
        {
            MethodInfo = methodInfo;
        }

        /// <inheritdoc />
        public int Length => throw new NotSupportedException();

        /// <inheritdoc />
        public ArraySegment<byte> GetMinSize(Address address, int minSize)
        {
            var interval = Interval.From(MethodInfo.Address, MethodInfo.Address + MethodInfo.RawBytes.Length);
            if (interval.Contains(address))
                return new ArraySegment<byte>(MethodInfo.RawBytes).Slice(address - MethodInfo.Address);

            if (MethodInfo.ExtraRaw != null)
                foreach (var (eAddress, eHex) in MethodInfo.ExtraRaw)
                {
                    interval = Interval.From(eAddress, eAddress + eHex.Length / 2);
                    if (interval.Contains(address))
                        return new ArraySegment<byte>(HexHelper.ToBytes(eHex)).Slice(address - eAddress);
                }

            throw new NotSupportedException($"Access to {address} in '{MethodInfo.Id} is not supported.");
        }
    }
}