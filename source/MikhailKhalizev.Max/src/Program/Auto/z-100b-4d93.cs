using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("322c2c81-2275-4e3d-adf6-d60eb88737f9")]
        public void Method_100b_4d93()
        {
            ii(0x100b_4d93, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_4d98, 5); calld(Definitions.sys_check_available_stack_size, 0xb_0fb5); /* call 0x10165d52 */
            ii(0x100b_4d9d, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_4d9e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_4d9f, 1); pushd(esi);                             /* push esi */
            ii(0x100b_4da0, 1); pushd(edi);                             /* push edi */
            ii(0x100b_4da1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_4da2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_4da4, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_4daa, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_4dad, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100b_4db0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_4db2, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_4db5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_4db8, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4dbb, 5); calld(0x1007_6574, -0x3_e84c);          /* call 0x10076574 */
            ii(0x100b_4dc0, 5); calld(0x1015_2962, 0x9_db9d);           /* call 0x10152962 */
            ii(0x100b_4dc5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_4dc7, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_4dca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_4dcd, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4dd0, 5); calld(0x1007_6574, -0x3_e861);          /* call 0x10076574 */
            ii(0x100b_4dd5, 5); calld(0x1015_2962, 0x9_db88);           /* call 0x10152962 */
            ii(0x100b_4dda, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_4ddd, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4de0, 5); calld(0x1007_65d0, -0x3_e815);          /* call 0x100765d0 */
            ii(0x100b_4de5, 5); calld(0x100a_b50c, -0x98de);            /* call 0x100ab50c */
            ii(0x100b_4dea, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_4ded, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4df0, 5); calld(0x1007_65d0, -0x3_e825);          /* call 0x100765d0 */
            ii(0x100b_4df5, 5); calld(0x100a_b50c, -0x98ee);            /* call 0x100ab50c */
            ii(0x100b_4dfa, 4); movsx(ebx, memb_a32[ss, ebp - 0x4]);    /* movsx ebx, byte [ebp-0x4] */
            ii(0x100b_4dfe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_4e01, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4e04, 5); calld(0x1007_65d0, -0x3_e839);          /* call 0x100765d0 */
            ii(0x100b_4e09, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_4e0b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_4e0e, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100b_4e11, 5); calld(0x1008_af84, -0x2_9e92);          /* call 0x1008af84 */
            ii(0x100b_4e16, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x100b_4e19, 3); calld_abs(memd_a32[ds, ecx + 0x1b]);    /* call dword [ecx+0x1b] */
            ii(0x100b_4e1c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_4e1f, 5); calld(0x100b_4d3b, -0xe9);              /* call 0x100b4d3b */
            ii(0x100b_4e24, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_4e26, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_4e27, 1); popd(edi);                              /* pop edi */
            ii(0x100b_4e28, 1); popd(esi);                              /* pop esi */
            ii(0x100b_4e29, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_4e2a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_4e2b, 1); retd(); return;                         /* ret */
        }
    }
}
