using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6b60684c-b434-438a-b24f-3777dc94c529")]
        public void Method_0013_d634()
        {
            ii(0x13_d634, 4); popw(memw_a16[ds, 0x1c88]);               /* pop word [0x1c88] */
            ii(0x13_d638, 4); popw(memw_a16[ds, 0x1c8a]);               /* pop word [0x1c8a] */
            ii(0x13_d63c, 2); mov(ah, 0x30);                            /* mov ah, 0x30 */
            ii(0x13_d63e, 2); @int(0x21);                               /* int 0x21 */
            ii(0x13_d640, 3); mov(memw_a16[ds, 0x1c56], ax);            /* mov [0x1c56], ax */
            ii(0x13_d643, 3); mov(dx, 0x1);                             /* mov dx, 0x1 */
            ii(0x13_d646, 2); cmp(al, 0x2);                             /* cmp al, 0x2 */
            ii(0x13_d648, 2); if(jzw(0x13_d673, 0x29)) goto l_0x13_d673; /* jz 0xd673 */
            ii(0x13_d64a, 4); mov(es, memw_a16[ds, 0x1c54]);            /* mov es, [0x1c54] */
            ii(0x13_d64e, 5); mov(es, memw_a16[es, 0x2c]);              /* mov es, [es:0x2c] */
            ii(0x13_d653, 4); mov(memw_a16[ds, 0x1c79], es);            /* mov [0x1c79], es */
            ii(0x13_d657, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x13_d659, 1); cwd();                                    /* cwd */
            ii(0x13_d65a, 3); mov(cx, 0x8000);                          /* mov cx, 0x8000 */
            ii(0x13_d65d, 2); xor(di, di);                              /* xor di, di */
        l_0x13_d65f:
            ii(0x13_d65f, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x13_d661, 1); scasb_a16();                              /* scasb */
            ii(0x13_d662, 2); if(jnzw(0x13_d65f, -0x5)) goto l_0x13_d65f; /* jnz 0xd65f */
            ii(0x13_d664, 1); inc(di);                                  /* inc di */
            ii(0x13_d665, 1); inc(di);                                  /* inc di */
            ii(0x13_d666, 4); mov(memw_a16[ds, 0x1c77], di);            /* mov [0x1c77], di */
            ii(0x13_d66a, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x13_d66d, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x13_d66f, 2); not(cx);                                  /* not cx */
            ii(0x13_d671, 2); mov(dx, cx);                              /* mov dx, cx */
        l_0x13_d673:
            ii(0x13_d673, 3); mov(di, 0x1);                             /* mov di, 0x1 */
            ii(0x13_d676, 3); mov(si, 0x81);                            /* mov si, 0x81 */
            ii(0x13_d679, 4); mov(ds, memw_a16[ds, 0x1c54]);            /* mov ds, [0x1c54] */
        l_0x13_d67d:
            ii(0x13_d67d, 1); lodsb_a16();                              /* lodsb */
            ii(0x13_d67e, 2); cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x13_d680, 2); if(jzw(0x13_d67d, -0x5)) goto l_0x13_d67d; /* jz 0xd67d */
            ii(0x13_d682, 2); cmp(al, 0x9);                             /* cmp al, 0x9 */
            ii(0x13_d684, 2); if(jzw(0x13_d67d, -0x9)) goto l_0x13_d67d; /* jz 0xd67d */
            ii(0x13_d686, 2); cmp(al, 0xd);                             /* cmp al, 0xd */
            ii(0x13_d688, 2); if(jzw(0x13_d6f9, 0x6f)) goto l_0x13_d6f9; /* jz 0xd6f9 */
            ii(0x13_d68a, 2); or(al, al);                               /* or al, al */
            ii(0x13_d68c, 2); if(jzw(0x13_d6f9, 0x6b)) goto l_0x13_d6f9; /* jz 0xd6f9 */
            ii(0x13_d68e, 1); inc(di);                                  /* inc di */
        l_0x13_d68f:
            ii(0x13_d68f, 1); dec(si);                                  /* dec si */
        l_0x13_d690:
            ii(0x13_d690, 1); lodsb_a16();                              /* lodsb */
            ii(0x13_d691, 2); cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x13_d693, 2); if(jzw(0x13_d67d, -0x18)) goto l_0x13_d67d; /* jz 0xd67d */
            ii(0x13_d695, 2); cmp(al, 0x9);                             /* cmp al, 0x9 */
            ii(0x13_d697, 2); if(jzw(0x13_d67d, -0x1c)) goto l_0x13_d67d; /* jz 0xd67d */
            ii(0x13_d699, 2); cmp(al, 0xd);                             /* cmp al, 0xd */
            ii(0x13_d69b, 2); if(jzw(0x13_d6f9, 0x5c)) goto l_0x13_d6f9; /* jz 0xd6f9 */
            ii(0x13_d69d, 2); or(al, al);                               /* or al, al */
            ii(0x13_d69f, 2); if(jzw(0x13_d6f9, 0x58)) goto l_0x13_d6f9; /* jz 0xd6f9 */
            ii(0x13_d6a1, 2); cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x13_d6a3, 2); if(jzw(0x13_d6c9, 0x24)) goto l_0x13_d6c9; /* jz 0xd6c9 */
            ii(0x13_d6a5, 2); cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x13_d6a7, 2); if(jzw(0x13_d6ac, 0x3)) goto l_0x13_d6ac; /* jz 0xd6ac */
            ii(0x13_d6a9, 1); inc(dx);                                  /* inc dx */
            ii(0x13_d6aa, 2); jmpw(0x13_d690, -0x1c); goto l_0x13_d690; /* jmp 0xd690 */
        l_0x13_d6ac:
            ii(0x13_d6ac, 2); xor(cx, cx);                              /* xor cx, cx */
        l_0x13_d6ae:
            ii(0x13_d6ae, 1); inc(cx);                                  /* inc cx */
            ii(0x13_d6af, 1); lodsb_a16();                              /* lodsb */
            ii(0x13_d6b0, 2); cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x13_d6b2, 2); if(jzw(0x13_d6ae, -0x6)) goto l_0x13_d6ae; /* jz 0xd6ae */
            ii(0x13_d6b4, 2); cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x13_d6b6, 2); if(jzw(0x13_d6bc, 0x4)) goto l_0x13_d6bc; /* jz 0xd6bc */
            ii(0x13_d6b8, 2); add(dx, cx);                              /* add dx, cx */
            ii(0x13_d6ba, 2); jmpw(0x13_d68f, -0x2d); goto l_0x13_d68f; /* jmp 0xd68f */
        l_0x13_d6bc:
            ii(0x13_d6bc, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x13_d6be, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x13_d6c0, 2); adc(dx, cx);                              /* adc dx, cx */
            ii(0x13_d6c2, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x13_d6c4, 2); if(jnzw(0x13_d690, -0x36)) goto l_0x13_d690; /* jnz 0xd690 */
            ii(0x13_d6c6, 2); jmpw(0x13_d6c9, 0x1); goto l_0x13_d6c9;   /* jmp 0xd6c9 */
        l_0x13_d6c8:
            ii(0x13_d6c8, 1); dec(si);                                  /* dec si */
        l_0x13_d6c9:
            ii(0x13_d6c9, 1); lodsb_a16();                              /* lodsb */
            ii(0x13_d6ca, 2); cmp(al, 0xd);                             /* cmp al, 0xd */
            ii(0x13_d6cc, 2); if(jzw(0x13_d6f9, 0x2b)) goto l_0x13_d6f9; /* jz 0xd6f9 */
            ii(0x13_d6ce, 2); or(al, al);                               /* or al, al */
            ii(0x13_d6d0, 2); if(jzw(0x13_d6f9, 0x27)) goto l_0x13_d6f9; /* jz 0xd6f9 */
            ii(0x13_d6d2, 2); cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x13_d6d4, 2); if(jzw(0x13_d690, -0x46)) goto l_0x13_d690; /* jz 0xd690 */
            ii(0x13_d6d6, 2); cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x13_d6d8, 2); if(jzw(0x13_d6dd, 0x3)) goto l_0x13_d6dd; /* jz 0xd6dd */
            ii(0x13_d6da, 1); inc(dx);                                  /* inc dx */
            ii(0x13_d6db, 2); jmpw(0x13_d6c9, -0x14); goto l_0x13_d6c9; /* jmp 0xd6c9 */
        l_0x13_d6dd:
            ii(0x13_d6dd, 2); xor(cx, cx);                              /* xor cx, cx */
        l_0x13_d6df:
            ii(0x13_d6df, 1); inc(cx);                                  /* inc cx */
            ii(0x13_d6e0, 1); lodsb_a16();                              /* lodsb */
            ii(0x13_d6e1, 2); cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x13_d6e3, 2); if(jzw(0x13_d6df, -0x6)) goto l_0x13_d6df; /* jz 0xd6df */
            ii(0x13_d6e5, 2); cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x13_d6e7, 2); if(jzw(0x13_d6ed, 0x4)) goto l_0x13_d6ed; /* jz 0xd6ed */
            ii(0x13_d6e9, 2); add(dx, cx);                              /* add dx, cx */
            ii(0x13_d6eb, 2); jmpw(0x13_d6c8, -0x25); goto l_0x13_d6c8; /* jmp 0xd6c8 */
        l_0x13_d6ed:
            ii(0x13_d6ed, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x13_d6ef, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x13_d6f1, 2); adc(dx, cx);                              /* adc dx, cx */
            ii(0x13_d6f3, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x13_d6f5, 2); if(jnzw(0x13_d6c9, -0x2e)) goto l_0x13_d6c9; /* jnz 0xd6c9 */
            ii(0x13_d6f7, 2); jmpw(0x13_d690, -0x69); goto l_0x13_d690; /* jmp 0xd690 */
        l_0x13_d6f9:
            ii(0x13_d6f9, 1); pushw(ss);                                /* push ss */
            ii(0x13_d6fa, 1); popw(ds);                                 /* pop ds */
            ii(0x13_d6fb, 4); mov(memw_a16[ds, 0x1c71], di);            /* mov [0x1c71], di */
            ii(0x13_d6ff, 2); add(dx, di);                              /* add dx, di */
            ii(0x13_d701, 1); inc(di);                                  /* inc di */
            ii(0x13_d702, 2); shl(di, 0x1);                             /* shl di, 1 */
            ii(0x13_d704, 2); add(dx, di);                              /* add dx, di */
            ii(0x13_d706, 1); inc(dx);                                  /* inc dx */
            ii(0x13_d707, 3); and(dl, 0xfe);                            /* and dl, 0xfe */
            ii(0x13_d70a, 2); sub(sp, dx);                              /* sub sp, dx */
            ii(0x13_d70c, 2); mov(ax, sp);                              /* mov ax, sp */
            ii(0x13_d70e, 3); mov(memw_a16[ds, 0x1c73], ax);            /* mov [0x1c73], ax */
            ii(0x13_d711, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_d713, 2); add(di, bx);                              /* add di, bx */
            ii(0x13_d715, 1); pushw(ss);                                /* push ss */
            ii(0x13_d716, 1); popw(es);                                 /* pop es */
            ii(0x13_d717, 3); mov(memw_a16[ss, bx], di);                /* mov [ss:bx], di */
            ii(0x13_d71a, 1); inc(bx);                                  /* inc bx */
            ii(0x13_d71b, 1); inc(bx);                                  /* inc bx */
            ii(0x13_d71c, 4); lds(si, ds, 0x1c77);                      /* lds si, [0x1c77] */
        l_0x13_d720:
            ii(0x13_d720, 1); lodsb_a16();                              /* lodsb */
            ii(0x13_d721, 1); stosb_a16();                              /* stosb */
            ii(0x13_d722, 2); or(al, al);                               /* or al, al */
            ii(0x13_d724, 2); if(jnzw(0x13_d720, -0x6)) goto l_0x13_d720; /* jnz 0xd720 */
            ii(0x13_d726, 5); mov(ds, memw_a16[ss, 0x1c54]);            /* mov ds, [ss:0x1c54] */
            ii(0x13_d72b, 3); mov(si, 0x81);                            /* mov si, 0x81 */
            ii(0x13_d72e, 2); jmpw(0x13_d733, 0x3); goto l_0x13_d733;   /* jmp 0xd733 */
        l_0x13_d730:
            ii(0x13_d730, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x13_d732, 1); stosb_a16();                              /* stosb */
        l_0x13_d733:
            ii(0x13_d733, 1); lodsb_a16();                              /* lodsb */
            ii(0x13_d734, 2); cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x13_d736, 2); if(jzw(0x13_d733, -0x5)) goto l_0x13_d733; /* jz 0xd733 */
            ii(0x13_d738, 2); cmp(al, 0x9);                             /* cmp al, 0x9 */
            ii(0x13_d73a, 2); if(jzw(0x13_d733, -0x9)) goto l_0x13_d733; /* jz 0xd733 */
            ii(0x13_d73c, 2); cmp(al, 0xd);                             /* cmp al, 0xd */
            ii(0x13_d73e, 2); if(jzw(0x13_d7bc, 0x7c)) goto l_0x13_d7bc; /* jz 0xd7bc */
            ii(0x13_d740, 2); or(al, al);                               /* or al, al */
            ii(0x13_d742, 2); if(jzw(0x13_d7bc, 0x78)) goto l_0x13_d7bc; /* jz 0xd7bc */
            ii(0x13_d744, 3); mov(memw_a16[ss, bx], di);                /* mov [ss:bx], di */
            ii(0x13_d747, 1); inc(bx);                                  /* inc bx */
            ii(0x13_d748, 1); inc(bx);                                  /* inc bx */
        l_0x13_d749:
            ii(0x13_d749, 1); dec(si);                                  /* dec si */
        l_0x13_d74a:
            ii(0x13_d74a, 1); lodsb_a16();                              /* lodsb */
            ii(0x13_d74b, 2); cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x13_d74d, 2); if(jzw(0x13_d730, -0x1f)) goto l_0x13_d730; /* jz 0xd730 */
            ii(0x13_d74f, 2); cmp(al, 0x9);                             /* cmp al, 0x9 */
            ii(0x13_d751, 2); if(jzw(0x13_d730, -0x23)) goto l_0x13_d730; /* jz 0xd730 */
            ii(0x13_d753, 2); cmp(al, 0xd);                             /* cmp al, 0xd */
            ii(0x13_d755, 2); if(jzw(0x13_d7b9, 0x62)) goto l_0x13_d7b9; /* jz 0xd7b9 */
            ii(0x13_d757, 2); or(al, al);                               /* or al, al */
            ii(0x13_d759, 2); if(jzw(0x13_d7b9, 0x5e)) goto l_0x13_d7b9; /* jz 0xd7b9 */
            ii(0x13_d75b, 2); cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x13_d75d, 2); if(jzw(0x13_d786, 0x27)) goto l_0x13_d786; /* jz 0xd786 */
            ii(0x13_d75f, 2); cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x13_d761, 2); if(jzw(0x13_d766, 0x3)) goto l_0x13_d766; /* jz 0xd766 */
            ii(0x13_d763, 1); stosb_a16();                              /* stosb */
            ii(0x13_d764, 2); jmpw(0x13_d74a, -0x1c); goto l_0x13_d74a; /* jmp 0xd74a */
        l_0x13_d766:
            ii(0x13_d766, 2); xor(cx, cx);                              /* xor cx, cx */
        l_0x13_d768:
            ii(0x13_d768, 1); inc(cx);                                  /* inc cx */
            ii(0x13_d769, 1); lodsb_a16();                              /* lodsb */
            ii(0x13_d76a, 2); cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x13_d76c, 2); if(jzw(0x13_d768, -0x6)) goto l_0x13_d768; /* jz 0xd768 */
            ii(0x13_d76e, 2); cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x13_d770, 2); if(jzw(0x13_d778, 0x6)) goto l_0x13_d778; /* jz 0xd778 */
            ii(0x13_d772, 2); mov(al, 0x5c);                            /* mov al, 0x5c */
            ii(0x13_d774, 2); rep_a16(() => stosb_a16());               /* rep stosb */
            ii(0x13_d776, 2); jmpw(0x13_d749, -0x2f); goto l_0x13_d749; /* jmp 0xd749 */
        l_0x13_d778:
            ii(0x13_d778, 2); mov(al, 0x5c);                            /* mov al, 0x5c */
            ii(0x13_d77a, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x13_d77c, 2); rep_a16(() => stosb_a16());               /* rep stosb */
            ii(0x13_d77e, 2); if(jaew(0x13_d786, 0x6)) goto l_0x13_d786; /* jae 0xd786 */
            ii(0x13_d780, 2); mov(al, 0x22);                            /* mov al, 0x22 */
            ii(0x13_d782, 1); stosb_a16();                              /* stosb */
            ii(0x13_d783, 2); jmpw(0x13_d74a, -0x3b); goto l_0x13_d74a; /* jmp 0xd74a */
        l_0x13_d785:
            ii(0x13_d785, 1); dec(si);                                  /* dec si */
        l_0x13_d786:
            ii(0x13_d786, 1); lodsb_a16();                              /* lodsb */
            ii(0x13_d787, 2); cmp(al, 0xd);                             /* cmp al, 0xd */
            ii(0x13_d789, 2); if(jzw(0x13_d7b9, 0x2e)) goto l_0x13_d7b9; /* jz 0xd7b9 */
            ii(0x13_d78b, 2); or(al, al);                               /* or al, al */
            ii(0x13_d78d, 2); if(jzw(0x13_d7b9, 0x2a)) goto l_0x13_d7b9; /* jz 0xd7b9 */
            ii(0x13_d78f, 2); cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x13_d791, 2); if(jzw(0x13_d74a, -0x49)) goto l_0x13_d74a; /* jz 0xd74a */
            ii(0x13_d793, 2); cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x13_d795, 2); if(jzw(0x13_d79a, 0x3)) goto l_0x13_d79a; /* jz 0xd79a */
            ii(0x13_d797, 1); stosb_a16();                              /* stosb */
            ii(0x13_d798, 2); jmpw(0x13_d786, -0x14); goto l_0x13_d786; /* jmp 0xd786 */
        l_0x13_d79a:
            ii(0x13_d79a, 2); xor(cx, cx);                              /* xor cx, cx */
        l_0x13_d79c:
            ii(0x13_d79c, 1); inc(cx);                                  /* inc cx */
            ii(0x13_d79d, 1); lodsb_a16();                              /* lodsb */
            ii(0x13_d79e, 2); cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x13_d7a0, 2); if(jzw(0x13_d79c, -0x6)) goto l_0x13_d79c; /* jz 0xd79c */
            ii(0x13_d7a2, 2); cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x13_d7a4, 2); if(jzw(0x13_d7ac, 0x6)) goto l_0x13_d7ac; /* jz 0xd7ac */
            ii(0x13_d7a6, 2); mov(al, 0x5c);                            /* mov al, 0x5c */
            ii(0x13_d7a8, 2); rep_a16(() => stosb_a16());               /* rep stosb */
            ii(0x13_d7aa, 2); jmpw(0x13_d785, -0x27); goto l_0x13_d785; /* jmp 0xd785 */
        l_0x13_d7ac:
            ii(0x13_d7ac, 2); mov(al, 0x5c);                            /* mov al, 0x5c */
            ii(0x13_d7ae, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x13_d7b0, 2); rep_a16(() => stosb_a16());               /* rep stosb */
            ii(0x13_d7b2, 2); if(jaew(0x13_d74a, -0x6a)) goto l_0x13_d74a; /* jae 0xd74a */
            ii(0x13_d7b4, 2); mov(al, 0x22);                            /* mov al, 0x22 */
            ii(0x13_d7b6, 1); stosb_a16();                              /* stosb */
            ii(0x13_d7b7, 2); jmpw(0x13_d786, -0x33); goto l_0x13_d786; /* jmp 0xd786 */
        l_0x13_d7b9:
            ii(0x13_d7b9, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x13_d7bb, 1); stosb_a16();                              /* stosb */
        l_0x13_d7bc:
            ii(0x13_d7bc, 1); pushw(ss);                                /* push ss */
            ii(0x13_d7bd, 1); popw(ds);                                 /* pop ds */
            ii(0x13_d7be, 4); mov(memw_a16[ds, bx], 0);                 /* mov word [bx], 0x0 */
            ii(0x13_d7c2, 4); if(jmpw_a16_far_ind(ds, 0x1c88)) return;  /* jmp far word [0x1c88] */
        }
    }
}
