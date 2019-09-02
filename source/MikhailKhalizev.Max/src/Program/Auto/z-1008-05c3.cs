using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_05c3-99fbb66a")]
        public void Method_1008_05c3()
        {
            ii(0x1008_05c3, 5); push(0x20);                             /* push 0x20 */
            ii(0x1008_05c8, 5); call(Definitions.sys_check_available_stack_size, 0xe_5785); /* call 0x10165d52 */
            ii(0x1008_05cd, 1); push(ebx);                              /* push ebx */
            ii(0x1008_05ce, 1); push(ecx);                              /* push ecx */
            ii(0x1008_05cf, 1); push(edx);                              /* push edx */
            ii(0x1008_05d0, 1); push(esi);                              /* push esi */
            ii(0x1008_05d1, 1); push(edi);                              /* push edi */
            ii(0x1008_05d2, 1); push(ebp);                              /* push ebp */
            ii(0x1008_05d3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_05d5, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1008_05db, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_05de, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_05e1, 4); cmp(memb[ds, eax + 19], 0);             /* cmp byte [eax+0x13], 0x0 */
            ii(0x1008_05e5, 2); if(jz(0x1008_05ef, 8)) goto l_0x1008_05ef; /* jz 0x100805ef */
            ii(0x1008_05e7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_05ea, 5); call(0x1007_f659, -0xf96);              /* call 0x1007f659 */
        l_0x1008_05ef:
            ii(0x1008_05ef, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_05f1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_05f2, 1); pop(edi);                               /* pop edi */
            ii(0x1008_05f3, 1); pop(esi);                               /* pop esi */
            ii(0x1008_05f4, 1); pop(edx);                               /* pop edx */
            ii(0x1008_05f5, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_05f6, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_05f7, 1); ret();                                  /* ret */
        }
    }
}
