using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_e788-15f51420")]
        public void Method_1014_e788()
        {
            ii(0x1014_e788, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_e78d, 5); call(Definitions.sys_check_available_stack_size, 0x1_75c0); /* call 0x10165d52 */
            ii(0x1014_e792, 1); push(ecx);                              /* push ecx */
            ii(0x1014_e793, 1); push(esi);                              /* push esi */
            ii(0x1014_e794, 1); push(edi);                              /* push edi */
            ii(0x1014_e795, 1); push(ebp);                              /* push ebp */
            ii(0x1014_e796, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_e798, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1014_e79e, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_e7a1, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1014_e7a4, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x1014_e7a7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_e7aa, 3); mov(edx, memd[ds, eax + 6]);            /* mov edx, [eax+0x6] */
            ii(0x1014_e7ad, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_e7b0, 3); imul(edx, edx, 0x33);                   /* imul edx, edx, 0x33 */
            ii(0x1014_e7b3, 5); mov(eax, 0x101c_81c0);                  /* mov eax, 0x101c81c0 */
            ii(0x1014_e7b8, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_e7ba, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_e7bd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_e7bf, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1014_e7c2, 3); mov(al, memb[ds, edx + 0x29]);          /* mov al, [edx+0x29] */
            ii(0x1014_e7c5, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_e7c8, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1014_e7cb, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1014_e7ce, 3); mov(memb[ds, edx + 0x2e], al);          /* mov [edx+0x2e], al */
            ii(0x1014_e7d1, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_e7d4, 3); mov(edx, memd[ds, eax + 6]);            /* mov edx, [eax+0x6] */
            ii(0x1014_e7d7, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1014_e7db, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1014_e7dd, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_e7df, 3); mov(dl, memb[ds, eax + 8]);             /* mov dl, [eax+0x8] */
            ii(0x1014_e7e2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_e7e5, 3); mov(memb[ds, eax + 0x2f], dl);          /* mov [eax+0x2f], dl */
            ii(0x1014_e7e8, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_e7eb, 3); mov(edx, memd[ds, eax + 6]);            /* mov edx, [eax+0x6] */
            ii(0x1014_e7ee, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1014_e7f2, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1014_e7f4, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_e7f6, 3); mov(dl, memb[ds, eax + 9]);             /* mov dl, [eax+0x9] */
            ii(0x1014_e7f9, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_e7fc, 3); mov(memb[ds, eax + 0x30], dl);          /* mov [eax+0x30], dl */
            ii(0x1014_e7ff, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1014_e803, 2); if(jz(0x1014_e81c, 0x17)) goto l_0x1014_e81c; /* jz 0x1014e81c */
            ii(0x1014_e805, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_e808, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_e80b, 4); add(dx, memw[ds, eax + 0x35]);          /* add dx, [eax+0x35] */
            ii(0x1014_e80f, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_e811, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_e814, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_e817, 5); call(0x1014_9b9b, -0x4c81);             /* call 0x10149b9b */
        l_0x1014_e81c:
            ii(0x1014_e81c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_e81e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_e81f, 1); pop(edi);                               /* pop edi */
            ii(0x1014_e820, 1); pop(esi);                               /* pop esi */
            ii(0x1014_e821, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_e822, 1); ret();                                  /* ret */
        }
    }
}
