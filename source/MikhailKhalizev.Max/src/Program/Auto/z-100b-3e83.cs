using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_3e83-19365a20")]
        public void Method_100b_3e83()
        {
            ii(0x100b_3e83, 5); push(0x20);                             /* push 0x20 */
            ii(0x100b_3e88, 5); call(Definitions.sys_check_available_stack_size, 0xb_1ec5); /* call 0x10165d52 */
            ii(0x100b_3e8d, 1); push(ecx);                              /* push ecx */
            ii(0x100b_3e8e, 1); push(esi);                              /* push esi */
            ii(0x100b_3e8f, 1); push(edi);                              /* push edi */
            ii(0x100b_3e90, 1); push(ebp);                              /* push ebp */
            ii(0x100b_3e91, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_3e93, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_3e99, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_3e9c, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100b_3e9f, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x100b_3ea2, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100b_3ea5, 3); add(edx, 0x1b);                         /* add edx, 0x1b */
            ii(0x100b_3ea8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_3eab, 5); call(0x1007_6d98, -0x3_d118);           /* call 0x10076d98 */
            ii(0x100b_3eb0, 2); test(al, al);                           /* test al, al */
            ii(0x100b_3eb2, 2); if(jz(0x100b_3ec9, 0x15)) goto l_0x100b_3ec9; /* jz 0x100b3ec9 */
            ii(0x100b_3eb4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_3eb6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_3eb9, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100b_3ebc, 5); call(0x1009_c8f8, -0x1_75c9);           /* call 0x1009c8f8 */
            ii(0x100b_3ec1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_3ec4, 5); call(0x100b_3ed0, 7);                   /* call 0x100b3ed0 */
        l_0x100b_3ec9:
            ii(0x100b_3ec9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_3ecb, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_3ecc, 1); pop(edi);                               /* pop edi */
            ii(0x100b_3ecd, 1); pop(esi);                               /* pop esi */
            ii(0x100b_3ece, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_3ecf, 1); ret();                                  /* ret */
        }
    }
}
