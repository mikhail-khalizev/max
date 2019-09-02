using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_a2d7-5ff181af")]
        public void Method_1010_a2d7()
        {
            ii(0x1010_a2d7, 5); push(0x38);                             /* push 0x38 */
            ii(0x1010_a2dc, 5); call(Definitions.sys_check_available_stack_size, 0x5_ba71); /* call 0x10165d52 */
            ii(0x1010_a2e1, 1); push(esi);                              /* push esi */
            ii(0x1010_a2e2, 1); push(edi);                              /* push edi */
            ii(0x1010_a2e3, 1); push(ebp);                              /* push ebp */
            ii(0x1010_a2e4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_a2e6, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1010_a2ec, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1010_a2ef, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x1010_a2f2, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1010_a2f5, 3); mov(memb[ss, ebp - 4], cl);             /* mov [ebp-0x4], cl */
            ii(0x1010_a2f8, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_a2fb, 4); cmp(memd[ds, eax + 16], 0);             /* cmp dword [eax+0x10], 0x0 */
            ii(0x1010_a2ff, 2); if(jz(0x1010_a312, 0x11)) goto l_0x1010_a312; /* jz 0x1010a312 */
            ii(0x1010_a301, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_a304, 3); mov(eax, memd[ds, eax + 16]);           /* mov eax, [eax+0x10] */
            ii(0x1010_a307, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1010_a309, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_a30e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_a310, 2); if(jnz(0x1010_a314, 2)) goto l_0x1010_a314; /* jnz 0x1010a314 */
        l_0x1010_a312:
            ii(0x1010_a312, 2); jmp(0x1010_a368, 0x54); goto l_0x1010_a368; /* jmp 0x1010a368 */
        l_0x1010_a314:
            ii(0x1010_a314, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1010_a317, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1010_a31a, 5); call(0x100d_4d78, -0x3_55a7);           /* call 0x100d4d78 */
            ii(0x1010_a31f, 1); push(eax);                              /* push eax */
            ii(0x1010_a320, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1010_a325, 1); push(eax);                              /* push eax */
            ii(0x1010_a326, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_a328, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1010_a32b, 1); push(eax);                              /* push eax */
            ii(0x1010_a32c, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_a32f, 4); mov(ax, memw[ds, eax + 12]);            /* mov ax, [eax+0xc] */
            ii(0x1010_a333, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1010_a336, 4); sub(ax, memw[ds, edx + 4]);             /* sub ax, [edx+0x4] */
            ii(0x1010_a33a, 1); cwde();                                 /* cwde */
            ii(0x1010_a33b, 1); push(eax);                              /* push eax */
            ii(0x1010_a33c, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_a33f, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x1010_a343, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1010_a346, 3); sub(ax, memw[ds, edx]);                 /* sub ax, [edx] */
            ii(0x1010_a349, 1); cwde();                                 /* cwde */
            ii(0x1010_a34a, 1); push(eax);                              /* push eax */
            ii(0x1010_a34b, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_a34e, 3); mov(ecx, memd[ds, eax + 2]);            /* mov ecx, [eax+0x2] */
            ii(0x1010_a351, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1010_a354, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_a357, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x1010_a35a, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_a35d, 3); mov(edx, memd[ds, eax + 16]);           /* mov edx, [eax+0x10] */
            ii(0x1010_a360, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_a363, 5); call(0x100e_ab9d, -0x1_f7cb);           /* call 0x100eab9d */
        l_0x1010_a368:
            ii(0x1010_a368, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_a36a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_a36b, 1); pop(edi);                               /* pop edi */
            ii(0x1010_a36c, 1); pop(esi);                               /* pop esi */
            ii(0x1010_a36d, 1); ret();                                  /* ret */
        }
    }
}
