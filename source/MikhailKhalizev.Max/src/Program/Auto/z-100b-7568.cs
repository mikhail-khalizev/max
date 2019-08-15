using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ecfba18b-a985-4c11-ab2c-9ab2f1c92480")]
        public void Method_100b_7568()
        {
            ii(0x100b_7568, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_756d, 5); calld(Definitions.sys_check_available_stack_size, 0xa_e7e0); /* call 0x10165d52 */
            ii(0x100b_7572, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_7573, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_7574, 1); pushd(esi);                             /* push esi */
            ii(0x100b_7575, 1); pushd(edi);                             /* push edi */
            ii(0x100b_7576, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_7577, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7579, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_757f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7582, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_7585, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100b_758c, 2); if(jzd(0x100b_75a2, 0x14)) goto l_0x100b_75a2; /* jz 0x100b75a2 */
            ii(0x100b_758e, 5); mov(edx, 0x101b_50a8);                  /* mov edx, 0x101b50a8 */
            ii(0x100b_7593, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7596, 5); calld(Definitions.sys_call_dtor_arr, 0xa_ea1d); /* call 0x10165fb8 */
            ii(0x100b_759b, 5); calld(Definitions.sys_delete_arr, 0xa_ea38); /* call 0x10165fd8 */
            ii(0x100b_75a0, 2); jmpd(0x100b_75fc, 0x5a); goto l_0x100b_75fc; /* jmp 0x100b75fc */
        l_0x100b_75a2:
            ii(0x100b_75a2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_75a4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_75a7, 3); add(eax, 0x3c);                         /* add eax, 0x3c */
            ii(0x100b_75aa, 5); calld(0x1009_b8ec, -0x1_bcc3);          /* call 0x1009b8ec */
            ii(0x100b_75af, 3); sub(eax, 0x3c);                         /* sub eax, 0x3c */
            ii(0x100b_75b2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_75b5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_75b7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_75ba, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100b_75bd, 5); calld(0x100a_a3c0, -0xd202);            /* call 0x100aa3c0 */
            ii(0x100b_75c2, 3); sub(eax, 0x2c);                         /* sub eax, 0x2c */
            ii(0x100b_75c5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_75c8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_75ca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_75cd, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_75d0, 5); calld(0x1007_5f2c, -0x4_16a9);          /* call 0x10075f2c */
            ii(0x100b_75d5, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x100b_75d8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_75db, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_75e0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_75e3, 5); calld(0x100a_284c, -0x1_4d9c);          /* call 0x100a284c */
            ii(0x100b_75e8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_75eb, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100b_75f2, 2); if(jzd(0x100b_75fc, 0x8)) goto l_0x100b_75fc; /* jz 0x100b75fc */
            ii(0x100b_75f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_75f7, 5); calld(Definitions.sys_delete, 0xa_e968); /* call 0x10165f64 */
        l_0x100b_75fc:
            ii(0x100b_75fc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_75ff, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_7602, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_7605, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7607, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_7608, 1); popd(edi);                              /* pop edi */
            ii(0x100b_7609, 1); popd(esi);                              /* pop esi */
            ii(0x100b_760a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_760b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_760c, 1); retd(); return;                         /* ret */
        }
    }
}
