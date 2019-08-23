using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_e35d-59f8891f")]
        public void Method_1015_e35d()
        {
            ii(0x1015_e35d, 5); push(0x20);                             /* push 0x20 */
            ii(0x1015_e362, 5); call(Definitions.sys_check_available_stack_size, 0x79eb); /* call 0x10165d52 */
            ii(0x1015_e367, 1); push(ebx);                              /* push ebx */
            ii(0x1015_e368, 1); push(ecx);                              /* push ecx */
            ii(0x1015_e369, 1); push(edx);                              /* push edx */
            ii(0x1015_e36a, 1); push(esi);                              /* push esi */
            ii(0x1015_e36b, 1); push(edi);                              /* push edi */
            ii(0x1015_e36c, 1); push(ebp);                              /* push ebp */
            ii(0x1015_e36d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_e36f, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1015_e375, 7); mov(memb[ds, 0x101c_8170], 0);          /* mov byte [0x101c8170], 0x0 */
            ii(0x1015_e37c, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1015_e381, 5); call(0x1015_de31, -0x555);              /* call 0x1015de31 */
            ii(0x1015_e386, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x1015_e38b, 5); call(0x1015_de31, -0x55f);              /* call 0x1015de31 */
            ii(0x1015_e390, 7); mov(memd[ss, ebp - 0x4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x1015_e397, 2); jmp(0x1015_e39f, 0x6); goto l_0x1015_e39f; /* jmp 0x1015e39f */
        l_0x1015_e399:
            ii(0x1015_e399, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e39c, 3); inc(memd[ss, ebp - 0x4]);               /* inc dword [ebp-0x4] */
        l_0x1015_e39f:
            ii(0x1015_e39f, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1015_e3a3, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x1015_e3a6, 2); if(jge(0x1015_e3bd, 0x15)) goto l_0x1015_e3bd; /* jge 0x1015e3bd */
            ii(0x1015_e3a8, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1015_e3ac, 3); imul(edx, eax, 0xa);                    /* imul edx, eax, 0xa */
            ii(0x1015_e3af, 5); mov(eax, 0x101c_9480);                  /* mov eax, 0x101c9480 */
            ii(0x1015_e3b4, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_e3b6, 5); call(0x1013_a6f4, -0x2_3cc7);           /* call 0x1013a6f4 */
            ii(0x1015_e3bb, 2); jmp(0x1015_e399, -0x24); goto l_0x1015_e399; /* jmp 0x1015e399 */
        l_0x1015_e3bd:
            ii(0x1015_e3bd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_e3bf, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_e3c0, 1); pop(edi);                               /* pop edi */
            ii(0x1015_e3c1, 1); pop(esi);                               /* pop esi */
            ii(0x1015_e3c2, 1); pop(edx);                               /* pop edx */
            ii(0x1015_e3c3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_e3c4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_e3c5, 1); ret();                                  /* ret */
        }
    }
}
