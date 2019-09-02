using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6d58-78a4b651")]
        public void Method_1007_6d58()
        {
            ii(0x1007_6d58, 5); push(0x28);                             /* push 0x28 */
            ii(0x1007_6d5d, 5); call(Definitions.sys_check_available_stack_size, 0xe_eff0); /* call 0x10165d52 */
            ii(0x1007_6d62, 1); push(ebx);                              /* push ebx */
            ii(0x1007_6d63, 1); push(ecx);                              /* push ecx */
            ii(0x1007_6d64, 1); push(edx);                              /* push edx */
            ii(0x1007_6d65, 1); push(esi);                              /* push esi */
            ii(0x1007_6d66, 1); push(edi);                              /* push edi */
            ii(0x1007_6d67, 1); push(ebp);                              /* push ebp */
            ii(0x1007_6d68, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6d6a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_6d70, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_6d73, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_6d76, 5); call(Definitions.my_ctor_0x101b_6edc, 0xc9); /* call 0x10076e44 */
            ii(0x1007_6d7b, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_6d7e, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x1007_6d81, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_6d84, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_6d87, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_6d8a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_6d8d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6d8f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_6d90, 1); pop(edi);                               /* pop edi */
            ii(0x1007_6d91, 1); pop(esi);                               /* pop esi */
            ii(0x1007_6d92, 1); pop(edx);                               /* pop edx */
            ii(0x1007_6d93, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_6d94, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_6d95, 1); ret();                                  /* ret */
        }
    }
}
