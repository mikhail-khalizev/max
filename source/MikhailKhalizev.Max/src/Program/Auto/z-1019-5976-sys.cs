using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5976-a936d794")]
        public void /* sys */ Method_1019_5976()
        {
            ii(0x1019_5976, 1); push(ebx);                              /* push ebx */
            ii(0x1019_5977, 1); push(ecx);                              /* push ecx */
            ii(0x1019_5978, 1); push(edx);                              /* push edx */
            ii(0x1019_5979, 1); push(esi);                              /* push esi */
            ii(0x1019_597a, 1); push(edi);                              /* push edi */
            ii(0x1019_597b, 1); push(ebp);                              /* push ebp */
            ii(0x1019_597c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_597e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1019_5984, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1019_5987, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1019_598a, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1019_598d, 6); push(memd[ds, eax + 0x101c_029c]);      /* push dword [eax+0x101c029c] */
            ii(0x1019_5993, 4); imul(eax, memd[ss, ebp - 8], 6);        /* imul eax, [ebp-0x8], 0x6 */
            ii(0x1019_5997, 7); movzx(edx, memw[ds, eax + 0x101c_0250]); /* movzx edx, word [eax+0x101c0250] */
            ii(0x1019_599e, 1); push(edx);                              /* push edx */
            ii(0x1019_599f, 6); push(memd[ds, eax + 0x101c_024c]);      /* push dword [eax+0x101c024c] */
            ii(0x1019_59a5, 5); call(/* sys */ 0x1019_4d46, -0xc64);    /* call 0x10194d46 */
            ii(0x1019_59aa, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1019_59ad, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1019_59b0, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1019_59b3, 6); push(memd[ds, eax + 0x101c_029c]);      /* push dword [eax+0x101c029c] */
            ii(0x1019_59b9, 4); imul(eax, memd[ss, ebp - 8], 6);        /* imul eax, [ebp-0x8], 0x6 */
            ii(0x1019_59bd, 7); movzx(edx, memw[ds, eax + 0x101c_026e]); /* movzx edx, word [eax+0x101c026e] */
            ii(0x1019_59c4, 1); push(edx);                              /* push edx */
            ii(0x1019_59c5, 6); push(memd[ds, eax + 0x101c_026a]);      /* push dword [eax+0x101c026a] */
            ii(0x1019_59cb, 5); call(/* sys */ 0x1019_4d46, -0xc8a);    /* call 0x10194d46 */
            ii(0x1019_59d0, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1019_59d3, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
            ii(0x1019_59da, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1019_59dd, 1); leave();                                /* leave */
            ii(0x1019_59de, 1); pop(edi);                               /* pop edi */
            ii(0x1019_59df, 1); pop(esi);                               /* pop esi */
            ii(0x1019_59e0, 1); pop(edx);                               /* pop edx */
            ii(0x1019_59e1, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_59e2, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_59e3, 1); ret();                                  /* ret */
        }
    }
}
