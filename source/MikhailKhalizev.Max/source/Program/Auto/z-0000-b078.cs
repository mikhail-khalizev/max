using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb078-5038930a")]
        public void Method_0000_b078()
        {
            ii(0xb078, 1);  push(bp);                                  /* push bp */
            ii(0xb079, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0xb07b, 1);  push(di);                                  /* push di */
            ii(0xb07c, 1);  push(si);                                  /* push si */
            ii(0xb07d, 3);  call(0x3880, -0x7800);                     /* call 0x3880 */
            ii(0xb080, 7);  movzx(ecx, memw[cs, 0x79f6]);              /* movzx ecx, word [cs:0x79f6] */
            ii(0xb087, 2);  if(jcxz(0xb102, 0x79)) goto l_0xb102;      /* jcxz 0xb102 */
            ii(0xb089, 6);  movzx(esi, memw[ds, 0xaa]);                /* movzx esi, word [0xaa] */
            ii(0xb08f, 2);  push(0x38);                                /* push 0x38 */
            ii(0xb091, 1);  pop(ds);                                   /* pop ds */
            ii(0xb092, 4);  shl(esi, 4);                               /* shl esi, 0x4 */
            ii(0xb096, 3);  mov(edi, esi);                             /* mov edi, esi */
            ii(0xb099, 7);  add(edi, 0x1c00);                          /* add edi, 0x1c00 */
            ii(0xb0a0, 6);  mov(edx, memd[cs, 0x79f8]);                /* mov edx, [cs:0x79f8] */
            ii(0xb0a6, 4);  xchg(memd_a32[ds, esi], edx);              /* xchg [esi], edx */
            ii(0xb0aa, 3);  add(si, 4);                                /* add si, 0x4 */
            ii(0xb0ad, 3);  mov(eax, cr3);                             /* mov eax, cr3 */
            ii(0xb0b0, 3);  mov(cr3, eax);                             /* mov cr3, eax */
            ii(0xb0b3, 3);  lodsd_a32();                               /* a32 lodsd */
            ii(0xb0b6, 3);  mov(ebx, eax);                             /* mov ebx, eax */
            ii(0xb0b9, 4);  xchg(memd_a32[ds, edi], eax);              /* xchg [edi], eax */
            ii(0xb0bd, 8);  mov(memd_a32[ds, 0x30_0000], ebx);         /* mov [0x300000], ebx */
            ii(0xb0c5, 4);  mov(memd_a32[ds, edi], eax);               /* mov [edi], eax */
            ii(0xb0c9, 5);  mov(memd_a32[ds, esi - 8], edx);           /* mov [esi-0x8], edx */
            ii(0xb0ce, 3);  mov(eax, cr3);                             /* mov eax, cr3 */
            ii(0xb0d1, 3);  mov(cr3, eax);                             /* mov cr3, eax */
            ii(0xb0d4, 6);  mov(edi, 0x40_0004);                       /* mov edi, 0x400004 */
            ii(0xb0da, 1);  push(ds);                                  /* push ds */
            ii(0xb0db, 1);  pop(es);                                   /* pop es */
            ii(0xb0dc, 2);  mov(bx, cx);                               /* mov bx, cx */
            ii(0xb0de, 1);  dec(cx);                                   /* dec cx */
            ii(0xb0df, 4);  rep_a32(() => movsd_a32());                /* a32 rep movsd */
            ii(0xb0e3, 2);  mov(cx, bx);                               /* mov cx, bx */
            ii(0xb0e5, 3);  shl(cx, 0xa);                              /* shl cx, 0xa */
            ii(0xb0e8, 2);  sub(cx, bx);                               /* sub cx, bx */
            ii(0xb0ea, 3);  xor(eax, eax);                             /* xor eax, eax */
            ii(0xb0ed, 4);  rep_a32(() => stosd_a32());                /* a32 rep stosd */
            ii(0xb0f1, 1);  push(ss);                                  /* push ss */
            ii(0xb0f2, 1);  pop(ds);                                   /* pop ds */
            ii(0xb0f3, 4);  mov(cx, memw[ds, 0xdfa]);                  /* mov cx, [0xdfa] */
            ii(0xb0f7, 2);  if(jcxz(0xb102, 9)) goto l_0xb102;         /* jcxz 0xb102 */
            ii(0xb0f9, 6);  mov(esi, 0x3f_f000);                       /* mov esi, 0x3ff000 */
            ii(0xb0ff, 3);  call(0xb1d9, 0xd7);                        /* call 0xb1d9 */
        l_0xb102:
            ii(0xb102, 4);  push(memd[ss, bp + 4]);                    /* push dword [bp+0x4] */
            ii(0xb106, 5);  push(memd[ds, 0x98]);                      /* push dword [0x98] */
            ii(0xb10b, 5);  call_far_abs(0x70, 0x57bb);                /* call word 0x70:0x57bb */
            ii(0xb110, 3);  add(sp, 8);                                /* add sp, 0x8 */
            ii(0xb113, 1);  push(ax);                                  /* push ax */
            ii(0xb114, 3);  call(0x3f1c, -0x71fb);                     /* call 0x3f1c */
            ii(0xb117, 1);  pop(ax);                                   /* pop ax */
            ii(0xb118, 1);  inc(ax);                                   /* inc ax */
            ii(0xb119, 1);  pop(si);                                   /* pop si */
            ii(0xb11a, 1);  pop(di);                                   /* pop di */
            ii(0xb11b, 7);  mov(memw[cs, 0x79f6], 0);                  /* mov word [cs:0x79f6], 0x0 */
            ii(0xb122, 1);  pop(bp);                                   /* pop bp */
            ii(0xb123, 1);  ret();                                     /* ret */
        }
    }
}
