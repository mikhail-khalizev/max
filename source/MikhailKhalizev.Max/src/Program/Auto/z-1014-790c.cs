using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_790c-552bd6ba")]
        public void Method_1014_790c()
        {
            ii(0x1014_790c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_7911, 5); calld(Definitions.sys_check_available_stack_size, 0x1_e43c); /* call 0x10165d52 */
            ii(0x1014_7916, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_7917, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_7918, 1); pushd(esi);                             /* push esi */
            ii(0x1014_7919, 1); pushd(edi);                             /* push edi */
            ii(0x1014_791a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_791b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_791d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_7923, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7926, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_7929, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1014_7930, 2); if(jzd(0x1014_7946, 0x14)) goto l_0x1014_7946; /* jz 0x10147946 */
            ii(0x1014_7932, 5); mov(edx, 0x101b_711c);                  /* mov edx, 0x101b711c */
            ii(0x1014_7937, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_793a, 5); calld(Definitions.sys_call_dtor_arr, 0x1_e679); /* call 0x10165fb8 */
            ii(0x1014_793f, 5); calld(Definitions.sys_delete_arr, 0x1_e694); /* call 0x10165fd8 */
            ii(0x1014_7944, 2); jmpd(0x1014_7967, 0x21); goto l_0x1014_7967; /* jmp 0x10147967 */
        l_0x1014_7946:
            ii(0x1014_7946, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1014_794b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_794e, 5); calld(0x1013_ab27, -0xce2c);            /* call 0x1013ab27 */
            ii(0x1014_7953, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7956, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1014_795d, 2); if(jzd(0x1014_7967, 0x8)) goto l_0x1014_7967; /* jz 0x10147967 */
            ii(0x1014_795f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7962, 5); calld(Definitions.sys_delete, 0x1_e5fd); /* call 0x10165f64 */
        l_0x1014_7967:
            ii(0x1014_7967, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_796a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_796d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_7970, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7972, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7973, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7974, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7975, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_7976, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_7977, 1); retd(); return;                         /* ret */
        }
    }
}
