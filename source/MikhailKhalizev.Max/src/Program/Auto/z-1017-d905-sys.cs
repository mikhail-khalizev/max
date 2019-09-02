using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_d905-3d5b2aef")]
        public void /* sys */ Method_1017_d905()
        {
            ii(0x1017_d905, 1); push(ebx);                              /* push ebx */
            ii(0x1017_d906, 1); push(ecx);                              /* push ecx */
            ii(0x1017_d907, 1); push(edx);                              /* push edx */
            ii(0x1017_d908, 1); push(esi);                              /* push esi */
            ii(0x1017_d909, 1); push(edi);                              /* push edi */
            ii(0x1017_d90a, 1); push(ebp);                              /* push ebp */
            ii(0x1017_d90b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_d90d, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1017_d913, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1017_d916, 7); cmp(memb[ds, 0x101c_1a54], 0);          /* cmp byte [0x101c1a54], 0x0 */
            ii(0x1017_d91d, 2); if(jz(0x1017_d92e, 0xf)) goto l_0x1017_d92e; /* jz 0x1017d92e */
            ii(0x1017_d91f, 5); call(/* sys */ 0x1019_4b45, 0x1_7221);  /* call 0x10194b45 */
            ii(0x1017_d924, 5); call(/* sys */ 0x1019_4b9d, 0x1_7274);  /* call 0x10194b9d */
            ii(0x1017_d929, 5); call(/* sys */ 0x1019_4b71, 0x1_7243);  /* call 0x10194b71 */
        l_0x1017_d92e:
            ii(0x1017_d92e, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
            ii(0x1017_d935, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1017_d938, 1); leave();                                /* leave */
            ii(0x1017_d939, 1); pop(edi);                               /* pop edi */
            ii(0x1017_d93a, 1); pop(esi);                               /* pop esi */
            ii(0x1017_d93b, 1); pop(edx);                               /* pop edx */
            ii(0x1017_d93c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_d93d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_d93e, 1); ret();                                  /* ret */
        }
    }
}
