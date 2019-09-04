using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_8cfc-1426b4ed")]
        public void my_dtor_d1()
        {
            ii(0x1008_8cfc, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_8d01, 5); call(Definitions.sys_check_available_stack_size, 0xd_d04c); /* call 0x10165d52 */
            ii(0x1008_8d06, 1); push(ebx);                              /* push ebx */
            ii(0x1008_8d07, 1); push(ecx);                              /* push ecx */
            ii(0x1008_8d08, 1); push(esi);                              /* push esi */
            ii(0x1008_8d09, 1); push(edi);                              /* push edi */
            ii(0x1008_8d0a, 1); push(ebp);                              /* push ebp */
            ii(0x1008_8d0b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8d0d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8d13, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_8d16, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_8d19, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_8d1b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_8d1e, 3); add(eax, 7);                            /* add eax, 0x7 */
            ii(0x1008_8d21, 5); call(0x1007_5f2c, -0x1_2dfa);           /* call 0x10075f2c */
            ii(0x1008_8d26, 3); sub(eax, 7);                            /* sub eax, 0x7 */
            ii(0x1008_8d29, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_8d2c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_8d2e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_8d31, 5); call(0x1008_bc9f, 0x2f69);              /* call 0x1008bc9f */
            ii(0x1008_8d36, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_8d39, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_8d3c, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_8d3f, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_8d42, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8d44, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_8d45, 1); pop(edi);                               /* pop edi */
            ii(0x1008_8d46, 1); pop(esi);                               /* pop esi */
            ii(0x1008_8d47, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_8d48, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_8d49, 1); ret();                                  /* ret */
        }
    }
}
