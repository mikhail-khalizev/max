using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bcd20b5e-0129-45da-beed-b3a4cbf353e9")]
        public void Method_1008_a12c()
        {
            ii(0x1008_a12c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_a131, 5); calld(Definitions.sys_check_available_stack_size, 0xdbc1c); /* call 0x10165d52 */
            ii(0x1008_a136, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a137, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a138, 1); pushd(edx);                             /* push edx */
            ii(0x1008_a139, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a13a, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a13b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a13c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a13e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_a144, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_a147, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_a14a, 5); calld(0x1007_6c30, -0x1351f);           /* call 0x10076c30 */
            ii(0x1008_a14f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a152, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a155, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a157, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a158, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a159, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a15a, 1); popd(edx);                              /* pop edx */
            ii(0x1008_a15b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a15c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a15d, 1); retd(); return;                         /* ret */
        }
    }
}
