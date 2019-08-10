using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("490158d9-33d5-40b3-8591-9ea0b9e2c028")]
        public void /* sys */ Method_1019_a9b3()
        {
            ii(0x1019_a9b3, 3); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1019_a9b6, 8); mov(memd_a32[ss, esp + 0x8], 0xc000_0000); /* mov dword [esp+0x8], 0xc0000000 */
            ii(0x1019_a9be, 8); mov(memd_a32[ss, esp + 0xc], 0x4150_017e); /* mov dword [esp+0xc], 0x4150017e */
            ii(0x1019_a9c6, 7); mov(memd_a32[ss, esp], 0x8000_0000);    /* mov dword [esp], 0x80000000 */
            ii(0x1019_a9cd, 8); mov(memd_a32[ss, esp + 0x4], 0x4147_ffff); /* mov dword [esp+0x4], 0x4147ffff */
            ii(0x1019_a9d5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_a9d7, 5); mov(al, memb_a32[ds, 0x101b_ddad]);     /* mov al, [0x101bddad] */
            ii(0x1019_a9dc, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1019_a9df, 2); if(jld(0x1019_aa04, 0x23)) goto l_0x1019_aa04; /* jl 0x1019aa04 */
            ii(0x1019_a9e1, 4); fld(memq_a32[ss, esp + 0x8]);           /* fld qword [esp+0x8] */
            ii(0x1019_a9e5, 2); fld(ST(0));                             /* fld st0 */
            ii(0x1019_a9e7, 3); fld(memq_a32[ss, esp]);                 /* fld qword [esp] */
            ii(0x1019_a9ea, 2); fxch(ST(0), ST(1));                     /* fxch st0, st1 */
            ii(0x1019_a9ec, 2); fdiv(ST(0), ST(1));                     /* fdiv st0, st1 */
            ii(0x1019_a9ee, 2); fmulp(ST(1), ST(0));                    /* fmulp st1, st0 */
            ii(0x1019_a9f0, 2); fsubp(ST(1), ST(0));                    /* fsubp st1, st0 */
            ii(0x1019_a9f2, 6); fcomp(memq_a32[ds, 0x101b_370c]);       /* fcomp qword [0x101b370c] */
            ii(0x1019_a9f8, 2); fnstsw(ax);                             /* fnstsw ax */
            ii(0x1019_a9fa, 1); sahf();                                 /* sahf */
            ii(0x1019_a9fb, 2); if(jbed(0x1019_aa04, 0x7)) goto l_0x1019_aa04; /* jbe 0x1019aa04 */
            ii(0x1019_a9fd, 7); or(memb_a32[ds, 0x101b_e89c], 0x1);     /* or byte [0x101be89c], 0x1 */
        l_0x1019_aa04:
            ii(0x1019_aa04, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1019_aa07, 1); retd(); return;                         /* ret */
        }
    }
}
