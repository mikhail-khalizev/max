using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("583530c1-29c9-4454-990e-d29a296a2ce2")]
        public void Method_1008_8ac4()
        {
            ii(0x1008_8ac4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_8ac9, 5); calld(Definitions.sys_check_available_stack_size, 0xd_d284); /* call 0x10165d52 */
            ii(0x1008_8ace, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_8acf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_8ad0, 1); pushd(esi);                             /* push esi */
            ii(0x1008_8ad1, 1); pushd(edi);                             /* push edi */
            ii(0x1008_8ad2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_8ad3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8ad5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8adb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8ade, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_8ae1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_8ae6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8ae9, 5); calld(0x1008_8a84, -0x6a);              /* call 0x10088a84 */
            ii(0x1008_8aee, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8af1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8af4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_8af7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_8afa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8afc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_8afd, 1); popd(edi);                              /* pop edi */
            ii(0x1008_8afe, 1); popd(esi);                              /* pop esi */
            ii(0x1008_8aff, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_8b00, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_8b01, 1); retd(); return;                         /* ret */
        }
    }
}
