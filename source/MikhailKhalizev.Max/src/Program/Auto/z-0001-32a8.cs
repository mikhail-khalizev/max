using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_32a8-d10019c7")]
        public void Method_0001_32a8()
        {
            ii(0x1_32a8, 1);  pop(ax);                                  /* pop ax */
            ii(0x1_32a9, 1);  push(cs);                                 /* push cs */
            ii(0x1_32aa, 1);  push(ax);                                 /* push ax */
            ii(0x1_32ab, 1);  push(bp);                                 /* push bp */
            ii(0x1_32ac, 2);  mov(bp, sp);                              /* mov bp, sp */
            ii(0x1_32ae, 2);  pushad();                                 /* pushad */
            ii(0x1_32b0, 2);  push(fs);                                 /* push fs */
            ii(0x1_32b2, 2);  push(gs);                                 /* push gs */
            ii(0x1_32b4, 2);  push(0);                                  /* push 0x0 */
            ii(0x1_32b6, 5);  call_far_abs(0x18, 0x2aeb);               /* call word 0x18:0x2aeb */
            ii(0x1_32bb, 4);  mov(edi, memd[ss, bp + 6]);               /* mov edi, [bp+0x6] */
            ii(0x1_32bf, 4);  shr(edi, 6);                              /* shr edi, 0x6 */
            ii(0x1_32c3, 3);  add(edi, esi);                            /* add edi, esi */
            ii(0x1_32c6, 4);  mov(ecx, memd[ss, bp + 0xa]);             /* mov ecx, [bp+0xa] */
            ii(0x1_32ca, 4);  shr(ecx, 6);                              /* shr ecx, 0x6 */
            ii(0x1_32ce, 3);  add(ecx, esi);                            /* add ecx, esi */
            ii(0x1_32d1, 5);  mov(ebx, memd[ds, 0x9c]);                 /* mov ebx, [0x9c] */
            ii(0x1_32d6, 6);  movsx(eax, memw[ds, 0xdf0]);              /* movsx eax, word [0xdf0] */
            ii(0x1_32dc, 3);  not(eax);                                 /* not eax */
            ii(0x1_32df, 3);  add(ebx, eax);                            /* add ebx, eax */
            ii(0x1_32e2, 4);  and(bx, memw[ds, 0xdf0]);                 /* and bx, [0xdf0] */
            ii(0x1_32e6, 4);  shr(ebx, 6);                              /* shr ebx, 0x6 */
            ii(0x1_32ea, 3);  add(ebx, esi);                            /* add ebx, esi */
            ii(0x1_32ed, 3);  cmp(ecx, ebx);                            /* cmp ecx, ebx */
            ii(0x1_32f0, 2);  if(jae_func(0x1_3321, 0x2f)) return;      /* jae 0x3321 */
            ii(0x1_32f2, 3);  mov(ax, 0xfffc);                          /* mov ax, 0xfffc */
            ii(0x1_32f5, 2);  and(di, ax);                              /* and di, ax */
            ii(0x1_32f7, 2);  and(cx, ax);                              /* and cx, ax */
        }
    }
}
