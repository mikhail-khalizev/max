using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_dcc4-26e4c0e7")]
        public void /* sys */ sys_timer_3()
        {
            ii(0x1018_dcc4, 1);  push(ebx);                            /* push ebx */
            ii(0x1018_dcc5, 5);  mov(ecx, 0);                          /* mov ecx, 0x0 */
            ii(0x1018_dcca, 7);  cmp(memd[ds, 0x101b_e420], 0);        /* cmp dword [0x101be420], 0x0 */
            ii(0x1018_dcd1, 2);  if(js(0x1018_dcda, 7)) goto l_0x1018_dcda;/* js 0x1018dcda */
            ii(0x1018_dcd3, 2);  jmp(0x1018_dcfe, 0x29); goto l_0x1018_dcfe;/* jmp 0x1018dcfe */
        l_0x1018_dcd5:
            ii(0x1018_dcd5, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
        l_0x1018_dcda:
            ii(0x1018_dcda, 2);  mov(al, 0x80);                        /* mov al, 0x80 */
            ii(0x1018_dcdc, 1);  cli();                                /* cli */
            ii(0x1018_dcdd, 2);  outb(0x43, al);                       /* out 0x43, al */
            ii(0x1018_dcdf, 2);  inb(al, 0x42);                        /* in al, 0x42 */
            ii(0x1018_dce1, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1018_dce3, 2);  inb(al, 0x42);                        /* in al, 0x42 */
            ii(0x1018_dce5, 2);  mov(ah, al);                          /* mov ah, al */
            ii(0x1018_dce7, 2);  mov(al, bl);                          /* mov al, bl */
            ii(0x1018_dce9, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1018_dceb, 7);  mov(bx, memw[ds, 0x1020_9dd0]);       /* mov bx, [0x10209dd0] */
            ii(0x1018_dcf2, 3);  sub(bx, ax);                          /* sub bx, ax */
            ii(0x1018_dcf5, 6);  add(ebx, memd[ds, 0x101b_e420]);      /* add ebx, [0x101be420] */
            ii(0x1018_dcfb, 1);  sti();                                /* sti */
            ii(0x1018_dcfc, 2);  if(js(0x1018_dcd5, -0x29)) goto l_0x1018_dcd5;/* js 0x1018dcd5 */
        l_0x1018_dcfe:
            ii(0x1018_dcfe, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1018_dd00, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1018_dd01, 1);  ret();                                /* ret */
        }
    }
}
