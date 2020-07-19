using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_8f78-243c0a37")]
        public void /* sys */ Method_1017_8f78()
        {
            ii(0x1017_8f78, 1);  push(ebx);                            /* push ebx */
            ii(0x1017_8f79, 1);  push(edx);                            /* push edx */
            ii(0x1017_8f7a, 3);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x1017_8f7d, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1017_8f7f, 2);  mov(eax, esp);                        /* mov eax, esp */
            ii(0x1017_8f81, 5);  call(/* sys */ 0x1018_d7c5, 0x1_483f);/* call 0x1018d7c5 */
            ii(0x1017_8f86, 5);  cmp(eax, 0x1f4);                      /* cmp eax, 0x1f4 */
            ii(0x1017_8f8b, 2);  if(jl(0x1017_8f90, 3)) goto l_0x1017_8f90;/* jl 0x10178f90 */
            ii(0x1017_8f8d, 3);  inc(memd[ss, esp]);                   /* inc dword [esp] */
        l_0x1017_8f90:
            ii(0x1017_8f90, 2);  mov(eax, esp);                        /* mov eax, esp */
            ii(0x1017_8f92, 5);  call(/* sys */ 0x1018_d888, 0x1_48f1);/* call 0x1018d888 */
            ii(0x1017_8f97, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1017_8f99, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1017_8f9b, 2);  if(jz(0x1017_8f9f, 2)) goto l_0x1017_8f9f;/* jz 0x10178f9f */
            ii(0x1017_8f9d, 2);  mov(memd[ds, edx], eax);              /* mov [edx], eax */
        l_0x1017_8f9f:
            ii(0x1017_8f9f, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1017_8fa1, 3);  add(esp, 0x24);                       /* add esp, 0x24 */
            ii(0x1017_8fa4, 1);  pop(edx);                             /* pop edx */
            ii(0x1017_8fa5, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1017_8fa6, 1);  ret();                                /* ret */
        }
    }
}
