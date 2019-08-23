using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c484-7cdbc22f")]
        public void Method_1009_c484()
        {
            ii(0x1009_c484, 5); push(0x28);                             /* push 0x28 */
            ii(0x1009_c489, 5); call(Definitions.sys_check_available_stack_size, 0xc_98c4); /* call 0x10165d52 */
            ii(0x1009_c48e, 1); push(ebx);                              /* push ebx */
            ii(0x1009_c48f, 1); push(ecx);                              /* push ecx */
            ii(0x1009_c490, 1); push(edx);                              /* push edx */
            ii(0x1009_c491, 1); push(esi);                              /* push esi */
            ii(0x1009_c492, 1); push(edi);                              /* push edi */
            ii(0x1009_c493, 1); push(ebp);                              /* push ebp */
            ii(0x1009_c494, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c496, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_c49c, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_c49f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_c4a2, 5); call(Definitions.my_ctor_0x101b_6edc, -0x2_5663); /* call 0x10076e44 */
            ii(0x1009_c4a7, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_c4aa, 3); lea(eax, memd[ss, ebp - 0x4]);          /* lea eax, [ebp-0x4] */
            ii(0x1009_c4ad, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c4b0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_c4b3, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_c4b6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_c4b9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c4bb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_c4bc, 1); pop(edi);                               /* pop edi */
            ii(0x1009_c4bd, 1); pop(esi);                               /* pop esi */
            ii(0x1009_c4be, 1); pop(edx);                               /* pop edx */
            ii(0x1009_c4bf, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_c4c0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_c4c1, 1); ret();                                  /* ret */
        }
    }
}
