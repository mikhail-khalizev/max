using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_ac92-4a0725bb")]
        public void /* sys */ Method_1019_ac92()
        {
            ii(0x1019_ac92, 1); push(ecx);                              /* push ecx */
            ii(0x1019_ac93, 1); push(esi);                              /* push esi */
            ii(0x1019_ac94, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1019_ac96, 3); mov(esi, memd[ds, eax + 0x10]);         /* mov esi, [eax+0x10] */
            ii(0x1019_ac99, 3); cmp(esi, memd[ds, edx + 0x10]);         /* cmp esi, [edx+0x10] */
            ii(0x1019_ac9c, 2); if(jle(0x1019_aca6, 8)) goto l_0x1019_aca6; /* jle 0x1019aca6 */
        l_0x1019_ac9e:
            ii(0x1019_ac9e, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1019_aca3, 1); pop(esi);                               /* pop esi */
            ii(0x1019_aca4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_aca5, 1); ret(); return;                          /* ret */
        l_0x1019_aca6:
            ii(0x1019_aca6, 3); cmp(esi, memd[ds, ecx + 0x10]);         /* cmp esi, [ecx+0x10] */
            ii(0x1019_aca9, 2); if(jl(0x1019_acc1, 0x16)) goto l_0x1019_acc1; /* jl 0x1019acc1 */
            ii(0x1019_acab, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1019_acad, 5); call(/* sys */ 0x1019_abad, -0x105);    /* call 0x1019abad */
            ii(0x1019_acb2, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1019_acb4, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1019_acb6, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1019_acb8, 5); call(/* sys */ 0x1019_abad, -0x110);    /* call 0x1019abad */
            ii(0x1019_acbd, 2); cmp(esi, eax);                          /* cmp esi, eax */
            ii(0x1019_acbf, 2); if(jg(0x1019_ac9e, -0x23)) goto l_0x1019_ac9e; /* jg 0x1019ac9e */
        l_0x1019_acc1:
            ii(0x1019_acc1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_acc3, 1); pop(esi);                               /* pop esi */
            ii(0x1019_acc4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_acc5, 1); ret();                                  /* ret */
        }
    }
}
