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

        private readonly Dictionary<int /* index */, List<(RegisterInfo RegisterInfo, Value Value)>> _registers =new Dictionary<int, List<(RegisterInfo, Value)>>();


        public Value GetRegister(RegisterInfo registerInfo)
        {
            if (!_registers.TryGetValue(registerInfo.Index, out var items))
            {
                var inputValue = new InputValue(new RegisterValue(registerInfo));
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


        public Value GetMemory(Value address) => throw new NotImplementedException();

        public void SetMemory(Value address, Value value)
        {
            throw new NotImplementedException();
        }
    }
}