using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_1ee0-d3518728")]
        public void /* sys */ sys_strncpy()
        {
            ii(0x1017_1ee0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_1ee1, 1); pushd(esi);                             /* push esi */
            ii(0x1017_1ee2, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_1ee4, 2); jmpd(0x1017_1ef1, 0xb); goto l_0x1017_1ef1; /* jmp 0x10171ef1 */
        l_0x1017_1ee6:
            ii(0x1017_1ee6, 2); mov(cl, memb_a32[ds, edx]);             /* mov cl, [edx] */
            ii(0x1017_1ee8, 2); test(cl, cl);                           /* test cl, cl */
            ii(0x1017_1eea, 2); if(jzd(0x1017_1ef5, 0x9)) goto l_0x1017_1ef5; /* jz 0x10171ef5 */
            ii(0x1017_1eec, 1); inc(edx);                               /* inc edx */
            ii(0x1017_1eed, 1); dec(ebx);                               /* dec ebx */
            ii(0x1017_1eee, 2); mov(memb_a32[ds, eax], cl);             /* mov [eax], cl */
            ii(0x1017_1ef0, 1); inc(eax);                               /* inc eax */
        l_0x1017_1ef1:
            ii(0x1017_1ef1, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_1ef3, 2); if(jnzd(0x1017_1ee6, -0xf)) goto l_0x1017_1ee6; /* jnz 0x10171ee6 */
        l_0x1017_1ef5:
            ii(0x1017_1ef5, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_1ef7, 2); if(jzd(0x1017_1f00, 0x7)) goto l_0x1017_1f00; /* jz 0x10171f00 */
            ii(0x1017_1ef9, 1); dec(ebx);                               /* dec ebx */
            ii(0x1017_1efa, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
            ii(0x1017_1efd, 1); inc(eax);                               /* inc eax */
            ii(0x1017_1efe, 2); jmpd(0x1017_1ef5, -0xb); goto l_0x1017_1ef5; /* jmp 0x10171ef5 */
        l_0x1017_1f00:
            ii(0x1017_1f00, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_1f02, 1); popd(esi);                              /* pop esi */
            ii(0x1017_1f03, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_1f04, 1); retd();                                 /* ret */
        }
    }
}
