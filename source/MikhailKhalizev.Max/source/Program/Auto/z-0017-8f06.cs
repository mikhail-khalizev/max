using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_8f06-2d507263")]
        public void Method_0017_8f06()
        {
            ii(0x17_8f06, 1);  push(bp);                               /* push bp */
            ii(0x17_8f07, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x17_8f09, 1);  pushfw();                               /* pushfw */
            ii(0x17_8f0a, 1);  cli();                                  /* cli */
            ii(0x17_8f0b, 1);  push(es);                               /* push es */
            ii(0x17_8f0c, 2);  push(edi);                              /* push edi */
            ii(0x17_8f0e, 2);  push(ecx);                              /* push ecx */
            ii(0x17_8f10, 2);  push(eax);                              /* push eax */
            ii(0x17_8f12, 4);  mov(es, memw[ds, 0xaa]);                /* mov es, [0xaa] */
            ii(0x17_8f16, 5);  mov(ecx, memd[ds, 0x1f50]);             /* mov ecx, [0x1f50] */
            ii(0x17_8f1b, 5);  mov(edi, memd[ds, 0x4fb4]);             /* mov edi, [0x4fb4] */
            ii(0x17_8f20, 4);  mov(eax, memd[ss, bp + 4]);             /* mov eax, [bp+0x4] */
            ii(0x17_8f24, 4);  repne_a32(() => scasd_a32());           /* a32 repne scasd */
            ii(0x17_8f28, 4);  if(jz(0x17_8f34, 8)) goto l_0x17_8f34;  /* jz 0x8f34 */
            ii(0x17_8f2c, 6);  mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x17_8f32, 2);  if(jcxz(0x17_8f3d, 9)) goto l_0x17_8f3d;/* jcxz 0x8f3d */
        l_0x17_8f34:
            ii(0x17_8f34, 4);  mov(eax, memd[ds, 0x1f50]);             /* mov eax, [0x1f50] */
            ii(0x17_8f38, 3);  sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x17_8f3b, 2);  dec(eax);                               /* dec eax */
        l_0x17_8f3d:
            ii(0x17_8f3d, 2);  mov(cx, ax);                            /* mov cx, ax */
            ii(0x17_8f3f, 4);  rol(eax, 0x10);                         /* rol eax, 0x10 */
            ii(0x17_8f43, 2);  mov(dx, ax);                            /* mov dx, ax */
            ii(0x17_8f45, 2);  pop(eax);                               /* pop eax */
            ii(0x17_8f47, 2);  mov(ax, cx);                            /* mov ax, cx */
            ii(0x17_8f49, 2);  pop(ecx);                               /* pop ecx */
            ii(0x17_8f4b, 2);  pop(edi);                               /* pop edi */
            ii(0x17_8f4d, 1);  pop(es);                                /* pop es */
            ii(0x17_8f4e, 1);  popfw();                                /* popfw */
            ii(0x17_8f4f, 1);  pop(bp);                                /* pop bp */
            ii(0x17_8f50, 1);  ret();                                  /* ret */
        }
    }
}
