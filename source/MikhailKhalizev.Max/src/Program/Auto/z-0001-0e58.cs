using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("752c0e13-105d-406c-b47a-7d4d6e1820f5")]
        public void Method_0001_0e58()
        {
            ii(0x1_0e58, 2);  mov(bp, sp);                              /* mov bp, sp */
            ii(0x1_0e5a, 5);  mov(eax, memd_a32[ss, ebp + 0xc]);        /* mov eax, [ebp+0xc] */
            ii(0x1_0e5f, 5);  mov(ebp, memd_a32[ss, ebp + 0x10]);       /* mov ebp, [ebp+0x10] */
            ii(0x1_0e64, 3);  cmp(cl, 0x8);                             /* cmp cl, 0x8 */
            ii(0x1_0e67, 2);  if(jnzw(0x1_0e73, 0xa)) goto l_0x1_0e73;  /* jnz 0xe73 */
            ii(0x1_0e69, 3);  or(eax, eax);                             /* or eax, eax */
            ii(0x1_0e6c, 2);  if(jzw(0x1_0eca, 0x5c)) goto l_0x1_0eca;  /* jz 0xeca */
        l_0x1_0e6e:
            ii(0x1_0e6e, 2);  popd(eax);                                /* pop eax */
            ii(0x1_0e70, 2);  popd(ebp);                                /* pop ebp */
            ii(0x1_0e72, 1);  retw(); return;                           /* ret */
        l_0x1_0e73:
            ii(0x1_0e73, 2);  pushd(esi);                               /* push esi */
            ii(0x1_0e75, 3);  mov(esi, eax);                            /* mov esi, eax */
            ii(0x1_0e78, 4);  cmp(esi, 0x2);                            /* cmp esi, 0x2 */
            ii(0x1_0e7c, 4);  if(jbw(0x1_0ec8, 0x48)) goto l_0x1_0ec8;  /* jb 0xec8 */
            ii(0x1_0e80, 3);  lar(ax, bp);                              /* lar ax, bp */
            ii(0x1_0e83, 4);  if(jnzw(0x1_0ec8, 0x41)) goto l_0x1_0ec8; /* jnz 0xec8 */
            ii(0x1_0e87, 2);  mov(al, ah);                              /* mov al, ah */
            ii(0x1_0e89, 2);  and(al, 0x8a);                            /* and al, 0x8a */
            ii(0x1_0e8b, 2);  cmp(al, -0x76 /* 0x8a */);                /* cmp al, 0x8a */
            ii(0x1_0e8d, 4);  if(jnzw(0x1_0ec8, 0x37)) goto l_0x1_0ec8; /* jnz 0xec8 */
            ii(0x1_0e91, 3);  shr(ah, 0x5);                             /* shr ah, 0x5 */
            ii(0x1_0e94, 3);  and(ah, 0x3);                             /* and ah, 0x3 */
            ii(0x1_0e97, 1);  pushw(bx);                                /* push bx */
            ii(0x1_0e98, 2);  mov(bx, cs);                              /* mov bx, cs */
            ii(0x1_0e9a, 3);  and(bl, 0x3);                             /* and bl, 0x3 */
            ii(0x1_0e9d, 2);  mov(al, bl);                              /* mov al, bl */
            ii(0x1_0e9f, 1);  popw(bx);                                 /* pop bx */
            ii(0x1_0ea0, 2);  cmp(al, ah);                              /* cmp al, ah */
            ii(0x1_0ea2, 4);  if(jaw(0x1_0ec8, 0x22)) goto l_0x1_0ec8;  /* ja 0xec8 */
            ii(0x1_0ea6, 4);  lsl(eax, bp);                             /* lsl eax, bp */
            ii(0x1_0eaa, 3);  cmp(esi, eax);                            /* cmp esi, eax */
            ii(0x1_0ead, 4);  if(jaw(0x1_0ec8, 0x17)) goto l_0x1_0ec8;  /* ja 0xec8 */
            ii(0x1_0eb1, 2);  mov(ah, cl);                              /* mov ah, cl */
            ii(0x1_0eb3, 3);  and(ah, 0x1f);                            /* and ah, 0x1f */
            ii(0x1_0eb6, 2);  mov(al, 0xcd);                            /* mov al, 0xcd */
            ii(0x1_0eb8, 1);  pushw(ds);                                /* push ds */
            ii(0x1_0eb9, 2);  mov(ds, bp);                              /* mov ds, bp */
            ii(0x1_0ebb, 4);  cmp(ax, memw_a32[ds, esi - 0x2]);         /* cmp ax, [esi-0x2] */
            ii(0x1_0ebf, 1);  popw(ds);                                 /* pop ds */
            ii(0x1_0ec0, 2);  popd(esi);                                /* pop esi */
            ii(0x1_0ec2, 4);  if(jnzw(0x1_0eca, 0x4)) goto l_0x1_0eca;  /* jnz 0xeca */
            ii(0x1_0ec6, 2);  jmpw(0x1_0e6e, -0x5a); goto l_0x1_0e6e;   /* jmp 0xe6e */
        l_0x1_0ec8:
            ii(0x1_0ec8, 2);  popd(esi);                                /* pop esi */
        l_0x1_0eca:
            ii(0x1_0eca, 2);  popd(eax);                                /* pop eax */
            ii(0x1_0ecc, 2);  popd(ebp);                                /* pop ebp */
            ii(0x1_0ece, 3);  test(cl, 0x20);                           /* test cl, 0x20 */
            ii(0x1_0ed1, 2);  if(jzw(0x1_0ed5, 0x2)) goto l_0x1_0ed5;   /* jz 0xed5 */
            ii(0x1_0ed3, 2);  pushd(eax);                               /* push eax */
        l_0x1_0ed5:
            ii(0x1_0ed5, 2);  pushad();                                 /* pushad */
            ii(0x1_0ed7, 1);  pushw(ds);                                /* push ds */
            ii(0x1_0ed8, 2);  mov(bx, ss);                              /* mov bx, ss */
            ii(0x1_0eda, 1);  pushw(es);                                /* push es */
            ii(0x1_0edb, 4);  lar(eax, bx);                             /* lar eax, bx */
            ii(0x1_0edf, 3);  mov(ebp, esp);                            /* mov ebp, esp */
            ii(0x1_0ee2, 5);  bt(eax, 0x16);                            /* bt eax, 0x16 */
            ii(0x1_0ee7, 2);  if(jbw(0x1_0eed, 0x4)) goto l_0x1_0eed;   /* jb 0xeed */
            ii(0x1_0ee9, 4);  movzx(ebp, sp);                           /* movzx ebp, sp */
        l_0x1_0eed:
            ii(0x1_0eed, 4);  mov(dx, memw_a32[ss, ebp + 0x26]);        /* mov dx, [ebp+0x26] */
            ii(0x1_0ef1, 4);  and(ecx, 0x20);                           /* and ecx, 0x20 */
            ii(0x1_0ef5, 2);  if(jzw(0x1_0f0a, 0x13)) goto l_0x1_0f0a;  /* jz 0xf0a */
            ii(0x1_0ef7, 5);  xchg(memd_a32[ss, ebp + 0x24], eax);      /* xchg [ebp+0x24], eax */
            ii(0x1_0efc, 5);  xchg(memd_a32[ss, ebp + 0x28], eax);      /* xchg [ebp+0x28], eax */
            ii(0x1_0f01, 5);  xchg(memd_a32[ss, ebp + 0x24], eax);      /* xchg [ebp+0x24], eax */
            ii(0x1_0f06, 4);  mov(dx, memw_a32[ss, ebp + 0x26]);        /* mov dx, [ebp+0x26] */
        l_0x1_0f0a:
            ii(0x1_0f0a, 4);  mov(memw_a32[ss, ebp + 0x1c], dx);        /* mov [ebp+0x1c], dx */
            ii(0x1_0f0e, 1);  cld();                                    /* cld */
            ii(0x1_0f0f, 5);  mov(cx, memw_a16[cs, 0x4d76]);            /* mov cx, [cs:0x4d76] */
            ii(0x1_0f14, 4);  mov(si, memw_a32[ss, ebp + 0x24]);        /* mov si, [ebp+0x24] */
            ii(0x1_0f18, 2);  if(jcxzw(0x1_0f92, 0x78)) goto l_0x1_0f92; /* jcxz 0xf92 */
            ii(0x1_0f1a, 2);  mov(es, cx);                              /* mov es, cx */
            ii(0x1_0f1c, 2);  pushw(0x20);                              /* push 0x20 */
            ii(0x1_0f1e, 1);  popw(ds);                                 /* pop ds */
            ii(0x1_0f1f, 6);  add(memw_a16[ds, 0xc16], 0x400);          /* add word [0xc16], 0x400 */
            ii(0x1_0f25, 6);  movzx(edi, memw_a16[ds, 0xc16]);          /* movzx edi, word [0xc16] */
            ii(0x1_0f2b, 4);  cmp(di, 0x4000);                          /* cmp di, 0x4000 */
            ii(0x1_0f2f, 2);  if(jaw(0x1_0f8c, 0x5b)) goto l_0x1_0f8c;  /* ja 0xf8c */
            ii(0x1_0f31, 3);  sub(di, 0x2e);                            /* sub di, 0x2e */
            ii(0x1_0f34, 3);  lea(ax, si - 0xd);                        /* lea ax, [si-0xd] */
            ii(0x1_0f37, 4);  mov(memw_a16[es, di + 0x2a], ax);         /* mov [es:di+0x2a], ax */
            ii(0x1_0f3b, 4);  mov(memw_a16[es, di + 0x28], ax);         /* mov [es:di+0x28], ax */
            ii(0x1_0f3f, 4);  movzx(eax, di);                           /* movzx eax, di */
            ii(0x1_0f43, 4);  xchg(memw_a32[ss, ebp + 0x4], ax);        /* xchg [ebp+0x4], ax */
            ii(0x1_0f47, 1);  stosw_a16();                              /* stosw */
            ii(0x1_0f48, 1);  inc(si);                                  /* inc si */
            ii(0x1_0f49, 4);  mov(memw_a32[ss, ebp + 0x24], si);        /* mov [ebp+0x24], si */
            ii(0x1_0f4d, 3);  add(si, -0x14 /* 0xec */);                /* add si, 0xffec */
            ii(0x1_0f50, 3);  mov(cx, 0x4);                             /* mov cx, 0x4 */
            ii(0x1_0f53, 3);  rep_a16(() => movsw_a16(cs));             /* cs rep movsw */
            ii(0x1_0f56, 3);  mov(ax, 0x54a3);                          /* mov ax, 0x54a3 */
            ii(0x1_0f59, 2);  stosd_a16();                              /* stosd */
            ii(0x1_0f5b, 2);  mov(ax, cs);                              /* mov ax, cs */
            ii(0x1_0f5d, 2);  stosd_a16();                              /* stosd */
            ii(0x1_0f5f, 2);  mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x1_0f61, 5);  lea(esi, ebp + 0x28);                     /* lea esi, [ebp+0x28] */
            ii(0x1_0f66, 5);  rep_a32(() => movsd_a32(ss));             /* a32 ss rep movsd */
            ii(0x1_0f6b, 3);  xchg(esi, eax);                           /* a32 xchg esi, eax */
            ii(0x1_0f6e, 2);  stosd_a16();                              /* stosd */
            ii(0x1_0f70, 2);  mov(ax, ss);                              /* mov ax, ss */
            ii(0x1_0f72, 1);  stosw_a16();                              /* stosw */
            ii(0x1_0f73, 1);  popw(es);                                 /* pop es */
            ii(0x1_0f74, 1);  popw(ds);                                 /* pop ds */
            ii(0x1_0f75, 2);  popad();                                  /* popad */
            ii(0x1_0f77, 5);  mov(ss, memw_a16[cs, 0x4d76]);            /* mov ss, [cs:0x4d76] */
            ii(0x1_0f7c, 4);  movzx(esp, di);                           /* movzx esp, di */
            ii(0x1_0f80, 1);  popw(di);                                 /* pop di */
            ii(0x1_0f81, 2);  retfd(); return;                          /* o32 retf */
        //  ii(0x1_0f83, 9);  Недостижимый (и не декодированный) код.
        l_0x1_0f8c:
            ii(0x1_0f8c, 6);  sub(memw_a16[ds, 0xc16], 0x400);          /* sub word [0xc16], 0x400 */
        l_0x1_0f92:
            ii(0x1_0f92, 5);  add(memw_a32[ss, ebp + 0x24], -0xd /* 0xf3 */); /* add word [ebp+0x24], 0xfff3 */
            ii(0x1_0f97, 5);  test(memb_a16[cs, si - 0x5], 0x20);       /* test byte [cs:si-0x5], 0x20 */
            ii(0x1_0f9c, 1);  popw(es);                                 /* pop es */
            ii(0x1_0f9d, 1);  popw(ds);                                 /* pop ds */
            ii(0x1_0f9e, 2);  popad();                                  /* popad */
            ii(0x1_0fa0, 2);  if(jzw(0x1_0fa5, 0x3)) goto l_0x1_0fa5;   /* jz 0xfa5 */
            ii(0x1_0fa2, 3);  retw(0x6); return;                        /* ret 0x6 */
        l_0x1_0fa5:
            ii(0x1_0fa5, 3);  retw(0x2); return;                        /* ret 0x2 */
        }
    }
}
