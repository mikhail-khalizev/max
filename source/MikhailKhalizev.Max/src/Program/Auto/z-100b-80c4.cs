using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_80c4-362c6b20")]
        public void Method_100b_80c4()
        {
            ii(0x100b_80c4, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_80c9, 5); call(Definitions.sys_check_available_stack_size, 0xa_dc84); /* call 0x10165d52 */
            ii(0x100b_80ce, 1); push(ebx);                              /* push ebx */
            ii(0x100b_80cf, 1); push(ecx);                              /* push ecx */
            ii(0x100b_80d0, 1); push(edx);                              /* push edx */
            ii(0x100b_80d1, 1); push(esi);                              /* push esi */
            ii(0x100b_80d2, 1); push(edi);                              /* push edi */
            ii(0x100b_80d3, 1); push(ebp);                              /* push ebp */
            ii(0x100b_80d4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_80d6, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100b_80dc, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100b_80df, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_80e2, 3); mov(al, memb[ds, eax + 0x13]);          /* mov al, [eax+0x13] */
            ii(0x100b_80e5, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x100b_80e8, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100b_80eb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_80ed, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_80ee, 1); pop(edi);                               /* pop edi */
            ii(0x100b_80ef, 1); pop(esi);                               /* pop esi */
            ii(0x100b_80f0, 1); pop(edx);                               /* pop edx */
            ii(0x100b_80f1, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_80f2, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_80f3, 1); ret();                                  /* ret */
        }
    }
}
