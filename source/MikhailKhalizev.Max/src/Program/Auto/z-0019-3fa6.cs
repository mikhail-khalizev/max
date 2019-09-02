using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_3fa6-b2fa0fa9")]
        public void Method_0019_3fa6()
        {
            ii(0x19_3fa6, 2); mov(dx, cx);                              /* mov dx, cx */
            ii(0x19_3fa8, 3); add(dx, 0x27);                            /* add dx, 0x27 */
            ii(0x19_3fab, 3); and(dl, 0xf0);                            /* and dl, 0xf0 */
            ii(0x19_3fae, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x19_3fb0, 2); neg(bx);                                  /* neg bx */
            ii(0x19_3fb2, 2); neg(bx);                                  /* neg bx */
            ii(0x19_3fb4, 1); cmc();                                    /* cmc */
            ii(0x19_3fb5, 2); rcr(bx, 1);                               /* rcr bx, 1 */
            ii(0x19_3fb7, 2); shr(bx, 1);                               /* shr bx, 1 */
            ii(0x19_3fb9, 2); shr(bx, 1);                               /* shr bx, 1 */
            ii(0x19_3fbb, 2); shr(bx, 1);                               /* shr bx, 1 */
        l_0x19_3fbd:
            ii(0x19_3fbd, 2); mov(ah, 0x48);                            /* mov ah, 0x48 */
            ii(0x19_3fbf, 2); @int(0x21);                               /* int 0x21 */
            ii(0x19_3fc1, 2); if(jb(0x19_3fe9, 0x26)) goto l_0x19_3fe9; /* jb 0x3fe9 */
            ii(0x19_3fc3, 4); cmp(ax, memw[ds, 0x3bae]);                /* cmp ax, [0x3bae] */
            ii(0x19_3fc7, 2); if(jbe(0x19_3fbd, -0xc)) goto l_0x19_3fbd; /* jbe 0x3fbd */
            ii(0x19_3fc9, 4); cmp(ax, memw[ds, 0x3bac]);                /* cmp ax, [0x3bac] */
            ii(0x19_3fcd, 2); if(jbe(0x19_3fd2, 3)) goto l_0x19_3fd2;   /* jbe 0x3fd2 */
            ii(0x19_3fcf, 3); mov(memw[ds, 0x3bac], ax);                /* mov [0x3bac], ax */
        l_0x19_3fd2:
            ii(0x19_3fd2, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_3fd4, 2); xor(bx, bx);                              /* xor bx, bx */
            ii(0x19_3fd6, 4); mov(ax, memw[es, di + 12]);               /* mov ax, [es:di+0xc] */
            ii(0x19_3fda, 3); mov(memw[ds, bx + 2], ax);                /* mov [bx+0x2], ax */
            ii(0x19_3fdd, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x19_3fdf, 3); call(0x19_3fea, 8);                       /* call 0x3fea */
            ii(0x19_3fe2, 3); call(0x19_401e, 0x39);                    /* call 0x401e */
            ii(0x19_3fe5, 1); clc();                                    /* clc */
            ii(0x19_3fe6, 2); jmp(0x19_3fe9, 1); goto l_0x19_3fe9;      /* jmp 0x3fe9 */
        //  ii(0x19_3fe8, 1); stc();                                    /* stc */
        l_0x19_3fe9:
            ii(0x19_3fe9, 1); ret();                                    /* ret */
        }
    }
}
