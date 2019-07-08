using System;
using System.Linq;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Abstractions.Registers;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.FullSimulate
{
    public class Memory
    {
        public byte[] Ram { get; set; }

        public bool A20Gate { get; set; }

        private Processor Processor { get; }

        /* Two pages cache. */
        private readonly byte[] cache = new byte[0x2000];
        private readonly bool[] cache_ena = new bool[2];
        private readonly Address[] cache_map = new Address[2];

        public Memory(Processor processor)
        {
            Processor = processor;
            Ram = new byte[32 * 1024 * 1024]; // 32Mb = 0x200_0000
        }

        /// <summary>
        /// no seg, no pg - may return size more, then input size.
        /// </summary>
        public ArraySegment<byte> mem_phys_raw(Address address, int size)
        {
            var physMem = new ArraySegment<byte>(Ram);

            if (A20Gate == false)
                address &= 0xf_ffff;

            var input = new Interval<Address>(address, address + size);

            for (var i = 0; i < 2; i++)
            {
                if (cache_ena[i] == false)
                    continue;

                var cacheRegion = new Interval<Address>(cache_map[i], cache_map[i] + 0x1000);

                if (!cacheRegion.IsIntersects(input, false))
                    continue;

                if (cacheRegion.Contains(input))
                {
                    // Запрашиваемый регион полностью содержится в кеше.
                    return new ArraySegment<byte>(
                        cache,
                        i * 0x1000 + address - cache_map[i],
                        0x1000 - (address - cache_map[i]));
                }
                else
                {
                    // Выгружаем страницу обратно.
                    Array.Copy(cache, i * 0x1000, Ram, cache_map[i], 0x1000);
                    cache_ena[i] = false;
                }
            }

            var ret = physMem.Slice(address);

            if (ret.Count < size)
                throw new InvalidOperationException("Доступна только часть памяти.");

            return ret;
        }

        /// <summary>
        /// no seg, yes pg - may return size more, then input size.
        /// </summary>
        public ArraySegment<byte> mem_pg_raw(Address addr, int size)
        {
            if (!Processor.cr0.pg)
                return mem_phys_raw(addr, size);

            var physAddresses = new Address[2]; /* { current, current + page } */
            physAddresses[0] = mem_pg_raw_get_phys_addr(addr);

            Address startPageBase = physAddresses[0] & ~0xfffu;
            Address endPageBase = (physAddresses[0] + (size == 0 ? 0 : size - 1)) & ~0xfffu;

            // Одна страница.

            if (startPageBase == endPageBase)
                return mem_phys_raw(physAddresses[0], size)
                    .Slice(0,
                        endPageBase + 0x1000 -
                        physAddresses[0]); /* Ограничим размер страницей в которой находится область. */

            // Более двух страниц.

            if (startPageBase + 0x1000 != endPageBase)
                throw new NotImplementedException();

            physAddresses[1] = mem_pg_raw_get_phys_addr(addr + 0x1000);

            // Страницы идут последовательно.

            if (physAddresses[0] + 0x1000 == physAddresses[1])
                return mem_phys_raw(physAddresses[0], size)
                    .Slice(0,
                        endPageBase + 0x1000 -
                        physAddresses[0]); /* Ограничим размер страницами в которых находится область. */


            // Не идут последовательно -> загружаем в кэш.

            if (!A20Gate)
                throw new NotImplementedException();

            for (var i = 0; i < 2; i++)
            {
                if (cache_ena[i]) /* Страница кэша занята. */
                {
                    if ((cache_map[i] | 0xfff) != (physAddresses[i] | 0xfff)) /* И не тем, чем нужно. */
                    {
                        /* Выгружаем страницу обратно. */
                        Array.Copy(cache, i * 0x1000, Ram, cache_map[i], 0x1000);
                        cache_ena[i] = false;
                    }
                }

                if (!cache_ena[i]) /* Страница кэша пуста. */
                {
                    // Загружаем страницу.
                    cache_map[i] = physAddresses[i] & ~0xfffu;
                    Array.Copy(Ram, cache_map[i], cache, i * 0x1000, 0x1000);
                    cache_ena[i] = true;
                }
            }

            return new ArraySegment<byte>(
                cache,
                physAddresses[0] - cache_map[0],
                0x2000 - (physAddresses[0] - cache_map[0]));
        }

        /// <summary>
        /// yes seg, yes pg - may return size more, then input size.
        /// </summary>
        public ArraySegment<byte> mem_seg_pg_raw(SegmentRegister seg, Address address, int size)
        {
            if (seg.Descriptor.Present == false /* @todo || seg.is_null() */)
                throw new NotImplementedException();

            if (seg.fail_limit_check(address, size))
                throw new NotImplementedException();

            var ret = mem_pg_raw(seg.Descriptor.Base + address, size);


            // correct size with segment limit

            Address end = address + ret.Count;

            if (seg.Descriptor.Limit + 1 != 0)
            {
                if (end == 0)
                    end = seg.Descriptor.Limit + 1; // todo can't understand
                else
                    end = Math.Min(end, seg.Descriptor.Limit + 1);
            }

            if (end <= address)
                throw new NotImplementedException();

            ret = ret.Slice(0, end - address);

            return ret;
        }

        /// <summary>
        /// @note На самом деле это внутренняя функция. Она сделана "публичной" в целях отладки. */
        /// </summary>
        public Address mem_pg_raw_get_phys_addr(Address address)
        {
            if (!Processor.cr0.pg)
                return address;

            while (true)
            {
                if (Processor.cr4.pae)
                    throw new NotImplementedException();

                var pdi = address >> 22;
                var pti = (address >> 12) & 0x3ff;
                var off = address & 0xfff;

                var pde = mem_phys_raw((Processor.cr3 & 0xffff_f000) + 4 * pdi, 4).GetUInt32();

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

        public bool mem_pg_equals(Address address, ArraySegment<byte> left)
        {
            var proccessed = 0;

            while (left.Count != 0)
            {
                var code = mem_pg_raw(address + proccessed, 1);

                if (left.Count <= code.Count)
                    return code.Slice(0, left.Count).SequenceEqual(left);
                
                if (left.Slice(0, code.Count).SequenceEqual(code) == false)
                    return false;

                proccessed += code.Count;
                left = left.Slice(code.Count);
            }

            return true;
        }
    }
}