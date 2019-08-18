using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1298-d10019c7")]
        public void Method_0001_1298()
        {
            ii(0x1_1298, 1);  popw(ax);                                 /* pop ax */
            ii(0x1_1299, 1);  pushw(cs);                                /* push cs */
            ii(0x1_129a, 1);  pushw(ax);                                /* push ax */
            ii(0x1_129b, 1);  pushw(bp);                                /* push bp */
            ii(0x1_129c, 2);  mov(bp, sp);                              /* mov bp, sp */
            ii(0x1_129e, 2);  pushad();                                 /* pushad */
            ii(0x1_12a0, 2);  pushw(fs);                                /* push fs */
            ii(0x1_12a2, 2);  pushw(gs);                                /* push gs */
            ii(0x1_12a4, 2);  pushw(0);                                 /* push 0x0 */
            ii(0x1_12a6, 5);  callw_far_abs(0x18, 0x2aeb);              /* call word 0x18:0x2aeb */
            ii(0x1_12ab, 4);  mov(edi, memd_a16[ss, bp + 0x6]);         /* mov edi, [bp+0x6] */
            ii(0x1_12af, 4);  shr(edi, 0x6);                            /* shr edi, 0x6 */
            ii(0x1_12b3, 3);  add(edi, esi);                            /* add edi, esi */
            ii(0x1_12b6, 4);  mov(ecx, memd_a16[ss, bp + 0xa]);         /* mov ecx, [bp+0xa] */
            ii(0x1_12ba, 4);  shr(ecx, 0x6);                            /* shr ecx, 0x6 */
            ii(0x1_12be, 3);  add(ecx, esi);                            /* add ecx, esi */
            ii(0x1_12c1, 5);  mov(ebx, memd_a16[ds, 0x9c]);             /* mov ebx, [0x9c] */
            ii(0x1_12c6, 6);  movsx(eax, memw_a16[ds, 0xdf0]);          /* movsx eax, word [0xdf0] */
            ii(0x1_12cc, 3);  not(eax);                                 /* not eax */
            ii(0x1_12cf, 3);  add(ebx, eax);                            /* add ebx, eax */
            ii(0x1_12d2, 4);  and(bx, memw_a16[ds, 0xdf0]);             /* and bx, [0xdf0] */
            ii(0x1_12d6, 4);  shr(ebx, 0x6);                            /* shr ebx, 0x6 */
            ii(0x1_12da, 3);  add(ebx, esi);                            /* add ebx, esi */
            ii(0x1_12dd, 3);  cmp(ecx, ebx);                            /* cmp ecx, ebx */
            ii(0x1_12e0, 2);  if(jaew_func(0x1_1311, 0x2f)) return;     /* jae 0x1311 */
            ii(0x1_12e2, 3);  mov(ax, 0xfffc);                          /* mov ax, 0xfffc */
            ii(0x1_12e5, 2);  and(di, ax);                              /* and di, ax */
            ii(0x1_12e7, 2);  and(cx, ax);                              /* and cx, ax */
        }
    }
}
