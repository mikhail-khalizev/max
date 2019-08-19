using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_907b-903d75c0")]
        public void /* sys */ Method_1017_907b()
        {
            ii(0x1017_907b, 3); mov(ecx, memd_a32[ss, esp]);            /* mov ecx, [esp] */
            ii(0x1017_907e, 2); sub(ecx, esi);                          /* sub ecx, esi */
            ii(0x1017_9080, 2); cmp(ecx, ebp);                          /* cmp ecx, ebp */
            ii(0x1017_9082, 2); if(jbd_func(0x1017_90c3, 0x3f)) return; /* jb 0x101790c3 */
            ii(0x1017_9084, 2); mov(edi, esi);                          /* mov edi, esi */
            ii(0x1017_9086, 2); mov(al, memb_a32[ds, ebx]);             /* mov al, [ebx] */
            ii(0x1017_9088, 1); pushd(es);                              /* push es */
            ii(0x1017_9089, 2); if(jecxzd_func(0x1017_9096, 0xb)) return; /* jecxz 0x10179096 */
            ii(0x1017_908b, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_908d, 2); mov(es, edx);                           /* mov es, edx */
            ii(0x1017_908f, 2); repne_a32(() => scasb_a32());           /* repne scasb */
            ii(0x1017_9091, 2); if(jnzd_func(0x1017_9096, 0x3)) return; /* jnz 0x10179096 */
            ii(0x1017_9093, 1); dec(edi);                               /* dec edi */
        }
    }
}
