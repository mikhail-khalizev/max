using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_da94-e68b3a62")]
        public void Method_0018_da94()
        {
            ii(0x18_da94, 1); pushw(bp);                                /* push bp */
            ii(0x18_da95, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_da97, 2); pushw(0x8);                               /* push 0x8 */
            ii(0x18_da99, 1); popw(ds);                                 /* pop ds */
            ii(0x18_da9a, 1); pushfw();                                 /* pushfw */
            ii(0x18_da9b, 1); cli();                                    /* cli */
            ii(0x18_da9c, 3); mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x18_da9f, 3); and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0x18_daa2, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x18_daa5, 2); mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x18_daa7, 3); mov(al, memb_a16[ss, bp + 0xc]);          /* mov al, [bp+0xc] */
            ii(0x18_daaa, 3); mov(memb_a16[ds, bx + 0x5], al);          /* mov [bx+0x5], al */
            ii(0x18_daad, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x18_dab0, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x18_dab3, 3); mov(cx, 0x4);                             /* mov cx, 0x4 */
        l_0x18_dab6:
            ii(0x18_dab6, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x18_dab8, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x18_daba, 2); if(loopw_a16(0x18_dab6, -0x6)) goto l_0x18_dab6; /* loop 0xdab6 */
            ii(0x18_dabc, 3); mov(memw_a16[ds, bx + 0x2], ax);          /* mov [bx+0x2], ax */
            ii(0x18_dabf, 3); mov(memb_a16[ds, bx + 0x4], dl);          /* mov [bx+0x4], dl */
            ii(0x18_dac2, 3); mov(memb_a16[ds, bx + 0x7], dh);          /* mov [bx+0x7], dh */
            ii(0x18_dac5, 1); popw(dx);                                 /* pop dx */
            ii(0x18_dac6, 1); popw(bp);                                 /* pop bp */
            ii(0x18_dac7, 1); popw(ax);                                 /* pop ax */
            ii(0x18_dac8, 2); mov(cx, ss);                              /* mov cx, ss */
            ii(0x18_daca, 2); mov(ss, cx);                              /* mov ss, cx */
            ii(0x18_dacc, 2); pushw(0x20);                              /* push 0x20 */
            ii(0x18_dace, 1); popw(ds);                                 /* pop ds */
            ii(0x18_dacf, 1); pushw(dx);                                /* push dx */
            ii(0x18_dad0, 1); popfw();                                  /* popfw */
            ii(0x18_dad1, 2); if(jmpw_abs(ax)) return;                  /* jmp ax */
            ii(0x18_dad3, 1); pushw(bp);                                /* push bp */
            ii(0x18_dad4, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_dad6, 1); pushw(es);                                /* push es */
            ii(0x18_dad7, 1); pushw(di);                                /* push di */
            ii(0x18_dad8, 3); mov(es, memw_a16[ss, bp + 0x4]);          /* mov es, [bp+0x4] */
            ii(0x18_dadb, 3); mov(di, memw_a16[ss, bp + 0x6]);          /* mov di, [bp+0x6] */
            ii(0x18_dade, 3); mov(cx, memw_a16[ss, bp + 0x8]);          /* mov cx, [bp+0x8] */
            ii(0x18_dae1, 3); mov(al, memb_a16[ss, bp + 0xa]);          /* mov al, [bp+0xa] */
            ii(0x18_dae4, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x18_dae6, 1); cld();                                    /* cld */
            ii(0x18_dae7, 3); sub(cx, 0x1);                             /* sub cx, 0x1 */
            ii(0x18_daea, 1); inc(cx);                                  /* inc cx */
            ii(0x18_daeb, 2); rcr(cx, 0x1);                             /* rcr cx, 1 */
            ii(0x18_daed, 2); rep_a16(() => stosw_a16());               /* rep stosw */
            ii(0x18_daef, 2); rcl(cx, 0x1);                             /* rcl cx, 1 */
            ii(0x18_daf1, 2); rep_a16(() => stosb_a16());               /* rep stosb */
            ii(0x18_daf3, 1); popw(di);                                 /* pop di */
            ii(0x18_daf4, 1); popw(es);                                 /* pop es */
            ii(0x18_daf5, 1); popw(bp);                                 /* pop bp */
            ii(0x18_daf6, 1); retw(); return;                           /* ret */
        //  ii(0x18_daf7, 16); Недостижимый (и не декодированный) код.
        //    ii(0x18_db07, 2); pushd(ebx);                               /* push ebx */
        //    ii(0x18_db09, 4); mov(ebx, memd_a16[ss, bp + 0x4]);         /* mov ebx, [bp+0x4] */
        //    ii(0x18_db0d, 2); pushd(esi);                               /* push esi */
        //    ii(0x18_db0f, 4); shl(ebx, 0x4);                            /* shl ebx, 0x4 */
        //    ii(0x18_db13, 5); movzx(esi, memw_a16[ss, bp + 0x8]);       /* movzx esi, word [bp+0x8] */
        //    ii(0x18_db18, 4); mov(es, memw_a16[ds, 0xc2e]);             /* mov es, [0xc2e] */
        //    ii(0x18_db1c, 5); mov(ax, memw_a32[es, ebx + esi]);         /* mov ax, [es:ebx+esi] */
        //    ii(0x18_db21, 6); mov(dx, memw_a32[es, ebx + esi + 0x2]);   /* mov dx, [es:ebx+esi+0x2] */
        //    ii(0x18_db27, 2); popd(esi);                                /* pop esi */
        //    ii(0x18_db29, 2); popd(ebx);                                /* pop ebx */
        //    ii(0x18_db2b, 1); popw(bp);                                 /* pop bp */
        //    ii(0x18_db2c, 1); retw(); return;                           /* ret */
        }
    }
}
