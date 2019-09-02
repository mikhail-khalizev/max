using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_eb80-bec86cc3")]
        public void Method_0018_eb80()
        {
            ii(0x18_eb80, 2); push(0x20);                               /* push 0x20 */
            ii(0x18_eb82, 1); pop(ds);                                  /* pop ds */
            ii(0x18_eb83, 6); mov(memw_a32[ss, ebp + 32], 0x5a);        /* mov word [ebp+0x20], 0x5a */
            ii(0x18_eb89, 3); mov(cx, 1);                               /* mov cx, 0x1 */
            ii(0x18_eb8c, 3); mov(ax, memw[ds, 0x2e]);                  /* mov ax, [0x2e] */
            ii(0x18_eb8f, 2); cmp(al, 0xb);                             /* cmp al, 0xb */
            ii(0x18_eb91, 2); if(jz(0x18_eb96, 3)) goto l_0x18_eb96;    /* jz 0xeb96 */
            ii(0x18_eb93, 3); or(cl, 2);                                /* or cl, 0x2 */
        l_0x18_eb96:
            ii(0x18_eb96, 4); mov(memw_a32[ss, ebp + 20], cx);          /* mov [ebp+0x14], cx */
            ii(0x18_eb9a, 4); mov(memb_a32[ss, ebp + 28], ah);          /* mov [ebp+0x1c], ah */
            ii(0x18_eb9e, 3); mov(ax, memw[ds, 0x50]);                  /* mov ax, [0x50] */
            ii(0x18_eba1, 2); xchg(al, ah);                             /* xchg al, ah */
            ii(0x18_eba3, 4); mov(memw_a32[ss, ebp + 24], ax);          /* mov [ebp+0x18], ax */
            ii(0x18_eba7, 3); if(jmp_func(0x18_e067, -0xb43)) return;   /* jmp 0xe067 */
        }
    }
}
