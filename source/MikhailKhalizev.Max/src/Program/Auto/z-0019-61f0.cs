using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_61f0-f79d61ed")]
        public void Method_0019_61f0()
        {
            ii(0x19_61f0, 4); enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x19_61f4, 1); pushw(di);                                /* push di */
            ii(0x19_61f5, 1); pushw(si);                                /* push si */
            ii(0x19_61f6, 3); lea(ax, bp - 0x8);                        /* lea ax, [bp-0x8] */
            ii(0x19_61f9, 1); pushw(ss);                                /* push ss */
            ii(0x19_61fa, 1); pushw(ax);                                /* push ax */
            ii(0x19_61fb, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_61fe, 5); callw_far_abs(0x80, 0x4f82);              /* call word 0x80:0x4f82 */
            ii(0x19_6203, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_6206, 4); sub(memw_a16[ss, bp + 0x6], 0x1);         /* sub word [bp+0x6], 0x1 */
            ii(0x19_620a, 4); sbb(memw_a16[ss, bp + 0x8], 0);           /* sbb word [bp+0x8], 0x0 */
            ii(0x19_620e, 4); cmp(memw_a16[ss, bp + 0x8], 0x10);        /* cmp word [bp+0x8], 0x10 */
            ii(0x19_6212, 2); if(jbew(0x19_6217, 0x3)) goto l_0x19_6217; /* jbe 0x6217 */
            ii(0x19_6214, 3); jmpw(0x19_622c, 0x15); goto l_0x19_622c;  /* jmp 0x622c */
        l_0x19_6217:
            ii(0x19_6217, 2); if(jaew(0x19_621c, 0x3)) goto l_0x19_621c; /* jae 0x621c */
            ii(0x19_6219, 3); jmpw(0x19_6225, 0x9); goto l_0x19_6225;   /* jmp 0x6225 */
        l_0x19_621c:
            ii(0x19_621c, 4); cmp(memw_a16[ss, bp + 0x6], 0);           /* cmp word [bp+0x6], 0x0 */
            ii(0x19_6220, 2); if(jbw(0x19_6225, 0x3)) goto l_0x19_6225; /* jb 0x6225 */
            ii(0x19_6222, 3); jmpw(0x19_622c, 0x7); goto l_0x19_622c;   /* jmp 0x622c */
        l_0x19_6225:
            ii(0x19_6225, 4); and(memb_a16[ss, bp - 0x2], 0x7f);        /* and byte [bp-0x2], 0x7f */
            ii(0x19_6229, 3); jmpw(0x19_623b, 0xf); goto l_0x19_623b;   /* jmp 0x623b */
        l_0x19_622c:
            ii(0x19_622c, 2); pushw(0xc);                               /* push 0xc */
            ii(0x19_622e, 3); lea(ax, bp + 0x6);                        /* lea ax, [bp+0x6] */
            ii(0x19_6231, 1); pushw(ax);                                /* push ax */
            ii(0x19_6232, 5); callw_far_abs(0x80, 0x435a);              /* call word 0x80:0x435a */
            ii(0x19_6237, 4); or(memb_a16[ss, bp - 0x2], -0x80 /* 0x80 */); /* or byte [bp-0x2], 0x80 */
        l_0x19_623b:
            ii(0x19_623b, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x19_623e, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x19_6241, 3); mov(al, memb_a16[ss, bp + 0x8]);          /* mov al, [bp+0x8] */
            ii(0x19_6244, 3); xor(al, memb_a16[ss, bp - 0x2]);          /* xor al, [bp-0x2] */
            ii(0x19_6247, 2); and(al, 0xf);                             /* and al, 0xf */
            ii(0x19_6249, 3); xor(memb_a16[ss, bp - 0x2], al);          /* xor [bp-0x2], al */
            ii(0x19_624c, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x19_624f, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x19_6252, 3); mov(al, memb_a16[ss, bp + 0xc]);          /* mov al, [bp+0xc] */
            ii(0x19_6255, 3); mov(memb_a16[ss, bp - 0x4], al);          /* mov [bp-0x4], al */
            ii(0x19_6258, 3); mov(al, memb_a16[ss, bp + 0xd]);          /* mov al, [bp+0xd] */
            ii(0x19_625b, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x19_625d, 3); mov(memb_a16[ss, bp - 0x1], al);          /* mov [bp-0x1], al */
            ii(0x19_6260, 3); lea(ax, bp - 0x8);                        /* lea ax, [bp-0x8] */
            ii(0x19_6263, 1); pushw(ss);                                /* push ss */
            ii(0x19_6264, 1); pushw(ax);                                /* push ax */
            ii(0x19_6265, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_6268, 5); callw_far_abs(0x80, 0x4ff4);              /* call word 0x80:0x4ff4 */
            ii(0x19_626d, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_6270, 1); popw(si);                                 /* pop si */
            ii(0x19_6271, 1); popw(di);                                 /* pop di */
            ii(0x19_6272, 1); leavew();                                 /* leave */
            ii(0x19_6273, 1); retw(); return;                           /* ret */
        }
    }
}
