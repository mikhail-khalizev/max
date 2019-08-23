using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0260-9110974")]
        public void Method_1012_0260()
        {
            ii(0x1012_0260, 5); push(0x24);                             /* push 0x24 */
            ii(0x1012_0265, 5); call(Definitions.sys_check_available_stack_size, 0x4_5ae8); /* call 0x10165d52 */
            ii(0x1012_026a, 1); push(ebx);                              /* push ebx */
            ii(0x1012_026b, 1); push(ecx);                              /* push ecx */
            ii(0x1012_026c, 1); push(esi);                              /* push esi */
            ii(0x1012_026d, 1); push(edi);                              /* push edi */
            ii(0x1012_026e, 1); push(ebp);                              /* push ebp */
            ii(0x1012_026f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0271, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_0277, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_027a, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_027d, 7); test(memd[ss, ebp - 0x4], 0x4);         /* test dword [ebp-0x4], 0x4 */
            ii(0x1012_0284, 2); if(jz(0x1012_029a, 0x14)) goto l_0x1012_029a; /* jz 0x1012029a */
            ii(0x1012_0286, 5); mov(edx, 0x101b_68a8);                  /* mov edx, 0x101b68a8 */
            ii(0x1012_028b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_028e, 5); call(Definitions.sys_call_dtor_arr, 0x4_5d25); /* call 0x10165fb8 */
            ii(0x1012_0293, 5); call(Definitions.sys_delete_arr, 0x4_5d40); /* call 0x10165fd8 */
            ii(0x1012_0298, 2); jmp(0x1012_02bb, 0x21); goto l_0x1012_02bb; /* jmp 0x101202bb */
        l_0x1012_029a:
            ii(0x1012_029a, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_029f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_02a2, 5); call(0x1013_ab27, 0x1_a880);            /* call 0x1013ab27 */
            ii(0x1012_02a7, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_02aa, 7); test(memd[ss, ebp - 0x4], 0x2);         /* test dword [ebp-0x4], 0x2 */
            ii(0x1012_02b1, 2); if(jz(0x1012_02bb, 0x8)) goto l_0x1012_02bb; /* jz 0x101202bb */
            ii(0x1012_02b3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_02b6, 5); call(Definitions.sys_delete, 0x4_5ca9); /* call 0x10165f64 */
        l_0x1012_02bb:
            ii(0x1012_02bb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_02be, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1012_02c1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_02c4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_02c6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_02c7, 1); pop(edi);                               /* pop edi */
            ii(0x1012_02c8, 1); pop(esi);                               /* pop esi */
            ii(0x1012_02c9, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_02ca, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_02cb, 1); ret();                                  /* ret */
        }
    }
}
