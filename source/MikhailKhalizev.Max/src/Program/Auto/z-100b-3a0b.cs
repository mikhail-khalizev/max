using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2cf75a3f-24bb-4280-8d88-a9ebcc3bc6fb")]
        public void Method_100b_3a0b()
        {
            ii(0x100b_3a0b, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_3a10, 5); calld(Definitions.sys_check_available_stack_size, 0xb_233d); /* call 0x10165d52 */
            ii(0x100b_3a15, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_3a16, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_3a17, 1); pushd(esi);                             /* push esi */
            ii(0x100b_3a18, 1); pushd(edi);                             /* push edi */
            ii(0x100b_3a19, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_3a1a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_3a1c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_3a22, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_3a25, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_3a28, 5); mov(edx, StringDefinitions.ActivateUnit); /* mov edx, 0x101a10e1 */
            ii(0x100b_3a2d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3a30, 5); calld(Definitions.sys_strcpy, 0xb_249a); /* call 0x10165ecf */
            ii(0x100b_3a35, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3a38, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_3a3b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_3a3e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_3a40, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_3a41, 1); popd(edi);                              /* pop edi */
            ii(0x100b_3a42, 1); popd(esi);                              /* pop esi */
            ii(0x100b_3a43, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_3a44, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_3a45, 1); retd(); return;                         /* ret */
        }
    }
}
