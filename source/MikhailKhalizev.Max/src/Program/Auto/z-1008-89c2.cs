using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_89c2-3ff95fd3")]
        public void Method_1008_89c2()
        {
            ii(0x1008_89c2, 5); push(0x20);                             /* push 0x20 */
            ii(0x1008_89c7, 5); call(Definitions.sys_check_available_stack_size, 0xd_d386); /* call 0x10165d52 */
            ii(0x1008_89cc, 1); push(ebx);                              /* push ebx */
            ii(0x1008_89cd, 1); push(ecx);                              /* push ecx */
            ii(0x1008_89ce, 1); push(esi);                              /* push esi */
            ii(0x1008_89cf, 1); push(edi);                              /* push edi */
            ii(0x1008_89d0, 1); push(ebp);                              /* push ebp */
            ii(0x1008_89d1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_89d3, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_89d9, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_89dc, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_89df, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_89e2, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1008_89e5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_89e8, 5); call(0x1007_6d98, -0x1_1c55);           /* call 0x10076d98 */
            ii(0x1008_89ed, 2); test(al, al);                           /* test al, al */
            ii(0x1008_89ef, 2); if(jz(0x1008_89fe, 0xd)) goto l_0x1008_89fe; /* jz 0x100889fe */
            ii(0x1008_89f1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_89f3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_89f6, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_89f9, 5); call(0x1007_6630, -0x1_23ce);           /* call 0x10076630 */
        l_0x1008_89fe:
            ii(0x1008_89fe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8a00, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_8a01, 1); pop(edi);                               /* pop edi */
            ii(0x1008_8a02, 1); pop(esi);                               /* pop esi */
            ii(0x1008_8a03, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_8a04, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_8a05, 1); ret();                                  /* ret */
        }
    }
}
