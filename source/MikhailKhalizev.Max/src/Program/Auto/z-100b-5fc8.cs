using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7e33f05f-366d-4aa3-9d36-46c854cb4478")]
        public void Method_100b_5fc8()
        {
            ii(0x100b_5fc8, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_5fcd, 5); calld(Definitions.sys_check_available_stack_size, 0xa_fd80); /* call 0x10165d52 */
            ii(0x100b_5fd2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_5fd3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_5fd4, 1); pushd(esi);                             /* push esi */
            ii(0x100b_5fd5, 1); pushd(edi);                             /* push edi */
            ii(0x100b_5fd6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_5fd7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_5fd9, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_5fdf, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_5fe2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_5fe5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_5fe8, 5); cmp(memw_a32[ds, eax + 0x8], 0x4e);     /* cmp word [eax+0x8], 0x4e */
            ii(0x100b_5fed, 2); if(jzd(0x100b_5ff9, 0xa)) goto l_0x100b_5ff9; /* jz 0x100b5ff9 */
            ii(0x100b_5fef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_5ff2, 5); cmp(memw_a32[ds, eax + 0x8], 0x48);     /* cmp word [eax+0x8], 0x48 */
            ii(0x100b_5ff7, 2); if(jnzd(0x100b_5ffb, 0x2)) goto l_0x100b_5ffb; /* jnz 0x100b5ffb */
        l_0x100b_5ff9:
            ii(0x100b_5ff9, 2); jmpd(0x100b_6005, 0xa); goto l_0x100b_6005; /* jmp 0x100b6005 */
        l_0x100b_5ffb:
            ii(0x100b_5ffb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_5ffe, 5); cmp(memw_a32[ds, eax + 0x8], 0x41);     /* cmp word [eax+0x8], 0x41 */
            ii(0x100b_6003, 2); if(jnzd(0x100b_602f, 0x2a)) goto l_0x100b_602f; /* jnz 0x100b602f */
        l_0x100b_6005:
            ii(0x100b_6005, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_6008, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_600b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_600e, 5); calld(0x1008_ab1c, -0x2_b4f7);          /* call 0x1008ab1c */
            ii(0x100b_6013, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_6016, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_6019, 5); calld(0x1015_27ed, 0x9_c7cf);           /* call 0x101527ed */
            ii(0x100b_601e, 5); calld(0x1008_b0e4, -0x2_af3f);          /* call 0x1008b0e4 */
            ii(0x100b_6023, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_6025, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100b_6027, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_602a, 5); calld(0x100a_297d, -0x1_36b2);          /* call 0x100a297d */
        l_0x100b_602f:
            ii(0x100b_602f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_6031, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_6032, 1); popd(edi);                              /* pop edi */
            ii(0x100b_6033, 1); popd(esi);                              /* pop esi */
            ii(0x100b_6034, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_6035, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_6036, 1); retd(); return;                         /* ret */
        }
    }
}