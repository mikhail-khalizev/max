using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0f266aee-1042-44b7-ab06-cebbd8b8d4ac")]
        public void Method_0000_faed()
        {
            ii(0xfaed, 2);    pushd(edi);                               /* push edi */
            ii(0xfaef, 4);    mov(edi, memd_a16[ss, bp + 0x4]);         /* mov edi, [bp+0x4] */
            ii(0xfaf3, 2);    pushd(esi);                               /* push esi */
            ii(0xfaf5, 4);    shl(edi, 0x4);                            /* shl edi, 0x4 */
            ii(0xfaf9, 4);    movzx(esi, bp);                           /* movzx esi, bp */
            ii(0xfafd, 3);    add(di, memw_a16[ss, bp + 0x8]);          /* add di, [bp+0x8] */
            ii(0xfb00, 3);    add(si, 0xa);                             /* add si, 0xa */
            ii(0xfb03, 4);    mov(es, memw_a16[ds, 0xc2e]);             /* mov es, [0xc2e] */
            ii(0xfb07, 4);    movsd_a32(ss);                            /* a32 ss movsd */
            ii(0xfb0b, 2);    popd(esi);                                /* pop esi */
            ii(0xfb0d, 2);    popd(edi);                                /* pop edi */
            ii(0xfb0f, 1);    popw(bp);                                 /* pop bp */
            ii(0xfb10, 1);    retw(); return;                           /* ret */
        }
    }
}
