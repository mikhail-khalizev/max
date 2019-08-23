using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_04b0-98209e37")]
        public void Method_100e_04b0()
        {
            ii(0x100e_04b0, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_04b5, 5); call(Definitions.sys_check_available_stack_size, 0x8_5898); /* call 0x10165d52 */
            ii(0x100e_04ba, 1); push(ebx);                              /* push ebx */
            ii(0x100e_04bb, 1); push(ecx);                              /* push ecx */
            ii(0x100e_04bc, 1); push(edx);                              /* push edx */
            ii(0x100e_04bd, 1); push(esi);                              /* push esi */
            ii(0x100e_04be, 1); push(edi);                              /* push edi */
            ii(0x100e_04bf, 1); push(ebp);                              /* push ebp */
            ii(0x100e_04c0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_04c2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_04c8, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_04cb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_04ce, 5); call(0x1007_6c30, -0x6_98a3);           /* call 0x10076c30 */
            ii(0x100e_04d3, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_04d6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_04d9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_04db, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_04dc, 1); pop(edi);                               /* pop edi */
            ii(0x100e_04dd, 1); pop(esi);                               /* pop esi */
            ii(0x100e_04de, 1); pop(edx);                               /* pop edx */
            ii(0x100e_04df, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_04e0, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_04e1, 1); ret();                                  /* ret */
        }
    }
}
