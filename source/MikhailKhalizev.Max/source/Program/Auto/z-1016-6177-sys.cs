using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_6177-9b824866")]
        public void /* sys */ Method_1016_6177()
        {
            ii(0x1016_6177, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_6178, 1);  push(esi);                            /* push esi */
            ii(0x1016_6179, 1);  push(edi);                            /* push edi */
            ii(0x1016_617a, 2);  mov(ecx, ebx);                        /* mov ecx, ebx */
            ii(0x1016_617c, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1016_617e, 2);  if(jz(0x1016_61c0, 0x40)) goto l_0x1016_61c0;/* jz 0x101661c0 */
            ii(0x1016_6180, 2);  if(jae(0x1016_61aa, 0x28)) goto l_0x1016_61aa;/* jae 0x101661aa */
            ii(0x1016_6182, 3);  lea(edi, memd[ds, edx + ebx]);        /* lea edi, [edx+ebx] */
            ii(0x1016_6185, 2);  cmp(edi, eax);                        /* cmp edi, eax */
            ii(0x1016_6187, 2);  if(jbe(0x1016_61aa, 0x21)) goto l_0x1016_61aa;/* jbe 0x101661aa */
            ii(0x1016_6189, 3);  lea(esi, memd[ds, edi - 1]);          /* lea esi, [edi-0x1] */
            ii(0x1016_618c, 3);  lea(edi, memd[ds, eax + ebx]);        /* lea edi, [eax+ebx] */
            ii(0x1016_618f, 2);  mov(edx, ds);                         /* mov edx, ds */
            ii(0x1016_6191, 1);  dec(edi);                             /* dec edi */
            ii(0x1016_6192, 1);  pushd(es);                            /* push es */
            ii(0x1016_6193, 2);  mov(es, edx);                         /* mov es, edx */
            ii(0x1016_6195, 1);  std();                                /* std */
            ii(0x1016_6196, 1);  dec(esi);                             /* dec esi */
            ii(0x1016_6197, 1);  dec(edi);                             /* dec edi */
            ii(0x1016_6198, 2);  shr(ecx, 1);                          /* shr ecx, 1 */
            ii(0x1016_619a, 3);  rep(() => movsw());                   /* rep movsw */
            ii(0x1016_619d, 2);  adc(ecx, ecx);                        /* adc ecx, ecx */
            ii(0x1016_619f, 1);  inc(esi);                             /* inc esi */
            ii(0x1016_61a0, 1);  inc(edi);                             /* inc edi */
            ii(0x1016_61a1, 3);  rep(() => movsb());                   /* o16 rep movsb */
            ii(0x1016_61a4, 1);  popd(es);                             /* pop es */
            ii(0x1016_61a5, 1);  cld();                                /* cld */
            ii(0x1016_61a6, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_61a7, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_61a8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_61a9, 1);  ret(); return;                        /* ret */
        l_0x1016_61aa:
            ii(0x1016_61aa, 2);  mov(esi, edx);                        /* mov esi, edx */
            ii(0x1016_61ac, 2);  mov(edi, eax);                        /* mov edi, eax */
            ii(0x1016_61ae, 2);  mov(edx, ds);                         /* mov edx, ds */
            ii(0x1016_61b0, 1);  pushd(es);                            /* push es */
            ii(0x1016_61b1, 2);  mov(es, edx);                         /* mov es, edx */
            ii(0x1016_61b3, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_61b4, 3);  shr(ecx, 2);                          /* shr ecx, 0x2 */
            ii(0x1016_61b7, 2);  rep(() => movsd());                   /* rep movsd */
            ii(0x1016_61b9, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_61ba, 3);  and(ecx, 3);                          /* and ecx, 0x3 */
            ii(0x1016_61bd, 2);  rep(() => movsb());                   /* rep movsb */
            ii(0x1016_61bf, 1);  popd(es);                             /* pop es */
        l_0x1016_61c0:
            ii(0x1016_61c0, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_61c1, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_61c2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_61c3, 1);  ret();                                /* ret */
        }
    }
}
