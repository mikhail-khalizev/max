using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1c115e07-ab97-4fec-93ba-558d75a430e3")]
        public void Method_1013_a994()
        {
            ii(0x1013_a994, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_a999, 5); calld(Definitions.sys_check_available_stack_size, 0x2_b3b4); /* call 0x10165d52 */
            ii(0x1013_a99e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_a99f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_a9a0, 1); pushd(esi);                             /* push esi */
            ii(0x1013_a9a1, 1); pushd(edi);                             /* push edi */
            ii(0x1013_a9a2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_a9a3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_a9a5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_a9ab, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_a9ae, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_a9b1, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1013_a9b8, 2); if(jzd(0x1013_a9ce, 0x14)) goto l_0x1013_a9ce; /* jz 0x1013a9ce */
            ii(0x1013_a9ba, 5); mov(edx, 0x101b_6e84);                  /* mov edx, 0x101b6e84 */
            ii(0x1013_a9bf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_a9c2, 5); calld(Definitions.sys_call_dtor_arr, 0x2_b5f1); /* call 0x10165fb8 */
            ii(0x1013_a9c7, 5); calld(Definitions.sys_delete_arr, 0x2_b60c); /* call 0x10165fd8 */
            ii(0x1013_a9cc, 2); jmpd(0x1013_aa28, 0x5a); goto l_0x1013_aa28; /* jmp 0x1013aa28 */
        l_0x1013_a9ce:
            ii(0x1013_a9ce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a9d0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_a9d3, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1013_a9d6, 5); calld(0x1007_5e24, -0xc_4bb7);          /* call 0x10075e24 */
            ii(0x1013_a9db, 3); sub(eax, 0xe);                          /* sub eax, 0xe */
            ii(0x1013_a9de, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_a9e1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a9e3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_a9e6, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1013_a9e9, 5); calld(0x1007_5e24, -0xc_4bca);          /* call 0x10075e24 */
            ii(0x1013_a9ee, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x1013_a9f1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_a9f4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a9f6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_a9f9, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1013_a9fc, 5); calld(Definitions.my_dtor_0x101b_6edc, 0x244); /* call 0x1013ac45 */
            ii(0x1013_aa01, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x1013_aa04, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_aa07, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_aa0c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_aa0f, 5); calld(0x1013_ab27, 0x113);              /* call 0x1013ab27 */
            ii(0x1013_aa14, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_aa17, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1013_aa1e, 2); if(jzd(0x1013_aa28, 0x8)) goto l_0x1013_aa28; /* jz 0x1013aa28 */
            ii(0x1013_aa20, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_aa23, 5); calld(Definitions.sys_delete, 0x2_b53c); /* call 0x10165f64 */
        l_0x1013_aa28:
            ii(0x1013_aa28, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_aa2b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_aa2e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_aa31, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_aa33, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_aa34, 1); popd(edi);                              /* pop edi */
            ii(0x1013_aa35, 1); popd(esi);                              /* pop esi */
            ii(0x1013_aa36, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_aa37, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_aa38, 1); retd(); return;                         /* ret */
        }
    }
}
