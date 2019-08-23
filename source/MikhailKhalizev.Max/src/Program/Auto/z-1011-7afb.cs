using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_7afb-8b8d762")]
        public void Method_1011_7afb()
        {
            ii(0x1011_7afb, 5); push(0x20);                             /* push 0x20 */
            ii(0x1011_7b00, 5); call(Definitions.sys_check_available_stack_size, 0x4_e24d); /* call 0x10165d52 */
            ii(0x1011_7b05, 1); push(ebx);                              /* push ebx */
            ii(0x1011_7b06, 1); push(ecx);                              /* push ecx */
            ii(0x1011_7b07, 1); push(edx);                              /* push edx */
            ii(0x1011_7b08, 1); push(esi);                              /* push esi */
            ii(0x1011_7b09, 1); push(edi);                              /* push edi */
            ii(0x1011_7b0a, 1); push(ebp);                              /* push ebp */
            ii(0x1011_7b0b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_7b0d, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_7b13, 7); mov(memd[ss, ebp - 0x4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x1011_7b1a, 2); jmp(0x1011_7b22, 0x6); goto l_0x1011_7b22; /* jmp 0x10117b22 */
        l_0x1011_7b1c:
            ii(0x1011_7b1c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_7b1f, 3); inc(memd[ss, ebp - 0x4]);               /* inc dword [ebp-0x4] */
        l_0x1011_7b22:
            ii(0x1011_7b22, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1011_7b26, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1011_7b29, 2); if(jge(0x1011_7b40, 0x15)) goto l_0x1011_7b40; /* jge 0x10117b40 */
            ii(0x1011_7b2b, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1011_7b2f, 3); imul(edx, eax, 0xa);                    /* imul edx, eax, 0xa */
            ii(0x1011_7b32, 5); mov(eax, 0x101c_52bc);                  /* mov eax, 0x101c52bc */
            ii(0x1011_7b37, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_7b39, 5); call(0x1013_a6f4, 0x2_2bb6);            /* call 0x1013a6f4 */
            ii(0x1011_7b3e, 2); jmp(0x1011_7b1c, -0x24); goto l_0x1011_7b1c; /* jmp 0x10117b1c */
        l_0x1011_7b40:
            ii(0x1011_7b40, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_7b42, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_7b43, 1); pop(edi);                               /* pop edi */
            ii(0x1011_7b44, 1); pop(esi);                               /* pop esi */
            ii(0x1011_7b45, 1); pop(edx);                               /* pop edx */
            ii(0x1011_7b46, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_7b47, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_7b48, 1); ret();                                  /* ret */
        }
    }
}
