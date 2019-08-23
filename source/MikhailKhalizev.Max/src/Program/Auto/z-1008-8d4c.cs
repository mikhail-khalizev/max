using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_8d4c-271e7dd2")]
        public void Method_1008_8d4c()
        {
            ii(0x1008_8d4c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_8d51, 5); calld(Definitions.sys_check_available_stack_size, 0xd_cffc); /* call 0x10165d52 */
            ii(0x1008_8d56, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_8d57, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_8d58, 1); pushd(esi);                             /* push esi */
            ii(0x1008_8d59, 1); pushd(edi);                             /* push edi */
            ii(0x1008_8d5a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_8d5b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8d5d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8d63, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8d66, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_8d69, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_8d6e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8d71, 5); calld(Definitions.my_dtor_0x101b_6edc, 0xb_1ecf); /* call 0x1013ac45 */
            ii(0x1008_8d76, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8d79, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8d7c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_8d7f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_8d82, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8d84, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_8d85, 1); popd(edi);                              /* pop edi */
            ii(0x1008_8d86, 1); popd(esi);                              /* pop esi */
            ii(0x1008_8d87, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_8d88, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_8d89, 1); retd();                                 /* ret */
        }
    }
}
