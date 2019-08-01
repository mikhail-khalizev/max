using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("85615d78-9766-4d78-87fd-ad2aad9d9f7b")]
        public void Method_0000_4a31()
        {
            ii(0x4a31, 4);    mov(bx, memw_a16[ds, 0x8b2]);             /* mov bx, [0x8b2] */
            ii(0x4a35, 4);    cmp(bx, 0x80);                            /* cmp bx, 0x80 */
            ii(0x4a39, 2);    if(jbw(0x4a86, 0x4b)) goto l_0x4a86;      /* jb 0x5236 */
            ii(0x4a3b, 3);    mov(ax, memw_a16[ds, 0x8aa]);             /* mov ax, [0x8aa] */
            ii(0x4a3e, 3);    cmp(ax, 0x80);                            /* cmp ax, 0x80 */
            ii(0x4a41, 2);    if(jbw(0x4a86, 0x43)) goto l_0x4a86;      /* jb 0x5236 */
            ii(0x4a43, 3);    callw(0x3880, -0x11c6);                   /* call 0x4030 */
            ii(0x4a46, 2);    xor(cx, cx);                              /* xor cx, cx */
            ii(0x4a48, 3);    lar(cx, bx);                              /* lar cx, bx */
            ii(0x4a4b, 3);    and(ch, 0x18);                            /* and ch, 0x18 */
            ii(0x4a4e, 3);    cmp(ch, 0x18);                            /* cmp ch, 0x18 */
            ii(0x4a51, 2);    if(jnzw(0x4a83, 0x30)) goto l_0x4a83;     /* jnz 0x5233 */
            ii(0x4a53, 2);    xor(cx, cx);                              /* xor cx, cx */
            ii(0x4a55, 3);    lar(cx, ax);                              /* lar cx, ax */
            ii(0x4a58, 3);    and(ch, 0x18);                            /* and ch, 0x18 */
            ii(0x4a5b, 3);    cmp(ch, 0x10);                            /* cmp ch, 0x10 */
            ii(0x4a5e, 2);    if(jnzw(0x4a83, 0x23)) goto l_0x4a83;     /* jnz 0x5233 */
            ii(0x4a60, 4);    mov(memw_a16[ds, 0xf50], sp);             /* mov [0xf50], sp */
            ii(0x4a64, 2);    mov(ss, ax);                              /* mov ss, ax */
            ii(0x4a66, 4);    mov(sp, memw_a16[ds, 0x8a8]);             /* mov sp, [0x8a8] */
            ii(0x4a6a, 2);    pushw(0x20);                              /* push 0x20 */
            ii(0x4a6c, 4);    pushw(memw_a16[ds, 0x996]);               /* push word [0x996] */
            ii(0x4a70, 4);    mov(ds, memw_a16[ds, 0x8ae]);             /* mov ds, [0x8ae] */
            ii(0x4a74, 5);    callw_a16_far_ind(es, 0x8b0);             /* call far word [es:0x8b0] */
            ii(0x4a79, 2);    pushw(0x20);                              /* push 0x20 */
            ii(0x4a7b, 1);    popw(ds);                                 /* pop ds */
            ii(0x4a7c, 2);    pushw(0x20);                              /* push 0x20 */
            ii(0x4a7e, 1);    popw(ss);                                 /* pop ss */
            ii(0x4a7f, 4);    mov(sp, memw_a16[ds, 0xf50]);             /* mov sp, [0xf50] */
        l_0x4a83:
            ii(0x4a83, 3);    callw(0x3f19, -0xb6d);                    /* call 0x46c9 */
        l_0x4a86:
            ii(0x4a86, 1);    retw(); return;                           /* ret */
        }
    }
}