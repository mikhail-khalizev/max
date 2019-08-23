using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_49d8-16ce6368")]
        public void Method_1016_49d8()
        {
            ii(0x1016_49d8, 5); push(0x28);                             /* push 0x28 */
            ii(0x1016_49dd, 5); call(Definitions.sys_check_available_stack_size, 0x1370); /* call 0x10165d52 */
            ii(0x1016_49e2, 1); push(ebx);                              /* push ebx */
            ii(0x1016_49e3, 1); push(ecx);                              /* push ecx */
            ii(0x1016_49e4, 1); push(esi);                              /* push esi */
            ii(0x1016_49e5, 1); push(edi);                              /* push edi */
            ii(0x1016_49e6, 1); push(ebp);                              /* push ebp */
            ii(0x1016_49e7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_49e9, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_49ef, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_49f2, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1016_49f5, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_49f8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_49fb, 5); call(0x1007_6cd0, -0xe_dd30);           /* call 0x10076cd0 */
            ii(0x1016_4a00, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_4a03, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1016_4a06, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1016_4a09, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4a0c, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1016_4a0f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_4a12, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4a14, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_4a15, 1); pop(edi);                               /* pop edi */
            ii(0x1016_4a16, 1); pop(esi);                               /* pop esi */
            ii(0x1016_4a17, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_4a18, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_4a19, 1); ret();                                  /* ret */
        }
    }
}
