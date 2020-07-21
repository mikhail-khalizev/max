using System;
using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers;
using MikhailKhalizev.Processor.x86.Decoder;
using MikhailKhalizev.Processor.x86.Utils;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class Block
    {
        public List<InputValue> Input { get; } = new List<InputValue>();
        public Value NextBlockIndex { get; set; }
        public List<Block> NextBlocks { get; set; }

        private readonly Dictionary<int /* register index */, (RegisterInfo RegisterInfo, Value Value)> _registers =
            new Dictionary<int, (RegisterInfo, Value)>();

        private readonly Dictionary<Value /* address */, MemoryValue> _memory = new Dictionary<Value, MemoryValue>();

        // TODO Union input registers with the same index.

        public Value GetRegister(RegisterInfo registerInfo)
        {
            if (!_registers.TryGetValue(registerInfo.Index, out var item))
            {
                var inputValue = new InputValue(new RegisterValue(registerInfo));
                Input.Add(inputValue);

                _registers[registerInfo.Index] = (registerInfo, inputValue);
                return inputValue;
            }

            if (item.RegisterInfo == registerInfo)
                return item.Value;

            return Operations.Combine(
                registerInfo.LengthInBits,
                item.Value,
                item.RegisterInfo.BitOffset - registerInfo.BitOffset,
                item.RegisterInfo.BitMask >> registerInfo.BitOffset);
        }

        public void SetRegister(RegisterInfo registerInfo, Value value)
        {
            if (!_registers.TryGetValue(registerInfo.Index, out var item))
            {
                _registers[registerInfo.Index] = (registerInfo, value);
                return;
            }

            if (item.RegisterInfo == registerInfo)
            {
                _registers[registerInfo.Index] = (registerInfo, value);
                return;
            }

            var combination = Operations.Combine(
                Math.Max(
                    item.RegisterInfo.LengthInBits + item.RegisterInfo.BitOffset,
                    registerInfo.LengthInBits + registerInfo.BitOffset),
                (item.Value, item.RegisterInfo.BitOffset, item.RegisterInfo.BitMask),
                (value, registerInfo.BitOffset, registerInfo.BitMask));

            var resultRegisterInfo = new[] { registerInfo, item.RegisterInfo }
                .OrderBy(x => x.LengthInBits)
                .Concat(
                    RegisterInfo.Registers
                        .Where(x => x.Index == registerInfo.Index)
                        .OrderBy(x => x.LengthInBits)
                )
                .Where(x => x.BitOffset == 0)
                .First(x => combination.LengthInBits <= x.LengthInBits);

            _registers[registerInfo.Index] = (resultRegisterInfo, combination);
        }


        public void UpdateFlags(EflagsMaskEnum flags, bool value)
        {
            UpdateFlags(flags, (Value) value);
        }

        public void UpdateFlags(EflagsMaskEnum flags, Value value)
        {
            UpdateFlags((flags, value));
        }

        public void UpdateFlags(params (EflagsMaskEnum flags, Value value)[] items)
        {
            UpdateFlags(items.AsEnumerable());
        }

        public void UpdateFlags(IEnumerable<(EflagsMaskEnum flags, Value value)> items)
        {
            var eflagsRegister = RegisterInfo.Eflags;
            var eflagsValue = GetRegister(eflagsRegister);

            var result = Enumerable.Empty<(Value Value, int Offset, int Mask)>()
                .Append((eflagsValue, 0, BinaryHelper.MaskInt32(eflagsValue.LengthInBits)))
                .Concat(
                    items.Select(
                        x =>
                        {
                            var (flags, value) = x;
                            if (flags == 0)
                                throw new ArgumentException($"{nameof(flags)} is 0.");

                            var offset = 0;
                            while (((int) flags & (1 << offset)) == 0)
                                offset++;

                            return (value, offset, 1 << offset);
                        }));

            var newEflagsValue = Operations.Combine(eflagsValue.LengthInBits, result);
            SetRegister(eflagsRegister, newEflagsValue);
        }


        public Value GetMemory(RegisterInfo segment, Value address, int lengthInBits)
        {
            // TODO

            var v = new MemoryValue(segment, address, lengthInBits);
            // Input.Add(v);
            return v;
        }

        public void SetMemory(RegisterInfo segment, Value address, Value value)
        {
            // TODO

            _memory[address] = new MemoryValue(segment, address, value.LengthInBits);
        }
    }
}