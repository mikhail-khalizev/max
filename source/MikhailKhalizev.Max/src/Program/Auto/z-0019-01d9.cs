using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3a98205b-da24-47cb-bf08-9ce4fd3900f7")]
        public void Method_0019_01d9()
        {
            ii(0x19_01d9, 2); pushd(edx);                               /* push edx */
            ii(0x19_01db, 3); mov(dx, 0x1);                             /* mov dx, 0x1 */
            ii(0x19_01de, 1); pushw(ds);                                /* push ds */
            ii(0x19_01df, 2); pushd(esi);                               /* push esi */
            ii(0x19_01e1, 3); mov(si, 0xa8);                            /* mov si, 0xa8 */
            ii(0x19_01e4, 2); mov(ds, si);                              /* mov ds, si */
            ii(0x19_01e6, 5); mov(esi, memd_a16[ds, 0xa42]);            /* mov esi, [0xa42] */
            ii(0x19_01eb, 4); popd(memd_a16[ds, si + 0x10]);            /* pop dword [si+0x10] */
            ii(0x19_01ef, 3); popw(memw_a16[ds, si + 0x4]);             /* pop word [si+0x4] */
            ii(0x19_01f2, 4); popd(memd_a16[ds, si + 0x20]);            /* pop dword [si+0x20] */
            ii(0x19_01f6, 4); mov(memd_a16[ds, si + 0x28], eax);        /* mov [si+0x28], eax */
            ii(0x19_01fa, 4); mov(memd_a16[ds, si + 0x1c], ebx);        /* mov [si+0x1c], ebx */
            ii(0x19_01fe, 4); mov(memd_a16[ds, si + 0x24], ecx);        /* mov [si+0x24], ecx */
            ii(0x19_0202, 4); mov(memd_a16[ds, si + 0xc], edi);         /* mov [si+0xc], edi */
            ii(0x19_0206, 4); mov(memd_a16[ds, si + 0x14], ebp);        /* mov [si+0x14], ebp */
            ii(0x19_020a, 3); mov(memw_a16[ds, si + 0x6], es);          /* mov [si+0x6], es */
            ii(0x19_020d, 3); mov(memw_a16[ds, si + 0x8], fs);          /* mov [si+0x8], fs */
            ii(0x19_0210, 3); mov(memw_a16[ds, si + 0xa], gs);          /* mov [si+0xa], gs */
            ii(0x19_0213, 3); mov(eax, ds);                             /* mov eax, ds */
            ii(0x19_0216, 3); mov(ebx, ss);                             /* mov ebx, ss */
            ii(0x19_0219, 3); cmp(ebx, eax);                            /* cmp ebx, eax */
            ii(0x19_021c, 2); if(jzw(0x19_0234, 0x16)) goto l_0x19_0234; /* jz 0x234 */
            ii(0x19_021e, 4); cmp(bx, memw_a16[ds, 0]);                 /* cmp bx, [0x0] */
            ii(0x19_0222, 2); if(jzw(0x19_0234, 0x10)) goto l_0x19_0234; /* jz 0x234 */
            ii(0x19_0224, 3); mov(eax, esi);                            /* mov eax, esi */
            ii(0x19_0227, 6); sub(eax, 0x2c8);                          /* sub eax, 0x2c8 */
            ii(0x19_022d, 2); mov(bp, ds);                              /* mov bp, ds */
            ii(0x19_022f, 2); mov(ss, bp);                              /* mov ss, bp */
            ii(0x19_0231, 3); mov(esp, eax);                            /* mov esp, eax */
        l_0x19_0234:
            ii(0x19_0234, 1); pushw(dx);                                /* push dx */
            ii(0x19_0235, 4); movzx(ebp, sp);                           /* movzx ebp, sp */
            ii(0x19_0239, 1); pushw(ds);                                /* push ds */
            ii(0x19_023a, 1); pushw(si);                                /* push si */
            ii(0x19_023b, 3); mov(al, memb_a16[ds, si + 0x38]);         /* mov al, [si+0x38] */
            ii(0x19_023e, 3); movzx(ax, al);                            /* movzx ax, al */
            ii(0x19_0241, 3); shl(ax, 0x3);                             /* shl ax, 0x3 */
            ii(0x19_0244, 1); pushw(ax);                                /* push ax */
            ii(0x19_0245, 1); nop();                                    /* nop */
            ii(0x19_0246, 1); pushw(cs);                                /* push cs */
            ii(0x19_0247, 3); callw(0x19_0074, -0x1d6);                 /* call 0x74 */
            ii(0x19_024a, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_024c, 5); mov(esi, memd_a16[ds, 0xa42]);            /* mov esi, [0xa42] */
            ii(0x19_0251, 1); popw(dx);                                 /* pop dx */
            ii(0x19_0252, 3); pushw(memw_a16[ds, si + 0x4]);            /* push word [si+0x4] */
            ii(0x19_0255, 4); pushd(memd_a16[ds, si + 0x20]);           /* push dword [si+0x20] */
            ii(0x19_0259, 3); pushw(memw_a16[ds, si + 0x3a]);           /* push word [si+0x3a] */
            ii(0x19_025c, 3); pushw(memw_a16[ds, si + 0x6]);            /* push word [si+0x6] */
            ii(0x19_025f, 1); popw(es);                                 /* pop es */
            ii(0x19_0260, 3); pushw(memw_a16[ds, si + 0x8]);            /* push word [si+0x8] */
            ii(0x19_0263, 2); popw(fs);                                 /* pop fs */
            ii(0x19_0265, 3); pushw(memw_a16[ds, si + 0xa]);            /* push word [si+0xa] */
            ii(0x19_0268, 2); popw(gs);                                 /* pop gs */
            ii(0x19_026a, 4); mov(eax, memd_a16[ds, si + 0x28]);        /* mov eax, [si+0x28] */
            ii(0x19_026e, 4); mov(ebx, memd_a16[ds, si + 0x1c]);        /* mov ebx, [si+0x1c] */
            ii(0x19_0272, 4); mov(ecx, memd_a16[ds, si + 0x24]);        /* mov ecx, [si+0x24] */
            ii(0x19_0276, 4); mov(ebp, memd_a16[ds, si + 0x14]);        /* mov ebp, [si+0x14] */
            ii(0x19_027a, 4); mov(edi, memd_a16[ds, si + 0xc]);         /* mov edi, [si+0xc] */
            ii(0x19_027e, 4); mov(esi, memd_a16[ds, si + 0x10]);        /* mov esi, [si+0x10] */
            ii(0x19_0282, 2); test(dx, dx);                             /* test dx, dx */
            ii(0x19_0284, 4); movzx(edx, sp);                           /* movzx edx, sp */
            ii(0x19_0288, 2); if(jzw(0x19_0294, 0xa)) goto l_0x19_0294; /* jz 0x294 */
            ii(0x19_028a, 5); popw(memw_a32[ss, edx + 0x10]);           /* pop word [ss:edx+0x10] */
            ii(0x19_028f, 2); popd(edx);                                /* pop edx */
            ii(0x19_0291, 1); popw(ds);                                 /* pop ds */
            ii(0x19_0292, 2); iretd(); return;                          /* iretd */
        l_0x19_0294:
            ii(0x19_0294, 5); popw(memw_a32[ss, edx + 0xc]);            /* pop word [ss:edx+0xc] */
            ii(0x19_0299, 2); popd(edx);                                /* pop edx */
            ii(0x19_029b, 1); popw(ds);                                 /* pop ds */
            ii(0x19_029c, 1); iretw(); return;                          /* iretw */
        }
    }
}
