using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a7b8-bc6392ec")]
        public void Method_100c_a7b8()
        {
            ii(0x100c_a7b8, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_a7bd, 5); call(Definitions.sys_check_available_stack_size, 0x9_b590); /* call 0x10165d52 */
            ii(0x100c_a7c2, 1); push(ebx);                              /* push ebx */
            ii(0x100c_a7c3, 1); push(ecx);                              /* push ecx */
            ii(0x100c_a7c4, 1); push(esi);                              /* push esi */
            ii(0x100c_a7c5, 1); push(edi);                              /* push edi */
            ii(0x100c_a7c6, 1); push(ebp);                              /* push ebp */
            ii(0x100c_a7c7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a7c9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a7cf, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_a7d2, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_a7d5, 7); test(memd[ss, ebp - 0x4], 0x4);         /* test dword [ebp-0x4], 0x4 */
            ii(0x100c_a7dc, 2); if(jz(0x100c_a7f2, 0x14)) goto l_0x100c_a7f2; /* jz 0x100ca7f2 */
            ii(0x100c_a7de, 5); mov(edx, 0x101b_56ac);                  /* mov edx, 0x101b56ac */
            ii(0x100c_a7e3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a7e6, 5); call(Definitions.sys_call_dtor_arr, 0x9_b7cd); /* call 0x10165fb8 */
            ii(0x100c_a7eb, 5); call(Definitions.sys_delete_arr, 0x9_b7e8); /* call 0x10165fd8 */
            ii(0x100c_a7f0, 2); jmp(0x100c_a813, 0x21); goto l_0x100c_a813; /* jmp 0x100ca813 */
        l_0x100c_a7f2:
            ii(0x100c_a7f2, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100c_a7f7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a7fa, 5); call(0x100a_284c, -0x2_7fb3);           /* call 0x100a284c */
            ii(0x100c_a7ff, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_a802, 7); test(memd[ss, ebp - 0x4], 0x2);         /* test dword [ebp-0x4], 0x2 */
            ii(0x100c_a809, 2); if(jz(0x100c_a813, 0x8)) goto l_0x100c_a813; /* jz 0x100ca813 */
            ii(0x100c_a80b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a80e, 5); call(Definitions.sys_delete, 0x9_b751); /* call 0x10165f64 */
        l_0x100c_a813:
            ii(0x100c_a813, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a816, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_a819, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_a81c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a81e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_a81f, 1); pop(edi);                               /* pop edi */
            ii(0x100c_a820, 1); pop(esi);                               /* pop esi */
            ii(0x100c_a821, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_a822, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_a823, 1); ret();                                  /* ret */
        }
    }
}
