using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_7ce4-de6f8760")]
        public void my_ctor_0x101b_66dc()
        {
            ii(0x1011_7ce4, 5); push(0x28);                             /* push 0x28 */
            ii(0x1011_7ce9, 5); call(Definitions.sys_check_available_stack_size, 0x4_e064); /* call 0x10165d52 */
            ii(0x1011_7cee, 1); push(ebx);                              /* push ebx */
            ii(0x1011_7cef, 1); push(ecx);                              /* push ecx */
            ii(0x1011_7cf0, 1); push(edx);                              /* push edx */
            ii(0x1011_7cf1, 1); push(esi);                              /* push esi */
            ii(0x1011_7cf2, 1); push(edi);                              /* push edi */
            ii(0x1011_7cf3, 1); push(ebp);                              /* push ebp */
            ii(0x1011_7cf4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_7cf6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_7cfc, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_7cff, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_7d02, 5); call(0x1013_a0af, 0x2_23a8);            /* call 0x1013a0af */
            ii(0x1011_7d07, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_7d0a, 3); lea(eax, memd[ss, ebp - 0x4]);          /* lea eax, [ebp-0x4] */
            ii(0x1011_7d0d, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_7d10, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_7d13, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1011_7d16, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_7d19, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_7d1b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_7d1c, 1); pop(edi);                               /* pop edi */
            ii(0x1011_7d1d, 1); pop(esi);                               /* pop esi */
            ii(0x1011_7d1e, 1); pop(edx);                               /* pop edx */
            ii(0x1011_7d1f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_7d20, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_7d21, 1); ret();                                  /* ret */
        }
    }
}
