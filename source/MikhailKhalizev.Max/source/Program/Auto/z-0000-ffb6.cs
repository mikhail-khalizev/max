using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xffb6-3741a1fb")]
        public void Method_0000_ffb6()
        {
            ii(0xffb6, 2);  pushad();                                  /* pushad */
            ii(0xffb8, 1);  push(es);                                  /* push es */
            ii(0xffb9, 1);  push(ds);                                  /* push ds */
            ii(0xffba, 2);  mov(bx, ss);                               /* mov bx, ss */
            ii(0xffbc, 3);  mov(ebp, esp);                             /* mov ebp, esp */
            ii(0xffbf, 4);  lar(ebx, bx);                              /* lar ebx, bx */
            ii(0xffc3, 5);  bt(ebx, 0x16);                             /* bt ebx, 0x16 */
            ii(0xffc8, 2);  if(jb(0xffd0, 6)) goto l_0xffd0;           /* jb 0xffd0 */
            ii(0xffca, 4);  movzx(ebp, sp);                            /* movzx ebp, sp */
            ii(0xffce, 2);  xchg(bx, bx);                              /* xchg bx, bx */
        l_0xffd0:
            ii(0xffd0, 4);  mov(bx, memw_a32[ss, ebp + 40]);           /* mov bx, [ebp+0x28] */
            ii(0xffd4, 3);  cmp(bx, 0x71);                             /* cmp bx, 0x71 */
            ii(0xffd7, 2);  if(jb(0xffe4, 0xb)) goto l_0xffe4;         /* jb 0xffe4 */
            ii(0xffd9, 4);  lar(ebx, bx);                              /* lar ebx, bx */
            ii(0xffdd, 5);  bt(ebx, 0x16);                             /* bt ebx, 0x16 */
            ii(0xffe2, 2);  xchg(bx, bx);                              /* xchg bx, bx */
        l_0xffe4:
            ii(0xffe4, 2);  sbb(bx, bx);                               /* sbb bx, bx */
            ii(0xffe6, 1);  push(bx);                                  /* push bx */
            ii(0xffe7, 2);  push(-1 /* 0xff */);                       /* push 0xffff */
            ii(0xffe9, 5);  and(esi, memd_a32[ss, ebp - 4]);           /* and esi, [ebp-0x4] */
            ii(0xffee, 5);  and(edi, memd_a32[ss, ebp - 4]);           /* and edi, [ebp-0x4] */
            ii(0xfff3, 3);  cmp(ah, 0xf);                              /* cmp ah, 0xf */
            ii(0xfff6, 2);  if(jae(0x1_0022, 0x2a)) goto l_0x1_0022;   /* jae 0x22 */
            ii(0xfff8, 5);  and(memb_a32[ss, ebp + 44], -2 /* 0xfe */);/* and byte [ebp+0x2c], 0xfe */
            ii(0xfffd, 2);  xor(bx, bx);                               /* xor bx, bx */
            ii(0xffff, 2);  mov(bl, ah);                               /* mov bl, ah */
            ii(0x1_0001, 2);  shl(bx, 1);                              /* shl bx, 1 */
            ii(0x1_0003, 5);  mov(si, memw[cs, bx + 0x44b8]);          /* mov si, [cs:bx+0x44b8] */
            ii(0x1_0008, 2);  xor(ah, ah);                             /* xor ah, ah */
            ii(0x1_000a, 2);  mov(bx, ax);                             /* mov bx, ax */
            ii(0x1_000c, 4);  mov(ax, memw[cs, si - 2]);               /* mov ax, [cs:si-0x2] */
            ii(0x1_0010, 2);  test(al, al);                            /* test al, al */
            ii(0x1_0012, 2);  if(js(0x1_001e, 0xa)) goto l_0x1_001e;   /* js 0x1e */
            ii(0x1_0014, 2);  cmp(bl, ah);                             /* cmp bl, ah */
            ii(0x1_0016, 2);  if(jae(0x1_0022, 0xa)) goto l_0x1_0022;  /* jae 0x22 */
            ii(0x1_0018, 2);  shl(bx, 1);                              /* shl bx, 1 */
            ii(0x1_001a, 1);  cld();                                   /* cld */
            ii(0x1_001b, 3);  if(jmp_abs(memw[cs, bx + si])) return;   /* jmp word [cs:bx+si] */
        l_0x1_001e:
            ii(0x1_001e, 4);  if(jmp_far_ind(memw[cs, si - 6])) return;/* jmp far word [cs:si-0x6] */
        l_0x1_0022:
            ii(0x1_0022, 5);  or(memb_a32[ss, ebp + 44], 1);           /* or byte [ebp+0x2c], 0x1 */
            ii(0x1_0027, 3);  mov(esp, ebp);                           /* mov esp, ebp */
            ii(0x1_002a, 1);  pop(ds);                                 /* pop ds */
            ii(0x1_002b, 1);  pop(es);                                 /* pop es */
            ii(0x1_002c, 2);  popad();                                 /* popad */
            ii(0x1_002e, 2);  iretd();                                 /* iretd */
        }
    }
}
