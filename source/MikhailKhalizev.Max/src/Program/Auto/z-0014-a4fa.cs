using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d4f364ca-b88c-4957-a691-87b4a21410ae")]
        public void Method_0014_a4fa()
        {
            ii(0x14_a4fa, 4); mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x14_a4fe, 3); mov(ss, memw_a16[ds, bx + 0x2]);          /* mov ss, [bx+0x2] */
            ii(0x14_a501, 3); mov(sp, memw_a16[ds, bx + 0xe]);          /* mov sp, [bx+0xe] */
            ii(0x14_a504, 3); mov(es, memw_a16[ss, bp + 0x6]);          /* mov es, [bp+0x6] */
            ii(0x14_a507, 3); mov(di, memw_a16[ds, bx + 0x8]);          /* mov di, [bx+0x8] */
            ii(0x14_a50a, 3); mov(si, memw_a16[ds, bx + 0xa]);          /* mov si, [bx+0xa] */
            ii(0x14_a50d, 3); pushw(memw_a16[ds, si + 0x4]);            /* push word [si+0x4] */
            ii(0x14_a510, 3); mov(cx, 0x15);                            /* mov cx, 0x15 */
            ii(0x14_a513, 1); cld();                                    /* cld */
            ii(0x14_a514, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x14_a516, 1); popw(cx);                                 /* pop cx */
            ii(0x14_a517, 2); jcxzw_func(0x14_a56b, 0x52);              /* jcxz 0xa56b */
            ii(0x14_a519, 1); retw(); return;                           /* ret */
        }
    }
}
