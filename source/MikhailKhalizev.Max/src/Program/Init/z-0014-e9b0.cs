using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5b952c9b-de84-41a1-8e6d-16a361305bf0")]
        public void Method_0014_e9b0()
        {
            ii(0x14_e9b0, 3); callw(0x14_e868, -0x14b);                 /* call 0xe868 */
            ii(0x14_e9b3, 3); callw(0x14_e958, -0x5e);                  /* call 0xe958 */
            ii(0x14_e9b6, 3); mov(bx, 0x4d6c);                          /* mov bx, 0x4d6c */
        l_0x14_e9b9:
            ii(0x14_e9b9, 3); add(bx, 0xc);                             /* add bx, 0xc */
            ii(0x14_e9bc, 4); cmp(bx, 0x4e38);                          /* cmp bx, 0x4e38 */
            ii(0x14_e9c0, 2); jaew_func(0x14_e9ad, -0x15);              /* jae 0xe9ad */
            ii(0x14_e9c2, 4); cmp(memw_a16[ds, bx + 0x4], 0);           /* cmp word [bx+0x4], 0x0 */
            ii(0x14_e9c6, 2); if(jnzw(0x14_e9b9, -0xf)) goto l_0x14_e9b9; /* jnz 0xe9b9 */
            ii(0x14_e9c8, 5); mov(eax, memd_a32[ss, ebp + 0x8]);        /* mov eax, [ebp+0x8] */
            ii(0x14_e9cd, 3); mov(memd_a16[ds, bx], eax);               /* mov [bx], eax */
            ii(0x14_e9d0, 4); mov(ax, memw_a32[ss, ebp + 0]);           /* mov ax, [ebp] */
            ii(0x14_e9d4, 3); mov(memw_a16[ds, bx + 0x4], ax);          /* mov [bx+0x4], ax */
            ii(0x14_e9d7, 5); mov(eax, memd_a32[ss, ebp + 0x4]);        /* mov eax, [ebp+0x4] */
            ii(0x14_e9dc, 5); and(eax, memd_a32[ss, ebp - 0x4]);        /* and eax, [ebp-0x4] */
            ii(0x14_e9e1, 4); mov(memd_a16[ds, bx + 0x6], eax);         /* mov [bx+0x6], eax */
            ii(0x14_e9e5, 4); mov(ax, memw_a32[ss, ebp + 0x2]);         /* mov ax, [ebp+0x2] */
            ii(0x14_e9e9, 3); mov(memw_a16[ds, bx + 0xa], ax);          /* mov [bx+0xa], ax */
            ii(0x14_e9ec, 4); sub(bx, 0x4d78);                          /* sub bx, 0x4d78 */
            ii(0x14_e9f0, 1); xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x14_e9f1, 2); mov(cl, 0xc);                             /* mov cl, 0xc */
            ii(0x14_e9f3, 2); div(cl);                                  /* div cl */
            ii(0x14_e9f5, 3); shl(ax, 0x2);                             /* shl ax, 0x2 */
            ii(0x14_e9f8, 3); add(ax, 0x1f60);                          /* add ax, 0x1f60 */
            ii(0x14_e9fb, 4); mov(memw_a32[ss, ebp + 0x18], ax);        /* mov [ebp+0x18], ax */
            ii(0x14_e9ff, 2); pushw(0x20);                              /* push 0x20 */
            ii(0x14_ea01, 1); popw(ds);                                 /* pop ds */
            ii(0x14_ea02, 3); mov(ax, memw_a16[ds, 0x9b6]);             /* mov ax, [0x9b6] */
            ii(0x14_ea05, 4); mov(memw_a32[ss, ebp + 0x1c], ax);        /* mov [ebp+0x1c], ax */
            ii(0x14_ea09, 3); jmpw_func(0x14_e067, -0x9a5); return;     /* jmp 0xe067 */
        }
    }
}