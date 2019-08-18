using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_bca4-b2642ba5")]
        public void Method_1009_bca4()
        {
            ii(0x1009_bca4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_bca9, 5); calld(Definitions.sys_check_available_stack_size, 0xc_a0a4); /* call 0x10165d52 */
            ii(0x1009_bcae, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_bcaf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_bcb0, 1); pushd(esi);                             /* push esi */
            ii(0x1009_bcb1, 1); pushd(edi);                             /* push edi */
            ii(0x1009_bcb2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_bcb3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_bcb5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_bcbb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_bcbe, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_bcc1, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1009_bcc8, 2); if(jzd(0x1009_bcde, 0x14)) goto l_0x1009_bcde; /* jz 0x1009bcde */
            ii(0x1009_bcca, 5); mov(edx, 0x101b_40d0);                  /* mov edx, 0x101b40d0 */
            ii(0x1009_bccf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bcd2, 5); calld(Definitions.sys_call_dtor_arr, 0xc_a2e1); /* call 0x10165fb8 */
            ii(0x1009_bcd7, 5); calld(Definitions.sys_delete_arr, 0xc_a2fc); /* call 0x10165fd8 */
            ii(0x1009_bcdc, 2); jmpd(0x1009_bd12, 0x34); goto l_0x1009_bd12; /* jmp 0x1009bd12 */
        l_0x1009_bcde:
            ii(0x1009_bcde, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_bce0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bce3, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_bce6, 5); calld(0x1009_bbf8, -0xf3);              /* call 0x1009bbf8 */
            ii(0x1009_bceb, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1009_bcee, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_bcf1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1009_bcf6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bcf9, 5); calld(0x100a_284c, 0x6b4e);             /* call 0x100a284c */
            ii(0x1009_bcfe, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_bd01, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1009_bd08, 2); if(jzd(0x1009_bd12, 0x8)) goto l_0x1009_bd12; /* jz 0x1009bd12 */
            ii(0x1009_bd0a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bd0d, 5); calld(Definitions.sys_delete, 0xc_a252); /* call 0x10165f64 */
        l_0x1009_bd12:
            ii(0x1009_bd12, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bd15, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_bd18, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_bd1b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_bd1d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_bd1e, 1); popd(edi);                              /* pop edi */
            ii(0x1009_bd1f, 1); popd(esi);                              /* pop esi */
            ii(0x1009_bd20, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_bd21, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_bd22, 1); retd(); return;                         /* ret */
        }
    }
}
