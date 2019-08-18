using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a070-8e3e052d")]
        public void Method_100a_a070()
        {
            ii(0x100a_a070, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_a075, 5); calld(Definitions.sys_check_available_stack_size, 0xb_bcd8); /* call 0x10165d52 */
            ii(0x100a_a07a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_a07b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_a07c, 1); pushd(esi);                             /* push esi */
            ii(0x100a_a07d, 1); pushd(edi);                             /* push edi */
            ii(0x100a_a07e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_a07f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a081, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a087, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a08a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_a08d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_a092, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a095, 5); calld(0x1007_5e24, -0x3_4276);          /* call 0x10075e24 */
            ii(0x100a_a09a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a09d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a0a0, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_a0a3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_a0a6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a0a8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_a0a9, 1); popd(edi);                              /* pop edi */
            ii(0x100a_a0aa, 1); popd(esi);                              /* pop esi */
            ii(0x100a_a0ab, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_a0ac, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_a0ad, 1); retd(); return;                         /* ret */
        }
    }
}
