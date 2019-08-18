using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4abc3dc4-2c42-4c9e-96df-294034be6f0b")]
        public void Method_100c_d77c()
        {
            ii(0x100c_d77c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_d781, 5); calld(Definitions.sys_check_available_stack_size, 0x9_85cc); /* call 0x10165d52 */
            ii(0x100c_d786, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_d787, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_d788, 1); pushd(esi);                             /* push esi */
            ii(0x100c_d789, 1); pushd(edi);                             /* push edi */
            ii(0x100c_d78a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_d78b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_d78d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_d793, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_d796, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_d799, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100c_d7a0, 2); if(jzd(0x100c_d7b6, 0x14)) goto l_0x100c_d7b6; /* jz 0x100cd7b6 */
            ii(0x100c_d7a2, 5); mov(edx, 0x101b_59c8);                  /* mov edx, 0x101b59c8 */
            ii(0x100c_d7a7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d7aa, 5); calld(Definitions.sys_call_dtor_arr, 0x9_8809); /* call 0x10165fb8 */
            ii(0x100c_d7af, 5); calld(Definitions.sys_delete_arr, 0x9_8824); /* call 0x10165fd8 */
            ii(0x100c_d7b4, 2); jmpd(0x100c_d7d7, 0x21); goto l_0x100c_d7d7; /* jmp 0x100cd7d7 */
        l_0x100c_d7b6:
            ii(0x100c_d7b6, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100c_d7bb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d7be, 5); calld(0x100c_d67c, -0x147);             /* call 0x100cd67c */
            ii(0x100c_d7c3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_d7c6, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100c_d7cd, 2); if(jzd(0x100c_d7d7, 0x8)) goto l_0x100c_d7d7; /* jz 0x100cd7d7 */
            ii(0x100c_d7cf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d7d2, 5); calld(Definitions.sys_delete, 0x9_878d); /* call 0x10165f64 */
        l_0x100c_d7d7:
            ii(0x100c_d7d7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d7da, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_d7dd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_d7e0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_d7e2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_d7e3, 1); popd(edi);                              /* pop edi */
            ii(0x100c_d7e4, 1); popd(esi);                              /* pop esi */
            ii(0x100c_d7e5, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_d7e6, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_d7e7, 1); retd(); return;                         /* ret */
        }
    }
}
