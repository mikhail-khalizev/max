using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_f2d8-d10019c7")]
        public void Method_0018_f2d8()
        {
            ii(0x18_f2d8, 1);  pop(ax);                                /* pop ax */
            ii(0x18_f2d9, 1);  push(cs);                               /* push cs */
            ii(0x18_f2da, 1);  push(ax);                               /* push ax */
            ii(0x18_f2db, 1);  push(bp);                               /* push bp */
            ii(0x18_f2dc, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x18_f2de, 2);  pushad();                               /* pushad */
            ii(0x18_f2e0, 2);  push(fs);                               /* push fs */
            ii(0x18_f2e2, 2);  push(gs);                               /* push gs */
            ii(0x18_f2e4, 2);  push(0);                                /* push 0x0 */
            ii(0x18_f2e6, 5);  call_far_abs(0x18, 0x2aeb);             /* call word 0x18:0x2aeb */
            ii(0x18_f2eb, 4);  mov(edi, memd[ss, bp + 6]);             /* mov edi, [bp+0x6] */
            ii(0x18_f2ef, 4);  shr(edi, 6);                            /* shr edi, 0x6 */
            ii(0x18_f2f3, 3);  add(edi, esi);                          /* add edi, esi */
            ii(0x18_f2f6, 4);  mov(ecx, memd[ss, bp + 10]);            /* mov ecx, [bp+0xa] */
            ii(0x18_f2fa, 4);  shr(ecx, 6);                            /* shr ecx, 0x6 */
            ii(0x18_f2fe, 3);  add(ecx, esi);                          /* add ecx, esi */
            ii(0x18_f301, 5);  mov(ebx, memd[ds, 0x9c]);               /* mov ebx, [0x9c] */
            ii(0x18_f306, 6);  movsx(eax, memw[ds, 0xdf0]);            /* movsx eax, word [0xdf0] */
            ii(0x18_f30c, 3);  not(eax);                               /* not eax */
            ii(0x18_f30f, 3);  add(ebx, eax);                          /* add ebx, eax */
            ii(0x18_f312, 4);  and(bx, memw[ds, 0xdf0]);               /* and bx, [0xdf0] */
            ii(0x18_f316, 4);  shr(ebx, 6);                            /* shr ebx, 0x6 */
            ii(0x18_f31a, 3);  add(ebx, esi);                          /* add ebx, esi */
            ii(0x18_f31d, 3);  cmp(ecx, ebx);                          /* cmp ecx, ebx */
            ii(0x18_f320, 2);  if(jae_func(0x18_f351, 0x2f)) return;   /* jae 0xf351 */
            ii(0x18_f322, 3);  mov(ax, 0xfffc);                        /* mov ax, 0xfffc */
            ii(0x18_f325, 2);  and(di, ax);                            /* and di, ax */
            ii(0x18_f327, 2);  and(cx, ax);                            /* and cx, ax */
        }
    }
}
