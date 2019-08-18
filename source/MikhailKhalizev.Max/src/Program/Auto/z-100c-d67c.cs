using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_d67c-56e10ec7")]
        public void Method_100c_d67c()
        {
            ii(0x100c_d67c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_d681, 5); calld(Definitions.sys_check_available_stack_size, 0x9_86cc); /* call 0x10165d52 */
            ii(0x100c_d686, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_d687, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_d688, 1); pushd(esi);                             /* push esi */
            ii(0x100c_d689, 1); pushd(edi);                             /* push edi */
            ii(0x100c_d68a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_d68b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_d68d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_d693, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_d696, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_d699, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100c_d6a0, 2); if(jzd(0x100c_d6b6, 0x14)) goto l_0x100c_d6b6; /* jz 0x100cd6b6 */
            ii(0x100c_d6a2, 5); mov(edx, 0x101b_59a0);                  /* mov edx, 0x101b59a0 */
            ii(0x100c_d6a7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d6aa, 5); calld(Definitions.sys_call_dtor_arr, 0x9_8909); /* call 0x10165fb8 */
            ii(0x100c_d6af, 5); calld(Definitions.sys_delete_arr, 0x9_8924); /* call 0x10165fd8 */
            ii(0x100c_d6b4, 2); jmpd(0x100c_d6fd, 0x47); goto l_0x100c_d6fd; /* jmp 0x100cd6fd */
        l_0x100c_d6b6:
            ii(0x100c_d6b6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_d6b8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d6bb, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_d6be, 5); calld(0x1007_5f2c, -0x5_7797);          /* call 0x10075f2c */
            ii(0x100c_d6c3, 3); sub(eax, 0x17);                         /* sub eax, 0x17 */
            ii(0x100c_d6c6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_d6c9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_d6cb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d6ce, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_d6d1, 5); calld(0x1007_5f2c, -0x5_77aa);          /* call 0x10075f2c */
            ii(0x100c_d6d6, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x100c_d6d9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_d6dc, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100c_d6e1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d6e4, 5); calld(0x100a_284c, -0x2_ae9d);          /* call 0x100a284c */
            ii(0x100c_d6e9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_d6ec, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100c_d6f3, 2); if(jzd(0x100c_d6fd, 0x8)) goto l_0x100c_d6fd; /* jz 0x100cd6fd */
            ii(0x100c_d6f5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d6f8, 5); calld(Definitions.sys_delete, 0x9_8867); /* call 0x10165f64 */
        l_0x100c_d6fd:
            ii(0x100c_d6fd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d700, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_d703, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_d706, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_d708, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_d709, 1); popd(edi);                              /* pop edi */
            ii(0x100c_d70a, 1); popd(esi);                              /* pop esi */
            ii(0x100c_d70b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_d70c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_d70d, 1); retd(); return;                         /* ret */
        }
    }
}
