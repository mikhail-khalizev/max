using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_fefc-85bef5fe")]
        public void Method_1009_fefc()
        {
            ii(0x1009_fefc, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_ff01, 5); call(Definitions.sys_check_available_stack_size, 0xc_5e4c); /* call 0x10165d52 */
            ii(0x1009_ff06, 1); push(ebx);                              /* push ebx */
            ii(0x1009_ff07, 1); push(ecx);                              /* push ecx */
            ii(0x1009_ff08, 1); push(esi);                              /* push esi */
            ii(0x1009_ff09, 1); push(edi);                              /* push edi */
            ii(0x1009_ff0a, 1); push(ebp);                              /* push ebp */
            ii(0x1009_ff0b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_ff0d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_ff13, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_ff16, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1009_ff19, 7); test(memd[ss, ebp - 4], 4);             /* test dword [ebp-0x4], 0x4 */
            ii(0x1009_ff20, 2); if(jz(0x1009_ff36, 0x14)) goto l_0x1009_ff36; /* jz 0x1009ff36 */
            ii(0x1009_ff22, 5); mov(edx, 0x101b_489c);                  /* mov edx, 0x101b489c */
            ii(0x1009_ff27, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_ff2a, 5); call(Definitions.sys_call_dtor_arr, 0xc_6089); /* call 0x10165fb8 */
            ii(0x1009_ff2f, 5); call(Definitions.sys_delete_arr, 0xc_60a4); /* call 0x10165fd8 */
            ii(0x1009_ff34, 2); jmp(0x1009_ff57, 0x21); goto l_0x1009_ff57; /* jmp 0x1009ff57 */
        l_0x1009_ff36:
            ii(0x1009_ff36, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1009_ff3b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_ff3e, 5); call(0x1009_fdbc, -0x187);              /* call 0x1009fdbc */
            ii(0x1009_ff43, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_ff46, 7); test(memd[ss, ebp - 4], 2);             /* test dword [ebp-0x4], 0x2 */
            ii(0x1009_ff4d, 2); if(jz(0x1009_ff57, 8)) goto l_0x1009_ff57; /* jz 0x1009ff57 */
            ii(0x1009_ff4f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_ff52, 5); call(Definitions.sys_delete, 0xc_600d); /* call 0x10165f64 */
        l_0x1009_ff57:
            ii(0x1009_ff57, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_ff5a, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1009_ff5d, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_ff60, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_ff62, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_ff63, 1); pop(edi);                               /* pop edi */
            ii(0x1009_ff64, 1); pop(esi);                               /* pop esi */
            ii(0x1009_ff65, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_ff66, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_ff67, 1); ret();                                  /* ret */
        }
    }
}
