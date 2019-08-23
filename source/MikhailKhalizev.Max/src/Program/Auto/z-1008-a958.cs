using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a958-89d081cb")]
        public void Method_1008_a958()
        {
            ii(0x1008_a958, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_a95d, 5); call(Definitions.sys_check_available_stack_size, 0xd_b3f0); /* call 0x10165d52 */
            ii(0x1008_a962, 1); push(ebx);                              /* push ebx */
            ii(0x1008_a963, 1); push(ecx);                              /* push ecx */
            ii(0x1008_a964, 1); push(edx);                              /* push edx */
            ii(0x1008_a965, 1); push(esi);                              /* push esi */
            ii(0x1008_a966, 1); push(edi);                              /* push edi */
            ii(0x1008_a967, 1); push(ebp);                              /* push ebp */
            ii(0x1008_a968, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a96a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_a970, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_a973, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_a976, 5); call(Definitions.my_ctor_0x101b_6edc, -0x1_3b37); /* call 0x10076e44 */
            ii(0x1008_a97b, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_a97e, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1008_a981, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_a984, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_a987, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_a98a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_a98d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a98f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_a990, 1); pop(edi);                               /* pop edi */
            ii(0x1008_a991, 1); pop(esi);                               /* pop esi */
            ii(0x1008_a992, 1); pop(edx);                               /* pop edx */
            ii(0x1008_a993, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_a994, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_a995, 1); ret();                                  /* ret */
        }
    }
}
