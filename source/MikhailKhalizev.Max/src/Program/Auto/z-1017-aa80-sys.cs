using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_aa80-cae8fbf8")]
        public void /* sys */ Method_1017_aa80()
        {
            ii(0x1017_aa80, 1); push(ebp);                              /* push ebp */
            ii(0x1017_aa81, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_aa83, 1); push(ebx);                              /* push ebx */
            ii(0x1017_aa84, 1); push(ecx);                              /* push ecx */
            ii(0x1017_aa85, 7); cmp(memd[ds, 0x1020_9c94], 0);          /* cmp dword [0x10209c94], 0x0 */
            ii(0x1017_aa8c, 2); if(jnz(0x1017_aa9e, 0x10)) goto l_0x1017_aa9e; /* jnz 0x1017aa9e */
            ii(0x1017_aa8e, 1); push(edx);                              /* push edx */
            ii(0x1017_aa8f, 1); push(eax);                              /* push eax */
            ii(0x1017_aa90, 5); push(0x1020_9dd5);                      /* push 0x10209dd5 */
            ii(0x1017_aa95, 6); call_abs(memd[ds, 0x101b_e450]);        /* call dword [0x101be450] */ /* Вызов '0x1019_4101'. */
            ii(0x1017_aa9b, 3); add(esp, 0xc);                          /* add esp, 0xc */
        l_0x1017_aa9e:
            ii(0x1017_aa9e, 3); lea(esp, memd[ss, ebp - 0x8]);          /* lea esp, [ebp-0x8] */
            ii(0x1017_aaa1, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_aaa2, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_aaa3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_aaa4, 1); ret();                                  /* ret */
        }
    }
}
