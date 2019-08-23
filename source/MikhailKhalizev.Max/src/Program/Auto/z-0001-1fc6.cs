using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1fc6-3741a1fb")]
        public void Method_0001_1fc6()
        {
            ii(0x1_1fc6, 2);  pushad();                                 /* pushad */
            ii(0x1_1fc8, 1);  push(es);                                 /* push es */
            ii(0x1_1fc9, 1);  push(ds);                                 /* push ds */
            ii(0x1_1fca, 2);  mov(bx, ss);                              /* mov bx, ss */
            ii(0x1_1fcc, 3);  mov(ebp, esp);                            /* mov ebp, esp */
            ii(0x1_1fcf, 4);  lar(ebx, bx);                             /* lar ebx, bx */
            ii(0x1_1fd3, 5);  bt(ebx, 0x16);                            /* bt ebx, 0x16 */
            ii(0x1_1fd8, 2);  if(jb(0x1_1fe0, 0x6)) goto l_0x1_1fe0;    /* jb 0x1fe0 */
            ii(0x1_1fda, 4);  movzx(ebp, sp);                           /* movzx ebp, sp */
            ii(0x1_1fde, 2);  xchg(bx, bx);                             /* xchg bx, bx */
        l_0x1_1fe0:
            ii(0x1_1fe0, 4);  mov(bx, memw_a32[ss, ebp + 0x28]);        /* mov bx, [ebp+0x28] */
            ii(0x1_1fe4, 3);  cmp(bx, 0x71);                            /* cmp bx, 0x71 */
            ii(0x1_1fe7, 2);  if(jb(0x1_1ff4, 0xb)) goto l_0x1_1ff4;    /* jb 0x1ff4 */
            ii(0x1_1fe9, 4);  lar(ebx, bx);                             /* lar ebx, bx */
            ii(0x1_1fed, 5);  bt(ebx, 0x16);                            /* bt ebx, 0x16 */
            ii(0x1_1ff2, 2);  xchg(bx, bx);                             /* xchg bx, bx */
        l_0x1_1ff4:
            ii(0x1_1ff4, 2);  sbb(bx, bx);                              /* sbb bx, bx */
            ii(0x1_1ff6, 1);  push(bx);                                 /* push bx */
            ii(0x1_1ff7, 2);  push(-0x1 /* 0xff */);                    /* push 0xffff */
            ii(0x1_1ff9, 5);  and(esi, memd_a32[ss, ebp - 0x4]);        /* and esi, [ebp-0x4] */
            ii(0x1_1ffe, 5);  and(edi, memd_a32[ss, ebp - 0x4]);        /* and edi, [ebp-0x4] */
            ii(0x1_2003, 3);  cmp(ah, 0xf);                             /* cmp ah, 0xf */
            ii(0x1_2006, 2);  if(jae(0x1_2032, 0x2a)) goto l_0x1_2032;  /* jae 0x2032 */
            ii(0x1_2008, 5);  and(memb_a32[ss, ebp + 0x2c], -0x2 /* 0xfe */); /* and byte [ebp+0x2c], 0xfe */
            ii(0x1_200d, 2);  xor(bx, bx);                              /* xor bx, bx */
            ii(0x1_200f, 2);  mov(bl, ah);                              /* mov bl, ah */
            ii(0x1_2011, 2);  shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x1_2013, 5);  mov(si, memw[cs, bx + 0x44b8]);           /* mov si, [cs:bx+0x44b8] */
            ii(0x1_2018, 2);  xor(ah, ah);                              /* xor ah, ah */
            ii(0x1_201a, 2);  mov(bx, ax);                              /* mov bx, ax */
            ii(0x1_201c, 4);  mov(ax, memw[cs, si - 0x2]);              /* mov ax, [cs:si-0x2] */
            ii(0x1_2020, 2);  test(al, al);                             /* test al, al */
            ii(0x1_2022, 2);  if(js(0x1_202e, 0xa)) goto l_0x1_202e;    /* js 0x202e */
            ii(0x1_2024, 2);  cmp(bl, ah);                              /* cmp bl, ah */
            ii(0x1_2026, 2);  if(jae(0x1_2032, 0xa)) goto l_0x1_2032;   /* jae 0x2032 */
            ii(0x1_2028, 2);  shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x1_202a, 1);  cld();                                    /* cld */
            ii(0x1_202b, 3);  if(jmp_abs(memw[cs, bx + si])) return;    /* jmp word [cs:bx+si] */
        l_0x1_202e:
            ii(0x1_202e, 4);  if(jmp_far_ind(cs, si - 0x6)) return;     /* jmp far word [cs:si-0x6] */
        l_0x1_2032:
            ii(0x1_2032, 5);  or(memb_a32[ss, ebp + 0x2c], 0x1);        /* or byte [ebp+0x2c], 0x1 */
            ii(0x1_2037, 3);  mov(esp, ebp);                            /* mov esp, ebp */
            ii(0x1_203a, 1);  pop(ds);                                  /* pop ds */
            ii(0x1_203b, 1);  pop(es);                                  /* pop es */
            ii(0x1_203c, 2);  popad();                                  /* popad */
            ii(0x1_203e, 2);  iretd();                                  /* iretd */
        }
    }
}
