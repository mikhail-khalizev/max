using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("440b201b-b1a2-4fcc-8212-b42d6567614a")]
        public void Method_1014_79e4()
        {
            ii(0x1014_79e4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_79e9, 5); calld(Definitions.sys_check_available_stack_size, 0x1_e364); /* call 0x10165d52 */
            ii(0x1014_79ee, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_79ef, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_79f0, 1); pushd(esi);                             /* push esi */
            ii(0x1014_79f1, 1); pushd(edi);                             /* push edi */
            ii(0x1014_79f2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_79f3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_79f5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_79fb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_79fe, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_7a01, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1014_7a08, 2); if(jzd(0x1014_7a1e, 0x14)) goto l_0x1014_7a1e; /* jz 0x10147a1e */
            ii(0x1014_7a0a, 5); mov(edx, 0x101b_7144);                  /* mov edx, 0x101b7144 */
            ii(0x1014_7a0f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7a12, 5); calld(Definitions.sys_call_dtor_arr, 0x1_e5a1); /* call 0x10165fb8 */
            ii(0x1014_7a17, 5); calld(Definitions.sys_delete_arr, 0x1_e5bc); /* call 0x10165fd8 */
            ii(0x1014_7a1c, 2); jmpd(0x1014_7a52, 0x34); goto l_0x1014_7a52; /* jmp 0x10147a52 */
        l_0x1014_7a1e:
            ii(0x1014_7a1e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_7a20, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7a23, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1014_7a26, 5); calld(Definitions.my_string_dtor, -0x5f01); /* call 0x10141b2a */
            ii(0x1014_7a2b, 3); sub(eax, 0x14);                         /* sub eax, 0x14 */
            ii(0x1014_7a2e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7a31, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1014_7a36, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7a39, 5); calld(0x1014_4fba, -0x2a84);            /* call 0x10144fba */
            ii(0x1014_7a3e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7a41, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1014_7a48, 2); if(jzd(0x1014_7a52, 0x8)) goto l_0x1014_7a52; /* jz 0x10147a52 */
            ii(0x1014_7a4a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7a4d, 5); calld(Definitions.sys_delete, 0x1_e512); /* call 0x10165f64 */
        l_0x1014_7a52:
            ii(0x1014_7a52, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7a55, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_7a58, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_7a5b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7a5d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7a5e, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7a5f, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7a60, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_7a61, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_7a62, 1); retd(); return;                         /* ret */
        }
    }
}
