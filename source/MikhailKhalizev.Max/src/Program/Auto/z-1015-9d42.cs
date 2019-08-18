using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c583b370-0b21-442c-b3e8-a911afe9970f")]
        public void Method_1015_9d42()
        {
            ii(0x1015_9d42, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_9d47, 5); calld(Definitions.sys_check_available_stack_size, 0xc006); /* call 0x10165d52 */
            ii(0x1015_9d4c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_9d4d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_9d4e, 1); pushd(esi);                             /* push esi */
            ii(0x1015_9d4f, 1); pushd(edi);                             /* push edi */
            ii(0x1015_9d50, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_9d51, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_9d53, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_9d59, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_9d5c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_9d5f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_9d62, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_9d65, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_9d6a, 5); calld(0x100f_448c, -0x6_58e3);          /* call 0x100f448c */
            ii(0x1015_9d6f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_9d72, 4); cmp(memb_a32[ds, eax + 0x3d], 0x8);     /* cmp byte [eax+0x3d], 0x8 */
            ii(0x1015_9d76, 2); if(jnzd(0x1015_9d84, 0xc)) goto l_0x1015_9d84; /* jnz 0x10159d84 */
            ii(0x1015_9d78, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_9d7b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_9d7d, 5); calld(0x1015_9680, -0x702);             /* call 0x10159680 */
            ii(0x1015_9d82, 2); jmpd(0x1015_9d99, 0x15); goto l_0x1015_9d99; /* jmp 0x10159d99 */
        l_0x1015_9d84:
            ii(0x1015_9d84, 5); calld(0x100f_fc13, -0x5_a176);          /* call 0x100ffc13 */
            ii(0x1015_9d89, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_9d8c, 5); calld(0x1014_48cc, -0x1_54c5);          /* call 0x101448cc */
            ii(0x1015_9d91, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_9d94, 5); calld(0x100f_fa70, -0x5_a329);          /* call 0x100ffa70 */
        l_0x1015_9d99:
            ii(0x1015_9d99, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_9d9b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_9d9c, 1); popd(edi);                              /* pop edi */
            ii(0x1015_9d9d, 1); popd(esi);                              /* pop esi */
            ii(0x1015_9d9e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_9d9f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_9da0, 1); retd(); return;                         /* ret */
        }
    }
}
