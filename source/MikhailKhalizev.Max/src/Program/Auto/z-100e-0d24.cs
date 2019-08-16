using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("20579bb2-8d16-4f96-82b0-67f819e1c48c")]
        public void Method_100e_0d24()
        {
            ii(0x100e_0d24, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100e_0d29, 5); calld(Definitions.sys_check_available_stack_size, 0x8_5024); /* call 0x10165d52 */
            ii(0x100e_0d2e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_0d2f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0d30, 1); pushd(edx);                             /* push edx */
            ii(0x100e_0d31, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0d32, 1); pushd(edi);                             /* push edi */
            ii(0x100e_0d33, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_0d34, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0d36, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_0d3c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_0d3f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_0d42, 5); calld(0x1013_a0af, 0x5_9368);           /* call 0x1013a0af */
            ii(0x100e_0d47, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_0d4a, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100e_0d4d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_0d50, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_0d53, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_0d56, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_0d59, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0d5b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0d5c, 1); popd(edi);                              /* pop edi */
            ii(0x100e_0d5d, 1); popd(esi);                              /* pop esi */
            ii(0x100e_0d5e, 1); popd(edx);                              /* pop edx */
            ii(0x100e_0d5f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0d60, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_0d61, 1); retd(); return;                         /* ret */
        }
    }
}