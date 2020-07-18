using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e9b0-70874de1")]
        public void Method_0018_e9b0()
        {
            ii(0x18_e9b0, 3);  call(0x18_e868, -0x14b);                /* call 0xe868 */
            ii(0x18_e9b3, 3);  call(0x18_e958, -0x5e);                 /* call 0xe958 */
            ii(0x18_e9b6, 3);  mov(bx, 0x4d6c);                        /* mov bx, 0x4d6c */
        l_0x18_e9b9:
            ii(0x18_e9b9, 3);  add(bx, 0xc);                           /* add bx, 0xc */
            ii(0x18_e9bc, 4);  cmp(bx, 0x4e38);                        /* cmp bx, 0x4e38 */
            ii(0x18_e9c0, 2);  if(jae_func(0x18_e9ad, -0x15)) return;  /* jae 0xe9ad */
            ii(0x18_e9c2, 4);  cmp(memw[ds, bx + 4], 0);               /* cmp word [bx+0x4], 0x0 */
            ii(0x18_e9c6, 2);  if(jnz(0x18_e9b9, -0xf)) goto l_0x18_e9b9;/* jnz 0xe9b9 */
            ii(0x18_e9c8, 5);  mov(eax, memd_a32[ss, ebp + 8]);        /* mov eax, [ebp+0x8] */
            ii(0x18_e9cd, 3);  mov(memd[ds, bx], eax);                 /* mov [bx], eax */
            ii(0x18_e9d0, 4);  mov(ax, memw_a32[ss, ebp]);             /* mov ax, [ebp] */
            ii(0x18_e9d4, 3);  mov(memw[ds, bx + 4], ax);              /* mov [bx+0x4], ax */
            ii(0x18_e9d7, 5);  mov(eax, memd_a32[ss, ebp + 4]);        /* mov eax, [ebp+0x4] */
            ii(0x18_e9dc, 5);  and(eax, memd_a32[ss, ebp - 4]);        /* and eax, [ebp-0x4] */
            ii(0x18_e9e1, 4);  mov(memd[ds, bx + 6], eax);             /* mov [bx+0x6], eax */
            ii(0x18_e9e5, 4);  mov(ax, memw_a32[ss, ebp + 2]);         /* mov ax, [ebp+0x2] */
            ii(0x18_e9e9, 3);  mov(memw[ds, bx + 10], ax);             /* mov [bx+0xa], ax */
            ii(0x18_e9ec, 4);  sub(bx, 0x4d78);                        /* sub bx, 0x4d78 */
            ii(0x18_e9f0, 1);  xchg(bx, ax);                           /* xchg bx, ax */
            ii(0x18_e9f1, 2);  mov(cl, 0xc);                           /* mov cl, 0xc */
            ii(0x18_e9f3, 2);  div(cl);                                /* div cl */
            ii(0x18_e9f5, 3);  shl(ax, 2);                             /* shl ax, 0x2 */
            ii(0x18_e9f8, 3);  add(ax, 0x1f60);                        /* add ax, 0x1f60 */
            ii(0x18_e9fb, 4);  mov(memw_a32[ss, ebp + 24], ax);        /* mov [ebp+0x18], ax */
            ii(0x18_e9ff, 2);  push(0x20);                             /* push 0x20 */
            ii(0x18_ea01, 1);  pop(ds);                                /* pop ds */
            ii(0x18_ea02, 3);  mov(ax, memw[ds, 0x9b6]);               /* mov ax, [0x9b6] */
            ii(0x18_ea05, 4);  mov(memw_a32[ss, ebp + 28], ax);        /* mov [ebp+0x1c], ax */
            ii(0x18_ea09, 3);  jmp_func(0x18_e067, -0x9a5);            /* jmp 0xe067 */
        }
    }
}
