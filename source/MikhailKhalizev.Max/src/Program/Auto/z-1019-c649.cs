using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_c649-8eecef68")]
        public void Method_1019_c649()
        {
            ii(0x1019_c649, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_c64a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_c64c, 1); pushd(eax);                             /* push eax */
            ii(0x1019_c64d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_c64e, 1); pushd(edx);                             /* push edx */
            ii(0x1019_c64f, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1019_c652, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1019_c655, 1); pushd(eax);                             /* push eax */
            ii(0x1019_c656, 3); mov(edx, memd_a32[ss, ebp + 0xc]);      /* mov edx, [ebp+0xc] */
            ii(0x1019_c659, 1); pushd(edx);                             /* push edx */
            ii(0x1019_c65a, 3); mov(ebx, memd_a32[ss, ebp + 0x8]);      /* mov ebx, [ebp+0x8] */
            ii(0x1019_c65d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_c65e, 5); calld(0x1019_cce2, 0x67f);              /* call 0x1019cce2 */
            ii(0x1019_c663, 2); fldz();                                 /* fldz */
            ii(0x1019_c665, 2); fcompp();                               /* fcompp */
            ii(0x1019_c667, 2); fnstsw(ax);                             /* fnstsw ax */
            ii(0x1019_c669, 1); sahf();                                 /* sahf */
            ii(0x1019_c66a, 2); if(jbed(0x1019_c678, 0xc)) goto l_0x1019_c678; /* jbe 0x1019c678 */
            ii(0x1019_c66c, 3); fld(memq_a32[ss, ebp - 0x14]);          /* fld qword [ebp-0x14] */
            ii(0x1019_c66f, 6); fadd(memq_a32[ds, 0x101b_3850]);        /* fadd qword [0x101b3850] */
            ii(0x1019_c675, 3); fstp(memq_a32[ss, ebp - 0x14]);         /* fstp qword [ebp-0x14] */
        l_0x1019_c678:
            ii(0x1019_c678, 3); fld(memq_a32[ss, ebp - 0x14]);          /* fld qword [ebp-0x14] */
            ii(0x1019_c67b, 3); lea(esp, ebp - 0xc);                    /* lea esp, [ebp-0xc] */
            ii(0x1019_c67e, 1); popd(edx);                              /* pop edx */
            ii(0x1019_c67f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_c680, 1); popd(eax);                              /* pop eax */
            ii(0x1019_c681, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_c682, 3); retd(0x8); return;                      /* ret 0x8 */
        }
    }
}