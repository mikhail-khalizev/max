using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4d24e866-bd59-4a60-a2ec-5903211f82f2")]
        public void Method_1019_cca5()
        {
            ii(0x1019_cca5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_cca6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_cca8, 1); pushd(eax);                             /* push eax */
            ii(0x1019_cca9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_ccaa, 1); pushd(edx);                             /* push edx */
            ii(0x1019_ccab, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1019_ccae, 3); and(eax, 0x1f);                         /* and eax, 0x1f */
            ii(0x1019_ccb1, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1019_ccb4, 2); if(jzd(0x1019_ccce, 0x18)) goto l_0x1019_ccce; /* jz 0x1019ccce */
            ii(0x1019_ccb6, 3); mov(edx, memd_a32[ss, ebp + 0xc]);      /* mov edx, [ebp+0xc] */
            ii(0x1019_ccb9, 3); mov(ebx, memd_a32[ss, ebp + 0x8]);      /* mov ebx, [ebp+0x8] */
            ii(0x1019_ccbc, 6); test(edx, 0x7fff_ffff);                 /* test edx, 0x7fffffff */
            ii(0x1019_ccc2, 2); if(jnzd(0x1019_ccce, 0xa)) goto l_0x1019_ccce; /* jnz 0x1019ccce */
            ii(0x1019_ccc4, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1019_ccc6, 2); if(jnzd(0x1019_ccce, 0x6)) goto l_0x1019_ccce; /* jnz 0x1019ccce */
            ii(0x1019_ccc8, 4); or(ax, 0x1080);                         /* or ax, 0x1080 */
            ii(0x1019_cccc, 2); jmpd(0x1019_ccd2, 0x4); goto l_0x1019_ccd2; /* jmp 0x1019ccd2 */
        l_0x1019_ccce:
            ii(0x1019_ccce, 4); or(ax, 0x1040);                         /* or ax, 0x1040 */
        l_0x1019_ccd2:
            ii(0x1019_ccd2, 3); lea(edx, ebp + 0x8);                    /* lea edx, [ebp+0x8] */
            ii(0x1019_ccd5, 5); calld(/* sys */ 0x1019_6628, -0x66b2);  /* call 0x10196628 */
            ii(0x1019_ccda, 1); popd(edx);                              /* pop edx */
            ii(0x1019_ccdb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_ccdc, 1); popd(eax);                              /* pop eax */
            ii(0x1019_ccdd, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_ccde, 3); retd(0xc); return;                      /* ret 0xc */
        }
    }
}
