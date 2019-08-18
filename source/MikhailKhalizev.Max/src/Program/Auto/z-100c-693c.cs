using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("17955be7-fd8d-4f26-98da-5df7cd7aa963")]
        public void Method_100c_693c()
        {
            ii(0x100c_693c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_693f, 5); calld(0x100c_ae28, 0x44e4);             /* call 0x100cae28 */
            ii(0x100c_6944, 1); cwde();                                 /* cwde */
            ii(0x100c_6945, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_6947, 6); if(jnzd_func(0x100c_7115, 0x7c8)) return; /* jnz 0x100c7115 */
            ii(0x100c_694d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_6950, 3); mov(al, memb_a32[ds, eax + 0x2]);       /* mov al, [eax+0x2] */
            ii(0x100c_6953, 3); mov(memb_a32[ss, ebp - 0x2c], al);      /* mov [ebp-0x2c], al */
            ii(0x100c_6956, 5); if(jmpd_func(0x100c_70f8, 0x79d)) return; /* jmp 0x100c70f8 */
        }
    }
}
