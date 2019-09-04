using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a594-2126f1f2")]
        public void Method_100c_a594()
        {
            ii(0x100c_a594, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_a599, 5); call(Definitions.sys_check_available_stack_size, 0x9_b7b4); /* call 0x10165d52 */
            ii(0x100c_a59e, 1); push(ebx);                              /* push ebx */
            ii(0x100c_a59f, 1); push(ecx);                              /* push ecx */
            ii(0x100c_a5a0, 1); push(esi);                              /* push esi */
            ii(0x100c_a5a1, 1); push(edi);                              /* push edi */
            ii(0x100c_a5a2, 1); push(ebp);                              /* push ebp */
            ii(0x100c_a5a3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a5a5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a5ab, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_a5ae, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_a5b1, 7); test(memd[ss, ebp - 4], 4);             /* test dword [ebp-0x4], 0x4 */
            ii(0x100c_a5b8, 2); if(jz(0x100c_a5ce, 0x14)) goto l_0x100c_a5ce; /* jz 0x100ca5ce */
            ii(0x100c_a5ba, 5); mov(edx, 0x101b_5670);                  /* mov edx, 0x101b5670 */
            ii(0x100c_a5bf, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a5c2, 5); call(Definitions.sys_call_dtor_arr, 0x9_b9f1); /* call 0x10165fb8 */
            ii(0x100c_a5c7, 5); call(Definitions.sys_delete_arr, 0x9_ba0c); /* call 0x10165fd8 */
            ii(0x100c_a5cc, 2); jmp(0x100c_a615, 0x47); goto l_0x100c_a615; /* jmp 0x100ca615 */
        l_0x100c_a5ce:
            ii(0x100c_a5ce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_a5d0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a5d3, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100c_a5d6, 5); call(0x1008_8b7c, -0x4_1a5f);           /* call 0x10088b7c */
            ii(0x100c_a5db, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x100c_a5de, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_a5e1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_a5e3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a5e6, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x100c_a5e9, 5); call(0x1007_5f2c, -0x5_46c2);           /* call 0x10075f2c */
            ii(0x100c_a5ee, 3); sub(eax, 6);                            /* sub eax, 0x6 */
            ii(0x100c_a5f1, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_a5f4, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100c_a5f9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a5fc, 5); call(0x1013_ab27, 0x7_0526);            /* call 0x1013ab27 */
            ii(0x100c_a601, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_a604, 7); test(memd[ss, ebp - 4], 2);             /* test dword [ebp-0x4], 0x2 */
            ii(0x100c_a60b, 2); if(jz(0x100c_a615, 8)) goto l_0x100c_a615; /* jz 0x100ca615 */
            ii(0x100c_a60d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a610, 5); call(Definitions.sys_delete, 0x9_b94f); /* call 0x10165f64 */
        l_0x100c_a615:
            ii(0x100c_a615, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a618, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100c_a61b, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100c_a61e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a620, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_a621, 1); pop(edi);                               /* pop edi */
            ii(0x100c_a622, 1); pop(esi);                               /* pop esi */
            ii(0x100c_a623, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_a624, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_a625, 1); ret();                                  /* ret */
        }
    }
}
