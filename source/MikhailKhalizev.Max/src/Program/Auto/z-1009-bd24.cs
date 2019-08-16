using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6c86ce56-07a0-4f19-aeb8-6eae0a36c625")]
        public void Method_1009_bd24()
        {
            ii(0x1009_bd24, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_bd29, 5); calld(Definitions.sys_check_available_stack_size, 0xc_a024); /* call 0x10165d52 */
            ii(0x1009_bd2e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_bd2f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_bd30, 1); pushd(esi);                             /* push esi */
            ii(0x1009_bd31, 1); pushd(edi);                             /* push edi */
            ii(0x1009_bd32, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_bd33, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_bd35, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_bd3b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_bd3e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_bd41, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1009_bd48, 2); if(jzd(0x1009_bd5e, 0x14)) goto l_0x1009_bd5e; /* jz 0x1009bd5e */
            ii(0x1009_bd4a, 5); mov(edx, 0x101b_40e4);                  /* mov edx, 0x101b40e4 */
            ii(0x1009_bd4f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bd52, 5); calld(Definitions.sys_call_dtor_arr, 0xc_a261); /* call 0x10165fb8 */
            ii(0x1009_bd57, 5); calld(Definitions.sys_delete_arr, 0xc_a27c); /* call 0x10165fd8 */
            ii(0x1009_bd5c, 2); jmpd(0x1009_bd92, 0x34); goto l_0x1009_bd92; /* jmp 0x1009bd92 */
        l_0x1009_bd5e:
            ii(0x1009_bd5e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_bd60, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bd63, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_bd66, 5); calld(0x1009_bbf8, -0x173);             /* call 0x1009bbf8 */
            ii(0x1009_bd6b, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1009_bd6e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_bd71, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1009_bd76, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bd79, 5); calld(0x100a_284c, 0x6ace);             /* call 0x100a284c */
            ii(0x1009_bd7e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_bd81, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1009_bd88, 2); if(jzd(0x1009_bd92, 0x8)) goto l_0x1009_bd92; /* jz 0x1009bd92 */
            ii(0x1009_bd8a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bd8d, 5); calld(Definitions.sys_delete, 0xc_a1d2); /* call 0x10165f64 */
        l_0x1009_bd92:
            ii(0x1009_bd92, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bd95, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_bd98, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_bd9b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_bd9d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_bd9e, 1); popd(edi);                              /* pop edi */
            ii(0x1009_bd9f, 1); popd(esi);                              /* pop esi */
            ii(0x1009_bda0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_bda1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_bda2, 1); retd(); return;                         /* ret */
        }
    }
}