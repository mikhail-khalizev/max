using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_b92a-e70c40f6")]
        public void Method_100e_b92a()
        {
            ii(0x100e_b92a, 5); push(0x20);                             /* push 0x20 */
            ii(0x100e_b92f, 5); call(Definitions.sys_check_available_stack_size, 0x7_a41e); /* call 0x10165d52 */
            ii(0x100e_b934, 1); push(ebx);                              /* push ebx */
            ii(0x100e_b935, 1); push(ecx);                              /* push ecx */
            ii(0x100e_b936, 1); push(edx);                              /* push edx */
            ii(0x100e_b937, 1); push(esi);                              /* push esi */
            ii(0x100e_b938, 1); push(edi);                              /* push edi */
            ii(0x100e_b939, 1); push(ebp);                              /* push ebp */
            ii(0x100e_b93a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_b93c, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100e_b942, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_b945, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_b948, 4); cmp(memb[ds, eax + 50], 0);             /* cmp byte [eax+0x32], 0x0 */
            ii(0x100e_b94c, 2); if(jz(0x100e_b958, 0xa)) goto l_0x100e_b958; /* jz 0x100eb958 */
            ii(0x100e_b94e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_b951, 5); call(0x100e_b58f, -0x3c7);              /* call 0x100eb58f */
            ii(0x100e_b956, 2); jmp(0x100e_b974, 0x1c); goto l_0x100e_b974; /* jmp 0x100eb974 */
        l_0x100e_b958:
            ii(0x100e_b958, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_b95b, 3); mov(eax, memd[ds, eax + 42]);           /* mov eax, [eax+0x2a] */
            ii(0x100e_b95e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_b961, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_b963, 2); if(jz(0x100e_b974, 0xf)) goto l_0x100e_b974; /* jz 0x100eb974 */
            ii(0x100e_b965, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_b968, 4); dec(memw[ds, eax + 44]);                /* dec word [eax+0x2c] */
            ii(0x100e_b96c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_b96f, 5); call(0x100e_b84d, -0x127);              /* call 0x100eb84d */
        l_0x100e_b974:
            ii(0x100e_b974, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_b976, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_b977, 1); pop(edi);                               /* pop edi */
            ii(0x100e_b978, 1); pop(esi);                               /* pop esi */
            ii(0x100e_b979, 1); pop(edx);                               /* pop edx */
            ii(0x100e_b97a, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_b97b, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_b97c, 1); ret();                                  /* ret */
        }
    }
}
