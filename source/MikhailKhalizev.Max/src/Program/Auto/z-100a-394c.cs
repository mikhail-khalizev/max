using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("04deeaf1-576d-4b69-82b6-efaa01c1773d")]
        public void Method_100a_394c()
        {
            ii(0x100a_394c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_3951, 5); calld(Definitions.sys_check_available_stack_size, 0xc_23fc); /* call 0x10165d52 */
            ii(0x100a_3956, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_3957, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_3958, 1); pushd(esi);                             /* push esi */
            ii(0x100a_3959, 1); pushd(edi);                             /* push edi */
            ii(0x100a_395a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_395b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_395d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_3963, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_3966, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_3969, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100a_3970, 2); if(jzd(0x100a_3986, 0x14)) goto l_0x100a_3986; /* jz 0x100a3986 */
            ii(0x100a_3972, 5); mov(edx, 0x101b_4d44);                  /* mov edx, 0x101b4d44 */
            ii(0x100a_3977, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_397a, 5); calld(Definitions.sys_call_dtor_arr, 0xc_2639); /* call 0x10165fb8 */
            ii(0x100a_397f, 5); calld(Definitions.sys_delete_arr, 0xc_2654); /* call 0x10165fd8 */
            ii(0x100a_3984, 2); jmpd(0x100a_39c4, 0x3e); goto l_0x100a_39c4; /* jmp 0x100a39c4 */
        l_0x100a_3986:
            ii(0x100a_3986, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3989, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_4f24); /* mov dword [eax+0x2], 0x101b4f24 */
            ii(0x100a_3990, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_3992, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3995, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_3998, 5); calld(0x1008_8b7c, -0x1_ae21);          /* call 0x10088b7c */
            ii(0x100a_399d, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x100a_39a0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_39a3, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_39a8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_39ab, 5); calld(0x100a_36c9, -0x2e7);             /* call 0x100a36c9 */
            ii(0x100a_39b0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_39b3, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100a_39ba, 2); if(jzd(0x100a_39c4, 0x8)) goto l_0x100a_39c4; /* jz 0x100a39c4 */
            ii(0x100a_39bc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_39bf, 5); calld(Definitions.sys_delete, 0xc_25a0); /* call 0x10165f64 */
        l_0x100a_39c4:
            ii(0x100a_39c4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_39c7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_39ca, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_39cd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_39cf, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_39d0, 1); popd(edi);                              /* pop edi */
            ii(0x100a_39d1, 1); popd(esi);                              /* pop esi */
            ii(0x100a_39d2, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_39d3, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_39d4, 1); retd(); return;                         /* ret */
        }
    }
}
