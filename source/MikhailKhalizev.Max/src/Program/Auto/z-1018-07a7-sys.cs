using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_07a7-37ff8599")]
        public void /* sys */ Method_1018_07a7()
        {
            ii(0x1018_07a7, 1); push(ecx);                              /* push ecx */
            ii(0x1018_07a8, 1); push(esi);                              /* push esi */
            ii(0x1018_07a9, 1); push(edi);                              /* push edi */
            ii(0x1018_07aa, 1); push(ebp);                              /* push ebp */
            ii(0x1018_07ab, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_07ad, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1018_07b3, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1018_07b6, 3); mov(memd[ss, ebp - 0x10], edx);         /* mov [ebp-0x10], edx */
            ii(0x1018_07b9, 3); mov(memd[ss, ebp - 0xc], ebx);          /* mov [ebp-0xc], ebx */
            ii(0x1018_07bc, 7); imul(edx, memd[ss, ebp - 0x14], 0xc0);  /* imul edx, [ebp-0x14], 0xc0 */
            ii(0x1018_07c3, 4); imul(eax, memd[ss, ebp - 0x10], 6);     /* imul eax, [ebp-0x10], 0x6 */
            ii(0x1018_07c7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_07c9, 7); lgs(eax, memd[ds, eax + 0x1020_b718]);  /* lgs eax, [eax+0x1020b718] */
            ii(0x1018_07d0, 5); movsx(eax, memw[gs, eax + 0x30]);       /* movsx eax, word [gs:eax+0x30] */
            ii(0x1018_07d5, 3); test(ah, 0x80);                         /* test ah, 0x80 */
            ii(0x1018_07d8, 2); if(jz(0x1018_0814, 0x3a)) goto l_0x1018_0814; /* jz 0x10180814 */
            ii(0x1018_07da, 7); imul(eax, memd[ss, ebp - 0x14], 0xc0);  /* imul eax, [ebp-0x14], 0xc0 */
            ii(0x1018_07e1, 4); imul(edx, memd[ss, ebp - 0x10], 6);     /* imul edx, [ebp-0x10], 0x6 */
            ii(0x1018_07e5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_07e7, 7); lgs(eax, memd[ds, eax + 0x1020_b718]);  /* lgs eax, [eax+0x1020b718] */
            ii(0x1018_07ee, 5); movsx(eax, memw[gs, eax + 0x32]);       /* movsx eax, word [gs:eax+0x32] */
            ii(0x1018_07f3, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1018_07f6, 7); imul(edx, memd[ss, ebp - 0x14], 0xc0);  /* imul edx, [ebp-0x14], 0xc0 */
            ii(0x1018_07fd, 4); imul(eax, memd[ss, ebp - 0x10], 6);     /* imul eax, [ebp-0x10], 0x6 */
            ii(0x1018_0801, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_0803, 7); lgs(edx, memd[ds, edx + 0x1020_b718]);  /* lgs edx, [edx+0x1020b718] */
            ii(0x1018_080a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1018_080d, 5); mov(memw[gs, edx + 0x32], ax);          /* mov [gs:edx+0x32], ax */
            ii(0x1018_0812, 2); jmp(0x1018_081d, 9); goto l_0x1018_081d; /* jmp 0x1018081d */
        l_0x1018_0814:
            ii(0x1018_0814, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x1018_081b, 2); jmp(0x1018_0823, 6); goto l_0x1018_0823; /* jmp 0x10180823 */
        l_0x1018_081d:
            ii(0x1018_081d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1018_0820, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x1018_0823:
            ii(0x1018_0823, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1018_0826, 1); leave();                                /* leave */
            ii(0x1018_0827, 1); pop(edi);                               /* pop edi */
            ii(0x1018_0828, 1); pop(esi);                               /* pop esi */
            ii(0x1018_0829, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_082a, 1); ret();                                  /* ret */
        }
    }
}
