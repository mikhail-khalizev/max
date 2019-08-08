using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("22c257a4-eb06-4ba6-b4a8-c8d0ed5b62e3")]
        public void Method_1014_4eb0()
        {
            ii(0x1014_4eb0, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_4eb5, 5); calld(Definitions.sys_check_available_stack_size, 0x2_0e98); /* call 0x10165d52 */
            ii(0x1014_4eba, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_4ebb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_4ebc, 1); pushd(edx);                             /* push edx */
            ii(0x1014_4ebd, 1); pushd(esi);                             /* push esi */
            ii(0x1014_4ebe, 1); pushd(edi);                             /* push edi */
            ii(0x1014_4ebf, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_4ec0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_4ec2, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_4ec8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_4ecb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_4ece, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1014_4ed1, 5); calld(0x1007_6998, -0xc_e53e);          /* call 0x10076998 */
            ii(0x1014_4ed6, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x1014_4ed9, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_4edc, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1014_4edf, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_4ee2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_4ee5, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_4ee8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_4eeb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_4eed, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_4eee, 1); popd(edi);                              /* pop edi */
            ii(0x1014_4eef, 1); popd(esi);                              /* pop esi */
            ii(0x1014_4ef0, 1); popd(edx);                              /* pop edx */
            ii(0x1014_4ef1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_4ef2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_4ef3, 1); retd(); return;                         /* ret */
        }
    }
}
