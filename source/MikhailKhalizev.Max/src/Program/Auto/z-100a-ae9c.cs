using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6ac30740-cb28-429a-986e-59c528b03347")]
        public void Method_100a_ae9c()
        {
            ii(0x100a_ae9c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_aea1, 5); calld(Definitions.sys_check_available_stack_size, 0xb_aeac); /* call 0x10165d52 */
            ii(0x100a_aea6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_aea7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_aea8, 1); pushd(edx);                             /* push edx */
            ii(0x100a_aea9, 1); pushd(esi);                             /* push esi */
            ii(0x100a_aeaa, 1); pushd(edi);                             /* push edi */
            ii(0x100a_aeab, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_aeac, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_aeae, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_aeb4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_aeb7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_aeba, 5); calld(Definitions.my_ctor_0x101b6edc, -0x3_407b); /* call 0x10076e44 */
            ii(0x100a_aebf, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_aec2, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100a_aec5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_aec8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_aecb, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_aece, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_aed1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_aed3, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_aed4, 1); popd(edi);                              /* pop edi */
            ii(0x100a_aed5, 1); popd(esi);                              /* pop esi */
            ii(0x100a_aed6, 1); popd(edx);                              /* pop edx */
            ii(0x100a_aed7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_aed8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_aed9, 1); retd(); return;                         /* ret */
        }
    }
}
