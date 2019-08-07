using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ea0b2228-20f3-4ec8-afd7-b9a5b0c9915a")]
        public void Method_0014_eb83()
        {
            ii(0x14_eb83, 6); mov(memw_a32[ss, ebp + 0x20], 0x5a);      /* mov word [ebp+0x20], 0x5a */
            ii(0x14_eb89, 3); mov(cx, 0x1);                             /* mov cx, 0x1 */
            ii(0x14_eb8c, 3); mov(ax, memw_a16[ds, 0x2e]);              /* mov ax, [0x2e] */
            ii(0x14_eb8f, 2); cmp(al, 0xb);                             /* cmp al, 0xb */
            ii(0x14_eb91, 2); if(jzw(0x14_eb96, 0x3)) goto l_0x14_eb96; /* jz 0xeb96 */
            ii(0x14_eb93, 3); or(cl, 0x2);                              /* or cl, 0x2 */
        l_0x14_eb96:
            ii(0x14_eb96, 4); mov(memw_a32[ss, ebp + 0x14], cx);        /* mov [ebp+0x14], cx */
            ii(0x14_eb9a, 4); mov(memb_a32[ss, ebp + 0x1c], ah);        /* mov [ebp+0x1c], ah */
            ii(0x14_eb9e, 3); mov(ax, memw_a16[ds, 0x50]);              /* mov ax, [0x50] */
            ii(0x14_eba1, 2); xchg(al, ah);                             /* xchg al, ah */
            ii(0x14_eba3, 4); mov(memw_a32[ss, ebp + 0x18], ax);        /* mov [ebp+0x18], ax */
            ii(0x14_eba7, 3); jmpw_func(0x14_e067, -0xb43); return;     /* jmp 0xe067 */
        }
    }
}
