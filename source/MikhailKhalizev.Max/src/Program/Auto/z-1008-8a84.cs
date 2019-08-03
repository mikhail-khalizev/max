using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f1c4d7ac-90cd-45b6-bf24-9eaa2d2630ee")]
        public void Method_1008_8a84()
        {
            ii(0x1008_8a84, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_8a89, 5); calld(Definitions.sys_check_available_stack_size, 0xdd2c4); /* call 0x10165d52 */
            ii(0x1008_8a8e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_8a8f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_8a90, 1); pushd(esi);                             /* push esi */
            ii(0x1008_8a91, 1); pushd(edi);                             /* push edi */
            ii(0x1008_8a92, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_8a93, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8a95, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8a9b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8a9e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_8aa1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_8aa6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8aa9, 5); calld(Definitions.my_dtor_0x101b6edc, 0xb2197); /* call 0x1013ac45 */
            ii(0x1008_8aae, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8ab1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8ab4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_8ab7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_8aba, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8abc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_8abd, 1); popd(edi);                              /* pop edi */
            ii(0x1008_8abe, 1); popd(esi);                              /* pop esi */
            ii(0x1008_8abf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_8ac0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_8ac1, 1); retd(); return;                         /* ret */
        }
    }
}
