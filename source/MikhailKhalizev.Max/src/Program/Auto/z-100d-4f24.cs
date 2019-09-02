using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_4f24-1a2cc4ef")]
        public void Method_100d_4f24()
        {
            ii(0x100d_4f24, 5); push(0x24);                             /* push 0x24 */
            ii(0x100d_4f29, 5); call(Definitions.sys_check_available_stack_size, 0x9_0e24); /* call 0x10165d52 */
            ii(0x100d_4f2e, 1); push(ebx);                              /* push ebx */
            ii(0x100d_4f2f, 1); push(ecx);                              /* push ecx */
            ii(0x100d_4f30, 1); push(edx);                              /* push edx */
            ii(0x100d_4f31, 1); push(esi);                              /* push esi */
            ii(0x100d_4f32, 1); push(edi);                              /* push edi */
            ii(0x100d_4f33, 1); push(ebp);                              /* push ebp */
            ii(0x100d_4f34, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_4f36, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100d_4f3c, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100d_4f3f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_4f42, 4); mov(ax, memw[ds, eax + 0xa]);           /* mov ax, [eax+0xa] */
            ii(0x100d_4f46, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_4f49, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_4f4c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_4f4e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_4f4f, 1); pop(edi);                               /* pop edi */
            ii(0x100d_4f50, 1); pop(esi);                               /* pop esi */
            ii(0x100d_4f51, 1); pop(edx);                               /* pop edx */
            ii(0x100d_4f52, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_4f53, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_4f54, 1); ret();                                  /* ret */
        }
    }
}
