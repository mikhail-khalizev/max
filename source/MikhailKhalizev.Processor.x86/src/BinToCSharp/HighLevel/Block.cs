using System;
using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Processor.x86.Decoder;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class Block
    {
        public List<InputValue> Input { get; } = new List<InputValue>();
        public Value NextBlockIndex { get; set; }
        public List<Block> NextBlocks { get; set; }

        private readonly Dictionary<int /* register index */, List<(RegisterInfo RegisterInfo, Value Value)>> _registers = new Dictionary<int, List<(RegisterInfo, Value)>>();
        private readonly Dictionary<Value /* address */, MemoryValue> _memory = new Dictionary<Value, MemoryValue>();

        public Value GetRegister(RegisterInfo registerInfo)
        {
            if (!_registers.TryGetValue(registerInfo.Index, out var items))
            {
                var inputValue = new InputValue(new RegisterValue(registerInfo));
                Input.Add(inputValue);

                _registers[registerInfo.Index] = new List<(RegisterInfo, Value)> { (registerInfo, inputValue) };
                return inputValue;
            }

            if (items.Count == 1 && items[0].RegisterInfo == registerInfo)
                return items[0].Value;

            throw new NotImplementedException(
                $"RegisterInfo = {registerInfo}, " +
                $"Current registers = {string.Join(", ", items.Select(x => x.RegisterInfo))}.");
        }

        public void SetRegister(RegisterInfo registerInfo, Value value)
        {
            if (!_registers.TryGetValue(registerInfo.Index, out var items))
            {
                _registers[registerInfo.Index] = new List<(RegisterInfo, Value)> { (registerInfo, value) };
                return;
            }

            if (items.Count == 1 && items[0].RegisterInfo == registerInfo)
            {
                items[0] = (registerInfo, value);
                return;
            }
            
            throw new NotImplementedException(
                $"RegisterInfo = {registerInfo}, " +
                $"Current registers = {string.Join(", ", items.Select(x => x.RegisterInfo))}.");
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