using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_9fb5-e02d998f")]
        public void Method_0018_9fb5()
        {
            ii(0x18_9fb5, 4);  mov(ebx, memd[ss, bp + 42]);            /* mov ebx, [bp+0x2a] */
            ii(0x18_9fb9, 5);  pop(memd_a32[ds, ebx - 4]);             /* pop dword [ebx-0x4] */
            ii(0x18_9fbe, 4);  mov(eax, memd[ss, bp + 30]);            /* mov eax, [bp+0x1e] */
            ii(0x18_9fc2, 4);  mov(memd_a32[ds, ebx], eax);            /* mov [ebx], eax */
            ii(0x18_9fc6, 3);  mov(ax, memw[ss, bp + 34]);             /* mov ax, [bp+0x22] */
            ii(0x18_9fc9, 4);  mov(memw_a32[ds, ebx + 4], ax);         /* mov [ebx+0x4], ax */
            ii(0x18_9fcd, 3);  mov(ax, memw[ss, bp + 40]);             /* mov ax, [bp+0x28] */
            ii(0x18_9fd0, 4);  mov(memw_a32[ds, ebx + 10], ax);        /* mov [ebx+0xa], ax */
            ii(0x18_9fd4, 2);  pop(eax);                               /* pop eax */
            ii(0x18_9fd6, 3);  cmp(dx, memw[ss, bp + 6]);              /* cmp dx, [bp+0x6] */
            ii(0x18_9fd9, 2);  if(jnz(0x18_a016, 0x3b)) goto l_0x18_a016;/* jnz 0xa016 */
        l_0x18_9fdb:
            ii(0x18_9fdb, 2);  mov(es, dx);                            /* mov es, dx */
            ii(0x18_9fdd, 1);  pop(dx);                                /* pop dx */
            ii(0x18_9fde, 3);  cmp(dx, memw[ss, bp + 4]);              /* cmp dx, [bp+0x4] */
            ii(0x18_9fe1, 2);  if(jnz(0x18_a012, 0x2f)) goto l_0x18_a012;/* jnz 0xa012 */
        l_0x18_9fe3:
            ii(0x18_9fe3, 4);  mov(memw_a32[ds, ebx - 8], dx);         /* mov [ebx-0x8], dx */
            ii(0x18_9fe7, 4);  pop(memw_a32[ds, ebx - 6]);             /* pop word [ebx-0x6] */
            ii(0x18_9feb, 5);  pop(memd_a32[ds, ebx - 4]);             /* pop dword [ebx-0x4] */
            ii(0x18_9ff0, 4);  pop(memw_a32[ds, ebx - 10]);            /* pop word [ebx-0xa] */
            ii(0x18_9ff4, 1);  pop(dx);                                /* pop dx */
            ii(0x18_9ff5, 3);  and(dh, 0xe);                           /* and dh, 0xe */
            ii(0x18_9ff8, 4);  mov(memw_a32[ds, ebx + 8], dx);         /* mov [ebx+0x8], dx */
            ii(0x18_9ffc, 7);  add(memw[ss, 0x996], 0x180);            /* add word [ss:0x996], 0x180 */
            ii(0x18_a003, 3);  mov(ss, memw[ss, bp + 2]);              /* mov ss, [bp+0x2] */
            ii(0x18_a006, 5);  lea(esp, memd_a32[ds, ebx - 10]);       /* lea esp, [ebx-0xa] */
            ii(0x18_a00b, 1);  pop(dx);                                /* pop dx */
            ii(0x18_a00c, 1);  pop(ds);                                /* pop ds */
            ii(0x18_a00d, 1);  pop(bp);                                /* pop bp */
            ii(0x18_a00e, 2);  pop(ebx);                               /* pop ebx */
            ii(0x18_a010, 2);  iretd(); return;                        /* iretd */
        l_0x18_a012:
            ii(0x18_a012, 2);  xor(dx, dx);                            /* xor dx, dx */
            ii(0x18_a014, 2);  jmp(0x18_9fe3, -0x33); goto l_0x18_9fe3;/* jmp 0x9fe3 */
        l_0x18_a016:
            ii(0x18_a016, 2);  xor(dx, dx);                            /* xor dx, dx */
            ii(0x18_a018, 2);  jmp(0x18_9fdb, -0x3f); goto l_0x18_9fdb;/* jmp 0x9fdb */
        }
    }
}
