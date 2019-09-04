using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_a2b3-92f88d")]
        public void Method_100d_a2b3()
        {
            ii(0x100d_a2b3, 5); push(0x34);                             /* push 0x34 */
            ii(0x100d_a2b8, 5); call(Definitions.sys_check_available_stack_size, 0x8_ba95); /* call 0x10165d52 */
            ii(0x100d_a2bd, 1); push(ebx);                              /* push ebx */
            ii(0x100d_a2be, 1); push(ecx);                              /* push ecx */
            ii(0x100d_a2bf, 1); push(esi);                              /* push esi */
            ii(0x100d_a2c0, 1); push(edi);                              /* push edi */
            ii(0x100d_a2c1, 1); push(ebp);                              /* push ebp */
            ii(0x100d_a2c2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_a2c4, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100d_a2ca, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_a2cd, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100d_a2d0, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100d_a2d4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_a2d7, 3); mov(eax, memd[ds, eax + 73]);           /* mov eax, [eax+0x49] */
            ii(0x100d_a2da, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_a2dd, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100d_a2e3, 6); mov(eax, memd[ds, eax + 0x101c_a562]);  /* mov eax, [eax+0x101ca562] */
            ii(0x100d_a2e9, 5); call(0x100c_b6b0, -0xec3e);             /* call 0x100cb6b0 */
            ii(0x100d_a2ee, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100d_a2f1, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100d_a2f5, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100d_a2f8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_a2fa, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_a2fd, 3); add(eax, 0x5b);                         /* add eax, 0x5b */
            ii(0x100d_a300, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_a302, 5); call(0x100c_b6f0, -0xec17);             /* call 0x100cb6f0 */
            ii(0x100d_a307, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100d_a30a, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100d_a30e, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100d_a311, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_a314, 6); add(edx, 0x1cf);                        /* add edx, 0x1cf */
            ii(0x100d_a31a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_a31c, 5); call(0x100c_b6f0, -0xec31);             /* call 0x100cb6f0 */
            ii(0x100d_a321, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100d_a324, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100d_a327, 5); cmp(memw[ds, eax + 12], 0);             /* cmp word [eax+0xc], 0x0 */
            ii(0x100d_a32c, 2); if(jz(0x100d_a36d, 0x3f)) goto l_0x100d_a36d; /* jz 0x100da36d */
            ii(0x100d_a32e, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x100d_a332, 5); mov(edx, 3);                            /* mov edx, 0x3 */
            ii(0x100d_a337, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_a33a, 3); mov(eax, memd[ds, eax + 73]);           /* mov eax, [eax+0x49] */
            ii(0x100d_a33d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_a340, 5); call(0x1013_3743, 0x5_93fe);            /* call 0x10133743 */
            ii(0x100d_a345, 1); cwde();                                 /* cwde */
            ii(0x100d_a346, 1); push(eax);                              /* push eax */
            ii(0x100d_a347, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100d_a34a, 3); add(eax, 0xc);                          /* add eax, 0xc */
            ii(0x100d_a34d, 1); push(eax);                              /* push eax */
            ii(0x100d_a34e, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100d_a351, 3); mov(ecx, memd[ds, eax + 10]);           /* mov ecx, [eax+0xa] */
            ii(0x100d_a354, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100d_a357, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100d_a35a, 3); mov(ebx, memd[ds, eax + 10]);           /* mov ebx, [eax+0xa] */
            ii(0x100d_a35d, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_a360, 5); mov(edx, 5);                            /* mov edx, 0x5 */
            ii(0x100d_a365, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_a368, 5); call(0x100d_9e3f, -0x52e);              /* call 0x100d9e3f */
        l_0x100d_a36d:
            ii(0x100d_a36d, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100d_a370, 5); cmp(memw[ds, eax + 10], 0);             /* cmp word [eax+0xa], 0x0 */
            ii(0x100d_a375, 2); if(jz(0x100d_a3b6, 0x3f)) goto l_0x100d_a3b6; /* jz 0x100da3b6 */
            ii(0x100d_a377, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x100d_a37b, 5); mov(edx, 4);                            /* mov edx, 0x4 */
            ii(0x100d_a380, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_a383, 3); mov(eax, memd[ds, eax + 73]);           /* mov eax, [eax+0x49] */
            ii(0x100d_a386, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_a389, 5); call(0x1013_3743, 0x5_93b5);            /* call 0x10133743 */
            ii(0x100d_a38e, 1); cwde();                                 /* cwde */
            ii(0x100d_a38f, 1); push(eax);                              /* push eax */
            ii(0x100d_a390, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100d_a393, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100d_a396, 1); push(eax);                              /* push eax */
            ii(0x100d_a397, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100d_a39a, 3); mov(ecx, memd[ds, eax + 8]);            /* mov ecx, [eax+0x8] */
            ii(0x100d_a39d, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100d_a3a0, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100d_a3a3, 3); mov(ebx, memd[ds, eax + 8]);            /* mov ebx, [eax+0x8] */
            ii(0x100d_a3a6, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_a3a9, 5); mov(edx, 6);                            /* mov edx, 0x6 */
            ii(0x100d_a3ae, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_a3b1, 5); call(0x100d_9e3f, -0x577);              /* call 0x100d9e3f */
        l_0x100d_a3b6:
            ii(0x100d_a3b6, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100d_a3b9, 5); cmp(memw[ds, eax + 23], 0);             /* cmp word [eax+0x17], 0x0 */
            ii(0x100d_a3be, 2); if(jz(0x100d_a3ff, 0x3f)) goto l_0x100d_a3ff; /* jz 0x100da3ff */
            ii(0x100d_a3c0, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x100d_a3c4, 5); mov(edx, 6);                            /* mov edx, 0x6 */
            ii(0x100d_a3c9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_a3cc, 3); mov(eax, memd[ds, eax + 73]);           /* mov eax, [eax+0x49] */
            ii(0x100d_a3cf, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_a3d2, 5); call(0x1013_3743, 0x5_936c);            /* call 0x10133743 */
            ii(0x100d_a3d7, 1); cwde();                                 /* cwde */
            ii(0x100d_a3d8, 1); push(eax);                              /* push eax */
            ii(0x100d_a3d9, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100d_a3dc, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100d_a3df, 1); push(eax);                              /* push eax */
            ii(0x100d_a3e0, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100d_a3e3, 3); mov(ecx, memd[ds, eax + 21]);           /* mov ecx, [eax+0x15] */
            ii(0x100d_a3e6, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100d_a3e9, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100d_a3ec, 3); mov(ebx, memd[ds, eax + 21]);           /* mov ebx, [eax+0x15] */
            ii(0x100d_a3ef, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_a3f2, 5); mov(edx, 7);                            /* mov edx, 0x7 */
            ii(0x100d_a3f7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_a3fa, 5); call(0x100d_9e3f, -0x5c0);              /* call 0x100d9e3f */
        l_0x100d_a3ff:
            ii(0x100d_a3ff, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_a401, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_a402, 1); pop(edi);                               /* pop edi */
            ii(0x100d_a403, 1); pop(esi);                               /* pop esi */
            ii(0x100d_a404, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_a405, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_a406, 1); ret();                                  /* ret */
        }
    }
}
