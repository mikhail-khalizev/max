using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_cca5-51d8a874")]
        public void Method_1019_cca5()
        {
            ii(0x1019_cca5, 1); push(ebp);                              /* push ebp */
            ii(0x1019_cca6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_cca8, 1); push(eax);                              /* push eax */
            ii(0x1019_cca9, 1); push(ebx);                              /* push ebx */
            ii(0x1019_ccaa, 1); push(edx);                              /* push edx */
            ii(0x1019_ccab, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x1019_ccae, 3); and(eax, 0x1f);                         /* and eax, 0x1f */
            ii(0x1019_ccb1, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1019_ccb4, 2); if(jz(0x1019_ccce, 0x18)) goto l_0x1019_ccce; /* jz 0x1019ccce */
            ii(0x1019_ccb6, 3); mov(edx, memd[ss, ebp + 0xc]);          /* mov edx, [ebp+0xc] */
            ii(0x1019_ccb9, 3); mov(ebx, memd[ss, ebp + 0x8]);          /* mov ebx, [ebp+0x8] */
            ii(0x1019_ccbc, 6); test(edx, 0x7fff_ffff);                 /* test edx, 0x7fffffff */
            ii(0x1019_ccc2, 2); if(jnz(0x1019_ccce, 0xa)) goto l_0x1019_ccce; /* jnz 0x1019ccce */
            ii(0x1019_ccc4, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1019_ccc6, 2); if(jnz(0x1019_ccce, 0x6)) goto l_0x1019_ccce; /* jnz 0x1019ccce */
            ii(0x1019_ccc8, 4); or(ax, 0x1080);                         /* or ax, 0x1080 */
            ii(0x1019_cccc, 2); jmp(0x1019_ccd2, 0x4); goto l_0x1019_ccd2; /* jmp 0x1019ccd2 */
        l_0x1019_ccce:
            ii(0x1019_ccce, 4); or(ax, 0x1040);                         /* or ax, 0x1040 */
        l_0x1019_ccd2:
            ii(0x1019_ccd2, 3); lea(edx, memd[ss, ebp + 0x8]);          /* lea edx, [ebp+0x8] */
            ii(0x1019_ccd5, 5); call(/* sys */ 0x1019_6628, -0x66b2);   /* call 0x10196628 */
            ii(0x1019_ccda, 1); pop(edx);                               /* pop edx */
            ii(0x1019_ccdb, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_ccdc, 1); pop(eax);                               /* pop eax */
            ii(0x1019_ccdd, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_ccde, 3); ret(0xc);                               /* ret 0xc */
        }
    }
}
