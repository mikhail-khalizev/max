using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_a24e-93b1778")]
        public void Method_100b_a24e()
        {
            ii(0x100b_a24e, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_a253, 5); call(Definitions.sys_check_available_stack_size, 0xa_bafa); /* call 0x10165d52 */
            ii(0x100b_a258, 1); push(esi);                              /* push esi */
            ii(0x100b_a259, 1); push(edi);                              /* push edi */
            ii(0x100b_a25a, 1); push(ebp);                              /* push ebp */
            ii(0x100b_a25b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_a25d, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100b_a263, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100b_a266, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x100b_a269, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x100b_a26c, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x100b_a26f, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
            ii(0x100b_a276, 2); jmp(0x100b_a27e, 6); goto l_0x100b_a27e; /* jmp 0x100ba27e */
        l_0x100b_a278:
            ii(0x100b_a278, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100b_a27b, 3); inc(memd[ss, ebp - 20]);                /* inc dword [ebp-0x14] */
        l_0x100b_a27e:
            ii(0x100b_a27e, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_a281, 5); call(0x1008_a4a0, -0x2_fde6);           /* call 0x1008a4a0 */
            ii(0x100b_a286, 4); cmp(ax, memw[ss, ebp - 20]);            /* cmp ax, [ebp-0x14] */
            ii(0x100b_a28a, 2); if(jle(0x100b_a2bd, 0x31)) goto l_0x100b_a2bd; /* jle 0x100ba2bd */
            ii(0x100b_a28c, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x100b_a290, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_a293, 5); call(0x1008_a3dc, -0x2_febc);           /* call 0x1008a3dc */
            ii(0x100b_a298, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100b_a29b, 4); cmp(ax, memw[ss, ebp - 8]);             /* cmp ax, [ebp-0x8] */
            ii(0x100b_a29f, 2); if(jnz(0x100b_a2bb, 0x1a)) goto l_0x100b_a2bb; /* jnz 0x100ba2bb */
            ii(0x100b_a2a1, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x100b_a2a5, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_a2a8, 5); call(0x1008_a3dc, -0x2_fed1);           /* call 0x1008a3dc */
            ii(0x100b_a2ad, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a2af, 4); mov(ax, memw[ds, edx + 2]);             /* mov ax, [edx+0x2] */
            ii(0x100b_a2b3, 4); imul(eax, memd[ss, ebp - 4]);           /* imul eax, [ebp-0x4] */
            ii(0x100b_a2b7, 4); mov(memw[ds, edx + 2], ax);             /* mov [edx+0x2], ax */
        l_0x100b_a2bb:
            ii(0x100b_a2bb, 2); jmp(0x100b_a278, -0x45); goto l_0x100b_a278; /* jmp 0x100ba278 */
        l_0x100b_a2bd:
            ii(0x100b_a2bd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_a2bf, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_a2c0, 1); pop(edi);                               /* pop edi */
            ii(0x100b_a2c1, 1); pop(esi);                               /* pop esi */
            ii(0x100b_a2c2, 1); ret();                                  /* ret */
        }
    }
}
