using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6452f5ea-d392-4978-889c-7d5238871cc5")]
        public void /* sys */ Method_1019_4799()
        {
            ii(0x1019_4799, 5); mov(eax, 0x101b_de0c);                  /* mov eax, 0x101bde0c */
            ii(0x1019_479e, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1019_47a0, 2); mov(ecx, esp);                          /* mov ecx, esp */
            ii(0x1019_47a2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_47a4, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1019_47a6, 3); mov(ax, dx);                            /* mov ax, dx */
            ii(0x1019_47a9, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1019_47ab, 5); calld(/* sys */ 0x1019_47c1, 0x11);     /* call 0x101947c1 */
            ii(0x1019_47b0, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_47b2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_47b4, 6); jnzd_func(0x1019_4950, 0x196);          /* jnz 0x10194950 */
            ii(0x1019_47ba, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1019_47bc, 5); jmpd_func(0x1019_49b1, 0x1f0); return;  /* jmp 0x101949b1 */
        }
    }
}
