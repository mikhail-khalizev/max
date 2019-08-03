using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("47a5079f-c0dc-4b3a-ae66-3332d91a5d86")]
        public void Method_0015_3fa6()
        {
            ii(0x15_3fa6, 2); mov(dx, cx);                              /* mov dx, cx */
            ii(0x15_3fa8, 3); add(dx, 0x27);                            /* add dx, 0x27 */
            ii(0x15_3fab, 3); and(dl, 0xf0);                            /* and dl, 0xf0 */
            ii(0x15_3fae, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x15_3fb0, 2); neg(bx);                                  /* neg bx */
            ii(0x15_3fb2, 2); neg(bx);                                  /* neg bx */
            ii(0x15_3fb4, 1); cmc();                                    /* cmc */
            ii(0x15_3fb5, 2); rcr(bx, 0x1);                             /* rcr bx, 1 */
            ii(0x15_3fb7, 2); shr(bx, 0x1);                             /* shr bx, 1 */
            ii(0x15_3fb9, 2); shr(bx, 0x1);                             /* shr bx, 1 */
            ii(0x15_3fbb, 2); shr(bx, 0x1);                             /* shr bx, 1 */
        l_0x15_3fbd:
            ii(0x15_3fbd, 2); mov(ah, 0x48);                            /* mov ah, 0x48 */
            ii(0x15_3fbf, 2); @int(0x21);                               /* int 0x21 */
            ii(0x15_3fc1, 2); if(jbw(0x15_3fe9, 0x26)) goto l_0x15_3fe9; /* jb 0x3fe9 */
            ii(0x15_3fc3, 4); cmp(ax, memw_a16[ds, 0x3bae]);            /* cmp ax, [0x3bae] */
            ii(0x15_3fc7, 2); if(jbew(0x15_3fbd, -0xc)) goto l_0x15_3fbd; /* jbe 0x3fbd */
            ii(0x15_3fc9, 4); cmp(ax, memw_a16[ds, 0x3bac]);            /* cmp ax, [0x3bac] */
            ii(0x15_3fcd, 2); if(jbew(0x15_3fd2, 0x3)) goto l_0x15_3fd2; /* jbe 0x3fd2 */
            ii(0x15_3fcf, 3); mov(memw_a16[ds, 0x3bac], ax);            /* mov [0x3bac], ax */
        l_0x15_3fd2:
            ii(0x15_3fd2, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_3fd4, 2); xor(bx, bx);                              /* xor bx, bx */
            ii(0x15_3fd6, 4); mov(ax, memw_a16[es, di + 0xc]);          /* mov ax, [es:di+0xc] */
            ii(0x15_3fda, 3); mov(memw_a16[ds, bx + 0x2], ax);          /* mov [bx+0x2], ax */
            ii(0x15_3fdd, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x15_3fdf, 3); callw(0x15_3fea, 0x8);                    /* call 0x3fea */
            ii(0x15_3fe2, 3); callw(0x15_401e, 0x39);                   /* call 0x401e */
            ii(0x15_3fe5, 1); clc();                                    /* clc */
            ii(0x15_3fe6, 2); jmpw(0x15_3fe9, 0x1); goto l_0x15_3fe9;   /* jmp 0x3fe9 */
        //  ii(0x15_3fe8, 1); Недостижимый код.
l_0x15_3fe9:
            ii(0x15_3fe9, 1); retw(); return;                           /* ret */
        }
    }
}