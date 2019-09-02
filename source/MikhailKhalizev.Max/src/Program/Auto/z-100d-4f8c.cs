using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_4f8c-3546fd91")]
        public void Method_100d_4f8c()
        {
            ii(0x100d_4f8c, 5); push(0x24);                             /* push 0x24 */
            ii(0x100d_4f91, 5); call(Definitions.sys_check_available_stack_size, 0x9_0dbc); /* call 0x10165d52 */
            ii(0x100d_4f96, 1); push(ebx);                              /* push ebx */
            ii(0x100d_4f97, 1); push(ecx);                              /* push ecx */
            ii(0x100d_4f98, 1); push(edx);                              /* push edx */
            ii(0x100d_4f99, 1); push(esi);                              /* push esi */
            ii(0x100d_4f9a, 1); push(edi);                              /* push edi */
            ii(0x100d_4f9b, 1); push(ebp);                              /* push ebp */
            ii(0x100d_4f9c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_4f9e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100d_4fa4, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100d_4fa7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_4faa, 3); mov(al, memb[ds, eax + 8]);             /* mov al, [eax+0x8] */
            ii(0x100d_4fad, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x100d_4fb0, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100d_4fb3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_4fb5, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_4fb6, 1); pop(edi);                               /* pop edi */
            ii(0x100d_4fb7, 1); pop(esi);                               /* pop esi */
            ii(0x100d_4fb8, 1); pop(edx);                               /* pop edx */
            ii(0x100d_4fb9, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_4fba, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_4fbb, 1); ret();                                  /* ret */
        }
    }
}
