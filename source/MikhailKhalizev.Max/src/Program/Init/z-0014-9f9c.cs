using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("11963703-26fd-4ef3-8784-12f6085c5b55")]
        public void Method_0014_9f9c()
        {
            ii(0x14_9f9c, 3); mov(ds, memw_a16[ss, bp + 0x2]);          /* mov ds, [bp+0x2] */
            ii(0x14_9f9f, 2); pushd(eax);                               /* push eax */
            ii(0x14_9fa1, 2); pushd(ebx);                               /* push ebx */
            ii(0x14_9fa3, 5); lar(ebx, memw_a16[ss, bp + 0x2]);         /* lar ebx, word [bp+0x2] */
            ii(0x14_9fa8, 5); bt(ebx, 0x16);                            /* bt ebx, 0x16 */
            ii(0x14_9fad, 6); mov(ebx, 0);                              /* mov ebx, 0x0 */
            ii(0x14_9fb3, 2); jaew_func(0x14_9fb6, 0x1);                /* jae 0x9fb6 */ /* Адрес перехода делит инструкцию в этой функции пополам. */
            ii(0x14_9fb5, 4); mov(ebx, memd_a16[ss, bp + 0x2a]);        /* mov ebx, [bp+0x2a] */
            ii(0x14_9fb9, 5); popd(memd_a32[ds, ebx - 0x4]);            /* pop dword [ebx-0x4] */
            ii(0x14_9fbe, 4); mov(eax, memd_a16[ss, bp + 0x1e]);        /* mov eax, [bp+0x1e] */
            ii(0x14_9fc2, 4); mov(memd_a32[ds, ebx], eax);              /* mov [ebx], eax */
            ii(0x14_9fc6, 3); mov(ax, memw_a16[ss, bp + 0x22]);         /* mov ax, [bp+0x22] */
            ii(0x14_9fc9, 4); mov(memw_a32[ds, ebx + 0x4], ax);         /* mov [ebx+0x4], ax */
            ii(0x14_9fcd, 3); mov(ax, memw_a16[ss, bp + 0x28]);         /* mov ax, [bp+0x28] */
            ii(0x14_9fd0, 4); mov(memw_a32[ds, ebx + 0xa], ax);         /* mov [ebx+0xa], ax */
            ii(0x14_9fd4, 2); popd(eax);                                /* pop eax */
            ii(0x14_9fd6, 3); cmp(dx, memw_a16[ss, bp + 0x6]);          /* cmp dx, [bp+0x6] */
            ii(0x14_9fd9, 2); if(jnzw(0x14_a016, 0x3b)) goto l_0x14_a016; /* jnz 0xa016 */
        l_0x14_9fdb:
            ii(0x14_9fdb, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x14_9fdd, 1); popw(dx);                                 /* pop dx */
            ii(0x14_9fde, 3); cmp(dx, memw_a16[ss, bp + 0x4]);          /* cmp dx, [bp+0x4] */
            ii(0x14_9fe1, 2); if(jnzw(0x14_a012, 0x2f)) goto l_0x14_a012; /* jnz 0xa012 */
        l_0x14_9fe3:
            ii(0x14_9fe3, 4); mov(memw_a32[ds, ebx - 0x8], dx);         /* mov [ebx-0x8], dx */
            ii(0x14_9fe7, 4); popw(memw_a32[ds, ebx - 0x6]);            /* pop word [ebx-0x6] */
            ii(0x14_9feb, 5); popd(memd_a32[ds, ebx - 0x4]);            /* pop dword [ebx-0x4] */
            ii(0x14_9ff0, 4); popw(memw_a32[ds, ebx - 0xa]);            /* pop word [ebx-0xa] */
            ii(0x14_9ff4, 1); popw(dx);                                 /* pop dx */
            ii(0x14_9ff5, 3); and(dh, 0xe);                             /* and dh, 0xe */
            ii(0x14_9ff8, 4); mov(memw_a32[ds, ebx + 0x8], dx);         /* mov [ebx+0x8], dx */
            ii(0x14_9ffc, 7); add(memw_a16[ss, 0x996], 0x180);          /* add word [ss:0x996], 0x180 */
            ii(0x14_a003, 3); mov(ss, memw_a16[ss, bp + 0x2]);          /* mov ss, [bp+0x2] */
            ii(0x14_a006, 5); lea(esp, ebx - 0xa);                      /* lea esp, [ebx-0xa] */
            ii(0x14_a00b, 1); popw(dx);                                 /* pop dx */
            ii(0x14_a00c, 1); popw(ds);                                 /* pop ds */
            ii(0x14_a00d, 1); popw(bp);                                 /* pop bp */
            ii(0x14_a00e, 2); popd(ebx);                                /* pop ebx */
            ii(0x14_a010, 2); iretd(); return;                          /* iretd */
        l_0x14_a012:
            ii(0x14_a012, 2); xor(dx, dx);                              /* xor dx, dx */
            ii(0x14_a014, 2); jmpw(0x14_9fe3, -0x33); goto l_0x14_9fe3; /* jmp 0x9fe3 */
        l_0x14_a016:
            ii(0x14_a016, 2); xor(dx, dx);                              /* xor dx, dx */
            ii(0x14_a018, 2); jmpw(0x14_9fdb, -0x3f); goto l_0x14_9fdb; /* jmp 0x9fdb */
        }
    }
}