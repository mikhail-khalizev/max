using System;

namespace MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Memory
{
    public interface IRandomAccess
    {
        // Для проверки доступности памяти, minSize может быть 0.
        // В этом случае, если память доступна, возвращенный буфер должен содержать как минимум один байт.
        // И буфер должен быть пуст, если память не доступна и вызов метода с minSize больше 0 завершится исключением.
        Span<byte> GetMinSize(Address address, int minSize);
    }
}