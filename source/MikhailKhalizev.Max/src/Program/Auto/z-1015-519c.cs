using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c91b21be-6f95-4a29-bac1-6a68c84631fb")]
        public void Method_1015_519c()
        {
            ii(0x1015_519c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_51a1, 5); calld(Definitions.sys_check_available_stack_size, 0x10bac); /* call 0x10165d52 */
            ii(0x1015_51a6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_51a7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_51a8, 1); pushd(esi);                             /* push esi */
            ii(0x1015_51a9, 1); pushd(edi);                             /* push edi */
            ii(0x1015_51aa, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_51ab, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_51ad, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_51b3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_51b6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_51b9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_51bc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_51bf, 5); calld(0x1013_a7ca, -0x1a9fa);           /* call 0x1013a7ca */
            ii(0x1015_51c4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_51c7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_51ca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_51cc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_51cd, 1); popd(edi);                              /* pop edi */
            ii(0x1015_51ce, 1); popd(esi);                              /* pop esi */
            ii(0x1015_51cf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_51d0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_51d1, 1); retd(); return;                         /* ret */
        }
    }
}
