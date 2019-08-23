using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_5eac-6058174")]
        public void Method_1007_5eac()
        {
            ii(0x1007_5eac, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_5eb1, 5); calld(Definitions.sys_check_available_stack_size, 0xe_fe9c); /* call 0x10165d52 */
            ii(0x1007_5eb6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_5eb7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_5eb8, 1); pushd(esi);                             /* push esi */
            ii(0x1007_5eb9, 1); pushd(edi);                             /* push edi */
            ii(0x1007_5eba, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_5ebb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_5ebd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_5ec3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_5ec6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_5ec9, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1007_5ece, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_5ed1, 5); calld(Definitions.my_dtor_0x101b_6edc, 0xc_4d6f); /* call 0x1013ac45 */
            ii(0x1007_5ed6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_5ed9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_5edc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_5edf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_5ee2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_5ee4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_5ee5, 1); popd(edi);                              /* pop edi */
            ii(0x1007_5ee6, 1); popd(esi);                              /* pop esi */
            ii(0x1007_5ee7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_5ee8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_5ee9, 1); retd();                                 /* ret */
        }
    }
}
