using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9f4d323a-a62d-4a19-b10b-f5d13685fe3f")]
        public void Method_0001_0030()
        {
            ii(0x1_0030, 6);  movzx(ebx, memw_a32[ss, ebp + 0x14]);     /* movzx ebx, word [ebp+0x14] */
            ii(0x1_0036, 3);  mov(ax, 0x8);                             /* mov ax, 0x8 */
            ii(0x1_0039, 2);  mov(ds, ax);                              /* mov ds, ax */
            ii(0x1_003b, 4);  cmp(bx, memw_a16[ds, 0x8]);               /* cmp bx, [0x8] */
            ii(0x1_003f, 2);  jaew_func(0x1_0022, -0x1f);               /* jae 0x22 */
            ii(0x1_0041, 3);  and(bx, -0x8 /* 0xf8 */);                 /* and bx, 0xfff8 */
            ii(0x1_0044, 2);  jzw_func(0x1_0022, -0x24);                /* jz 0x22 */
            ii(0x1_0046, 2);  xor(cx, cx);                              /* xor cx, cx */
            ii(0x1_0048, 3);  mov(cl, memb_a16[ds, bx + 0x5]);          /* mov cl, [bx+0x5] */
            ii(0x1_004b, 3);  test(cl, 0x80);                           /* test cl, 0x80 */
            ii(0x1_004e, 2);  if(jzw(0x1_0065, 0x15)) goto l_0x1_0065;  /* jz 0x65 */
            ii(0x1_0050, 1);  pushw(es);                                /* push es */
            ii(0x1_0051, 2);  pushw(0x50);                              /* push 0x50 */
            ii(0x1_0053, 1);  popw(es);                                 /* pop es */
            ii(0x1_0054, 1);  pushw(si);                                /* push si */
            ii(0x1_0055, 2);  mov(si, bx);                              /* mov si, bx */
            ii(0x1_0057, 3);  shr(si, 0x3);                             /* shr si, 0x3 */
            ii(0x1_005a, 3);  mov(al, memb_a16[es, si]);                /* mov al, [es:si] */
            ii(0x1_005d, 1);  popw(si);                                 /* pop si */
            ii(0x1_005e, 1);  popw(es);                                 /* pop es */
            ii(0x1_005f, 2);  and(al, 0xf0);                            /* and al, 0xf0 */
            ii(0x1_0061, 2);  cmp(al, -0x10 /* 0xf0 */);                /* cmp al, 0xf0 */
            ii(0x1_0063, 2);  if(jzw(0x1_0067, 0x2)) goto l_0x1_0067;   /* jz 0x67 */
        l_0x1_0065:
            ii(0x1_0065, 1);  clc();                                    /* clc */
            ii(0x1_0066, 1);  retw(); return;                           /* ret */
        l_0x1_0067:
            ii(0x1_0067, 1);  stc();                                    /* stc */
            ii(0x1_0068, 1);  retw(); return;                           /* ret */
        }
    }
}
