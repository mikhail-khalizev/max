using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_486b-25b4564d")]
        public void Method_1011_486b()
        {
            ii(0x1011_486b, 5); push(0x20);                             /* push 0x20 */
            ii(0x1011_4870, 5); call(Definitions.sys_check_available_stack_size, 0x5_14dd); /* call 0x10165d52 */
            ii(0x1011_4875, 1); push(ebx);                              /* push ebx */
            ii(0x1011_4876, 1); push(ecx);                              /* push ecx */
            ii(0x1011_4877, 1); push(edx);                              /* push edx */
            ii(0x1011_4878, 1); push(esi);                              /* push esi */
            ii(0x1011_4879, 1); push(edi);                              /* push edi */
            ii(0x1011_487a, 1); push(ebp);                              /* push ebp */
            ii(0x1011_487b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_487d, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1011_4883, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1011_4886, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_4889, 4); mov(memb[ds, eax + 0xb], 2);            /* mov byte [eax+0xb], 0x2 */
            ii(0x1011_488d, 5); call(0x1012_ab2f, 0x1_629d);            /* call 0x1012ab2f */
            ii(0x1011_4892, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_4895, 5); call(0x1011_390d, -0xf8d);              /* call 0x1011390d */
            ii(0x1011_489a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_489c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_489d, 1); pop(edi);                               /* pop edi */
            ii(0x1011_489e, 1); pop(esi);                               /* pop esi */
            ii(0x1011_489f, 1); pop(edx);                               /* pop edx */
            ii(0x1011_48a0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_48a1, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_48a2, 1); ret();                                  /* ret */
        }
    }
}
