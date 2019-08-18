using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a28c-636d2ab8")]
        public void Method_100c_a28c()
        {
            ii(0x100c_a28c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_a291, 5); calld(Definitions.sys_check_available_stack_size, 0x9_babc); /* call 0x10165d52 */
            ii(0x100c_a296, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_a297, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_a298, 1); pushd(esi);                             /* push esi */
            ii(0x100c_a299, 1); pushd(edi);                             /* push edi */
            ii(0x100c_a29a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_a29b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a29d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a2a3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_a2a6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_a2a9, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100c_a2b0, 2); if(jzd(0x100c_a2c6, 0x14)) goto l_0x100c_a2c6; /* jz 0x100ca2c6 */
            ii(0x100c_a2b2, 5); mov(edx, 0x101b_5648);                  /* mov edx, 0x101b5648 */
            ii(0x100c_a2b7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a2ba, 5); calld(Definitions.sys_call_dtor_arr, 0x9_bcf9); /* call 0x10165fb8 */
            ii(0x100c_a2bf, 5); calld(Definitions.sys_delete_arr, 0x9_bd14); /* call 0x10165fd8 */
            ii(0x100c_a2c4, 2); jmpd(0x100c_a2e7, 0x21); goto l_0x100c_a2e7; /* jmp 0x100ca2e7 */
        l_0x100c_a2c6:
            ii(0x100c_a2c6, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100c_a2cb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a2ce, 5); calld(0x100c_a200, -0xd3);              /* call 0x100ca200 */
            ii(0x100c_a2d3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_a2d6, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100c_a2dd, 2); if(jzd(0x100c_a2e7, 0x8)) goto l_0x100c_a2e7; /* jz 0x100ca2e7 */
            ii(0x100c_a2df, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a2e2, 5); calld(Definitions.sys_delete, 0x9_bc7d); /* call 0x10165f64 */
        l_0x100c_a2e7:
            ii(0x100c_a2e7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a2ea, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_a2ed, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_a2f0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a2f2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_a2f3, 1); popd(edi);                              /* pop edi */
            ii(0x100c_a2f4, 1); popd(esi);                              /* pop esi */
            ii(0x100c_a2f5, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_a2f6, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_a2f7, 1); retd(); return;                         /* ret */
        }
    }
}
