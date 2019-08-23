using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_d396-ea30eb3")]
        public void Method_1007_d396()
        {
            ii(0x1007_d396, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_d39b, 5); call(Definitions.sys_check_available_stack_size, 0xe_89b2); /* call 0x10165d52 */
            ii(0x1007_d3a0, 1); push(ecx);                              /* push ecx */
            ii(0x1007_d3a1, 1); push(esi);                              /* push esi */
            ii(0x1007_d3a2, 1); push(edi);                              /* push edi */
            ii(0x1007_d3a3, 1); push(ebp);                              /* push ebp */
            ii(0x1007_d3a4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_d3a6, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_d3ac, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_d3af, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1007_d3b2, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1007_d3b5, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1007_d3b9, 5); call(0x100c_dec2, 0x5_0b04);            /* call 0x100cdec2 */
            ii(0x1007_d3be, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_d3c0, 2); if(jz(0x1007_d3df, 0x1d)) goto l_0x1007_d3df; /* jz 0x1007d3df */
            ii(0x1007_d3c2, 4); movsx(ebx, memw[ss, ebp - 0x4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_d3c6, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1007_d3ca, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_d3cd, 5); call(0x100b_8462, 0x3_b090);            /* call 0x100b8462 */
            ii(0x1007_d3d2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_d3d4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_d3d7, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1007_d3da, 5); call(0x1008_a41c, 0xd03d);              /* call 0x1008a41c */
        l_0x1007_d3df:
            ii(0x1007_d3df, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_d3e1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_d3e2, 1); pop(edi);                               /* pop edi */
            ii(0x1007_d3e3, 1); pop(esi);                               /* pop esi */
            ii(0x1007_d3e4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_d3e5, 1); ret();                                  /* ret */
        }
    }
}
