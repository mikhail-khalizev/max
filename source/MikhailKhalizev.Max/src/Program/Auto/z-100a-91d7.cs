using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_91d7-cfaea34e")]
        public void Method_100a_91d7()
        {
            ii(0x100a_91d7, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_91dc, 5); call(Definitions.sys_check_available_stack_size, 0xb_cb71); /* call 0x10165d52 */
            ii(0x100a_91e1, 1); push(ebx);                              /* push ebx */
            ii(0x100a_91e2, 1); push(ecx);                              /* push ecx */
            ii(0x100a_91e3, 1); push(esi);                              /* push esi */
            ii(0x100a_91e4, 1); push(edi);                              /* push edi */
            ii(0x100a_91e5, 1); push(ebp);                              /* push ebp */
            ii(0x100a_91e6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_91e8, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_91ee, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_91f1, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_91f4, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100a_91f8, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_91fe, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100a_9204, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_9209, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x100a_920c, 2); if(jnz(0x100a_9231, 0x23)) goto l_0x100a_9231; /* jnz 0x100a9231 */
            ii(0x100a_920e, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_9211, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_9214, 5); call(0x1007_5e64, -0x3_33b5);           /* call 0x10075e64 */
            ii(0x100a_9219, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_921b, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100a_921f, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100a_9225, 5); mov(ebx, 0x101c_31c4);                  /* mov ebx, 0x101c31c4 */
            ii(0x100a_922a, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100a_922c, 5); call(0x100c_2a6d, 0x1_983c);            /* call 0x100c2a6d */
        l_0x100a_9231:
            ii(0x100a_9231, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_9233, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_9234, 1); pop(edi);                               /* pop edi */
            ii(0x100a_9235, 1); pop(esi);                               /* pop esi */
            ii(0x100a_9236, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_9237, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_9238, 1); ret();                                  /* ret */
        }
    }
}
