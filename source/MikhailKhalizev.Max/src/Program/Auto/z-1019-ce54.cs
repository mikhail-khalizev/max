using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_ce54-943ec404")]
        public void Method_1019_ce54()
        {
        l_0x1019_ce54:
            ii(0x1019_ce54, 7);  adc(memb[ds, esi + 152], 0);          /* adc byte [esi+0x98], 0x0 */
            ii(0x1019_ce5b, 2);  add(memb[ds, eax], al);               /* add [eax], al */
            ii(0x1019_ce5d, 2);  if(loope(0x1019_ce54, -0xb)) goto l_0x1019_ce54;/* loope 0x1019ce54 */
            ii(0x1019_ce5f, 5);  add(eax, 0);                          /* add eax, 0x0 */
            ii(0x1019_ce64, 2);  add(dl, cl);                          /* add dl, cl */
            ii(0x1019_ce66, 7);  call_far_abs(0, 0x23b);               /* call dword 0x0:0x0 */
            ii(0x1019_ce6d, 2);  inb(al, 0xb);                         /* in al, 0xb */
            ii(0x1019_ce6f, 1);  push(esp);                            /* push esp */
            ii(0x1019_ce70, 1);  popd(ss);                             /* pop ss */
            ii(0x1019_ce71, 2);  add(memb[ds, eax], al);               /* add [eax], al */
            ii(0x1019_ce73, 2);  add(memb[ds, eax], al);               /* add [eax], al */
            ii(0x1019_ce75, 5);  call(0x1102_16f0, 0xe8_4876);         /* call 0x110216f0 */
            ii(0x1019_ce7a, 2);  add(memb[ds, eax], al);               /* add [eax], al */
            ii(0x1019_ce7c, 2);  add(memb[ds, eax], dl);               /* add [eax], dl */
            ii(0x1019_ce7e, 1);  movsd();                              /* movsd */
            ii(0x1019_ce7f, 2);  aam(0x18);                            /* aam 0x18 */
            ii(0x1019_ce81, 2);  or(memd[ds, eax], eax);               /* or [eax], eax */
            ii(0x1019_ce83, 2);  add(memb[ds, eax], al);               /* add [eax], al */
            ii(0x1019_ce85, 5);  mov(al, memb[ds, 0x5af3_4e72]);       /* mov al, [0x5af34e72] */
            ii(0x1019_ce8a, 2);  add(memb[ds, eax], al);               /* add [eax], al */
            ii(0x1019_ce8c, 3);  add(memb[ds, eax + 122], al);         /* add [eax+0x7a], al */
            ii(0x1019_ce8f, 3);  adc(memb[ds, esi - 115], bh);         /* adc [esi-0x73], bh */
            ii(0x1019_ce92, 2);  add(eax, memd[ds, eax]);              /* add eax, [eax] */
            ii(0x1019_ce94, 6);  add(memb[ds, eax - 0x790d_5b3a], al); /* add [eax-0x790d5b3a], al */
            ii(0x1019_ce9a, 2);  and(eax, memd[ds, eax]);              /* and eax, [eax] */
            ii(0x1019_ce9c, 2);  add(memb[ds, eax], al);               /* add [eax], al */
            ii(0x1019_ce9e, 4);  shr(memd[ds, edi + 120], 0x45);       /* shr dword [edi+0x78], 0x45 */
            ii(0x1019_cea2, 2);  arpl(memw[ds, ecx], ax);              /* arpl [ecx], ax */
            ii(0x1019_cea4, 2);  add(memb[ds, eax], al);               /* add [eax], al */
            ii(0x1019_cea6, 3);  mov(bl, memb[ss, ebp - 77]);          /* mov bl, [ebp-0x4d] */
            ii(0x1019_cea9, 2);  mov(dh, 0xe0);                        /* mov dh, 0xe0 */
            ii(0x1019_ceab, 5);  or(eax, 0xa764_0000);                 /* or eax, 0xa7640000 */
            ii(0x1019_ceb0, 2);  add(al, 0x23);                        /* add al, 0x23 */
        }
    }
}
