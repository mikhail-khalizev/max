using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f1af3fee-d97b-46a1-8151-7ed699f1ed0d")]
        public void /* sys */ Method_1018_7204()
        {
            ii(0x1018_7204, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_7205, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_7207, 3); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1018_720a, 6); fcom(memq_a32[ds, 0x101b_e8a0]);        /* fcom qword [0x101be8a0] */
            ii(0x1018_7210, 1); wait();                                 /* wait */
            ii(0x1018_7211, 3); fnstsw(memw_a32[ss, ebp - 0x10]);       /* fnstsw word [ebp-0x10] */
            ii(0x1018_7214, 1); wait();                                 /* wait */
            ii(0x1018_7215, 3); mov(ah, memb_a32[ss, ebp - 0xf]);       /* mov ah, [ebp-0xf] */
            ii(0x1018_7218, 1); sahf();                                 /* sahf */
            ii(0x1018_7219, 2); if(jbed(0x1018_7233, 0x18)) goto l_0x1018_7233; /* jbe 0x10187233 */
            ii(0x1018_721b, 2); cmp(al, 0x7);                           /* cmp al, 0x7 */
            ii(0x1018_721d, 2); if(jzd(0x1018_722d, 0xe)) goto l_0x1018_722d; /* jz 0x1018722d */
            ii(0x1018_721f, 3); fstp(memq_a32[ss, ebp - 0x10]);         /* fstp qword [ebp-0x10] */
            ii(0x1018_7222, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1018_7225, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1018_7228, 5); calld(/* sys */ 0x1018_1f17, -0x5316);  /* call 0x10181f17 */
        l_0x1018_722d:
            ii(0x1018_722d, 2); mov(al, 0x1);                           /* mov al, 0x1 */
            ii(0x1018_722f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1018_7231, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_7232, 1); retd(); return;                         /* ret */
        l_0x1018_7233:
            ii(0x1018_7233, 6); fcom(memq_a32[ds, 0x101b_e8a8]);        /* fcom qword [0x101be8a8] */
            ii(0x1018_7239, 1); wait();                                 /* wait */
            ii(0x1018_723a, 3); fnstsw(memw_a32[ss, ebp - 0x10]);       /* fnstsw word [ebp-0x10] */
            ii(0x1018_723d, 1); wait();                                 /* wait */
            ii(0x1018_723e, 3); mov(ah, memb_a32[ss, ebp - 0xf]);       /* mov ah, [ebp-0xf] */
            ii(0x1018_7241, 1); sahf();                                 /* sahf */
            ii(0x1018_7242, 2); if(jad(0x1018_7248, 0x4)) goto l_0x1018_7248; /* ja 0x10187248 */
            ii(0x1018_7244, 2); fldz();                                 /* fldz */
            ii(0x1018_7246, 2); jmpd(0x1018_725c, 0x14); goto l_0x1018_725c; /* jmp 0x1018725c */
        l_0x1018_7248:
            ii(0x1018_7248, 2); fldl2e();                               /* fldl2e */
            ii(0x1018_724a, 2); fmulp(1 /* st1 */, 0 /* st0 */);        /* fmulp st1, st0 */
            ii(0x1018_724c, 2); fld(0 /* st0 */);                       /* fld st0 */
            ii(0x1018_724e, 2); frndint();                              /* frndint */
            ii(0x1018_7250, 2); fxch(0 /* st0 */, 1 /* st1 */);         /* fxch st0, st1 */
            ii(0x1018_7252, 2); fsub(0 /* st0 */, 1 /* st1 */);         /* fsub st0, st1 */
            ii(0x1018_7254, 2); f2xm1();                                /* f2xm1 */
            ii(0x1018_7256, 2); fld1();                                 /* fld1 */
            ii(0x1018_7258, 2); faddp(1 /* st1 */, 0 /* st0 */);        /* faddp st1, st0 */
            ii(0x1018_725a, 2); fscale();                               /* fscale */
        l_0x1018_725c:
            ii(0x1018_725c, 2); fstp(1 /* st1 */);                      /* fstp st1 */
            ii(0x1018_725e, 2); mov(al, 0);                             /* mov al, 0x0 */
            ii(0x1018_7260, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1018_7262, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_7263, 1); retd(); return;                         /* ret */
        }
    }
}