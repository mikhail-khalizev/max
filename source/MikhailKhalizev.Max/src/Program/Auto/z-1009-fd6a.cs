using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_fd6a-5de109d3")]
        public void Method_1009_fd6a()
        {
            ii(0x1009_fd6a, 5); push(0x20);                             /* push 0x20 */
            ii(0x1009_fd6f, 5); call(Definitions.sys_check_available_stack_size, 0xc_5fde); /* call 0x10165d52 */
            ii(0x1009_fd74, 1); push(ebx);                              /* push ebx */
            ii(0x1009_fd75, 1); push(ecx);                              /* push ecx */
            ii(0x1009_fd76, 1); push(esi);                              /* push esi */
            ii(0x1009_fd77, 1); push(edi);                              /* push edi */
            ii(0x1009_fd78, 1); push(ebp);                              /* push ebp */
            ii(0x1009_fd79, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_fd7b, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1009_fd81, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_fd84, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1009_fd87, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_fd8a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_fd8d, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_fd90, 5); call(0x1007_6e00, -0x2_8f95);           /* call 0x10076e00 */
            ii(0x1009_fd95, 2); test(al, al);                           /* test al, al */
            ii(0x1009_fd97, 2); if(jz(0x1009_fdb3, 0x1a)) goto l_0x1009_fdb3; /* jz 0x1009fdb3 */
            ii(0x1009_fd99, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_fd9b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_fd9e, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_fda1, 5); call(0x1007_6630, -0x2_9776);           /* call 0x10076630 */
            ii(0x1009_fda6, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_fda9, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_fdae, 5); call(0x100a_5e27, 0x6074);              /* call 0x100a5e27 */
        l_0x1009_fdb3:
            ii(0x1009_fdb3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_fdb5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_fdb6, 1); pop(edi);                               /* pop edi */
            ii(0x1009_fdb7, 1); pop(esi);                               /* pop esi */
            ii(0x1009_fdb8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_fdb9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_fdba, 1); ret();                                  /* ret */
        }
    }
}
