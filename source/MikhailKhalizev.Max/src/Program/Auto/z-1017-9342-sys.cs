using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9342-d8ee177b")]
        public void /* sys */ Method_1017_9342()
        {
            ii(0x1017_9342, 1); push(ebx);                              /* push ebx */
            ii(0x1017_9343, 1); push(ecx);                              /* push ecx */
            ii(0x1017_9344, 1); push(edx);                              /* push edx */
            ii(0x1017_9345, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1017_9347, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_9349:
            ii(0x1017_9349, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1017_934b, 2); test(al, al);                           /* test al, al */
            ii(0x1017_934d, 2); if(jz(0x1017_9361, 0x12)) goto l_0x1017_9361; /* jz 0x10179361 */
            ii(0x1017_934f, 2); sub(al, 0x61);                          /* sub al, 0x61 */
            ii(0x1017_9351, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_9353, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1017_9355, 3); cmp(ebx, 0x19);                         /* cmp ebx, 0x19 */
            ii(0x1017_9358, 2); if(jg(0x1017_935e, 4)) goto l_0x1017_935e; /* jg 0x1017935e */
            ii(0x1017_935a, 2); add(al, 0x41);                          /* add al, 0x41 */
            ii(0x1017_935c, 2); mov(memb[ds, edx], al);                 /* mov [edx], al */
        l_0x1017_935e:
            ii(0x1017_935e, 1); inc(edx);                               /* inc edx */
            ii(0x1017_935f, 2); jmp(0x1017_9349, -0x18); goto l_0x1017_9349; /* jmp 0x10179349 */
        l_0x1017_9361:
            ii(0x1017_9361, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_9363, 1); pop(edx);                               /* pop edx */
            ii(0x1017_9364, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_9365, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_9366, 1); ret();                                  /* ret */
        }
    }
}
