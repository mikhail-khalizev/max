using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_0d0d-f6665a11")]
        public void Method_1013_0d0d()
        {
            ii(0x1013_0d0d, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_0d12, 5); call(Definitions.sys_check_available_stack_size, 0x3_503b); /* call 0x10165d52 */
            ii(0x1013_0d17, 1); push(ebx);                              /* push ebx */
            ii(0x1013_0d18, 1); push(ecx);                              /* push ecx */
            ii(0x1013_0d19, 1); push(esi);                              /* push esi */
            ii(0x1013_0d1a, 1); push(edi);                              /* push edi */
            ii(0x1013_0d1b, 1); push(ebp);                              /* push ebp */
            ii(0x1013_0d1c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_0d1e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_0d24, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_0d27, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_0d2a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_0d2d, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_0d30, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_0d33, 4); cmp(memb[ds, eax + 0x17], 0x1);         /* cmp byte [eax+0x17], 0x1 */
            ii(0x1013_0d37, 2); if(jz(0x1013_0d4d, 0x14)) goto l_0x1013_0d4d; /* jz 0x10130d4d */
            ii(0x1013_0d39, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_0d3c, 4); mov(memb[ds, eax + 0x17], 0x1);         /* mov byte [eax+0x17], 0x1 */
            ii(0x1013_0d40, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_0d45, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_0d48, 5); call(0x1013_0c16, -0x137);              /* call 0x10130c16 */
        l_0x1013_0d4d:
            ii(0x1013_0d4d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_0d4f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_0d50, 1); pop(edi);                               /* pop edi */
            ii(0x1013_0d51, 1); pop(esi);                               /* pop esi */
            ii(0x1013_0d52, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_0d53, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_0d54, 1); ret();                                  /* ret */
        }
    }
}
