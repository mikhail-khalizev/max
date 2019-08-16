using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0d2660b9-2f83-417e-a6ee-43668fa640d8")]
        public void /* sys */ Method_1019_49bd()
        {
            ii(0x1019_49bd, 1); pushd(ds);                              /* push ds */
            ii(0x1019_49be, 5); calld(/* sys */ 0x1016_c9d0, -0x2_7ff3); /* call 0x1016c9d0 */
            ii(0x1019_49c3, 8); cmp(memw_a32[ds, 0x101c_1a52], 0x1);    /* cmp word [0x101c1a52], 0x1 */
            ii(0x1019_49cb, 1); popd(ds);                               /* pop ds */
            ii(0x1019_49cc, 2); if(jzd(0x1019_4a27, 0x59)) goto l_0x1019_4a27; /* jz 0x10194a27 */
            ii(0x1019_49ce, 1); nop();                                  /* nop */
            ii(0x1019_49cf, 1); nop();                                  /* nop */
            ii(0x1019_49d0, 1); nop();                                  /* nop */
            ii(0x1019_49d1, 1); nop();                                  /* nop */
            ii(0x1019_49d2, 1); pushad();                               /* pushad */
            ii(0x1019_49d3, 1); pushd(es);                              /* push es */
            ii(0x1019_49d4, 2); pushd(fs);                              /* push fs */
            ii(0x1019_49d6, 2); pushd(gs);                              /* push gs */
            ii(0x1019_49d8, 1); pushd(ds);                              /* push ds */
            ii(0x1019_49d9, 1); sti();                                  /* sti */
            ii(0x1019_49da, 4); mov(dx, 0x20);                          /* mov dx, 0x20 */
            ii(0x1019_49de, 2); mov(al, 0x20);                          /* mov al, 0x20 */
            ii(0x1019_49e0, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1019_49e1, 5); calld(/* sys */ 0x1016_c9d0, -0x2_8016); /* call 0x1016c9d0 */
            ii(0x1019_49e6, 1); pushd(ds);                              /* push ds */
            ii(0x1019_49e7, 1); popd(es);                               /* pop es */
            ii(0x1019_49e8, 9); mov(memw_a32[ds, 0x101c_1a52], 0x1);    /* mov word [0x101c1a52], 0x1 */
            ii(0x1019_49f1, 6); mov(memd_a32[ds, 0x101c_0a4a], esp);    /* mov [0x101c0a4a], esp */
            ii(0x1019_49f7, 7); mov(memw_a32[ds, 0x101c_0a4e], ss);     /* mov [0x101c0a4e], ss */
            ii(0x1019_49fe, 7); lss(esp, ds, 0x101c_0a42);              /* lss esp, [0x101c0a42] */
            ii(0x1019_4a05, 6); calld_a32_far_ind(ds, 0x101c_0a38);     /* call far dword [0x101c0a38] */
            ii(0x1019_4a0b, 1); cli();                                  /* cli */
            ii(0x1019_4a0c, 7); lss(esp, ds, 0x101c_0a4a);              /* lss esp, [0x101c0a4a] */
            ii(0x1019_4a13, 2); mov(al, 0x20);                          /* mov al, 0x20 */
            ii(0x1019_4a15, 2); outb(0x20, al);                         /* out 0x20, al */
            ii(0x1019_4a17, 9); mov(memw_a32[ds, 0x101c_1a52], 0);      /* mov word [0x101c1a52], 0x0 */
            ii(0x1019_4a20, 1); popd(ds);                               /* pop ds */
            ii(0x1019_4a21, 2); popd(gs);                               /* pop gs */
            ii(0x1019_4a23, 2); popd(fs);                               /* pop fs */
            ii(0x1019_4a25, 1); popd(es);                               /* pop es */
            ii(0x1019_4a26, 1); popad();                                /* popad */
        l_0x1019_4a27:
            ii(0x1019_4a27, 1); iretd(); return;                        /* iretd */
        }
    }
}
