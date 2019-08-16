using System;
using System.Runtime.InteropServices;
using MikhailKhalizev.Processor.x86.Core.Abstractions;
using MikhailKhalizev.Processor.x86.Core.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Core.Abstractions.Registers;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.Core
{
    public class Memory : IMemory, IDisposable
    {
        public byte[] Ram { get; set; }

        public bool A20Gate { get; set; }

        private Processor Processor { get; }

        private const int cacheLineSize = 0x1000; // 4kb.

        /* Two pages cache. */
        private readonly byte[] cache = new byte[2 * cacheLineSize];
        private readonly bool[] cache_ena = new bool[2];
        private readonly uint[] cache_map = new uint[2];

        private GCHandle _handleRam;
        private GCHandle _handleCache;

        public Memory(Processor processor)
        {
            Processor = processor;
            Ram = new byte[32 * 1024 * 1024]; // 32Mb = 0x200_0000

            _handleRam = GCHandle.Alloc(Ram, GCHandleType.Pinned);
            _handleCache = GCHandle.Alloc(cache, GCHandleType.Pinned);
        }

        /// <inheritdoc />
        public int Length => Ram.Length;

        /// <summary>
        /// no seg, no pg - may return size more, then input size.
        /// </summary>
        public ArraySegment<byte> mem_phys_raw(Address address, int size)
        {
            var a = (uint) address;

            if (!A20Gate)
                a &= 0xf_ffff;

            var inputBegin = a;
            var inputEnd = (uint) (a + size); // TODO mask end address with 0xf_ffff and check.

            for (var i = 0; i < 2; i++)
            {
                if (!cache_ena[i])
                    continue;

                var cacheRegionBegin = cache_map[i];
                var cacheRegionEnd = cache_map[i] + cacheLineSize;

                if (inputEnd <= cacheRegionBegin || cacheRegionEnd <= inputBegin) // !IsIntersects
                    continue;

                if (cacheRegionBegin <= inputBegin && inputEnd <= cacheRegionEnd) // Contains
                {
                    // Запрашиваемый регион полностью содержится в кеше.
                    return new ArraySegment<byte>(
                        cache,
                        (int)(i * cacheLineSize + inputBegin - cacheRegionBegin),
                        (int)(cacheRegionEnd - inputBegin));
                }
                else
                {
                    // Выгружаем страницу обратно.
                    Array.Copy(cache, i * cacheLineSize, Ram, cache_map[i], cacheLineSize);
                    cache_ena[i] = false;
                }
            }
            
            var physMem = new ArraySegment<byte>(Ram);
            var ret = physMem.Slice((int)inputBegin);

            if (ret.Count < size)
                throw new InvalidOperationException("Доступна только часть памяти.");

            return ret;
        }

        /// <inheritdoc />
        public ArraySegment<byte> GetMinSize(Address address, int minSize)
        {
            if (!Processor.cr0.pg)
                return mem_phys_raw(address, minSize);

            var physAddresses = new uint[2]; // { current, current + page }
            physAddresses[0] = GetRamAddress(address);

            var firstPageBase = physAddresses[0] & ~0xfffu;
            var lastPageBase = (uint) ((physAddresses[0] + (minSize == 0 ? 0 : minSize - 1)) & ~0xfffu);

            // Одна страница.

            if (firstPageBase == lastPageBase)
            {
                // Ограничим размер страницей в которой находится область.
                return mem_phys_raw(physAddresses[0], minSize)
                    .Slice(0, (int) (lastPageBase + cacheLineSize - physAddresses[0]));
            }

            // Более двух страниц.

            if (firstPageBase + cacheLineSize != lastPageBase)
                throw new NotImplementedException();

            // Две страницы.

            // Страницы идут последовательно.

            physAddresses[1] = GetRamAddress(address + cacheLineSize);

            if (physAddresses[0] + cacheLineSize == physAddresses[1])
            {
                // Ограничим размер страницами в которых находится область.
                return mem_phys_raw(physAddresses[0], minSize)
                    .Slice(0, (int) (lastPageBase + cacheLineSize - physAddresses[0])); 
            }

            // Не идут последовательно -> загружаем в кэш.

            if (!A20Gate)
                throw new NotImplementedException();

            for (var i = 0; i < 2; i++)
            {
                // Страница кэша занята.
                if (cache_ena[i]) 
                {
                    // И не тем, чем нужно.
                    if ((cache_map[i] | 0xfff) != (physAddresses[i] | 0xfff))
                    {
                        // Выгружаем страницу обратно.
                        Array.Copy(cache, i * cacheLineSize, Ram, cache_map[i], cacheLineSize);
                        cache_ena[i] = false;
                    }
                }

                // Страница кэша пуста.
                if (!cache_ena[i]) 
                {
                    // Загружаем страницу.
                    cache_map[i] = physAddresses[i] & ~0xfffu;
                    Array.Copy(Ram, cache_map[i], cache, i * cacheLineSize, cacheLineSize);
                    cache_ena[i] = true;
                }
            }

            return new ArraySegment<byte>(
                cache,
                (int)(physAddresses[0] - cache_map[0]),
                (int)(2 * cacheLineSize - physAddresses[0] + cache_map[0]));
        }

        public Address GetRamAddress(Address address)
        {
            if (!Processor.cr0.pg)
                return address;

            var a = (uint) address;

            var pdi = a >> 22;
            var pti = (a >> 12) & 0x3ff;
            var off = a & 0xfff;

            while (true)
            {
                if (Processor.cr4.pae)
                    throw new NotImplementedException();

                var pde = mem_phys_raw((Processor.cr3.UInt32 & 0xffff_f000) + 4 * pdi, 4).GetUInt32();

                if (Processor.cr4.pse && (pde & PdeMask.ps) != 0) // 4Mb page
                    throw new NotImplementedException();

                if ((pde & PdeMask.p) == 0 /* || @todo reserved bits sets */)
                {
                    Processor.paging_fault(address);
                    continue; // repeat
                }

                var pte = mem_phys_raw((pde & 0xffff_f000) + 4 * pti, 4).GetUInt32();
                if ((pte & PteMask.p) == 0 /* || @todo reserved bits sets */)
                {
                    Processor.paging_fault(address);
                    continue; // repeat
                }

                return (pte & 0xffff_f000) + off;
            }
        }

        #region IDispose

        private void ReleaseUnmanagedResources()
        {
            _handleRam.Free();
            _handleCache.Free();
        }

        /// <inheritdoc />
        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }

        /// <inheritdoc />
        ~Memory()
        {
            ReleaseUnmanagedResources();
        }

        #endregion
    }
}   