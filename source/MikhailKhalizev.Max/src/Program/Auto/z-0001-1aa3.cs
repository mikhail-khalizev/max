using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("15a183d7-8f62-410a-88c5-2942ba6dc517")]
        public void Method_0001_1aa3()
        {
            ii(0x1_1aa3, 1);  pushw(bp);                                /* push bp */
            ii(0x1_1aa4, 2);  mov(bp, sp);                              /* mov bp, sp */
            ii(0x1_1aa6, 1);  pushw(es);                                /* push es */
            ii(0x1_1aa7, 1);  pushw(di);                                /* push di */
            ii(0x1_1aa8, 3);  mov(es, memw_a16[ss, bp + 0x4]);          /* mov es, [bp+0x4] */
            ii(0x1_1aab, 3);  mov(di, memw_a16[ss, bp + 0x6]);          /* mov di, [bp+0x6] */
            ii(0x1_1aae, 3);  mov(cx, memw_a16[ss, bp + 0x8]);          /* mov cx, [bp+0x8] */
            ii(0x1_1ab1, 3);  mov(al, memb_a16[ss, bp + 0xa]);          /* mov al, [bp+0xa] */
            ii(0x1_1ab4, 2);  mov(ah, al);                              /* mov ah, al */
            ii(0x1_1ab6, 1);  cld();                                    /* cld */
            ii(0x1_1ab7, 3);  sub(cx, 0x1);                             /* sub cx, 0x1 */
            ii(0x1_1aba, 1);  inc(cx);                                  /* inc cx */
            ii(0x1_1abb, 2);  rcr(cx, 0x1);                             /* rcr cx, 1 */
            ii(0x1_1abd, 2);  rep_a16(() => stosw_a16());               /* rep stosw */
            ii(0x1_1abf, 2);  rcl(cx, 0x1);                             /* rcl cx, 1 */
            ii(0x1_1ac1, 2);  rep_a16(() => stosb_a16());               /* rep stosb */
            ii(0x1_1ac3, 1);  popw(di);                                 /* pop di */
            ii(0x1_1ac4, 1);  popw(es);                                 /* pop es */
            ii(0x1_1ac5, 1);  popw(bp);                                 /* pop bp */
            ii(0x1_1ac6, 1);  retw(); return;                           /* ret */
        }
    }
}
