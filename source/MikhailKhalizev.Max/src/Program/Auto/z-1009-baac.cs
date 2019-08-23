using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_baac-71ab7c75")]
        public void Method_1009_baac()
        {
            ii(0x1009_baac, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_bab1, 5); call(Definitions.sys_check_available_stack_size, 0xc_a29c); /* call 0x10165d52 */
            ii(0x1009_bab6, 1); push(ebx);                              /* push ebx */
            ii(0x1009_bab7, 1); push(ecx);                              /* push ecx */
            ii(0x1009_bab8, 1); push(esi);                              /* push esi */
            ii(0x1009_bab9, 1); push(edi);                              /* push edi */
            ii(0x1009_baba, 1); push(ebp);                              /* push ebp */
            ii(0x1009_babb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_babd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_bac3, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_bac6, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_bac9, 7); test(memd[ss, ebp - 0x4], 0x4);         /* test dword [ebp-0x4], 0x4 */
            ii(0x1009_bad0, 2); if(jz(0x1009_bae6, 0x14)) goto l_0x1009_bae6; /* jz 0x1009bae6 */
            ii(0x1009_bad2, 5); mov(edx, 0x101b_4094);                  /* mov edx, 0x101b4094 */
            ii(0x1009_bad7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_bada, 5); call(Definitions.sys_call_dtor_arr, 0xc_a4d9); /* call 0x10165fb8 */
            ii(0x1009_badf, 5); call(Definitions.sys_delete_arr, 0xc_a4f4); /* call 0x10165fd8 */
            ii(0x1009_bae4, 2); jmp(0x1009_bb53, 0x6d); goto l_0x1009_bb53; /* jmp 0x1009bb53 */
        l_0x1009_bae6:
            ii(0x1009_bae6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_bae8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_baeb, 3); add(eax, 0x2b);                         /* add eax, 0x2b */
            ii(0x1009_baee, 5); call(0x1009_b834, -0x2bf);              /* call 0x1009b834 */
            ii(0x1009_baf3, 3); sub(eax, 0x2b);                         /* sub eax, 0x2b */
            ii(0x1009_baf6, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_baf9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_bafb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_bafe, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1009_bb01, 5); call(0x1009_b8ec, -0x21a);              /* call 0x1009b8ec */
            ii(0x1009_bb06, 3); sub(eax, 0x26);                         /* sub eax, 0x26 */
            ii(0x1009_bb09, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_bb0c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_bb0e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_bb11, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1009_bb14, 5); call(0x1008_8b7c, -0x1_2f9d);           /* call 0x10088b7c */
            ii(0x1009_bb19, 3); sub(eax, 0x1d);                         /* sub eax, 0x1d */
            ii(0x1009_bb1c, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_bb1f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_bb21, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_bb24, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1009_bb27, 5); call(0x1007_5f2c, -0x2_5c00);           /* call 0x10075f2c */
            ii(0x1009_bb2c, 3); sub(eax, 0x19);                         /* sub eax, 0x19 */
            ii(0x1009_bb2f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_bb32, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1009_bb37, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_bb3a, 5); call(0x1009_b998, -0x1a7);              /* call 0x1009b998 */
            ii(0x1009_bb3f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_bb42, 7); test(memd[ss, ebp - 0x4], 0x2);         /* test dword [ebp-0x4], 0x2 */
            ii(0x1009_bb49, 2); if(jz(0x1009_bb53, 0x8)) goto l_0x1009_bb53; /* jz 0x1009bb53 */
            ii(0x1009_bb4b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_bb4e, 5); call(Definitions.sys_delete, 0xc_a411); /* call 0x10165f64 */
        l_0x1009_bb53:
            ii(0x1009_bb53, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_bb56, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_bb59, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_bb5c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_bb5e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_bb5f, 1); pop(edi);                               /* pop edi */
            ii(0x1009_bb60, 1); pop(esi);                               /* pop esi */
            ii(0x1009_bb61, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_bb62, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_bb63, 1); ret();                                  /* ret */
        }
    }
}
