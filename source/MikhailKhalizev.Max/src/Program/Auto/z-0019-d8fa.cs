using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_d8fa-f6d76e04")]
        public void Method_0019_d8fa()
        {
            ii(0x19_d8fa, 1); pushw(bp);                                /* push bp */
            ii(0x19_d8fb, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_d8fd, 1); pushw(ds);                                /* push ds */
            ii(0x19_d8fe, 1); pushw(es);                                /* push es */
            ii(0x19_d8ff, 2); pushw(fs);                                /* push fs */
            ii(0x19_d901, 2); pushw(gs);                                /* push gs */
            ii(0x19_d903, 1); pushw(si);                                /* push si */
            ii(0x19_d904, 1); pushw(di);                                /* push di */
            ii(0x19_d905, 3); pushw(0xa8);                              /* push 0xa8 */
            ii(0x19_d908, 1); popw(ds);                                 /* pop ds */
            ii(0x19_d909, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x19_d90b, 2); mov(gs, ax);                              /* mov gs, ax */
            ii(0x19_d90d, 3); mov(memw_a16[ds, 0x2b92], ax);            /* mov [0x2b92], ax */
            ii(0x19_d910, 4); mov(memw_a16[ds, 0x2b90], sp);            /* mov [0x2b90], sp */
            ii(0x19_d914, 2); mov(al, 0x88);                            /* mov al, 0x88 */
            ii(0x19_d916, 2); outb(0x99, al);                           /* out 0x99, al */
            ii(0x19_d918, 5); les(edi, ds, 0x2b94);                     /* les edi, [0x2b94] */
            ii(0x19_d91d, 5); mov(eax, memd_a32[es, edi]);              /* mov eax, [es:edi] */
            ii(0x19_d922, 9); mov(eax, memd_a32[es, edi - 0x800]);      /* mov eax, [es:edi-0x800] */
            ii(0x19_d92b, 6); lss(esp, ds, 0x2b94);                     /* lss esp, [0x2b94] */
            ii(0x19_d931, 2); popw(fs);                                 /* pop fs */
            ii(0x19_d933, 4); add(esp, 0x2);                            /* add esp, 0x2 */
            ii(0x19_d937, 1); pushw(ss);                                /* push ss */
            ii(0x19_d938, 1); pushw(ss);                                /* push ss */
            ii(0x19_d939, 1); popw(ds);                                 /* pop ds */
            ii(0x19_d93a, 1); popw(es);                                 /* pop es */
            ii(0x19_d93b, 3); mov(esi, esp);                            /* mov esi, esp */
            ii(0x19_d93e, 7); sub(esi, 0xc00);                          /* sub esi, 0xc00 */
            ii(0x19_d945, 4); mov(memb_a32[ds, esi], 0x68);             /* mov byte [esi], 0x68 */
            ii(0x19_d949, 6); mov(memw_a32[ds, esi + 0x1], 0x88);       /* mov word [esi+0x1], 0x88 */
            ii(0x19_d94f, 6); mov(memw_a32[ds, esi + 0x3], 0);          /* mov word [esi+0x3], 0x0 */
            ii(0x19_d955, 5); mov(memb_a32[ds, esi + 0x5], 0x68);       /* mov byte [esi+0x5], 0x68 */
            ii(0x19_d95a, 6); mov(memw_a32[ds, esi + 0x6], 0x8564);     /* mov word [esi+0x6], 0x8564 */
            ii(0x19_d960, 6); mov(memw_a32[ds, esi + 0x8], 0);          /* mov word [esi+0x8], 0x0 */
            ii(0x19_d966, 5); mov(memb_a32[ds, esi + 0xa], 0xcb);       /* mov byte [esi+0xa], 0xcb */
            ii(0x19_d96b, 2); pushd(esi);                               /* push esi */
            ii(0x19_d96d, 3); xor(eax, eax);                            /* xor eax, eax */
            ii(0x19_d970, 3); xor(ebx, ebx);                            /* xor ebx, ebx */
            ii(0x19_d973, 3); xor(ecx, ecx);                            /* xor ecx, ecx */
            ii(0x19_d976, 3); xor(edx, edx);                            /* xor edx, edx */
            ii(0x19_d979, 3); xor(edi, edi);                            /* xor edi, edi */
            ii(0x19_d97c, 3); xor(esi, esi);                            /* xor esi, esi */
            ii(0x19_d97f, 5); jmpd_a16_far_ind(gs, bp + 0x6);           /* jmp far dword [gs:bp+0x6] */
        }
    }
}
