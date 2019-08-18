using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3675af06-0713-4ca0-90d4-ee93b7aee2e4")]
        public void Method_0000_bf76()
        {
            ii(0xbf76, 3);    mov(bx, memw_a16[ss, bp + 0x2a]);         /* mov bx, [bp+0x2a] */
            ii(0xbf79, 5);    popd(memd_a32[ds, ebx - 0x4]);            /* pop dword [ebx-0x4] */
            ii(0xbf7e, 4);    mov(eax, memd_a16[ss, bp + 0x1e]);        /* mov eax, [bp+0x1e] */
            ii(0xbf82, 4);    mov(memd_a32[ds, ebx], eax);              /* mov [ebx], eax */
            ii(0xbf86, 3);    mov(ax, memw_a16[ss, bp + 0x22]);         /* mov ax, [bp+0x22] */
            ii(0xbf89, 4);    mov(memw_a32[ds, ebx + 0x4], ax);         /* mov [ebx+0x4], ax */
            ii(0xbf8d, 3);    mov(ax, memw_a16[ss, bp + 0x28]);         /* mov ax, [bp+0x28] */
            ii(0xbf90, 4);    mov(memw_a32[ds, ebx + 0xa], ax);         /* mov [ebx+0xa], ax */
            ii(0xbf94, 2);    popd(eax);                                /* pop eax */
            ii(0xbf96, 3);    cmp(dx, memw_a16[ss, bp + 0x6]);          /* cmp dx, [bp+0x6] */
            ii(0xbf99, 2);    if(jnzw(0xbfd6, 0x3b)) goto l_0xbfd6;     /* jnz 0xbfd6 */
        l_0xbf9b:
            ii(0xbf9b, 2);    mov(es, dx);                              /* mov es, dx */
            ii(0xbf9d, 1);    popw(dx);                                 /* pop dx */
            ii(0xbf9e, 3);    cmp(dx, memw_a16[ss, bp + 0x4]);          /* cmp dx, [bp+0x4] */
            ii(0xbfa1, 2);    if(jnzw(0xbfd2, 0x2f)) goto l_0xbfd2;     /* jnz 0xbfd2 */
        l_0xbfa3:
            ii(0xbfa3, 4);    mov(memw_a32[ds, ebx - 0x8], dx);         /* mov [ebx-0x8], dx */
            ii(0xbfa7, 4);    popw(memw_a32[ds, ebx - 0x6]);            /* pop word [ebx-0x6] */
            ii(0xbfab, 5);    popd(memd_a32[ds, ebx - 0x4]);            /* pop dword [ebx-0x4] */
            ii(0xbfb0, 4);    popw(memw_a32[ds, ebx - 0xa]);            /* pop word [ebx-0xa] */
            ii(0xbfb4, 1);    popw(dx);                                 /* pop dx */
            ii(0xbfb5, 3);    and(dh, 0xe);                             /* and dh, 0xe */
            ii(0xbfb8, 4);    mov(memw_a32[ds, ebx + 0x8], dx);         /* mov [ebx+0x8], dx */
            ii(0xbfbc, 7);    add(memw_a16[ss, 0x996], 0x180);          /* add word [ss:0x996], 0x180 */
            ii(0xbfc3, 3);    mov(ss, memw_a16[ss, bp + 0x2]);          /* mov ss, [bp+0x2] */
            ii(0xbfc6, 5);    lea(esp, ebx - 0xa);                      /* lea esp, [ebx-0xa] */
            ii(0xbfcb, 1);    popw(dx);                                 /* pop dx */
            ii(0xbfcc, 1);    popw(ds);                                 /* pop ds */
            ii(0xbfcd, 1);    popw(bp);                                 /* pop bp */
            ii(0xbfce, 2);    popd(ebx);                                /* pop ebx */
            ii(0xbfd0, 2);    iretd(); return;                          /* iretd */
        l_0xbfd2:
            ii(0xbfd2, 2);    xor(dx, dx);                              /* xor dx, dx */
            ii(0xbfd4, 2);    jmpw(0xbfa3, -0x33); goto l_0xbfa3;       /* jmp 0xbfa3 */
        l_0xbfd6:
            ii(0xbfd6, 2);    xor(dx, dx);                              /* xor dx, dx */
            ii(0xbfd8, 2);    jmpw(0xbf9b, -0x3f); goto l_0xbf9b;       /* jmp 0xbf9b */
        }
    }
}
