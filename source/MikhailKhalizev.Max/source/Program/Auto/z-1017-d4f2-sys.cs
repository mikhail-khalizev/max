using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_d4f2-7125fda8")]
        public void /* sys */ Method_1017_d4f2()
        {
            ii(0x1017_d4f2, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_d4f3, 1);  push(esi);                            /* push esi */
            ii(0x1017_d4f4, 1);  push(edi);                            /* push edi */
            ii(0x1017_d4f5, 1);  push(ebp);                            /* push ebp */
            ii(0x1017_d4f6, 2);  mov(ebp, eax);                        /* mov ebp, eax */
            ii(0x1017_d4f8, 2);  mov(esi, edx);                        /* mov esi, edx */
            ii(0x1017_d4fa, 5);  mov(ecx, 0xffff_ffff);                /* mov ecx, 0xffffffff */
            ii(0x1017_d4ff, 2);  mov(edi, ebp);                        /* mov edi, ebp */
            ii(0x1017_d501, 2);  xor(al, al);                          /* xor al, al */
            ii(0x1017_d503, 1);  pushd(es);                            /* push es */
            ii(0x1017_d504, 2);  if(jecxz_func(0x1017_d511, 0xb)) return;/* jecxz 0x1017d511 */
            ii(0x1017_d506, 2);  mov(edx, ds);                         /* mov edx, ds */
            ii(0x1017_d508, 2);  mov(es, edx);                         /* mov es, edx */
            ii(0x1017_d50a, 2);  repne(() => scasb());                 /* repne scasb */
            ii(0x1017_d50c, 2);  if(jnz_func(0x1017_d511, 3)) return;  /* jnz 0x1017d511 */
            ii(0x1017_d50e, 1);  dec(edi);                             /* dec edi */
        }
    }
}
