using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_efe8-8be945ae")]
        public void Method_0018_efe8()
        {
            ii(0x18_efe8, 1); cli();                                    /* cli */
            ii(0x18_efe9, 1); cld();                                    /* cld */
            ii(0x18_efea, 2); pushad();                                 /* pushad */
            ii(0x18_efec, 1); pushw(es);                                /* push es */
            ii(0x18_efed, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_efef, 4); les(edi, ss, bp + 0x34);                  /* les edi, [bp+0x34] */
            ii(0x18_eff3, 4); sub(edi, 0x18);                           /* sub edi, 0x18 */
            ii(0x18_eff7, 3); mov(eax, edi);                            /* mov eax, edi */
            ii(0x18_effa, 4); xchg(memd_a16[ss, bp + 0x2], eax);        /* xchg [bp+0x2], eax */
            ii(0x18_effe, 3); stosd_a32();                              /* a32 stosd */
            ii(0x18_f001, 2); nop();                                    /* a32 nop */
            ii(0x18_f003, 3); mov(ax, memw_a16[ss, bp + 0x3c]);         /* mov ax, [bp+0x3c] */
            ii(0x18_f006, 3); mov(ax, memw_a16[ss, bp + 0x3a]);         /* mov ax, [bp+0x3a] */
            ii(0x18_f009, 4); lea(esi, bp + 0x22);                      /* lea esi, [bp+0x22] */
            ii(0x18_f00d, 6); mov(ecx, 0x4);                            /* mov ecx, 0x4 */
            ii(0x18_f013, 3); movsw_a32(ss);                            /* a32 ss movsw */
            ii(0x18_f016, 2); stosw_a32();                              /* a32 stosw */
            ii(0x18_f018, 5); rep_a32(() => movsd_a32(ss));             /* a32 ss rep movsd */
            ii(0x18_f01d, 2); pushw(0x20);                              /* push 0x20 */
            ii(0x18_f01f, 1); popw(es);                                 /* pop es */
            ii(0x18_f020, 7); sub(memw_a16[es, 0xc16], 0x400);          /* sub word [es:0xc16], 0x400 */
            ii(0x18_f027, 1); popw(es);                                 /* pop es */
            ii(0x18_f028, 2); popad();                                  /* popad */
            ii(0x18_f02a, 3); add(sp, 0x16);                            /* add sp, 0x16 */
            ii(0x18_f02d, 1); popw(ss);                                 /* pop ss */
            ii(0x18_f02e, 3); mov(esp, edi);                            /* mov esp, edi */
            ii(0x18_f031, 2); popd(edi);                                /* pop edi */
            ii(0x18_f033, 1); retw(); return;                           /* ret */
        }
    }
}
