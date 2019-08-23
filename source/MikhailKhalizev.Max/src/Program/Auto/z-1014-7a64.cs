using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7a64-64fd7578")]
        public void Method_1014_7a64()
        {
            ii(0x1014_7a64, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_7a69, 5); calld(Definitions.sys_check_available_stack_size, 0x1_e2e4); /* call 0x10165d52 */
            ii(0x1014_7a6e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_7a6f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_7a70, 1); pushd(esi);                             /* push esi */
            ii(0x1014_7a71, 1); pushd(edi);                             /* push edi */
            ii(0x1014_7a72, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_7a73, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7a75, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_7a7b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7a7e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_7a81, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1014_7a88, 2); if(jzd(0x1014_7a9e, 0x14)) goto l_0x1014_7a9e; /* jz 0x10147a9e */
            ii(0x1014_7a8a, 5); mov(edx, 0x101b_7158);                  /* mov edx, 0x101b7158 */
            ii(0x1014_7a8f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7a92, 5); calld(Definitions.sys_call_dtor_arr, 0x1_e521); /* call 0x10165fb8 */
            ii(0x1014_7a97, 5); calld(Definitions.sys_delete_arr, 0x1_e53c); /* call 0x10165fd8 */
            ii(0x1014_7a9c, 2); jmpd(0x1014_7ad2, 0x34); goto l_0x1014_7ad2; /* jmp 0x10147ad2 */
        l_0x1014_7a9e:
            ii(0x1014_7a9e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_7aa0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7aa3, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1014_7aa6, 5); calld(Definitions.my_string_dtor, -0x5f81); /* call 0x10141b2a */
            ii(0x1014_7aab, 3); sub(eax, 0x14);                         /* sub eax, 0x14 */
            ii(0x1014_7aae, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7ab1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1014_7ab6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7ab9, 5); calld(0x1014_4fba, -0x2b04);            /* call 0x10144fba */
            ii(0x1014_7abe, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7ac1, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1014_7ac8, 2); if(jzd(0x1014_7ad2, 0x8)) goto l_0x1014_7ad2; /* jz 0x10147ad2 */
            ii(0x1014_7aca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7acd, 5); calld(Definitions.sys_delete, 0x1_e492); /* call 0x10165f64 */
        l_0x1014_7ad2:
            ii(0x1014_7ad2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7ad5, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_7ad8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_7adb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7add, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7ade, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7adf, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7ae0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_7ae1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_7ae2, 1); retd();                                 /* ret */
        }
    }
}
