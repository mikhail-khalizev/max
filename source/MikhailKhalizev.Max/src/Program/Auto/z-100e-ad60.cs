using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("27f69521-f164-42a3-91d2-4352ba30d01b")]
        public void Method_100e_ad60()
        {
            ii(0x100e_ad60, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_ad65, 5); calld(Definitions.sys_check_available_stack_size, 0x7_afe8); /* call 0x10165d52 */
            ii(0x100e_ad6a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_ad6b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_ad6c, 1); pushd(esi);                             /* push esi */
            ii(0x100e_ad6d, 1); pushd(edi);                             /* push edi */
            ii(0x100e_ad6e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_ad6f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_ad71, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_ad77, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_ad7a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_ad7d, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100e_ad84, 2); if(jzd(0x100e_ad9a, 0x14)) goto l_0x100e_ad9a; /* jz 0x100ead9a */
            ii(0x100e_ad86, 5); mov(edx, 0x101b_6158);                  /* mov edx, 0x101b6158 */
            ii(0x100e_ad8b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_ad8e, 5); calld(Definitions.sys_call_dtor_arr, 0x7_b225); /* call 0x10165fb8 */
            ii(0x100e_ad93, 5); calld(Definitions.sys_delete_arr, 0x7_b240); /* call 0x10165fd8 */
            ii(0x100e_ad98, 2); jmpd(0x100e_adbb, 0x21); goto l_0x100e_adbb; /* jmp 0x100eadbb */
        l_0x100e_ad9a:
            ii(0x100e_ad9a, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_ad9f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_ada2, 5); calld(0x100c_d916, -0x1_d491);          /* call 0x100cd916 */
            ii(0x100e_ada7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_adaa, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100e_adb1, 2); if(jzd(0x100e_adbb, 0x8)) goto l_0x100e_adbb; /* jz 0x100eadbb */
            ii(0x100e_adb3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_adb6, 5); calld(Definitions.sys_delete, 0x7_b1a9); /* call 0x10165f64 */
        l_0x100e_adbb:
            ii(0x100e_adbb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_adbe, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_adc1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_adc4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_adc6, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_adc7, 1); popd(edi);                              /* pop edi */
            ii(0x100e_adc8, 1); popd(esi);                              /* pop esi */
            ii(0x100e_adc9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_adca, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_adcb, 1); retd(); return;                         /* ret */
        }
    }
}
