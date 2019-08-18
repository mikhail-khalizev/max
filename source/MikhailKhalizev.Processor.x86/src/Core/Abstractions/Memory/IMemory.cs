using System;
using MikhailKhalizev.Processor.x86.Core.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.Core.Abstractions.Memory
{
    public interface IMemory
    {
        /// <summary>
        /// Ram size in bytes.
        /// </summary>
        int Length { get; }

        // Для проверки доступности памяти, minSize может быть 0.
        // В этом случае, если память доступна, возвращенный буфер должен содержать как минимум один байт.
        // И буфер должен быть пуст, если память не доступна и вызов метода с minSize больше 0 завершится исключением.
        ArraySegment<byte> GetMinSize(Address address, int minSize);
    }
}