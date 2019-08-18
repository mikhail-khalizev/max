using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9d4d1f8e-b19d-49a1-bf23-80f0a29b04c1")]
        public void Method_1010_2aec()
        {
            ii(0x1010_2aec, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1010_2af1, 5); calld(Definitions.sys_check_available_stack_size, 0x6_325c); /* call 0x10165d52 */
            ii(0x1010_2af6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_2af7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_2af8, 1); pushd(esi);                             /* push esi */
            ii(0x1010_2af9, 1); pushd(edi);                             /* push edi */
            ii(0x1010_2afa, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_2afb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_2afd, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_2b03, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_2b06, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_2b09, 5); calld(Definitions.my_set_al_1_v2, 0x32); /* call 0x10102b40 */
            ii(0x1010_2b0e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_2b10, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1010_2b12, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_2b15, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_2b18, 5); calld(Definitions.my_string_strcmp, 0x3_f653); /* call 0x10142170 */
            ii(0x1010_2b1d, 1); cwde();                                 /* cwde */
            ii(0x1010_2b1e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_2b20, 2); if(jnzd(0x1010_2b28, 0x6)) goto l_0x1010_2b28; /* jnz 0x10102b28 */
            ii(0x1010_2b22, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1010_2b26, 2); jmpd(0x1010_2b2c, 0x4); goto l_0x1010_2b2c; /* jmp 0x10102b2c */
        l_0x1010_2b28:
            ii(0x1010_2b28, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1010_2b2c:
            ii(0x1010_2b2c, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1010_2b2f, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1010_2b32, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1010_2b35, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_2b37, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_2b38, 1); popd(edi);                              /* pop edi */
            ii(0x1010_2b39, 1); popd(esi);                              /* pop esi */
            ii(0x1010_2b3a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_2b3b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_2b3c, 1); retd(); return;                         /* ret */
        }
    }
}
