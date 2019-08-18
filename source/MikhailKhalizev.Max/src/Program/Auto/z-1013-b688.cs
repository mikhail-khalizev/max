using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8737c914-8cdd-4329-a034-5ae5037d2daa")]
        public void Method_1013_b688()
        {
            ii(0x1013_b688, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_b68d, 5); calld(Definitions.sys_check_available_stack_size, 0x2_a6c0); /* call 0x10165d52 */
            ii(0x1013_b692, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_b693, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_b694, 1); pushd(esi);                             /* push esi */
            ii(0x1013_b695, 1); pushd(edi);                             /* push edi */
            ii(0x1013_b696, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_b697, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b699, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_b69f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_b6a2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_b6a5, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1013_b6ac, 2); if(jzd(0x1013_b6c2, 0x14)) goto l_0x1013_b6c2; /* jz 0x1013b6c2 */
            ii(0x1013_b6ae, 5); mov(edx, 0x101b_6ec8);                  /* mov edx, 0x101b6ec8 */
            ii(0x1013_b6b3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b6b6, 5); calld(Definitions.sys_call_dtor_arr, 0x2_a8fd); /* call 0x10165fb8 */
            ii(0x1013_b6bb, 5); calld(Definitions.sys_delete_arr, 0x2_a918); /* call 0x10165fd8 */
            ii(0x1013_b6c0, 2); jmpd(0x1013_b6f9, 0x37); goto l_0x1013_b6f9; /* jmp 0x1013b6f9 */
        l_0x1013_b6c2:
            ii(0x1013_b6c2, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_b6c7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b6ca, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1013_b6cd, 5); calld(0x100c_d916, -0x6_ddbc);          /* call 0x100cd916 */
            ii(0x1013_b6d2, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x1013_b6d5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_b6d8, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_b6dd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b6e0, 5); calld(0x1013_ab27, -0xbbe);             /* call 0x1013ab27 */
            ii(0x1013_b6e5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_b6e8, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1013_b6ef, 2); if(jzd(0x1013_b6f9, 0x8)) goto l_0x1013_b6f9; /* jz 0x1013b6f9 */
            ii(0x1013_b6f1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b6f4, 5); calld(Definitions.sys_delete, 0x2_a86b); /* call 0x10165f64 */
        l_0x1013_b6f9:
            ii(0x1013_b6f9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b6fc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_b6ff, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_b702, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b704, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_b705, 1); popd(edi);                              /* pop edi */
            ii(0x1013_b706, 1); popd(esi);                              /* pop esi */
            ii(0x1013_b707, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_b708, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_b709, 1); retd(); return;                         /* ret */
        }
    }
}
