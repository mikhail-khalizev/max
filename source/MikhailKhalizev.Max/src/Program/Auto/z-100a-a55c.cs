using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a55c-60ad6c4b")]
        public void Method_100a_a55c()
        {
            ii(0x100a_a55c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_a561, 5); calld(Definitions.sys_check_available_stack_size, 0xb_b7ec); /* call 0x10165d52 */
            ii(0x100a_a566, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_a567, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_a568, 1); pushd(esi);                             /* push esi */
            ii(0x100a_a569, 1); pushd(edi);                             /* push edi */
            ii(0x100a_a56a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_a56b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a56d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a573, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a576, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_a579, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100a_a580, 2); if(jzd(0x100a_a596, 0x14)) goto l_0x100a_a596; /* jz 0x100aa596 */
            ii(0x100a_a582, 5); mov(edx, 0x101b_4cb8);                  /* mov edx, 0x101b4cb8 */
            ii(0x100a_a587, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a58a, 5); calld(Definitions.sys_call_dtor_arr, 0xb_ba29); /* call 0x10165fb8 */
            ii(0x100a_a58f, 5); calld(Definitions.sys_delete_arr, 0xb_ba44); /* call 0x10165fd8 */
            ii(0x100a_a594, 2); jmpd(0x100a_a5b7, 0x21); goto l_0x100a_a5b7; /* jmp 0x100aa5b7 */
        l_0x100a_a596:
            ii(0x100a_a596, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_a59b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a59e, 5); calld(0x100c_d916, 0x2_3373);           /* call 0x100cd916 */
            ii(0x100a_a5a3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a5a6, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100a_a5ad, 2); if(jzd(0x100a_a5b7, 0x8)) goto l_0x100a_a5b7; /* jz 0x100aa5b7 */
            ii(0x100a_a5af, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a5b2, 5); calld(Definitions.sys_delete, 0xb_b9ad); /* call 0x10165f64 */
        l_0x100a_a5b7:
            ii(0x100a_a5b7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a5ba, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_a5bd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_a5c0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a5c2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_a5c3, 1); popd(edi);                              /* pop edi */
            ii(0x100a_a5c4, 1); popd(esi);                              /* pop esi */
            ii(0x100a_a5c5, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_a5c6, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_a5c7, 1); retd();                                 /* ret */
        }
    }
}
