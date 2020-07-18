using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9061-9a4a2252")]
        public void /* sys */ Method_1017_9061()
        {
            ii(0x1017_9061, 2);  mov(edi, ecx);                        /* mov edi, ecx */
            ii(0x1017_9063, 1);  popd(es);                             /* pop es */
            ii(0x1017_9064, 3);  mov(memd[ss, esp], edi);              /* mov [esp], edi */
            ii(0x1017_9067, 2);  mov(edi, ebx);                        /* mov edi, ebx */
            ii(0x1017_9069, 1);  pushd(es);                            /* push es */
            ii(0x1017_906a, 2);  mov(eax, ds);                         /* mov eax, ds */
            ii(0x1017_906c, 2);  mov(es, eax);                         /* mov es, eax */
            ii(0x1017_906e, 2);  sub(ecx, ecx);                        /* sub ecx, ecx */
            ii(0x1017_9070, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1017_9071, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1017_9073, 2);  repne(() => scasb());                 /* repne scasb */
            ii(0x1017_9075, 2);  not(ecx);                             /* not ecx */
            ii(0x1017_9077, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1017_9078, 1);  popd(es);                             /* pop es */
            ii(0x1017_9079, 2);  mov(ebp, ecx);                        /* mov ebp, ecx */
        }
    }
}
