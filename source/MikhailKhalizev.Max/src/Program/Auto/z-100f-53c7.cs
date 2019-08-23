using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_53c7-17bf61c9")]
        public void Method_100f_53c7()
        {
            ii(0x100f_53c7, 5); push(0x1c);                             /* push 0x1c */
            ii(0x100f_53cc, 5); call(Definitions.sys_check_available_stack_size, 0x7_0981); /* call 0x10165d52 */
            ii(0x100f_53d1, 1); push(ebx);                              /* push ebx */
            ii(0x100f_53d2, 1); push(ecx);                              /* push ecx */
            ii(0x100f_53d3, 1); push(edx);                              /* push edx */
            ii(0x100f_53d4, 1); push(esi);                              /* push esi */
            ii(0x100f_53d5, 1); push(edi);                              /* push edi */
            ii(0x100f_53d6, 1); push(ebp);                              /* push ebp */
            ii(0x100f_53d7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_53d9, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x100f_53df, 7); cmp(memb[ds, 0x101c_38a2], 0);          /* cmp byte [0x101c38a2], 0x0 */
            ii(0x100f_53e6, 2); if(jz(0x100f_53ed, 0x5)) goto l_0x100f_53ed; /* jz 0x100f53ed */
            ii(0x100f_53e8, 5); call(0x100f_f5c1, 0xa1d4);              /* call 0x100ff5c1 */
        l_0x100f_53ed:
            ii(0x100f_53ed, 7); mov(memb[ds, 0x101c_38a2], 0);          /* mov byte [0x101c38a2], 0x0 */
            ii(0x100f_53f4, 7); mov(memb[ds, 0x101c_38a3], 0);          /* mov byte [0x101c38a3], 0x0 */
            ii(0x100f_53fb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_53fd, 5); call(0x100f_448c, -0xf76);              /* call 0x100f448c */
            ii(0x100f_5402, 5); call(0x100f_40a6, -0x1361);             /* call 0x100f40a6 */
            ii(0x100f_5407, 5); call(0x1011_606c, 0x2_0c60);            /* call 0x1011606c */
            ii(0x100f_540c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_540d, 1); pop(edi);                               /* pop edi */
            ii(0x100f_540e, 1); pop(esi);                               /* pop esi */
            ii(0x100f_540f, 1); pop(edx);                               /* pop edx */
            ii(0x100f_5410, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_5411, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_5412, 1); ret();                                  /* ret */
        }
    }
}
