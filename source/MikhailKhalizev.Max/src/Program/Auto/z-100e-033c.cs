using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_033c-2428bdbf")]
        public void Method_100e_033c()
        {
            ii(0x100e_033c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_0341, 5); calld(Definitions.sys_check_available_stack_size, 0x8_5a0c); /* call 0x10165d52 */
            ii(0x100e_0346, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_0347, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0348, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0349, 1); pushd(edi);                             /* push edi */
            ii(0x100e_034a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_034b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_034d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_0353, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_0356, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_0359, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100e_0360, 2); if(jzd(0x100e_0376, 0x14)) goto l_0x100e_0376; /* jz 0x100e0376 */
            ii(0x100e_0362, 5); mov(edx, 0x101b_5dec);                  /* mov edx, 0x101b5dec */
            ii(0x100e_0367, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_036a, 5); calld(Definitions.sys_call_dtor_arr, 0x8_5c49); /* call 0x10165fb8 */
            ii(0x100e_036f, 5); calld(Definitions.sys_delete_arr, 0x8_5c64); /* call 0x10165fd8 */
            ii(0x100e_0374, 2); jmpd(0x100e_03aa, 0x34); goto l_0x100e_03aa; /* jmp 0x100e03aa */
        l_0x100e_0376:
            ii(0x100e_0376, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_0378, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_037b, 3); add(eax, 0x48);                         /* add eax, 0x48 */
            ii(0x100e_037e, 5); calld(0x100e_0244, -0x13f);             /* call 0x100e0244 */
            ii(0x100e_0383, 3); sub(eax, 0x48);                         /* sub eax, 0x48 */
            ii(0x100e_0386, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_0389, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_038e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_0391, 5); calld(0x100d_00b2, -0x1_02e4);          /* call 0x100d00b2 */
            ii(0x100e_0396, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_0399, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100e_03a0, 2); if(jzd(0x100e_03aa, 0x8)) goto l_0x100e_03aa; /* jz 0x100e03aa */
            ii(0x100e_03a2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_03a5, 5); calld(Definitions.sys_delete, 0x8_5bba); /* call 0x10165f64 */
        l_0x100e_03aa:
            ii(0x100e_03aa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_03ad, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_03b0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_03b3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_03b5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_03b6, 1); popd(edi);                              /* pop edi */
            ii(0x100e_03b7, 1); popd(esi);                              /* pop esi */
            ii(0x100e_03b8, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_03b9, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_03ba, 1); retd(); return;                         /* ret */
        }
    }
}
