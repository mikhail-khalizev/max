using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_d4ca-cc3f5036")]
        public void /* sys */ Method_1017_d4ca()
        {
            ii(0x1017_d4ca, 1);  push(esi);                            /* push esi */
            ii(0x1017_d4cb, 1);  push(edi);                            /* push edi */
            ii(0x1017_d4cc, 2);  mov(edi, eax);                        /* mov edi, eax */
            ii(0x1017_d4ce, 4);  mov(eax, memd[ss, esp + 12]);         /* mov eax, [esp+0xc] */
            ii(0x1017_d4d2, 2);  mov(esi, ebx);                        /* mov esi, ebx */
            ii(0x1017_d4d4, 1);  pushd(ds);                            /* push ds */
            ii(0x1017_d4d5, 1);  pushd(es);                            /* push es */
            ii(0x1017_d4d6, 1);  push(edi);                            /* push edi */
            ii(0x1017_d4d7, 1);  xchg(ecx, eax);                       /* xchg ecx, eax */
            ii(0x1017_d4d8, 2);  mov(ds, eax);                         /* mov ds, eax */
            ii(0x1017_d4da, 2);  mov(es, edx);                         /* mov es, edx */
            ii(0x1017_d4dc, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1017_d4de, 3);  shr(ecx, 2);                          /* shr ecx, 0x2 */
            ii(0x1017_d4e1, 2);  repne(() => movsd());                 /* repne movsd */
            ii(0x1017_d4e3, 2);  mov(cl, al);                          /* mov cl, al */
            ii(0x1017_d4e5, 3);  and(cl, 3);                           /* and cl, 0x3 */
            ii(0x1017_d4e8, 2);  repne(() => movsb());                 /* repne movsb */
            ii(0x1017_d4ea, 1);  pop(eax);                             /* pop eax */
            ii(0x1017_d4eb, 1);  popd(es);                             /* pop es */
            ii(0x1017_d4ec, 1);  popd(ds);                             /* pop ds */
            ii(0x1017_d4ed, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_d4ee, 1);  pop(esi);                             /* pop esi */
            ii(0x1017_d4ef, 3);  ret(4);                               /* ret 0x4 */
        }
    }
}
