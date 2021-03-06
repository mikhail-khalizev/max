using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_1ec7-4d85947c")]
        public void /* sys */ sys_strlen()
        {
            ii(0x1017_1ec7, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_1ec8, 1);  push(edi);                            /* push edi */
            ii(0x1017_1ec9, 2);  mov(edi, eax);                        /* mov edi, eax */
            ii(0x1017_1ecb, 1);  pushd(es);                            /* push es */
            ii(0x1017_1ecc, 2);  mov(eax, ds);                         /* mov eax, ds */
            ii(0x1017_1ece, 2);  mov(es, eax);                         /* mov es, eax */
            ii(0x1017_1ed0, 2);  sub(ecx, ecx);                        /* sub ecx, ecx */
            ii(0x1017_1ed2, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1017_1ed3, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1017_1ed5, 2);  repne(() => scasb());                 /* repne scasb */
            ii(0x1017_1ed7, 2);  not(ecx);                             /* not ecx */
            ii(0x1017_1ed9, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1017_1eda, 1);  popd(es);                             /* pop es */
            ii(0x1017_1edb, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1017_1edd, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_1ede, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1017_1edf, 1);  ret();                                /* ret */
        }
    }
}
