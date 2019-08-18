using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_b92c-705f61ec")]
        public void Method_1009_b92c()
        {
            ii(0x1009_b92c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_b931, 5); calld(Definitions.sys_check_available_stack_size, 0xc_a41c); /* call 0x10165d52 */
            ii(0x1009_b936, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_b937, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_b938, 1); pushd(esi);                             /* push esi */
            ii(0x1009_b939, 1); pushd(edi);                             /* push edi */
            ii(0x1009_b93a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_b93b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_b93d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_b943, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_b946, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_b949, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1009_b950, 2); if(jzd(0x1009_b966, 0x14)) goto l_0x1009_b966; /* jz 0x1009b966 */
            ii(0x1009_b952, 5); mov(edx, 0x101b_4080);                  /* mov edx, 0x101b4080 */
            ii(0x1009_b957, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b95a, 5); calld(Definitions.sys_call_dtor_arr, 0xc_a659); /* call 0x10165fb8 */
            ii(0x1009_b95f, 5); calld(Definitions.sys_delete_arr, 0xc_a674); /* call 0x10165fd8 */
            ii(0x1009_b964, 2); jmpd(0x1009_b987, 0x21); goto l_0x1009_b987; /* jmp 0x1009b987 */
        l_0x1009_b966:
            ii(0x1009_b966, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1009_b96b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b96e, 5); calld(0x1009_b874, -0xff);              /* call 0x1009b874 */
            ii(0x1009_b973, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_b976, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1009_b97d, 2); if(jzd(0x1009_b987, 0x8)) goto l_0x1009_b987; /* jz 0x1009b987 */
            ii(0x1009_b97f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b982, 5); calld(Definitions.sys_delete, 0xc_a5dd); /* call 0x10165f64 */
        l_0x1009_b987:
            ii(0x1009_b987, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b98a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_b98d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_b990, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_b992, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_b993, 1); popd(edi);                              /* pop edi */
            ii(0x1009_b994, 1); popd(esi);                              /* pop esi */
            ii(0x1009_b995, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_b996, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_b997, 1); retd(); return;                         /* ret */
        }
    }
}
