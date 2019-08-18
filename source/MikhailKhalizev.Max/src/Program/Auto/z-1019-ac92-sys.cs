using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("98785742-de19-4d30-a2c6-db5bd19637a7")]
        public void /* sys */ Method_1019_ac92()
        {
            ii(0x1019_ac92, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_ac93, 1); pushd(esi);                             /* push esi */
            ii(0x1019_ac94, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1019_ac96, 3); mov(esi, memd_a32[ds, eax + 0x10]);     /* mov esi, [eax+0x10] */
            ii(0x1019_ac99, 3); cmp(esi, memd_a32[ds, edx + 0x10]);     /* cmp esi, [edx+0x10] */
            ii(0x1019_ac9c, 2); if(jled(0x1019_aca6, 0x8)) goto l_0x1019_aca6; /* jle 0x1019aca6 */
        l_0x1019_ac9e:
            ii(0x1019_ac9e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1019_aca3, 1); popd(esi);                              /* pop esi */
            ii(0x1019_aca4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_aca5, 1); retd(); return;                         /* ret */
        l_0x1019_aca6:
            ii(0x1019_aca6, 3); cmp(esi, memd_a32[ds, ecx + 0x10]);     /* cmp esi, [ecx+0x10] */
            ii(0x1019_aca9, 2); if(jld(0x1019_acc1, 0x16)) goto l_0x1019_acc1; /* jl 0x1019acc1 */
            ii(0x1019_acab, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1019_acad, 5); calld(/* sys */ 0x1019_abad, -0x105);   /* call 0x1019abad */
            ii(0x1019_acb2, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1019_acb4, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1019_acb6, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1019_acb8, 5); calld(/* sys */ 0x1019_abad, -0x110);   /* call 0x1019abad */
            ii(0x1019_acbd, 2); cmp(esi, eax);                          /* cmp esi, eax */
            ii(0x1019_acbf, 2); if(jgd(0x1019_ac9e, -0x23)) goto l_0x1019_ac9e; /* jg 0x1019ac9e */
        l_0x1019_acc1:
            ii(0x1019_acc1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_acc3, 1); popd(esi);                              /* pop esi */
            ii(0x1019_acc4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_acc5, 1); retd(); return;                         /* ret */
        }
    }
}
