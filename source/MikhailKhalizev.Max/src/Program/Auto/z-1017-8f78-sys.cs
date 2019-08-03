using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e6ead748-123b-4457-995d-212ea7d41bc5")]
        public void /* sys */ Method_1017_8f78()
        {
            ii(0x1017_8f78, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_8f79, 1); pushd(edx);                             /* push edx */
            ii(0x1017_8f7a, 3); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1017_8f7d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_8f7f, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1017_8f81, 5); calld(/* sys */ 0x1018_d7c5, 0x1483f);  /* call 0x1018d7c5 */
            ii(0x1017_8f86, 5); cmp(eax, 0x1f4);                        /* cmp eax, 0x1f4 */
            ii(0x1017_8f8b, 2); if(jld(0x1017_8f90, 0x3)) goto l_0x1017_8f90; /* jl 0x10178f90 */
            ii(0x1017_8f8d, 3); inc(memd_a32[ss, esp]);                 /* inc dword [esp] */
        l_0x1017_8f90:
            ii(0x1017_8f90, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1017_8f92, 5); calld(/* sys */ 0x1018_d888, 0x148f1);  /* call 0x1018d888 */
            ii(0x1017_8f97, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_8f99, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_8f9b, 2); if(jzd(0x1017_8f9f, 0x2)) goto l_0x1017_8f9f; /* jz 0x10178f9f */
            ii(0x1017_8f9d, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
        l_0x1017_8f9f:
            ii(0x1017_8f9f, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_8fa1, 3); add(esp, 0x24);                         /* add esp, 0x24 */
            ii(0x1017_8fa4, 1); popd(edx);                              /* pop edx */
            ii(0x1017_8fa5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_8fa6, 1); retd(); return;                         /* ret */
        }
    }
}
