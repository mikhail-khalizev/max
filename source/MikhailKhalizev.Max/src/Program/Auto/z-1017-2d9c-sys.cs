using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_2d9c-8f080b7e")]
        public void /* sys */ Method_1017_2d9c()
        {
            ii(0x1017_2d9c, 1); pushad();                               /* pushad */
            ii(0x1017_2d9d, 1); pushd(ds);                              /* push ds */
            ii(0x1017_2d9e, 1); pushd(es);                              /* push es */
            ii(0x1017_2d9f, 2); pushd(fs);                              /* push fs */
            ii(0x1017_2da1, 2); pushd(gs);                              /* push gs */
            ii(0x1017_2da3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_2da5, 1); cld();                                  /* cld */
            ii(0x1017_2da6, 5); calld(/* sys */ 0x1016_c9d0, -0x63db);  /* call 0x1016c9d0 */
            ii(0x1017_2dab, 5); mov(edx, 0x60);                         /* mov edx, 0x60 */
            ii(0x1017_2db0, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1017_2db2, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1017_2db3, 6); mov(ebx, memd_a32[ds, 0x101b_e1e4]);    /* mov ebx, [0x101be1e4] */
            ii(0x1017_2db9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_2dbb, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_2dbd, 2); if(jnzd(0x1017_2df2, 0x33)) goto l_0x1017_2df2; /* jnz 0x10172df2 */
            ii(0x1017_2dbf, 7); cmp(memd_a32[ds, 0x101b_e85c], 0x1);    /* cmp dword [0x101be85c], 0x1 */
            ii(0x1017_2dc6, 3); setz(al);                               /* setz al */
            ii(0x1017_2dc9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_2dce, 2); if(jzd(0x1017_2dea, 0x1a)) goto l_0x1017_2dea; /* jz 0x10172dea */
            ii(0x1017_2dd0, 7); test(memb_a32[ds, 0x101b_e868], 0x1);   /* test byte [0x101be868], 0x1 */
            ii(0x1017_2dd7, 2); if(jzd(0x1017_2df2, 0x19)) goto l_0x1017_2df2; /* jz 0x10172df2 */
            ii(0x1017_2dd9, 10); mov(memd_a32[ds, 0x101b_e86c], 0x2);   /* mov dword [0x101be86c], 0x2 */
            ii(0x1017_2de3, 5); calld(/* sys */ 0x1018_62e4, 0x1_34fc); /* call 0x101862e4 */
            ii(0x1017_2de8, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1017_2dea:
            ii(0x1017_2dea, 3); mov(ax, dx);                            /* mov ax, dx */
            ii(0x1017_2ded, 5); calld(/* sys */ 0x1017_2e04, 0x12);     /* call 0x10172e04 */
        l_0x1017_2df2:
            ii(0x1017_2df2, 2); mov(al, 0x20);                          /* mov al, 0x20 */
            ii(0x1017_2df4, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1017_2df9, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1017_2dfa, 2); popd(gs);                               /* pop gs */
            ii(0x1017_2dfc, 2); popd(fs);                               /* pop fs */
            ii(0x1017_2dfe, 1); popd(es);                               /* pop es */
            ii(0x1017_2dff, 1); popd(ds);                               /* pop ds */
            ii(0x1017_2e00, 1); popad();                                /* popad */
            ii(0x1017_2e01, 1); iretd(); return;                        /* iretd */
        }
    }
}
