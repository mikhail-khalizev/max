using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_aab4-a5a50278")]
        public void Method_1008_aab4()
        {
            ii(0x1008_aab4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_aab9, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b294); /* call 0x10165d52 */
            ii(0x1008_aabe, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_aabf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_aac0, 1); pushd(esi);                             /* push esi */
            ii(0x1008_aac1, 1); pushd(edi);                             /* push edi */
            ii(0x1008_aac2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_aac3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_aac5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_aacb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_aace, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_aad1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_aad4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_aad7, 5); calld(0x1013_a66b, 0xa_fb8f);           /* call 0x1013a66b */
            ii(0x1008_aadc, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1008_aadf, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1008_aae2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_aae4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_aae5, 1); popd(edi);                              /* pop edi */
            ii(0x1008_aae6, 1); popd(esi);                              /* pop esi */
            ii(0x1008_aae7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_aae8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_aae9, 1); retd(); return;                         /* ret */
        }
    }
}
