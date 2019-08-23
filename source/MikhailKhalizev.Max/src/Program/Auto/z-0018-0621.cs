using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_0621-83c2c79f")]
        public void Method_0018_0621()
        {
            ii(0x18_0621, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x18_0625, 1); pushw(es);                                /* push es */
            ii(0x18_0626, 1); pushw(ds);                                /* push ds */
            ii(0x18_0627, 1); pushw(si);                                /* push si */
            ii(0x18_0628, 1); pushw(di);                                /* push di */
            ii(0x18_0629, 1); pushw(cx);                                /* push cx */
            ii(0x18_062a, 3); lds(si, ss, bp + 0xa);                    /* lds si, [bp+0xa] */
            ii(0x18_062d, 3); les(di, ss, bp + 0x6);                    /* les di, [bp+0x6] */
            ii(0x18_0630, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x18_0632, 3); mov(cx, memw_a16[ss, bp + 0xe]);          /* mov cx, [bp+0xe] */
            ii(0x18_0635, 2); if(jcxzw(0x18_0668, 0x31)) goto l_0x18_0668; /* jcxz 0x668 */
            ii(0x18_0637, 2); mov(ax, es);                              /* mov ax, es */
            ii(0x18_0639, 3); cmp(ax, memw_a16[ss, bp + 0xc]);          /* cmp ax, [bp+0xc] */
            ii(0x18_063c, 2); if(jnzw(0x18_0658, 0x1a)) goto l_0x18_0658; /* jnz 0x658 */
            ii(0x18_063e, 2); cmp(di, si);                              /* cmp di, si */
            ii(0x18_0640, 2); if(jbew(0x18_0658, 0x16)) goto l_0x18_0658; /* jbe 0x658 */
            ii(0x18_0642, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x18_0644, 2); add(ax, cx);                              /* add ax, cx */
            ii(0x18_0646, 2); cmp(di, ax);                              /* cmp di, ax */
            ii(0x18_0648, 2); if(jaew(0x18_0658, 0xe)) goto l_0x18_0658; /* jae 0x658 */
            ii(0x18_064a, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x18_064c, 2); add(si, cx);                              /* add si, cx */
            ii(0x18_064e, 2); add(di, cx);                              /* add di, cx */
            ii(0x18_0650, 1); dec(si);                                  /* dec si */
            ii(0x18_0651, 1); dec(di);                                  /* dec di */
            ii(0x18_0652, 1); std();                                    /* std */
            ii(0x18_0653, 2); rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x18_0655, 1); cld();                                    /* cld */
            ii(0x18_0656, 2); jmpw(0x18_0668, 0x10); goto l_0x18_0668;  /* jmp 0x668 */
        l_0x18_0658:
            ii(0x18_0658, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x18_065a, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x18_065c, 2); if(jzw(0x18_0660, 0x2)) goto l_0x18_0660; /* jz 0x660 */
            ii(0x18_065e, 1); movsb_a16();                              /* movsb */
            ii(0x18_065f, 1); dec(cx);                                  /* dec cx */
        l_0x18_0660:
            ii(0x18_0660, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x18_0662, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x18_0664, 2); adc(cx, cx);                              /* adc cx, cx */
            ii(0x18_0666, 2); rep_a16(() => movsb_a16());               /* rep movsb */
        l_0x18_0668:
            ii(0x18_0668, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x18_066a, 1); popw(cx);                                 /* pop cx */
            ii(0x18_066b, 1); popw(di);                                 /* pop di */
            ii(0x18_066c, 1); popw(si);                                 /* pop si */
            ii(0x18_066d, 1); popw(ds);                                 /* pop ds */
            ii(0x18_066e, 1); popw(es);                                 /* pop es */
            ii(0x18_066f, 1); leavew();                                 /* leave */
            ii(0x18_0670, 1); retfw();                                  /* retf */
        }
    }
}
