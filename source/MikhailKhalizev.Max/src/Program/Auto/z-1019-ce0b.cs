using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_ce0b-ab686761")]
        public void Method_1019_ce0b()
        {
            ii(0x1019_ce0b, 5); call(0x1019_cec0, 0xb0);                /* call 0x1019cec0 */
            ii(0x1019_ce10, 2); add(memb[ds, eax], al);                 /* add [eax], al */
            ii(0x1019_ce12, 2); add(memb[ds, eax], al);                 /* add [eax], al */
            ii(0x1019_ce14, 2); add(memb[ds, eax], al);                 /* add [eax], al */
            ii(0x1019_ce16, 2); add(memb[ds, eax], al);                 /* add [eax], al */
            ii(0x1019_ce18, 2); add(memb[ds, eax], al);                 /* add [eax], al */
            ii(0x1019_ce1a, 2); add(memb[ds, eax], al);                 /* add [eax], al */
            ii(0x1019_ce1c, 2); add(memd[ds, eax], eax);                /* add [eax], eax */
            ii(0x1019_ce1e, 2); add(memb[ds, eax], al);                 /* add [eax], al */
            ii(0x1019_ce20, 2); add(memb[ds, eax], al);                 /* add [eax], al */
            ii(0x1019_ce22, 2); add(memb[ds, eax], al);                 /* add [eax], al */
            ii(0x1019_ce24, 2); or(al, memb[ds, eax]);                  /* or al, [eax] */
            ii(0x1019_ce26, 2); add(memb[ds, eax], al);                 /* add [eax], al */
            ii(0x1019_ce28, 2); add(memb[ds, eax], al);                 /* add [eax], al */
            ii(0x1019_ce2a, 2); add(memb[ds, eax], al);                 /* add [eax], al */
            ii(0x1019_ce2c, 3); add(memb[fs, eax], al);                 /* add [fs:eax], al */
            ii(0x1019_ce2f, 2); add(memb[ds, eax], al);                 /* add [eax], al */
            ii(0x1019_ce31, 2); add(memb[ds, eax], al);                 /* add [eax], al */
            ii(0x1019_ce33, 2); add(al, ch);                            /* add al, ch */
            ii(0x1019_ce35, 2); add(eax, memd[ds, eax]);                /* add eax, [eax] */
            ii(0x1019_ce37, 2); add(memb[ds, eax], al);                 /* add [eax], al */
            ii(0x1019_ce39, 2); add(memb[ds, eax], al);                 /* add [eax], al */
            ii(0x1019_ce3b, 2); add(memb[ds, eax], dl);                 /* add [eax], dl */
            ii(0x1019_ce3d, 1); daa();                                  /* daa */
            ii(0x1019_ce3e, 2); add(memb[ds, eax], al);                 /* add [eax], al */
            ii(0x1019_ce40, 2); add(memb[ds, eax], al);                 /* add [eax], al */
            ii(0x1019_ce42, 2); add(memb[ds, eax], al);                 /* add [eax], al */
            ii(0x1019_ce44, 5); mov(al, memb[ds, 0x186]);               /* mov al, [0x186] */
            ii(0x1019_ce49, 2); add(memb[ds, eax], al);                 /* add [eax], al */
            ii(0x1019_ce4b, 3); add(memb[ds, eax + 66], al);            /* add [eax+0x42], al */
            ii(0x1019_ce4e, 3); sldt(memw[ds, eax]);                    /* sldt word [eax] */
            ii(0x1019_ce51, 2); add(memb[ds, eax], al);                 /* add [eax], al */
        }
    }
}
