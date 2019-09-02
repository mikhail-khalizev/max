using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_01b7-32b6c563")]
        public void Method_1015_01b7()
        {
            ii(0x1015_01b7, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1015_01bc, 5); call(Definitions.sys_check_available_stack_size, 0x1_5b91); /* call 0x10165d52 */
            ii(0x1015_01c1, 1); push(ebx);                              /* push ebx */
            ii(0x1015_01c2, 1); push(ecx);                              /* push ecx */
            ii(0x1015_01c3, 1); push(esi);                              /* push esi */
            ii(0x1015_01c4, 1); push(edi);                              /* push edi */
            ii(0x1015_01c5, 1); push(ebp);                              /* push ebp */
            ii(0x1015_01c6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_01c8, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1015_01ce, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_01d1, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1015_01d4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_01d7, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_01da, 5); call(0x1007_6730, -0xd_9aaf);           /* call 0x10076730 */
            ii(0x1015_01df, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1015_01e2, 3); mov(dl, memb[ds, edx + 0x4d]);          /* mov dl, [edx+0x4d] */
            ii(0x1015_01e5, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1015_01e7, 4); mov(ax, memw[ds, eax + 0xa]);           /* mov ax, [eax+0xa] */
            ii(0x1015_01eb, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1015_01ed, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1015_01f0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_01f3, 5); call(0x1015_012d, -0xcb);               /* call 0x1015012d */
            ii(0x1015_01f8, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_01fb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_01fe, 4); cmp(ax, memw[ss, ebp - 4]);             /* cmp ax, [ebp-0x4] */
            ii(0x1015_0202, 2); if(jle(0x1015_027e, 0x7a)) goto l_0x1015_027e; /* jle 0x1015027e */
            ii(0x1015_0204, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_0207, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_020a, 5); call(0x1007_6730, -0xd_9adf);           /* call 0x10076730 */
            ii(0x1015_020f, 3); mov(edx, memd[ds, eax + 8]);            /* mov edx, [eax+0x8] */
            ii(0x1015_0212, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_0215, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x1015_0218, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1015_021c, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1015_021f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_0222, 5); call(0x1015_09a6, 0x77f);               /* call 0x101509a6 */
            ii(0x1015_0227, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_022a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_022c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_022f, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1015_0231, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1015_0234, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_0237, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_023a, 5); call(0x1007_6730, -0xd_9b0f);           /* call 0x10076730 */
            ii(0x1015_023f, 3); mov(ebx, memd[ds, eax + 8]);            /* mov ebx, [eax+0x8] */
            ii(0x1015_0242, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_0245, 3); shl(ebx, 2);                            /* shl ebx, 0x2 */
            ii(0x1015_0248, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_024b, 5); call(0x1015_09a6, 0x756);               /* call 0x101509a6 */
            ii(0x1015_0250, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_0253, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1015_0257, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1015_025a, 3); lea(edx, memd[ds, eax + ebx]);          /* lea edx, [eax+ebx] */
            ii(0x1015_025d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_0260, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_0263, 5); call(0x1007_6730, -0xd_9b38);           /* call 0x10076730 */
            ii(0x1015_0268, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x1015_026b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_026e, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1015_0271, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1015_0273, 1); dec(edx);                               /* dec edx */
            ii(0x1015_0274, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_0276, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_0279, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1015_027b, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x1015_027e:
            ii(0x1015_027e, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x1015_0281, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1015_0284, 3); add(memb[ds, edx + 0x4d], al);          /* add [edx+0x4d], al */
            ii(0x1015_0287, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_028a, 5); call(0x1016_15c9, 0x1_133a);            /* call 0x101615c9 */
            ii(0x1015_028f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_0292, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1015_0295, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_0298, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_029a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_029b, 1); pop(edi);                               /* pop edi */
            ii(0x1015_029c, 1); pop(esi);                               /* pop esi */
            ii(0x1015_029d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_029e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_029f, 1); ret();                                  /* ret */
        }
    }
}
