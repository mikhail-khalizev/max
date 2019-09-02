using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_ceac-8104bb73")]
        public void Method_0017_ceac()
        {
            ii(0x17_ceac, 1); cli();                                    /* cli */
            ii(0x17_cead, 1); pop(ax);                                  /* pop ax */
            ii(0x17_ceae, 2); push(ebp);                                /* push ebp */
            ii(0x17_ceb0, 2); mov(cx, ds);                              /* mov cx, ds */
            ii(0x17_ceb2, 3); mov(si, 0x50c4);                          /* mov si, 0x50c4 */
            ii(0x17_ceb5, 3); mov(memw[ds, si + 0x79], ss);             /* mov [si+0x79], ss */
            ii(0x17_ceb8, 1); push(ss);                                 /* push ss */
            ii(0x17_ceb9, 1); pop(es);                                  /* pop es */
            ii(0x17_ceba, 4); mov(memd[ds, si + 0x75], esp);            /* mov [si+0x75], esp */
            ii(0x17_cebe, 4); lss(sp, memw[ds, si + 0x7b]);             /* lss sp, [si+0x7b] */
            ii(0x17_cec2, 2); mov(ds, cx);                              /* mov ds, cx */
            ii(0x17_cec4, 6); push(memd_a32[es, ebp + 0x2c]);           /* push dword [es:ebp+0x2c] */
            ii(0x17_ceca, 6); push(memd_a32[es, ebp + 0x28]);           /* push dword [es:ebp+0x28] */
            ii(0x17_ced0, 6); push(memd_a32[es, ebp + 0x24]);           /* push dword [es:ebp+0x24] */
            ii(0x17_ced6, 6); push(memd_a32[es, ebp + 0x20]);           /* push dword [es:ebp+0x20] */
            ii(0x17_cedc, 6); push(memd_a32[es, ebp + 0x1c]);           /* push dword [es:ebp+0x1c] */
            ii(0x17_cee2, 6); push(memd_a32[es, ebp + 0x18]);           /* push dword [es:ebp+0x18] */
            ii(0x17_cee8, 6); push(memd_a32[es, ebp + 0x14]);           /* push dword [es:ebp+0x14] */
            ii(0x17_ceee, 6); push(memd_a32[es, ebp + 0x10]);           /* push dword [es:ebp+0x10] */
            ii(0x17_cef4, 6); push(memd_a32[es, ebp + 0xc]);            /* push dword [es:ebp+0xc] */
            ii(0x17_cefa, 6); push(memd_a32[es, ebp + 8]);              /* push dword [es:ebp+0x8] */
            ii(0x17_cf00, 6); push(memd_a32[es, ebp + 4]);              /* push dword [es:ebp+0x4] */
            ii(0x17_cf06, 5); push(memw_a32[es, ebp + 2]);              /* push word [es:ebp+0x2] */
            ii(0x17_cf0b, 5); push(memw_a32[es, ebp]);                  /* push word [es:ebp] */
            ii(0x17_cf10, 6); push(memd_a32[es, ebp - 4]);              /* push dword [es:ebp-0x4] */
            ii(0x17_cf16, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_cf18, 3); add(bp, 4);                               /* add bp, 0x4 */
            ii(0x17_cf1b, 4); movzx(esp, sp);                           /* movzx esp, sp */
            ii(0x17_cf1f, 4); movzx(ebp, bp);                           /* movzx ebp, bp */
            ii(0x17_cf23, 1); sti();                                    /* sti */
            ii(0x17_cf24, 2); jmp_abs(ax);                              /* jmp ax */
        }
    }
}
