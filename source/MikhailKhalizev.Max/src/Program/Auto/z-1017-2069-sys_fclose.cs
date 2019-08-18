using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ccb1d6c7-4abc-4bab-a116-d47779bb6bac")]
        public void /* sys */ sys_fclose()
        {
            ii(0x1017_2069, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_206a, 1); pushd(edx);                             /* push edx */
            ii(0x1017_206b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_206d, 5); mov(eax, memd_a32[ds, 0x1020_b70c]);    /* mov eax, [0x1020b70c] */
        l_0x1017_2072:
            ii(0x1017_2072, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_2074, 2); if(jnzd(0x1017_207e, 0x8)) goto l_0x1017_207e; /* jnz 0x1017207e */
            ii(0x1017_2076, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1017_207b, 1); popd(edx);                              /* pop edx */
            ii(0x1017_207c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_207d, 1); retd(); return;                         /* ret */
        l_0x1017_207e:
            ii(0x1017_207e, 3); cmp(ebx, memd_a32[ds, eax + 0x4]);      /* cmp ebx, [eax+0x4] */
            ii(0x1017_2081, 2); if(jzd(0x1017_2087, 0x4)) goto l_0x1017_2087; /* jz 0x10172087 */
            ii(0x1017_2083, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1017_2085, 2); jmpd(0x1017_2072, -0x15); goto l_0x1017_2072; /* jmp 0x10172072 */
        l_0x1017_2087:
            ii(0x1017_2087, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1017_208c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_208e, 5); calld(/* sys */ 0x1017_2096, 0x3);      /* call 0x10172096 */
            ii(0x1017_2093, 1); popd(edx);                              /* pop edx */
            ii(0x1017_2094, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_2095, 1); retd(); return;                         /* ret */
        }
    }
}
