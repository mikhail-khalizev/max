using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fc1d5b0b-8458-4709-997f-5aae22d73d35")]
        public void Method_100e_464c()
        {
            ii(0x100e_464c, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x100e_4651, 5); calld(Definitions.sys_check_available_stack_size, 0x8_16fc); /* call 0x10165d52 */
            ii(0x100e_4656, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_4657, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_4658, 1); pushd(esi);                             /* push esi */
            ii(0x100e_4659, 1); pushd(edi);                             /* push edi */
            ii(0x100e_465a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_465b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_465d, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x100e_4663, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_4666, 3); mov(memd_a32[ss, ebp - 0x10], edx);     /* mov [ebp-0x10], edx */
            ii(0x100e_4669, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_466c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_466f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4672, 6); sub(memd_a32[ds, 0x101b_7f10], eax);    /* sub [0x101b7f10], eax */
            ii(0x100e_4678, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x100e_467d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_467f, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100e_4682, 5); calld(Definitions.sys_memset, 0x8_1759); /* call 0x10165de0 */
            ii(0x100e_4687, 6); mov(memw_a32[ss, ebp - 0x2c], 0x601);   /* mov word [ebp-0x2c], 0x601 */
            ii(0x100e_468d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_4690, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x100e_4693, 4); mov(memw_a32[ss, ebp - 0x28], ax);      /* mov [ebp-0x28], ax */
            ii(0x100e_4697, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_469a, 4); mov(memw_a32[ss, ebp - 0x24], ax);      /* mov [ebp-0x24], ax */
            ii(0x100e_469e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_46a1, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x100e_46a4, 4); mov(memw_a32[ss, ebp - 0x1c], ax);      /* mov [ebp-0x1c], ax */
            ii(0x100e_46a8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_46ab, 4); mov(memw_a32[ss, ebp - 0x18], ax);      /* mov [ebp-0x18], ax */
            ii(0x100e_46af, 3); lea(ebx, ebp - 0x2c);                   /* lea ebx, [ebp-0x2c] */
            ii(0x100e_46b2, 3); lea(edx, ebp - 0x2c);                   /* lea edx, [ebp-0x2c] */
            ii(0x100e_46b5, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x100e_46ba, 5); calld(/* sys */ 0x1016_c606, 0x8_7f47); /* call 0x1016c606 */
            ii(0x100e_46bf, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100e_46c3, 2); if(jnzd(0x100e_46ce, 0x9)) goto l_0x100e_46ce; /* jnz 0x100e46ce */
            ii(0x100e_46c5, 7); mov(memd_a32[ss, ebp - 0x30], 0x1);     /* mov dword [ebp-0x30], 0x1 */
            ii(0x100e_46cc, 2); jmpd(0x100e_46d5, 0x7); goto l_0x100e_46d5; /* jmp 0x100e46d5 */
        l_0x100e_46ce:
            ii(0x100e_46ce, 7); mov(memd_a32[ss, ebp - 0x30], 0);       /* mov dword [ebp-0x30], 0x0 */
        l_0x100e_46d5:
            ii(0x100e_46d5, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100e_46d8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_46db, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_46de, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_46e0, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_46e1, 1); popd(edi);                              /* pop edi */
            ii(0x100e_46e2, 1); popd(esi);                              /* pop esi */
            ii(0x100e_46e3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_46e4, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_46e5, 1); retd(); return;                         /* ret */
        }
    }
}
