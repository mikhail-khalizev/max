using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_ae20-9bcb7e42")]
        public void Method_100a_ae20()
        {
            ii(0x100a_ae20, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_ae25, 5); calld(Definitions.sys_check_available_stack_size, 0xb_af28); /* call 0x10165d52 */
            ii(0x100a_ae2a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_ae2b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_ae2c, 1); pushd(esi);                             /* push esi */
            ii(0x100a_ae2d, 1); pushd(edi);                             /* push edi */
            ii(0x100a_ae2e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_ae2f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ae31, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_ae37, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_ae3a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_ae3d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_ae40, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_ae43, 5); calld(0x1013_ac7d, 0x8_fe35);           /* call 0x1013ac7d */
            ii(0x100a_ae48, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_ae4b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_ae4e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_ae50, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_ae51, 1); popd(edi);                              /* pop edi */
            ii(0x100a_ae52, 1); popd(esi);                              /* pop esi */
            ii(0x100a_ae53, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_ae54, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_ae55, 1); retd();                                 /* ret */
        }
    }
}
