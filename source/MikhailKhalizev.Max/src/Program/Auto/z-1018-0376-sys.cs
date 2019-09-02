using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_0376-d18c2109")]
        public void /* sys */ Method_1018_0376()
        {
            ii(0x1018_0376, 1); push(ebx);                              /* push ebx */
            ii(0x1018_0377, 1); push(ecx);                              /* push ecx */
            ii(0x1018_0378, 1); push(esi);                              /* push esi */
            ii(0x1018_0379, 1); push(edi);                              /* push edi */
            ii(0x1018_037a, 1); push(ebp);                              /* push ebp */
            ii(0x1018_037b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_037d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1018_0383, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1018_0386, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1018_0389, 4); cmp(memd[ss, ebp - 8], 0x20);           /* cmp dword [ebp-0x8], 0x20 */
            ii(0x1018_038d, 2); if(jae(0x1018_03cc, 0x3d)) goto l_0x1018_03cc; /* jae 0x101803cc */
            ii(0x1018_038f, 7); imul(eax, memd[ss, ebp - 0xc], 0xc0);   /* imul eax, [ebp-0xc], 0xc0 */
            ii(0x1018_0396, 4); imul(edx, memd[ss, ebp - 8], 6);        /* imul edx, [ebp-0x8], 0x6 */
            ii(0x1018_039a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_039c, 7); lgs(eax, memd[ds, eax + 0x1020_b718]);  /* lgs eax, [eax+0x1020b718] */
            ii(0x1018_03a3, 5); and(memb[gs, eax + 0x31], 0x7f);        /* and byte [gs:eax+0x31], 0x7f */
            ii(0x1018_03a8, 7); imul(eax, memd[ss, ebp - 0xc], 0xc0);   /* imul eax, [ebp-0xc], 0xc0 */
            ii(0x1018_03af, 4); imul(edx, memd[ss, ebp - 8], 6);        /* imul edx, [ebp-0x8], 0x6 */
            ii(0x1018_03b3, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_03b5, 7); lgs(eax, memd[ds, eax + 0x1020_b718]);  /* lgs eax, [eax+0x1020b718] */
            ii(0x1018_03bc, 7); mov(memw[gs, eax + 0x34], 0);           /* mov word [gs:eax+0x34], 0x0 */
            ii(0x1018_03c3, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
            ii(0x1018_03ca, 2); jmp(0x1018_03d3, 7); goto l_0x1018_03d3; /* jmp 0x101803d3 */
        l_0x1018_03cc:
            ii(0x1018_03cc, 7); mov(memd[ss, ebp - 4], 0xa);            /* mov dword [ebp-0x4], 0xa */
        l_0x1018_03d3:
            ii(0x1018_03d3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1018_03d6, 1); leave();                                /* leave */
            ii(0x1018_03d7, 1); pop(edi);                               /* pop edi */
            ii(0x1018_03d8, 1); pop(esi);                               /* pop esi */
            ii(0x1018_03d9, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_03da, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_03db, 1); ret();                                  /* ret */
        }
    }
}
