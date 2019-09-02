using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_1f8e-e6f94e13")]
        public void /* sys */ Method_1017_1f8e()
        {
            ii(0x1017_1f8e, 1); push(ebx);                              /* push ebx */
            ii(0x1017_1f8f, 1); push(ecx);                              /* push ecx */
            ii(0x1017_1f90, 1); push(edx);                              /* push edx */
            ii(0x1017_1f91, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_1f93, 5); call(/* sys */ 0x1017_1fbd, 0x25);      /* call 0x10171fbd */
            ii(0x1017_1f98, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_1f9a, 2); if(jnz(0x1017_1fa5, 9)) goto l_0x1017_1fa5; /* jnz 0x10171fa5 */
            ii(0x1017_1f9c, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1017_1fa1, 1); pop(edx);                               /* pop edx */
            ii(0x1017_1fa2, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_1fa3, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_1fa4, 1); ret(); return;                          /* ret */
        l_0x1017_1fa5:
            ii(0x1017_1fa5, 3); mov(ebx, memd[ds, edx + 4]);            /* mov ebx, [edx+0x4] */
            ii(0x1017_1fa8, 2); mov(ecx, memd[ds, edx]);                /* mov ecx, [edx] */
            ii(0x1017_1faa, 1); dec(ebx);                               /* dec ebx */
            ii(0x1017_1fab, 1); inc(ecx);                               /* inc ecx */
            ii(0x1017_1fac, 3); mov(memd[ds, edx + 4], ebx);            /* mov [edx+0x4], ebx */
            ii(0x1017_1faf, 2); mov(memd[ds, edx], ecx);                /* mov [edx], ecx */
            ii(0x1017_1fb1, 3); mov(al, memb[ds, ecx - 1]);             /* mov al, [ecx-0x1] */
            ii(0x1017_1fb4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_1fb9, 1); pop(edx);                               /* pop edx */
            ii(0x1017_1fba, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_1fbb, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_1fbc, 1); ret();                                  /* ret */
        }
    }
}
