using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_7545-8b76b65c")]
        public void Method_1009_7545()
        {
            ii(0x1009_7545, 5);  push(0x44);                           /* push 0x44 */
            ii(0x1009_754a, 5);  call(Definitions.sys_check_available_stack_size, 0xc_e803);/* call 0x10165d52 */
            ii(0x1009_754f, 1);  push(esi);                            /* push esi */
            ii(0x1009_7550, 1);  push(edi);                            /* push edi */
            ii(0x1009_7551, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_7552, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_7554, 6);  sub(esp, 0x34);                       /* sub esp, 0x34 */
            ii(0x1009_755a, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_755d, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1009_7560, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1009_7563, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1009_7566, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_7569, 5);  call(Definitions.my_ctor_0x101b_4184, -0x2_0a7e);/* call 0x10076af0 */
            ii(0x1009_756e, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1009_7571, 5);  call(Definitions.my_ctor_0x101b_4184, -0x2_0a86);/* call 0x10076af0 */
        l_0x1009_7576:
            ii(0x1009_7576, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7579, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x1009_757c, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_757e, 2);  if(jle(0x1009_75cc, 0x4c)) goto l_0x1009_75cc;/* jle 0x100975cc */
            ii(0x1009_7580, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7583, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1009_7586, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1009_7589, 3);  add(edx, memd[ss, ebp - 12]);         /* add edx, [ebp-0xc] */
            ii(0x1009_758c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_758f, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_7591, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_7594, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1009_7596, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_7598, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_759a, 2);  mov(dl, memb[ds, eax]);               /* mov dl, [eax] */
            ii(0x1009_759c, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1009_75a0, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1009_75a2, 2);  if(jz(0x1009_75ca, 0x26)) goto l_0x1009_75ca;/* jz 0x100975ca */
            ii(0x1009_75a4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_75a7, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x1009_75aa, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_75ad, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1009_75b0, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1009_75b2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_75b5, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_75b7, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_75ba, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1009_75bc, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_75be, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1009_75c0, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1009_75c5, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1009_75c8, 2);  if(jnz(0x1009_75cc, 2)) goto l_0x1009_75cc;/* jnz 0x100975cc */
        l_0x1009_75ca:
            ii(0x1009_75ca, 2);  jmp(0x1009_75ce, 2); goto l_0x1009_75ce;/* jmp 0x100975ce */
        l_0x1009_75cc:
            ii(0x1009_75cc, 2);  jmp(0x1009_75d6, 8); goto l_0x1009_75d6;/* jmp 0x100975d6 */
        l_0x1009_75ce:
            ii(0x1009_75ce, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_75d1, 3);  dec(memw[ds, eax]);                   /* dec word [eax] */
            ii(0x1009_75d4, 2);  jmp(0x1009_7576, -0x60); goto l_0x1009_7576;/* jmp 0x10097576 */
        l_0x1009_75d6:
            ii(0x1009_75d6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_75d9, 3);  inc(memw[ds, eax]);                   /* inc word [eax] */
            ii(0x1009_75dc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_75df, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x1009_75e2, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x1009_75e9, 2);  if(jge(0x1009_7637, 0x4c)) goto l_0x1009_7637;/* jge 0x10097637 */
            ii(0x1009_75eb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_75ee, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1009_75f1, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1009_75f4, 3);  add(edx, memd[ss, ebp - 12]);         /* add edx, [ebp-0xc] */
            ii(0x1009_75f7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_75fa, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_75fc, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_75ff, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1009_7601, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_7603, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_7605, 2);  mov(dl, memb[ds, eax]);               /* mov dl, [eax] */
            ii(0x1009_7607, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1009_760b, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1009_760d, 2);  if(jz(0x1009_7635, 0x26)) goto l_0x1009_7635;/* jz 0x10097635 */
            ii(0x1009_760f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7612, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x1009_7615, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_7618, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1009_761b, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1009_761d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7620, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_7622, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_7625, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1009_7627, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_7629, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1009_762b, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1009_7630, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1009_7633, 2);  if(jnz(0x1009_7637, 2)) goto l_0x1009_7637;/* jnz 0x10097637 */
        l_0x1009_7635:
            ii(0x1009_7635, 2);  jmp(0x1009_763c, 5); goto l_0x1009_763c;/* jmp 0x1009763c */
        l_0x1009_7637:
            ii(0x1009_7637, 5);  jmp(0x1009_78b7, 0x27b); goto l_0x1009_78b7;/* jmp 0x100978b7 */
        l_0x1009_763c:
            ii(0x1009_763c, 4);  mov(memb[ss, ebp - 32], 0);           /* mov byte [ebp-0x20], 0x0 */
            ii(0x1009_7640, 4);  mov(memb[ss, ebp - 28], 0);           /* mov byte [ebp-0x1c], 0x0 */
            ii(0x1009_7644, 4);  mov(memb[ss, ebp - 24], 0);           /* mov byte [ebp-0x18], 0x0 */
            ii(0x1009_7648, 4);  mov(memb[ss, ebp - 20], 0);           /* mov byte [ebp-0x14], 0x0 */
        l_0x1009_764c:
            ii(0x1009_764c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_764f, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x1009_7652, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x1009_7659, 2);  if(jge(0x1009_76a7, 0x4c)) goto l_0x1009_76a7;/* jge 0x100976a7 */
            ii(0x1009_765b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_765e, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1009_7661, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1009_7664, 3);  add(edx, memd[ss, ebp - 12]);         /* add edx, [ebp-0xc] */
            ii(0x1009_7667, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_766a, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_766c, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_766f, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1009_7671, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_7673, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_7675, 2);  mov(dl, memb[ds, eax]);               /* mov dl, [eax] */
            ii(0x1009_7677, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1009_767b, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1009_767d, 2);  if(jz(0x1009_76a5, 0x26)) goto l_0x1009_76a5;/* jz 0x100976a5 */
            ii(0x1009_767f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7682, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x1009_7685, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_7688, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1009_768b, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1009_768d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7690, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_7692, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_7695, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1009_7697, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_7699, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1009_769b, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1009_76a0, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1009_76a3, 2);  if(jnz(0x1009_76a7, 2)) goto l_0x1009_76a7;/* jnz 0x100976a7 */
        l_0x1009_76a5:
            ii(0x1009_76a5, 2);  jmp(0x1009_76ac, 5); goto l_0x1009_76ac;/* jmp 0x100976ac */
        l_0x1009_76a7:
            ii(0x1009_76a7, 5);  jmp(0x1009_7869, 0x1bd); goto l_0x1009_7869;/* jmp 0x10097869 */
        l_0x1009_76ac:
            ii(0x1009_76ac, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1009_76b0, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1009_76b3, 2);  if(jnz(0x1009_76d4, 0x1f)) goto l_0x1009_76d4;/* jnz 0x100976d4 */
            ii(0x1009_76b5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_76b8, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x1009_76bb, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_76be, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1009_76c1, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1009_76c3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_76c6, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_76c8, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_76cb, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1009_76cd, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_76cf, 3);  mov(memb[ds, eax], 3);                /* mov byte [eax], 0x3 */
            ii(0x1009_76d2, 2);  jmp(0x1009_76f1, 0x1d); goto l_0x1009_76f1;/* jmp 0x100976f1 */
        l_0x1009_76d4:
            ii(0x1009_76d4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_76d7, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x1009_76da, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_76dd, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1009_76e0, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1009_76e2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_76e5, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_76e7, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_76ea, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1009_76ec, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_76ee, 3);  mov(memb[ds, eax], 5);                /* mov byte [eax], 0x5 */
        l_0x1009_76f1:
            ii(0x1009_76f1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_76f4, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_76f6, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_76f9, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_76fb, 2);  if(jle(0x1009_774b, 0x4e)) goto l_0x1009_774b;/* jle 0x1009774b */
            ii(0x1009_76fd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7700, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1009_7703, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1009_7706, 3);  add(edx, memd[ss, ebp - 12]);         /* add edx, [ebp-0xc] */
            ii(0x1009_7709, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_770c, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_770e, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_7711, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1009_7713, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_7715, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_7717, 3);  mov(dl, memb[ds, eax - 1]);           /* mov dl, [eax-0x1] */
            ii(0x1009_771a, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1009_771e, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1009_7720, 2);  if(jz(0x1009_7749, 0x27)) goto l_0x1009_7749;/* jz 0x10097749 */
            ii(0x1009_7722, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7725, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x1009_7728, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_772b, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1009_772e, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1009_7730, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7733, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_7735, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_7738, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1009_773a, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_773c, 3);  mov(al, memb[ds, eax - 1]);           /* mov al, [eax-0x1] */
            ii(0x1009_773f, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1009_7744, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1009_7747, 2);  if(jnz(0x1009_774b, 2)) goto l_0x1009_774b;/* jnz 0x1009774b */
        l_0x1009_7749:
            ii(0x1009_7749, 2);  jmp(0x1009_774d, 2); goto l_0x1009_774d;/* jmp 0x1009774d */
        l_0x1009_774b:
            ii(0x1009_774b, 2);  jmp(0x1009_7799, 0x4c); goto l_0x1009_7799;/* jmp 0x10097799 */
        l_0x1009_774d:
            ii(0x1009_774d, 4);  cmp(memb[ss, ebp - 28], 0);           /* cmp byte [ebp-0x1c], 0x0 */
            ii(0x1009_7751, 2);  if(jz(0x1009_7777, 0x24)) goto l_0x1009_7777;/* jz 0x10097777 */
            ii(0x1009_7753, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1009_7757, 3);  lea(edx, memd[ss, ebp - 36]);         /* lea edx, [ebp-0x24] */
            ii(0x1009_775a, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1009_775d, 5);  call(0x1007_5e64, -0x2_18fe);         /* call 0x10075e64 */
            ii(0x1009_7762, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1009_7764, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1009_7767, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_776a, 5);  call(0x1009_7545, -0x22a);            /* call 0x10097545 */
            ii(0x1009_776f, 4);  mov(memb[ss, ebp - 28], 0);           /* mov byte [ebp-0x1c], 0x0 */
            ii(0x1009_7773, 4);  mov(memb[ss, ebp - 32], 0);           /* mov byte [ebp-0x20], 0x0 */
        l_0x1009_7777:
            ii(0x1009_7777, 4);  cmp(memb[ss, ebp - 32], 0);           /* cmp byte [ebp-0x20], 0x0 */
            ii(0x1009_777b, 2);  if(jnz(0x1009_7797, 0x1a)) goto l_0x1009_7797;/* jnz 0x10097797 */
            ii(0x1009_777d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7780, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x1009_7783, 4);  mov(memw[ss, ebp - 36], ax);          /* mov [ebp-0x24], ax */
            ii(0x1009_7787, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_778a, 4);  mov(ax, memw[ds, eax + 2]);           /* mov ax, [eax+0x2] */
            ii(0x1009_778e, 1);  dec(eax);                             /* dec eax */
            ii(0x1009_778f, 4);  mov(memw[ss, ebp - 34], ax);          /* mov [ebp-0x22], ax */
            ii(0x1009_7793, 4);  mov(memb[ss, ebp - 32], 1);           /* mov byte [ebp-0x20], 0x1 */
        l_0x1009_7797:
            ii(0x1009_7797, 2);  jmp(0x1009_77a3, 0xa); goto l_0x1009_77a3;/* jmp 0x100977a3 */
        l_0x1009_7799:
            ii(0x1009_7799, 4);  cmp(memb[ss, ebp - 32], 0);           /* cmp byte [ebp-0x20], 0x0 */
            ii(0x1009_779d, 2);  if(jz(0x1009_77a3, 4)) goto l_0x1009_77a3;/* jz 0x100977a3 */
            ii(0x1009_779f, 4);  mov(memb[ss, ebp - 28], 1);           /* mov byte [ebp-0x1c], 0x1 */
        l_0x1009_77a3:
            ii(0x1009_77a3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_77a6, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1009_77a8, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1009_77ab, 5);  mov(eax, memd[ds, 0x101c_8172]);      /* mov eax, [0x101c8172] */
            ii(0x1009_77b0, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_77b3, 1);  dec(eax);                             /* dec eax */
            ii(0x1009_77b4, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1009_77b6, 2);  if(jge(0x1009_7806, 0x4e)) goto l_0x1009_7806;/* jge 0x10097806 */
            ii(0x1009_77b8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_77bb, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1009_77be, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1009_77c1, 3);  add(edx, memd[ss, ebp - 12]);         /* add edx, [ebp-0xc] */
            ii(0x1009_77c4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_77c7, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_77c9, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_77cc, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1009_77ce, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_77d0, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_77d2, 3);  mov(dl, memb[ds, eax + 1]);           /* mov dl, [eax+0x1] */
            ii(0x1009_77d5, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1009_77d9, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1009_77db, 2);  if(jz(0x1009_7804, 0x27)) goto l_0x1009_7804;/* jz 0x10097804 */
            ii(0x1009_77dd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_77e0, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x1009_77e3, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_77e6, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1009_77e9, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1009_77eb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_77ee, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_77f0, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_77f3, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1009_77f5, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_77f7, 3);  mov(al, memb[ds, eax + 1]);           /* mov al, [eax+0x1] */
            ii(0x1009_77fa, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1009_77ff, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1009_7802, 2);  if(jnz(0x1009_7806, 2)) goto l_0x1009_7806;/* jnz 0x10097806 */
        l_0x1009_7804:
            ii(0x1009_7804, 2);  jmp(0x1009_7808, 2); goto l_0x1009_7808;/* jmp 0x10097808 */
        l_0x1009_7806:
            ii(0x1009_7806, 2);  jmp(0x1009_7854, 0x4c); goto l_0x1009_7854;/* jmp 0x10097854 */
        l_0x1009_7808:
            ii(0x1009_7808, 4);  cmp(memb[ss, ebp - 20], 0);           /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1009_780c, 2);  if(jz(0x1009_7832, 0x24)) goto l_0x1009_7832;/* jz 0x10097832 */
            ii(0x1009_780e, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1009_7812, 3);  lea(edx, memd[ss, ebp - 40]);         /* lea edx, [ebp-0x28] */
            ii(0x1009_7815, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_7818, 5);  call(0x1007_5e64, -0x2_19b9);         /* call 0x10075e64 */
            ii(0x1009_781d, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1009_781f, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1009_7822, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_7825, 5);  call(0x1009_7545, -0x2e5);            /* call 0x10097545 */
            ii(0x1009_782a, 4);  mov(memb[ss, ebp - 20], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_782e, 4);  mov(memb[ss, ebp - 24], 0);           /* mov byte [ebp-0x18], 0x0 */
        l_0x1009_7832:
            ii(0x1009_7832, 4);  cmp(memb[ss, ebp - 24], 0);           /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1009_7836, 2);  if(jnz(0x1009_7852, 0x1a)) goto l_0x1009_7852;/* jnz 0x10097852 */
            ii(0x1009_7838, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_783b, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x1009_783e, 4);  mov(memw[ss, ebp - 40], ax);          /* mov [ebp-0x28], ax */
            ii(0x1009_7842, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7845, 4);  mov(ax, memw[ds, eax + 2]);           /* mov ax, [eax+0x2] */
            ii(0x1009_7849, 1);  inc(eax);                             /* inc eax */
            ii(0x1009_784a, 4);  mov(memw[ss, ebp - 38], ax);          /* mov [ebp-0x26], ax */
            ii(0x1009_784e, 4);  mov(memb[ss, ebp - 24], 1);           /* mov byte [ebp-0x18], 0x1 */
        l_0x1009_7852:
            ii(0x1009_7852, 2);  jmp(0x1009_785e, 0xa); goto l_0x1009_785e;/* jmp 0x1009785e */
        l_0x1009_7854:
            ii(0x1009_7854, 4);  cmp(memb[ss, ebp - 24], 0);           /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1009_7858, 2);  if(jz(0x1009_785e, 4)) goto l_0x1009_785e;/* jz 0x1009785e */
            ii(0x1009_785a, 4);  mov(memb[ss, ebp - 20], 1);           /* mov byte [ebp-0x14], 0x1 */
        l_0x1009_785e:
            ii(0x1009_785e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7861, 3);  inc(memw[ds, eax]);                   /* inc word [eax] */
            ii(0x1009_7864, 5);  jmp(0x1009_764c, -0x21d); goto l_0x1009_764c;/* jmp 0x1009764c */
        l_0x1009_7869:
            ii(0x1009_7869, 4);  cmp(memb[ss, ebp - 32], 0);           /* cmp byte [ebp-0x20], 0x0 */
            ii(0x1009_786d, 2);  if(jz(0x1009_78a2, 0x33)) goto l_0x1009_78a2;/* jz 0x100978a2 */
            ii(0x1009_786f, 4);  cmp(memb[ss, ebp - 24], 0);           /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1009_7873, 2);  if(jz(0x1009_7893, 0x1e)) goto l_0x1009_7893;/* jz 0x10097893 */
            ii(0x1009_7875, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1009_7879, 3);  lea(edx, memd[ss, ebp - 36]);         /* lea edx, [ebp-0x24] */
            ii(0x1009_787c, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_787f, 5);  call(0x1007_5e64, -0x2_1a20);         /* call 0x10075e64 */
            ii(0x1009_7884, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1009_7886, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1009_7889, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_788c, 5);  call(0x1009_7545, -0x34c);            /* call 0x10097545 */
            ii(0x1009_7891, 2);  jmp(0x1009_78a2, 0xf); goto l_0x1009_78a2;/* jmp 0x100978a2 */
        l_0x1009_7893:
            ii(0x1009_7893, 4);  mov(memb[ss, ebp - 24], 1);           /* mov byte [ebp-0x18], 0x1 */
            ii(0x1009_7897, 3);  lea(edx, memd[ss, ebp - 36]);         /* lea edx, [ebp-0x24] */
            ii(0x1009_789a, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1009_789d, 5);  call(0x1008_8b44, -0xed5e);           /* call 0x10088b44 */
        l_0x1009_78a2:
            ii(0x1009_78a2, 3);  lea(edx, memd[ss, ebp - 40]);         /* lea edx, [ebp-0x28] */
            ii(0x1009_78a5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_78a8, 5);  call(0x1008_8b44, -0xed69);           /* call 0x10088b44 */
            ii(0x1009_78ad, 4);  cmp(memb[ss, ebp - 24], 0);           /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1009_78b1, 6);  if(jnz(0x1009_7576, -0x341)) goto l_0x1009_7576;/* jnz 0x10097576 */
        l_0x1009_78b7:
            ii(0x1009_78b7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_78b9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_78ba, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_78bb, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_78bc, 1);  ret();                                /* ret */
        }
    }
}
