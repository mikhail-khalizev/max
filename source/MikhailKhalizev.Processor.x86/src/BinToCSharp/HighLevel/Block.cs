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
        // public Expression NextBlockIndex { get; set; }
        // public List<Block> NextBlocks { get; set; }

        private readonly Dictionary<int /* register index */, (RegisterInfo RegisterInfo, Expression Value)> _registers =
            new Dictionary<int, (RegisterInfo, Expression)>();

        private readonly Dictionary<Expression /* address */, MemoryExpression> _memory = new Dictionary<Expression, MemoryExpression>();


        public Expression GetRegister(RegisterInfo registerInfo)
        {
            if (!_registers.TryGetValue(registerInfo.Index, out var item))
            {
                var register = new RegisterExpression(registerInfo);
                _registers[registerInfo.Index] = (registerInfo, register);
                return register;
            }

            if (item.RegisterInfo == registerInfo)
                return item.Value;

            return Operations.Combine(
                registerInfo.LengthInBits,
                item.Value,
                item.RegisterInfo.BitOffset - registerInfo.BitOffset,
                item.RegisterInfo.BitMask >> registerInfo.BitOffset);
        }

        public void SetRegister(RegisterInfo registerInfo, Expression expression)
        {
            if (!_registers.TryGetValue(registerInfo.Index, out var item))
            {
                _registers[registerInfo.Index] = (registerInfo, expression);
                return;
            }

            if (item.RegisterInfo == registerInfo)
            {
                _registers[registerInfo.Index] = (registerInfo, expression);
                return;
            }

            var combination = Operations.Combine(
                Math.Max(
                    item.RegisterInfo.LengthInBits + item.RegisterInfo.BitOffset,
                    registerInfo.LengthInBits + registerInfo.BitOffset),
                (item.Value, item.RegisterInfo.BitOffset, item.RegisterInfo.BitMask),
                (expression, registerInfo.BitOffset, registerInfo.BitMask));

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
            UpdateFlags(flags, (Expression) value);
        }

        public void UpdateFlags(EflagsMaskEnum flags, Expression expression)
        {
            UpdateFlags((flags, expression));
        }

        public void UpdateFlags(params (EflagsMaskEnum flags, Expression value)[] items)
        {
            UpdateFlags(items.AsEnumerable());
        }

        public void UpdateFlags(IEnumerable<(EflagsMaskEnum flags, Expression value)> items)
        {
            var eflagsRegister = RegisterInfo.Eflags;
            var eflagsValue = GetRegister(eflagsRegister);

            var result = Enumerable.Empty<(Expression Value, int Offset, int Mask)>()
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


        public Expression GetMemory(RegisterInfo segment, Expression address, int lengthInBits)
        {
            // TODO

            var memory = new MemoryExpression(segment, address, lengthInBits);
            return memory;
        }

        public void SetMemory(RegisterInfo segment, Expression address, Expression expression)
        {
            // TODO

            _memory[address] = new MemoryExpression(segment, address, expression.LengthInBits);
        }
    }
}