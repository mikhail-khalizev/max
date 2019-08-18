using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7468-10a24398")]
        public void Method_100b_7468()
        {
            ii(0x100b_7468, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_746d, 5); calld(Definitions.sys_check_available_stack_size, 0xa_e8e0); /* call 0x10165d52 */
            ii(0x100b_7472, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_7473, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_7474, 1); pushd(esi);                             /* push esi */
            ii(0x100b_7475, 1); pushd(edi);                             /* push edi */
            ii(0x100b_7476, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_7477, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7479, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_747f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7482, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_7485, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100b_748c, 2); if(jzd(0x100b_74a2, 0x14)) goto l_0x100b_74a2; /* jz 0x100b74a2 */
            ii(0x100b_748e, 5); mov(edx, 0x101b_5080);                  /* mov edx, 0x101b5080 */
            ii(0x100b_7493, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7496, 5); calld(Definitions.sys_call_dtor_arr, 0xa_eb1d); /* call 0x10165fb8 */
            ii(0x100b_749b, 5); calld(Definitions.sys_delete_arr, 0xa_eb38); /* call 0x10165fd8 */
            ii(0x100b_74a0, 2); jmpd(0x100b_74d6, 0x34); goto l_0x100b_74d6; /* jmp 0x100b74d6 */
        l_0x100b_74a2:
            ii(0x100b_74a2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_74a4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_74a7, 3); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x100b_74aa, 5); calld(0x100b_7428, -0x87);              /* call 0x100b7428 */
            ii(0x100b_74af, 3); sub(eax, 0x1a);                         /* sub eax, 0x1a */
            ii(0x100b_74b2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_74b5, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_74ba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_74bd, 5); calld(0x100b_72d4, -0x1ee);             /* call 0x100b72d4 */
            ii(0x100b_74c2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_74c5, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100b_74cc, 2); if(jzd(0x100b_74d6, 0x8)) goto l_0x100b_74d6; /* jz 0x100b74d6 */
            ii(0x100b_74ce, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_74d1, 5); calld(Definitions.sys_delete, 0xa_ea8e); /* call 0x10165f64 */
        l_0x100b_74d6:
            ii(0x100b_74d6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_74d9, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_74dc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_74df, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_74e1, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_74e2, 1); popd(edi);                              /* pop edi */
            ii(0x100b_74e3, 1); popd(esi);                              /* pop esi */
            ii(0x100b_74e4, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_74e5, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_74e6, 1); retd(); return;                         /* ret */
        }
    }
}
