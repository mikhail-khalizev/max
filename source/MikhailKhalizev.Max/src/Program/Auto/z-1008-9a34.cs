using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9a34-a86de14c")]
        public void Method_1008_9a34()
        {
            ii(0x1008_9a34, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_9a39, 5); calld(Definitions.sys_check_available_stack_size, 0xd_c314); /* call 0x10165d52 */
            ii(0x1008_9a3e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9a3f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9a40, 1); pushd(edx);                             /* push edx */
            ii(0x1008_9a41, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9a42, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9a43, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9a44, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9a46, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_9a4c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_9a4f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_9a52, 5); calld(Definitions.my_ctor_0x101b_6edc, -0x1_2c13); /* call 0x10076e44 */
            ii(0x1008_9a57, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_9a5a, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1008_9a5d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9a60, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_9a63, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_9a66, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_9a69, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9a6b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9a6c, 1); popd(edi);                              /* pop edi */
            ii(0x1008_9a6d, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9a6e, 1); popd(edx);                              /* pop edx */
            ii(0x1008_9a6f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9a70, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9a71, 1); retd();                                 /* ret */
        }
    }
}
